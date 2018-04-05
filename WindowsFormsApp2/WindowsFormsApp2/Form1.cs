using System;
using System.Windows.Forms;
using ICARCOMLib;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace WindowsFormsApp2
{

    public partial class Main : Form
    {
        public IcarConstants.IcarConstants Iconstants;
        public ICAR Icar;
        Boolean config;
        SqlCommand command;
        SqlConnection connection;
        String connectStr;

        public Main()
        {
            connectStr = "Data Source=(LocalDB)" + @"\MSSQLLocalDB" + ";AttachDbFilename=|DataDirectory|" + @"\Database1.mdf" + ";Integrated Security=True";
            InitializeComponent();

            connection = new SqlConnection(connectStr);
            try
            {
                connection.Open();
                //MessageBox.Show("Connection open!");
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot open connection!");
            }
            //ICAR 
            Iconstants = new IcarConstants.IcarConstants();
            Icar = new ICAR();
            Icar.initialize();
            checkIcarError();
            config = false;

            command = new SqlCommand("SELECT Name FROM Person", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                VisitingCombo.Items.Add(reader["Name"].ToString());
            }
            connection.Close();
        }

        private void checkIcarError()
        {
            String errorStr;

            if (Icar.checkError() != 0)
            {
                errorStr = Icar.getErrorDescription();
                if (errorStr.Equals("warning!"))
                {
                    MessageBox.Show("IcarVisitor Form");
                }
                else
                {
                    MessageBox.Show(errorStr + "\nERROR");
                    this.Close();
                }
            }
        }

        //scans document
        private void Scan_Click(object sender, EventArgs e)
        {
            if (!config)
            {
                MessageBox.Show("Please configure the device first");
                configure();
            }

            SetDefault();
            String output = Icar.process();
            checkIcarError();
            byte[] bytes = Convert.FromBase64String(Icar.getResultImageBase64(1));
            Image img;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                img = Image.FromStream(ms);
            }
            Photo.Image = img;

            String res = Icar.getResultString().Replace(" # ", "\n");
            processResult(res);
        }

        private void processResult(string res)
        {
            String[] x = new String[20];
            String output;

            //docType
            String[] result = res.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[0].Split(null);
            TypeBox.Text = result[1];

            //Name
            int spot = 0;
            while (!result[spot].Equals("NAME:"))
            {
                spot++;
            }

            spot++;
            for (int i = 0; !result[spot].Equals("SURNAME:"); i++, spot++)
            {
                x[i] = result[spot];
            }
            output = x[0];
            for (int i = 1; x[i] != null; i++)
            {
                output = output + " " + x[i];
            }
            NameBox.Text = output;

            //surname
            output = null;
            spot++;
            for (int i = 0; !result[spot].Equals("ID_NUMBER:"); i++, spot++)
            {
                x[i] = result[spot];
            }


            output = x[0];
            for (int i = 1; x[i] != null; i++)
            {
                output = output + " " + x[i];
            }
            SurnameBox.Text = output;

            //cardNumber
            spot += 3;
            cardNBox.Text = result[spot];


            //gender
            while (!result[spot].Equals("SEX:"))
            {
                spot++;
            }

            spot += 1;
            if (result[spot++].Equals("M"))
            {

                MaleCheck.Checked = true;
                FemaleCheck.Checked = false;
            }
            else
            {
                MaleCheck.Checked = false;
                FemaleCheck.Checked = true;
            }
        }

        //configures device
        private void Configure_Click(object sender, EventArgs e)
        {
            configure();
        }

        public void configure()
        {
            Form2 conf = new Form2(Icar);
            conf.ShowDialog();
            config = true;
        }

        private void SetDefault()
        {
            String path = System.IO.Directory.GetCurrentDirectory() + @"\bin\image.bmp";
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getDeviceName(), ""); //device name
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getImgPath(), path);
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getDirctPath(), path);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDevice(), 25);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getRFIDDevice(), 3);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getSCdevice(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getUVLight(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getIRLight(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getImageMerging(), 5);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDateFormat(), 0);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getUpperCase(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getRemoveAccents(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDeleteFileProcess(), 0);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getProcessMode(), 0);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDigiCopyWidth(), 55);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDigiCopyWidth(), 86);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathDocImage(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathPhotoImg(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathSigImg(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathFingerImg(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getOutputUVImage(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getOutputIRImage(), 200);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorDocIMG(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorPhotoImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorSigImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorFingerPrintImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorModerUV(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorModeIR(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhanceDocImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhancePhotoImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhanceSigImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhanceFingerImg(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhanceDocCopyUV(), 1);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getEnhanceDocCopyIR(), 1);
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathPhotoImg(), path + @"/photoTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathRFIDPhotoImg(), path + @"/RFIDTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathDocImage(), path + @"/docTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathSigImg(), path + @"/signTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathFingerImg(), path + @"/fngrTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getPathDigitalImg(), path + @"/digiTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getUVImagePath(), path + @"/uvTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getIRImagePath(), path + @"/irTemp.jpg");
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getXMLPath(), path + @"/Output.XML");
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getTwainSizeX(), 175);
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getTwainSizeY(), 111);
            Icar.checkError();
        }

        private void Exit_Click(object sender, EventArgs e) {
            connection.Close();
            Environment.Exit(0);
        }

        private void DeliveryYes_CheckedChanged(object sender, EventArgs e)
        {
            if (DeliveryYes.Checked == true)
            {
                DeliveryNo.Checked = false;
            }
            else
            {
                DeliveryNo.Checked = true;
            }
        }

        private void DeliveryNo_CheckedChanged(object sender, EventArgs e)
        {
            if (DeliveryNo.Checked == true)
            {
                DeliveryYes.Checked = false;
            }
            else
            {
                DeliveryYes.Checked = true;
            }
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            String gender;
            if (MaleCheck.Checked == true)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            int delivery;
            if (DeliveryNo.Checked == true)
            {
                delivery = 0;
            }
            else
            {
                delivery = 1;
            }

            connection.Open();
            String query = "INSERT INTO Visits(Name,Surname,DocType,DocNumber,Gender,Company,Delivery,Entrance,Visiting) VALUES(" + NameBox.Text + " , " + SurnameBox.Text + " , " +
                TypeBox.Text + " , " + cardNBox.Text + " , " + gender + " , " + Companybox.Text + " , "
                + delivery + " ," + System.DateTime.Now + " , " + VisitingCombo.Text + ")";
            command = new SqlCommand(query, connection);
            connection.Execute("")

            SqlDataReader reader = command.ExecuteReader();
            connection.Close();
            
            MessageBox.Show("---" +VisitingCombo.Text.TrimEnd(' ')+ "---------");

            //command = new SqlCommand("INSERT " + NameBox.Text + ", " + SurnameBox.Text + ", " +
            //    TypeBox.Text + ", " + cardNBox.Text + ", " + gender + ", " + Companybox.Text + ", "
            //    + delivery + "," + System.DateTime.Now+", " + VisitingCombo.Text, connection);

            clearFields();
        }

        private void clearFields()
        {
            Photo.Image = null;
            cardNBox.Text = null;
            TypeBox.Text = null;
            NameBox.Text = null;
            SurnameBox.Text = null;
            Companybox.Text = null;
            MaleCheck.Checked = false;
            FemaleCheck.Checked = false;
            DeliveryNo.Checked = false;
            DeliveryYes.Checked = false;
        }
    }
}
