using System;
using System.Windows.Forms;
using ICARCOMLib;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WindowsFormsApp2
{

    public partial class PostisVisitor : Form
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
        private int days;
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public PostisVisitor()
        {
            this.Name = null;
            using (StreamReader reader = new StreamReader("daysToReset.txt"))
            {
                String line = reader.ReadLine();
                days = Int32.Parse(line.Split(null)[3]);
            }
            this.Name = null;

            using (StreamReader reader = new StreamReader("connectDBstring.txt"))
            {
                string line = reader.ReadLine();
                //line.Replace("/", "\\");
                connectStr = line;
            }
            //connectStr = "Data Source=192.168.1.101"+@"\MSSQLSERVER01"+ ",1433;Network Library=DBMSSOCN;Initial Catalog=PostisVisitor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            InitializeComponent();

            connection = new SqlConnection(connectStr);
            
            Login log = new Login(connection);
            log.ShowDialog();
            admin = log.getType();
            log.Close();
            visitorsTime();

            if (!admin)
            {
                Configure.Hide();
                Report.Hide();
            }
            groupBox1.Hide();
            VCompAdd.Enabled = admin;
            VisitingAdd.Enabled = admin;
            fillCompany();
            fillVisitor();

            VisitingCombo.Hide();
            VCompAdd.Hide();
            CompCombo.Hide();
            VisitingAdd.Hide();
            VisitingLabel.Hide();
            CompLabel.Hide();

            fieldEnabler();

            CompCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            VisitingCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            cardNBox.Text = null;

            //ICAR 
            Iconstants = new IcarConstants.IcarConstants();
            Icar = new ICAR();
            Icar.initialize();
            checkIcarError();
            config = false;

            Configurations conf = new Configurations(Icar, connection);
            conf.configure();

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.MaximizeBox = false;

            float Xratio = (float)(Screen.PrimaryScreen.Bounds.Width) / (float)(this.MinimumSize.Width);
            float Yratio = (float)(Screen.PrimaryScreen.Bounds.Height) / (float)(this.MinimumSize.Height);
            foreach(Control c in this.Controls)
            {
                float x = (float)c.Location.X * Xratio;
                float y = (float)c.Location.Y * Yratio;
                c.Location = new Point((int)x, (int)y);

                int w = c.Width * (int)Xratio;
                int h = c.Height * (int)Yratio;
                c.Size = new Size(w, h);
            }

            Scan.Image = Image.FromFile("images/scan.png");
            Exit.Image = Image.FromFile("images/exit.png");
            InButton.Image = Image.FromFile("images/ok.png");
            Configure.Image = Image.FromFile("images/config.png");
            Visitors.Image = Image.FromFile("images/visitors.png");
            Report.Image = Image.FromFile("images/report.png");
            pictureBox1.Image = Image.FromFile("images/company.jpg");

            groupBox2.Height = Height;
            VisitorsLabel.Text = getVisitors();
        }

        private string getVisitors()
        {
            Int32 count = 0;
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM toCheckOut", connection))
            {
                connection.Open();
                count = (Int32)command.ExecuteScalar();
                connection.Close();
            }
            return count.ToString();
        }

        private void fieldEnabler()
        {
            string fileName = Path.Combine(path, "fieldConfig.txt");
            bool field = false;
            using (StreamReader sr = new StreamReader(fileName))
            {
                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                nationBox.Visible = field;
                nationText.Visible = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                genderBox.Visible = field;
                genderText.Visible = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                dateBox.Visible = field;
                dateText.Visible = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                addressBox.Visible = field;
                addressText.Visible = field;

                if (sr.ReadLine() == "True")
                {
                    field = true;
                }
                commentBox.Visible = field;
                commentText.Visible = field;
            }
        }

        private void visitorsTime()
        {
            using (SqlCommand com = new SqlCommand("DELETE FROM Visits Where Entrance < @date",connection))
            {
                connection.Open();
                com.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now.AddDays(-days);
                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                connection.Close();
            }
        }

        private void checkIcarError()
        {
            String errorStr;

            if (Icar.checkError() != 0)
            {
                errorStr = Icar.getErrorDescription();
                if (errorStr.Equals("warning!"))
                {
                    MessageBox.Show("PostisVisitor Form");
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
            try
            {
                SetDefault();
                String output = Icar.process();
                checkIcarError();
                String resultimg = Icar.getResultImageBase64(1);
                byte[] bytes = Convert.FromBase64String(resultimg);
                Image img;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    img = Image.FromStream(ms);
                }
                img = new Bitmap(img, Photo.Width, Photo.Height);

                MakeWatermark(img);

                Photo.Image = img;

                String res = Icar.getResultString().Replace(" # ", " |\n");
                processResult(res);
                groupBox1.Show();
                VisitingCombo.Show();
                VCompAdd.Show();
                CompCombo.Show();
                VisitingAdd.Show();
                VisitingLabel.Show();
                CompLabel.Show();

            }
            catch(Exception)
            {
                MessageBox.Show(new Exception().Message);
            }
        }

        private static void MakeWatermark(Image img)
        {
            Graphics g = Graphics.FromImage(img);

            // Trigonometry: Tangent = Opposite / Adjacent
            double tangent = (double)img.Height /
                             (double)img.Width;

            // convert arctangent to degrees
            double angle = Math.Atan(tangent) * (180 / Math.PI);

            // a^2 = b^2 + c^2 ; a = sqrt(b^2 + c^2)
            double halfHypotenuse = (Math.Sqrt((img.Height
                                   * img.Height) +
                                   (img.Width *
                                   img.Width))) / 2;

            // Horizontally and vertically aligned the string
            // This makes the placement Point the physical 
            // center of the string instead of top-left.
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            String watermark = null;
            using (StreamReader reader = new StreamReader("watermarkText.txt"))
            {
                watermark = reader.ReadLine();
            }

            g.RotateTransform((float)angle);
            g.DrawString(watermark, new Font("Arial", 16), new SolidBrush(Color.Black),
                         new Point((int)halfHypotenuse, 0),
                         stringFormat);
        }

        private void configure()
        {
            Icar.cleanup();
            Icar.initialize();
            Configurations conf = new Configurations(Icar, connection);
            conf.ShowDialog();
            this.Enabled = false;
            while (conf.Visible) { }
            config = true;
            this.Enabled = true;
            Icar = conf.getI();
            processFields(conf.getFields());
            conf.Close();
        }

        private void processFields(bool[] fields)
        {
            nationBox.Visible = fields[0];
            nationText.Visible = fields[0];

            genderBox.Visible = fields[1];
            genderText.Visible = fields[1];

            dateBox.Visible = fields[2];
            dateText.Visible = fields[2];

            addressBox.Visible = fields[3];
            addressText.Visible = fields[3];

            commentBox.Visible = fields[4];
            commentText.Visible = fields[4];


            string fileName = Path.Combine(path, "fieldConfig.txt");
            using (StreamWriter wr = new StreamWriter(fileName))
            {
                for(int i = 0; i < fields.Length; i++)
                {
                    wr.WriteLine(fields[i]);
                }
            }
        }

        private void processResult(string res)
        {
            //docType
            String[] result = res.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)[0].Split(null);
            TypeBox.Text = result[1];

            NameBox.Text = searchField("NAME:", result);
            SurnameBox.Text = searchField("SURNAME:", result);

            idNBox.Text = searchField("DOC_NUMBER:", result);

            nationBox.Text = searchField("NATIONALITY:", result);

            genderBox.Text = searchField("SEX:", result);

            dateBox.Text = searchField("EXPIRY:", result);

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
            CompCombo.Items.Clear();
            VisitingCombo.Items.Clear();
            Login log = new Login(connection);
            this.Hide();
            log.ShowDialog();
            cleanup();
            while (log.Visible) { }
            this.Show();
            admin = log.getType();
            fillCompany();
            fieldEnabler();
            log.Close();
            if (!admin)
            {
                Configure.Hide();
                Report.Hide();
            }
            else
            {
                Configure.Show();
                Report.Show();
            }
            groupBox1.Hide();
            VisitorsLabel.Text = getVisitors();
        }

        private void cleanup()
        {
            Photo.Image = null;
            NameBox.Text = null;
            SurnameBox.Text = null;
            TypeBox.Text = null;
            idNBox.Text = null;
            cardNBox.Text = null;
            Companybox.Text = null;
            CompCombo.Text = null;
            VisitingCombo.Text = null;
            DeliveryNo.Checked = false;
            DeliveryYes.Checked = false;
            CompCombo.Items.Clear();
            VisitingCombo.Items.Clear();
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
            try
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
                if (!checkFields())
                {

                }
                else
                {
                    int Visiting = getWorker();
                    int res = -1;
                    res = getPerson();
                    if (res <= 0)
                    {
                        MessageBox.Show("-----");
                        addPerson();
                        res = getPerson();
                    }
                    int company = getCompany();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Visits(PersonID,CompanyID,Delivery,Entrance,Out,WorkerId,cardNumber,VisitingCompany,State,Address, Comment) " +
                        "VALUES(@PersonID,@CompanyID,@Delivery,@Entrance,@Out,@WorkerId,@cardNumber,@VisitingCompany,@State,@Address,@Comment)");

                    using (SqlCommand com = new SqlCommand(sb.ToString(), connection))
                    {

                        com.Parameters.Add("@PersonID", SqlDbType.Int).Value = res;
                        com.Parameters.Add("@CompanyID", SqlDbType.Int).Value = company;
                        com.Parameters.Add("@Delivery", SqlDbType.Bit).Value = delivery;
                        com.Parameters.Add("@Entrance", SqlDbType.DateTime).Value = DateTime.Now;
                        com.Parameters.Add("@Out", SqlDbType.DateTime).Value = DBNull.Value;
                        com.Parameters.Add("@WorkerId", SqlDbType.Int).Value = Visiting;
                        com.Parameters.Add("@cardNumber", SqlDbType.Int).Value = checkCard(cardNBox.Text);
                        com.Parameters.Add("@VisitingCompany", SqlDbType.NVarChar).Value = valuesCheck(Companybox.Text);
                        com.Parameters.Add("@State", SqlDbType.Bit).Value = 0;
                        com.Parameters.Add("@Address", SqlDbType.NVarChar).Value = addressBox.Text;
                        com.Parameters.Add("@Comment", SqlDbType.NVarChar).Value = commentBox.Text;

                        com.CommandType = CommandType.Text;

                        com.Connection = connection;

                        connection.Open();

                        String output = com.CommandText.ToString();
                        com.ExecuteNonQuery();
                        SqlTransaction trans = connection.BeginTransaction();
                        trans.Commit();
                        MessageBox.Show("Data Inserted!");
                    }
                    connection.Close();
                    clearFields();
                    groupBox1.Hide();
                    VisitingCombo.Hide();
                    VCompAdd.Hide();
                    CompCombo.Hide();
                    VisitingAdd.Hide();
                    VisitingLabel.Hide();
                    CompLabel.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

            VisitorsLabel.Text = getVisitors();
        }

        private Boolean checkFields()
        {
            if (Companybox.Text == "")
            {
                MessageBox.Show("Insert the name of the viisitor's company.");
                return false;
            }
            else if ((DeliveryNo.Checked) == false && (DeliveryYes.Checked == false))
            {
                MessageBox.Show("Specify if the visitor has a delivery.");
                return false;
            }
            else if (CompCombo.Text == "")
            {
                MessageBox.Show("Please identify wich company and wich division the visitor is visitng.");
                return false;
            }
            else if (VisitingCombo.Text == "")
            {
                MessageBox.Show("Please specfy who is being visited.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private object checkCard(String cardn)
        {
            if (cardn == "")
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
            try
            {
                SqlCommand com = new SqlCommand("SELECT PersonID FROM Person Where (Name = @Name OR Surname = @Surname) AND (IdNumber = @IdNumber AND DocType = @DocType)", connection);
                

                com.Parameters.Add("@Doctype", SqlDbType.NVarChar).Value = TypeBox.Text;
                com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = idNBox.Text;
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = SurnameBox.Text;

                com.ExecuteNonQuery();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    WorkId = Int32.Parse(reader["PersonID"].ToString());
                }
            }
            catch (Exception e) {
                MessageBox.Show("Erro "+e.GetHashCode()+": "+ e.Message);
            }
            connection.Close();
            MessageBox.Show("Found Person!" + " ID: "+ WorkId.ToString());
            return WorkId;
        }

        private int getCompany()
        {
            connection.Open();
            String[] compDep = CompCombo.Text.Split(',');
            int compID = 0;
            try
            {
                SqlCommand com = new SqlCommand("Select CompanyID as ID from Companies where CompanyName = @CompanyName AND Department = @Department  ", connection);

                com.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = compDep[0];
                com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = compDep[1];

                com.ExecuteNonQuery();
                SqlDataReader r = com.ExecuteReader();
                r.Read();
                compID = Int32.Parse(r["ID"].ToString());

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return compID;
        }

        private void addPerson()
        {
            connection.Open();

            try
            {
                SqlCommand com = new SqlCommand("Insert into Person(Name,Surname,DocType,IdNumber,PersonID,Expiry,Gender,Nationality) " +
                    "values(@Name,@Surname,@DocType,@IdNumber,NEXT VALUE FOR Person_Id_Seq,@Gender,@Expiry,@Nationality)", connection);
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = NameBox.Text;
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = SurnameBox.Text;
                com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = TypeBox.Text;
                com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = idNBox.Text;
                String[] d = dateBox.Text.Split('-');
                String td = d[0] + "/"+ d[1] +"/" + "20" + d[2];
                com.Parameters.Add("@Expiry", SqlDbType.NVarChar).Value = genderBox.Text;
                com.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = dateBox.Text.ToString();
                com.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = nationBox.Text;


                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                trans.Commit();
                Console.WriteLine("New Person Added!");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            connection.Close();
        }

        private int getWorker()
        {
            int WorkId = -1;
            String[] compText = CompCombo.Text.Split(',');
            connection.Open();
            try
            {
                SqlCommand com = new SqlCommand("Select Id from WorkerCompany Where Name = @Name AND Company = @Company AND Department = @Department", connection);

                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = VisitingCombo.Text.Trim();
                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = compText[0];
                com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = compText[1];

                com.ExecuteNonQuery();
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    WorkId = Int32.Parse(reader["Id"].ToString());
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
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
            commentBox.Text = null;
            addressBox.Text = null;
            nationBox.Text = null;
            dateBox.Text = null;
            genderBox.Text = null;
            VisitingCombo.Text = null;
            fillVisitor();
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
            try
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM WorkerCompany WHERE Company = @Company AND Department = @Department", connection);
                command.Parameters.Add("@Company", SqlDbType.NVarChar).Value = company[0];
                command.Parameters.Add("@Department", SqlDbType.NVarChar).Value = company[1];
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    VisitingCombo.Items.Add(reader["Name"].ToString());
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        private void VCompAdd_Click(object sender, EventArgs e)
        {
            NewDepartment form = new NewDepartment(connection);
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
            try
            {
                SqlCommand command = new SqlCommand("SELECT CompanyName as Company,Department FROM Companies", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CompCombo.Items.Add(reader["Company"].ToString().Trim() + "," + reader["Department"].ToString().Trim());
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
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
            form.ShowDialog();
            this.Enabled = false;
            while (form.Visible) { }
            this.Enabled = true;
            VisitorsLabel.Text = getVisitors();
        }

        private void VisitorButton_Click(object sender, EventArgs e)
        {
            VisitorTable visit = new VisitorTable(connection);
            visit.ShowDialog();
            this.Enabled = false;
            while (visit.Visible) { }
            this.Enabled = true;
        }

        private void fillVisitor()
        {
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT DISTINCT VisitingCompany FROM Visits", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Companybox.Items.Add(reader["VisitingCompany"].ToString().Trim());
                }
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }
    }
}