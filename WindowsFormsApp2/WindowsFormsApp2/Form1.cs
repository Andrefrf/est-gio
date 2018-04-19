using System;
using System.Windows.Forms;
using ICARCOMLib;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{

    public partial class Main : Form
    {
        private const string V = " , ";
        public IcarConstants.IcarConstants Iconstants;
        public ICAR Icar;
        protected Boolean config;
        SqlConnection connection;
        String connectStr;
        private static String SPLITTER = "|";

        public Main()
        {
            connectStr = "Data Source=(LocalDB)" + @"\MSSQLLocalDB" + ";AttachDbFilename=|DataDirectory|" + @"\Database1.mdf" + ";Integrated Security=True";
            MessageBox.Show(connectStr);
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

            SqlCommand command = new SqlCommand("SELECT Name FROM Person", connection);
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


            String res = Icar.getResultString().Replace(" # ", " |\n");
            processResult(res);
        }

        private void processResult(string res)
        {

            //docType
            String[] result = res.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[0].Split(null);
            TypeBox.Text = result[1];


            NameBox.Text = searchField("NAME:", result);
            SurnameBox.Text = searchField("SURNAME:", result);

            idNBox.Text = searchField("DOC_NUMBER:", result).Substring(0, 8);

        }

        private string searchField(string input, String[] result)
        {
            String output;
            String[] x = new String[20];
            int spot = 0;
            while (!result[spot].Equals(input))
            {
                spot++;
            }

            spot++;
            for (int i = 0; !result[spot].Equals(SPLITTER); i++, spot++)
            {
                x[i] = result[spot];
            }
            output = x[0];
            for (int i = 1; x[i] != null; i++)
            {
                output = output + " " + x[i];
            }
            return output;
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

        private void Exit_Click(object sender, EventArgs e)
        {
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
            else if (FemaleCheck.Checked == true)
            {
                gender = "F";
            }
            else
            {
                gender = null;
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

            string type = "";
            if (TypeBox.Text.Equals("IDENTITY"))
            {
                type = "id";
            }
            else if (TypeBox.Text.Equals("PASSPORT"))
            {
                type = "passport";
            }
            else if (TypeBox.Text.Equals("DRIVER_LICENSE"))
            {
                type = "driver";
            }
            else if (TypeBox.Text.Equals("VISA"))
            {
                type = "visa";
            }
            else if (TypeBox.Text.Equals("TRIPULATION"))
            {
                type = "tripulation";
            }
            else if (TypeBox.Text.Equals("RESIDENT_CARD"))
            {
                type = "resident";
            }
            else if (TypeBox.Text.Equals("PERSONAL_CARD"))
            {
                type = "personal";
            }
            else
            {
                type = "mrzNotRecognized";
            }
            StringBuilder sb = new StringBuilder();
            //sb.Append();
            using (SqlCommand com = new SqlCommand())
            {

                //com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = valuesCheck(NameBox.Text);
                //com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = valuesCheck(SurnameBox.Text);
                //com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = valuesCheck(type);
                //com.Parameters.Add("@DocNumber", SqlDbType.NVarChar).Value = valuesCheck(idNBox.Text);
                //com.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = valuesCheck(gender);
                //com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = valuesCheck(Companybox.Text);
                //com.Parameters.Add("@Delivery", SqlDbType.Bit).Value = delivery;
                //com.Parameters.Add("@Entrance", SqlDbType.Date).Value = DateTime.Now;
                //com.Parameters.Add("@Out", SqlDbType.Date).Value = DBNull.Value;
                //com.Parameters.Add("@Visiting", SqlDbType.NVarChar).Value = valuesCheck(VisitingCombo.Text);

                

                com.CommandType = System.Data.CommandType.Text;

                com.CommandText = "INSERT INTO Visits(Name,Surname,DocType,IdNumber,Gender,Company,Delivery,Entrance,Out,Visiting) VALUES(@Name,@Surname,@DocType,@DocNumber,@Gender,@Company,@Delivery,@Entrance,@Out,@Visiting)";
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "André";
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = "Ferreira";
                com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = "id";
                com.Parameters.Add("@DocNumber", SqlDbType.NVarChar).Value = "17286597";
                com.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "M";
                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = "Algo";
                com.Parameters.Add("@Delivery", SqlDbType.Bit).Value = 0;
                com.Parameters.Add("@Entrance", SqlDbType.Date).Value = DateTime.Now;
                com.Parameters.Add("@Out", SqlDbType.Date).Value = DBNull.Value;
                com.Parameters.Add("@Visiting", SqlDbType.NVarChar).Value = getVisiting("Miguel Santos");

                com.Connection = connection;

                connection.Open();

                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i< reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader.GetValue(i));
                        }
                        Console.Write("DONE!");
                    }
                }
                    com.ExecuteNonQuery();
            }

            connection.Close();

            clearFields();
        }

        private object getVisiting(string v)
        {
            connection.Open();

            SqlCommand com = new SqlCommand("SELECT Name FROM Person WHERE Name = @Name", connection);
            com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = v;

            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            String res = reader["Name"].ToString();

            connection.Close();

            return res;
        }

        private object valuesCheck(string text)
        {
            if (text == null)
            {
                return DBNull.Value;
            }
            else return text;
        }

        private void clearFields()
        {
            Photo.Image = null;
            idNBox.Text = null;
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
