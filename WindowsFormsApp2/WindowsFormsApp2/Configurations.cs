﻿using System;
using ICARCOMLib;
using IcarConstants;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Configurations : Form
    {
        public ICAR icar;
        public IcarConstants.IcarConstants Iconstants;
        public SqlConnection connection;

        public Configurations(ICAR icar, SqlConnection connection)
        {
            InitializeComponent();
            this.icar = icar;
            Iconstants = new IcarConstants.IcarConstants();
            String path = System.IO.Directory.GetCurrentDirectory() + @"\bin\image.bmp";
            FolderTextBox.Text = path;

            DeviceCombo.Text = DeviceCombo.Items[5].ToString();

            DocColor.Text = DocColor.Items[0].ToString();
            DocEnhancement.Text = DocEnhancement.Items[0].ToString();

            PhotoColor.Text = PhotoColor.Items[0].ToString();
            PhotoEnhancement.Text = PhotoEnhancement.Items[0].ToString();

            ProcessModeCombo.Text = ProcessModeCombo.Items[0].ToString();
            TiltingComboBox.Text = TiltingComboBox.Items[2].ToString();

            DateFormatCombo.Text = DateFormatCombo.Items[0].ToString();

            using (StreamReader reader = new StreamReader("daysToReset.txt"))
            {
                daysBox.Text = reader.ReadLine().Split(null)[3];
            }

            using (StreamReader reader = new StreamReader("watermarkText.txt"))
            {
                watermarkBox.Text = reader.ReadLine();
            }

            enabledFields();

            this.connection = connection;
        }

        private void enabledFields()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = Path.Combine(path, "fieldConfig.txt");
            bool field = false;
            using (StreamReader sr = new StreamReader(fileName))
            {
                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                nationCheck.Checked = field;
                

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                genderCheck.Checked = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                expireCheck.Checked = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                addressCheck.Checked = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                commentsCheck.Checked = field;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            configure();
            using (StreamWriter write = new StreamWriter("daysToReset.txt"))
            {
                write.WriteLine("Days for Reset: " + daysBox.Text);
            }
            using (StreamWriter write = new StreamWriter("watermarkText.txt"))
            {
                write.WriteLine(watermarkBox.Text);
            }
            this.Close();
        }

        public void configure()
        {
            icar.setPropertyString(Iconstants.getDeviceName(), DeviceNameBox.Text); //device name
            icar.checkError();
            icar.setPropertyString(Iconstants.getImgPath(), FolderTextBox.Text);
            icar.checkError();
            icar.setPropertyString(Iconstants.getDirctPath(), " ");
            icar.checkError();

            String type = DeviceCombo.Text;
            if (type.Equals("IcarBox 250"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBox250());
            }
            else if (type.Equals("IcarBox 250 VIU"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBox250Viu());
            }
            else if (type.Equals("IcarBox 260"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBox260());
            }
            else if (type.Equals("IcarBox 260 VIU"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBox260viu());
            }
            else if (type.Equals("IcarBox 240B"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBoxIcar240());
            }
            else if (type.Equals("IDBox"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getIDBox());
            }
            else if (type.Equals("IDBox VIU"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getIdBoxviu());
            }
            else if (type.Equals("IDBoxE"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getIdBoxE());
            }
            else if (type.Equals("IDBoxE VIU"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getIdBoxEviu());

            }
            else if (type.Equals("TWAIN compatible scanner"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBoxTwain());
            }
            else if (type.Equals("Virtual folder device"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBoxvirtual());
            }
            else if (type.Equals("Image file"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getDocImageImg());
            }
            else if (type.Equals("HP Photo Scan 1200"))
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBoxHP());
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getDevice(), Iconstants.getBoxIbm());
            }
            icar.checkError();

            icar.setPropertyNumber(Iconstants.getRFIDDevice(), 3);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getSCdevice(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getUVLight(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getIRLight(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getImageMerging(), 5);
            icar.checkError();

            type = DateFormatCombo.Text;
            if (type.Equals("DD-MM-YY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 0);
            }
            else if (type.Equals("DD-MM-YYYY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 1);
            }
            else if (type.Equals("DD-MM-YY??"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 2);
            }
            else if (type.Equals("MM-DD-YY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 3);
            }
            else if (type.Equals("MM-DD-YYYY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 4);
            }
            else if (type.Equals("MM-DD-YY??"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 5);
            }
            else if (type.Equals("YY-MM-DD"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 6);
            }
            else if (type.Equals("YYYY-MM-DD"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 7);
            }
            else if (type.Equals("YY??-MM-DD"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 8);
            }
            else if (type.Equals("MM-DD"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 9);
            }
            else if (type.Equals("MM-YY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 10);
            }
            else if (type.Equals("MM-YYYY"))
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 11);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getDateFormat(), 12);
            }
            icar.checkError();

            if (UpperCaseCheck.Checked == true)
            {
                icar.setPropertyNumber(Iconstants.getUpperCase(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getUpperCase(), 0);
            }
            icar.checkError();

            if (accentOutputCheck.Checked == true)
            {
                icar.setPropertyNumber(Iconstants.getRemoveAccents(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getRemoveAccents(), 0);
            }
            icar.checkError();

            if (deleteDocAfterProcess.Checked == true)
            {
                icar.setPropertyNumber(Iconstants.getDeleteFileProcess(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getDeleteFileProcess(), 0);
            }
            icar.checkError();

            if (ProcessModeCombo.Text.Equals("Document Reading"))
            {
                icar.setPropertyNumber(Iconstants.getProcessMode(), 0);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getProcessMode(), 1);
            }
            icar.checkError();

            icar.setPropertyNumber(Iconstants.getDigiCopyHeight(), Int32.Parse(digiCopyHeight.Text));
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getDigiCopyWidth(), Int32.Parse(digiCopyWidth.Text));
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getPathDocImage(), 200);
            icar.checkError();

            if (SavePhotoCheck.Checked == false)
            {
                icar.setPropertyNumber(Iconstants.getPathPhotoImg(), 200);
            }
            else
            {
                icar.setPropertyString(Iconstants.getPathPhotoImg(), SavePhotoBox.Text);
            }
            icar.checkError();

            icar.setPropertyNumber(Iconstants.getPathSigImg(), 200);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getPathFingerImg(), 200);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getOutputUVImage(), 200);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getOutputIRImage(), 200);
            icar.checkError();

            if (DocColor.Text.Equals("Color"))
            {
                icar.setPropertyNumber(Iconstants.getColorDocIMG(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getColorDocIMG(), 0);
            }
            icar.checkError();

            if (PhotoColor.Text.Equals("Color"))
            {
                icar.setPropertyNumber(Iconstants.getColorPhotoImg(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getColorPhotoImg(), 0);
            }
            icar.checkError();


            icar.setPropertyNumber(Iconstants.getColorSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getColorFingerPrintImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getColorModerUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getColorModeIR(), 1);
            icar.checkError();

            if (DocEnhancement.Text.Equals("Apply"))
            {
                icar.setPropertyNumber(Iconstants.getEnhanceDocImg(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getEnhanceDocImg(), 0);
            }
            icar.checkError();

            if (PhotoEnhancement.Text.Equals("Apply"))
            {
                icar.setPropertyNumber(Iconstants.getEnhancePhotoImg(), 1);
            }
            else
            {
                icar.setPropertyNumber(Iconstants.getEnhancePhotoImg(), 0);
            }
            icar.checkError();


            icar.setPropertyNumber(Iconstants.getEnhanceSigImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getEnhanceFingerImg(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getEnhanceDocCopyUV(), 1);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getEnhanceDocCopyIR(), 1);
            icar.checkError();

            icar.setPropertyString(Iconstants.getPathRFIDPhotoImg(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getPathDocImage(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getPathSigImg(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getPathFingerImg(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getPathDigitalImg(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getUVImagePath(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getIRImagePath(), "");
            icar.checkError();
            icar.setPropertyString(Iconstants.getXMLPath(), "");
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getTwainSizeX(), 175);
            icar.checkError();
            icar.setPropertyNumber(Iconstants.getTwainSizeY(), 111);
            icar.checkError();
        }

        internal bool[] getFields()
        {
            bool[] fields = new bool[5];
            fields[0] = nationCheck.Checked;
            fields[1] = genderCheck.Checked;
            fields[2] = expireCheck.Checked;
            fields[3] = addressCheck.Checked;
            fields[4] = commentsCheck.Checked;
            return fields;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public ICAR getI()
        {
            return icar;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            UserAdd adder = new UserAdd(connection);
            adder.ShowDialog();
            this.Enabled = false;
            while (adder.Visible) { }
            this.Enabled = true;
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            UserDelete del = new UserDelete(connection);
            del.ShowDialog();
            this.Enabled = false;
            while (del.Visible) { }
            this.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: Exportar tudo da DB

            string strSQL = "Select * from Person";

            SqlDataAdapter dt = new SqlDataAdapter(strSQL, connection);
            DataSet ds = new DataSet("Databse");
            dt.Fill(ds, "Person");

            strSQL = "Select * from Visits";
            dt = new SqlDataAdapter(strSQL,connection);
            dt.Fill(ds, "Visit");

            strSQL = "Select * from Users";
            dt = new SqlDataAdapter(strSQL, connection);
            dt.Fill(ds, "User");

            strSQL = "Select * from Workers";
            dt = new SqlDataAdapter(strSQL, connection);
            dt.Fill(ds, "Worker");

            strSQL = "Select * from WorksIn";
            dt = new SqlDataAdapter(strSQL, connection);
            dt.Fill(ds, "Working In");

            strSQL = "Select * from Companies";
            dt = new SqlDataAdapter(strSQL, connection);
            dt.Fill(ds, "Companie and Department");

            String path = xmlPath.Text + @"\database.xml";

            ds.WriteXml(path);

            MessageBox.Show("Data Exported to "+path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            xmlPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
