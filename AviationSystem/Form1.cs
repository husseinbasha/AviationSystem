using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using MaterialSkin;
using System.Data.Entity;

namespace AviationSystem
{
    public partial class Form1 : MaterialForm
    {
        SqlDataAdapter adp;
        DataSet ds;
        DataTable tb;
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {

            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        SqlConnection ConnectToDatabase() {

            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-UKB09DD\SQLEXPRESS;" +
                "Initial Catalog=ATS;" + "Integrated Security=SSPI;"
                ;
            return conn;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Operator Name : " + OperatorTextBox.Text + "\n" );
            var myFont11 = FontFactory.GetFont("NewJune", 18, BaseColor.BLACK);
            var p0 = new Paragraph("AK TRAVEL GLOBAL LTD.\n", myFont11);
            doc.Add(p0);

            
            Paragraph p2 = new Paragraph("A/C type : " + AirCraftTextBox.Text + "\n");
            Paragraph p3 = new Paragraph("Flight No. : " + FlightNumberTextBox.Text + "\n");

            Paragraph p4 = new Paragraph("Route : " + EntryTextBox.Text + "\n");

            Paragraph p5 = new Paragraph("Dtae And Time : " + dateTimePicker1.Text + "\n");

            Paragraph p6 = new Paragraph("purpose of flight : " + BillingAddressTextBox.Text + "\n");

            Paragraph p7 = new Paragraph("Billing Address : " + PurposeTextBox.Text + "\n");
            
            
            PdfPTable table = new PdfPTable(2);
            table.SpacingBefore = 10;
            PdfPCell cell = new PdfPCell(new Phrase("operator:", myFont11));
            PdfPCell cell2 = new PdfPCell(new Phrase(OperatorTextBox.Text, myFont11));
            cell.Colspan = 0 ;
            
            cell2.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell2.HorizontalAlignment = 1;
            table.AddCell(cell);
            table.AddCell(cell2);



            
            doc.Add(table);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Add(p7);

            doc.Close();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            


            
            
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }
        private void onClickClearTextBox(object sender, EventArgs e) {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;
            if (txt.Text == "Operator Name" ) {
                OperatorTextBox.Text = "";

            }


        }
        private void foucedOFF(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToTableBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var selectLanding = "select * from LandingPermit";
                var conString = ConnectToDatabase();
                

                adp = new SqlDataAdapter( selectLanding , conString );
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adp);
                conString.Open();
                DataSet dts = new DataSet();
                dts.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adp.Fill(dts);
                LandingPermitTable.ReadOnly = true;
                LandingPermitTable.DataSource = dts.Tables[0];
                conString.Close();

                
                var context = new ATSEntity();
                LandingPermitTable.DataSource = context.LandingPermits.ToList();


                var lp = new LandingPermit()
                {


                  
                    AircraftReg = AirCraftRegTextBox.Text,
                    AircraftType = AirCraftTextBox.Text,
                    ArrivalTime = dateTimePicker1.Value,
                    TakeoffTime = dateTimePicker1.Value,
                    EntryPoint = EntryTextBox.Text,
                    ExitPoint = ExitTextBox.Text,
                    OperatorName = OperatorTextBox.Text,
                    

            };

                

                context.LandingPermits.Add(lp);
                context.SaveChanges();
                MessageBox.Show("Winner Winner Chicken Dinner");

/*


                string select = "select * from LandingPermits";
                
                cmd = new SqlCommand(select , conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                LandingPermitTable.DataSource = da;
                
                 
                 
                
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show("You did something wrong");

            }
            /*
            try
            {
                int ofn = 0 ;
                int fn = 0;
                try {
                    ofn = System.Convert.ToInt32(PermitNumberTextBox.Text)
                        ;
                    fn = System.Convert.ToInt32(FlightNumberTextBox.Text);
                } catch (Exception ex) {
                    Console.WriteLine(ex);
                }
                SqlConnection conn =  ConnectToDatabase();

                string OverFlyInsertionSqlQuery = "insert into OverFlyPermit(OperatorName , OverFlyNumber , AircraftType , ArrivalTime , FlightNumber ,Purpose ,  EntryPoint , ExitPoint , AircraftReg ) values(' " + OperatorTextBox.Text + " ' , " + ofn + " , '" + AirCraftTextBox.Text + "' ,' "+ dateTimePicker1.Value + "' , " + fn + "  , ' " + PurposeTextBox.Text +  " ' , ' " + EntryTextBox.Text + " ' , ' " + ExitTextBox.Text + " ' , ' " +  AirCraftRegTextBox.Text + " ' )";
                cmd = new SqlCommand(OverFlyInsertionSqlQuery , conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Finally Success CONGRATS YOU CHAMP");
                conn.Close();
            }
            catch (SqlException sqlE) {
                MessageBox.Show("Failed you piece of shit go take a piss");

                Console.WriteLine(sqlE);
            }
        }
        */
        }
        private void AirCraftRegTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
