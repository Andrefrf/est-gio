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
        private const string FIRST_CONFIG = "Please configure the device first";
        public IcarConstants.IcarConstants Iconstants;
        public ICAR Icar;
        protected Boolean config;
        SqlConnection connection;
        String connectStr;
        private static String SPLITTER = "|";
        private Boolean admin;

        public Main()
        {
            this.Name = null;
            connectStr = "Data Source=(LocalDB)" + @"\MSSQLLocalDB" + ";AttachDbFilename="+ @"C:\USERS\USER\DESKTOP\ICARVISITOR\EST-GIO\WINDOWSFORMSAPP2\WINDOWSFORMSAPP2\Database.mdf" + ";Integrated Security=True";
            InitializeComponent();

            connection = new SqlConnection(connectStr);

            
            
            
            //ICAR 
            Iconstants = new IcarConstants.IcarConstants();
            Icar = new ICAR();
            Icar.initialize();
            checkIcarError();
            config = false;

            Login log = new Login(connection);
            log.ShowDialog();
            admin = log.getType();
            log.Close();

            fillCompany();

            CompCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            VisitingCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            cardNBox.Text = null;
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
                MessageBox.Show(FIRST_CONFIG);
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

        private void configure()
        {
            Configurations conf = new Configurations(Icar);
            conf.ShowDialog();
            this.Hide();
            while (conf.Visible) { }
            config = true;
            this.Show();
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

        private void SetDefault()
        {
            String path = Directory.GetCurrentDirectory() + @"\bin\image.bmp";
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getDeviceName(), ""); //device name
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getImgPath(), path); //image path
            Icar.checkError();
            Icar.setPropertyString(Iconstants.getDirctPath(), path); //
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDevice(), 25); //device type
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getRFIDDevice(), 3); //RFID Device
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getSCdevice(), 1);    //SmartCard Device  
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getUVLight(), 1);     //UV Light Y or N
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getIRLight(), 1);     //IR Light Y or N
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getImageMerging(), 5);   //Merge front and back 
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDateFormat(), 0);      //Date Format
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getUpperCase(), 1);       //UpperCase
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getRemoveAccents(), 1);   //with Accents
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDeleteFileProcess(), 0);   //delete file after process
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getProcessMode(), 0);         //how process
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDigiCopyWidth(), 55);      //width digital copy
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getDigiCopyHeight(), 86);      //height Digital Copy
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathDocImage(), 200);      //doc Image path   
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathPhotoImg(), 200);      //photo path
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathSigImg(), 200);        //signature path
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getPathFingerImg(), 200);     //finger path
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getOutputUVImage(), 200);     //UV Image
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getOutputIRImage(), 200);     //IR image
            Icar.checkError();
            Icar.setPropertyNumber(Iconstants.getColorDocIMG(), 1);         //doc color
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
            
            int delivery;
            if (DeliveryNo.Checked)
            {
                delivery = 0;
            }
            else
            {
                delivery = 1;
            }
            int Visiting = getWorker();
            addPerson();
            int res = getPerson();
            StringBuilder sb = new StringBuilder();
            int company = getCompany();
            sb.Append("INSERT INTO Visits(PersonID,Company,Delivery,Entrance,Out,WorkerId,cardNumber,VisitingCompany) VALUES(@PersonID,@Company,@Delivery,@Entrance,@Out,@WorkerId,@cardNumber,@VisitingCompany)");
            using (SqlCommand com = new SqlCommand(sb.ToString(),connection))
            {

                com.Parameters.Add("@PersonID", SqlDbType.Int).Value = res;
                com.Parameters.Add("@Company", SqlDbType.Int).Value = company;
                com.Parameters.Add("@Delivery", SqlDbType.Bit).Value = delivery;
                com.Parameters.Add("@Entrance", SqlDbType.DateTime).Value = DateTime.Now;
                com.Parameters.Add("@Out", SqlDbType.DateTime).Value = DBNull.Value;
                com.Parameters.Add("@WorkerId", SqlDbType.Int).Value = Visiting;
                com.Parameters.Add("@cardNumber", SqlDbType.Int).Value = checkCard(cardNBox.Text); 
                com.Parameters.Add("@VisitingCompany", SqlDbType.NVarChar).Value = valuesCheck(Companybox.Text);

                com.CommandType = System.Data.CommandType.Text;

                com.Connection = connection;

                connection.Open();

                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                trans.Commit();
                MessageBox.Show("Data Inserted!");
            }

            connection.Close();

            clearFields();
            
        }

        private object checkCard(String cardn)
        {
            if(cardn == "")
            {
                return DBNull.Value;
            }
            else
            {
                return Int32.Parse(cardn);
            }
        }

        private int getPerson()
        {
            int WorkId = 0;
            connection.Open();

            SqlCommand com = new SqlCommand("Select PersonID from Person Where DocType = @Doctype AND IdNumber = @IdNumber", connection);

            com.Parameters.Add("@Doctype", SqlDbType.NVarChar).Value = TypeBox.Text;
            com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = idNBox.Text;

            com.ExecuteNonQuery();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                WorkId = Int32.Parse(reader["PersonID"].ToString());
            }
            connection.Close();
            return WorkId;
        }

        private int getCompany()
        {
            connection.Open();
            String[] compDep = CompCombo.Text.Split(',');
            int compID = 0;
            try
            {
                SqlCommand com = new SqlCommand("Select ID from Companies where Company = @Company AND Department = @Department  ", connection);

                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = compDep[0];
                com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = compDep[1];

                com.ExecuteNonQuery();
                SqlDataReader r = com.ExecuteReader();
                r.Read();
                compID = Int32.Parse(r["ID"].ToString());

            }
            catch (SqlException)
            {

            }
            connection.Close();
            return compID;
        }

        private void addPerson()
        {
            connection.Open();
            
            try
            {
                SqlCommand com = new SqlCommand("Insert into Person(Name,Surname,DocType,IdNumber,PersonID) values(@Name,@Surname,@DocType,@IdNumber,NEXT VALUE FOR Person_Id_Seq)", connection);

                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = SurnameBox.Text;
                com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = TypeBox.Text;
                com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = idNBox.Text;

                
                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                trans.Commit();
                
            }
            catch (SqlException)
            {

            }
            connection.Close();
        }

        private int getWorker()
        {
            int WorkId = 0;
            String[] compText = CompCombo.Text.Split(',');
            connection.Open();

            SqlCommand com  = new SqlCommand("Select Id from WorkerCompany Where Name = @Name AND Company = @Company AND Department = @Department", connection);

            com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = VisitingCombo.Text.Trim();
            com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = compText[0];
            com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = compText[1];

            com.ExecuteNonQuery();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                WorkId = Int32.Parse(reader["Id"].ToString()) ;
            }
            connection.Close();
            return WorkId;
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
            DeliveryNo.Checked = false;
            DeliveryYes.Checked = false;
            cardNBox.Text = null;
        }

        private void VisitingAdd_Click(object sender, EventArgs e)
        {
            PersonForm form = new PersonForm(connection);
            form.ShowDialog();
            this.Hide();
            while (form.Visible) { }
            VisitingCombo.Items.Clear();
            fillVisiting();
            this.Show();
        }

        private void fillVisiting()
        {
            String[] company = CompCombo.Text.Split(',');
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Name FROM WorkerCompany WHERE Company = @Company AND Department = @Department", connection);
            command.Parameters.Add("@Company", SqlDbType.NVarChar).Value = company[0];
            command.Parameters.Add("@Department", SqlDbType.NVarChar).Value = company[1];
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                VisitingCombo.Items.Add(reader["Name"].ToString());
            }
            connection.Close();
        }

        private void VCompAdd_Click(object sender, EventArgs e)
        {
            NewCompFloorBuild form = new NewCompFloorBuild(connection);
            form.ShowDialog();
            this.Hide();
            while (form.Visible) { }
            CompCombo.Items.Clear();
            fillCompany();
            this.Show();
        }

        private void fillCompany()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Company,Department FROM Companies", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CompCombo.Items.Add(reader["Company"].ToString().Trim()+","+reader["Department"].ToString().Trim());
            }
            connection.Close();
        }

        private void selectedChange(object sender, EventArgs e)
        {
            if (CompCombo.Text == null) { }
            else
            {
                VisitingCombo.Enabled = true;
                VisitingAdd.Enabled = true;
                VisitingCombo.Text = null;
                VisitingCombo.Items.Clear();
                fillVisiting();
            }
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            CheckOut form = new CheckOut(connection);
            form.Show();
            
        }
    }
}