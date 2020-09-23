using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSBunifu.Config;
using System.IO;
using MySql.Data.MySqlClient;

namespace IDs
{
    public partial class Form1 : Form
    {
        SQLConfig qry = new SQLConfig();
        UsableFunction useFunc = new UsableFunction();

       // string conString = "datasource=localhost;database=idsdb;port=3306;username=root";

        MySqlConnection con = new MySqlConnection("datasource=localhost;database=idsdb;port=3306;username=root");
        MySqlCommand cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }


        public void ResizeImage(string OriginalFile, string NewFile, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            System.Drawing.Image FullsizeImage = System.Drawing.Image.FromFile(OriginalFile);
            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipNone);
            //FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
                NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
            }
            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);
            // Clear handle to original file so that we can overwrite it if necessary
            // Save resized picture
            NewImage.Save(@NewFile);
        }

        private void btnSaveImages_Click(object sender, EventArgs e)
        {


            printcard pr = new printcard();
            pr.Show();
           
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imgPath.Text = openFileDialog1.FileName;
                    picPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            var nums = "0123456789";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = nums[random.Next(nums.Length)];
            }

            var finalString = new String(stringChars);

            var prefix = "C20";

            var mychar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var chars = new char[1];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = mychar[random.Next(mychar.Length)];
            }
            var postfix = new String(chars);

            string studentNum =  prefix + finalString;
            // var year = "20";

            idNumber.Text = studentNum;

            FileStream fs;
            BinaryReader br;
            try
            {
                //   string FileName = picPath.Text;
                //'" + studentNum + "','" + txtName.Text + "','" + txtSurname.Text +"','"+ 
                //drpProg.Text + "'," + txtLevel.Text + ",'" + txtSemester.Text +"'," + bacrode + ",'"+ImageData+"'

                if(txtLevel.Text == "" && txtName.Text == "" && txtSurname.Text == "" && txtSurname.Text == "" && cmbPro.Text =="")
                {
                    MessageBox.Show("Name should not be empty");
                    return;
                }
                else
                {
                    byte[] ImageData = null;
                    fs = new FileStream(imgPath.Text, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();



                    string cmdString = "INSERT INTO tblperson (studentnumber,name,surname,programme,level,semester,barcode,photo)" +
                                     " Values(@studentNumber, @name, @surname, @programme, @lvl, @semester, @barcode, @photo)";

                    cmd = new MySqlCommand(cmdString, con);

                    cmd.Parameters.Add("@studentNumber", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@surname", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@programme", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@lvl", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@semester", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@barcode", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@photo", MySqlDbType.Blob);
                    cmd.Parameters["@studentNumber"].Value = studentNum;
                    cmd.Parameters["@name"].Value = txtName.Text;
                    cmd.Parameters["@surname"].Value = txtSurname.Text;
                    cmd.Parameters["@programme"].Value = cmbPro.Text;

                    cmd.Parameters["@lvl"].Value = txtLevel.Text;
                    cmd.Parameters["@semester"].Value = txtSemester.Text;
                    cmd.Parameters["@barcode"].Value = studentNum;
                    cmd.Parameters["@photo"].Value = ImageData;

                    // qry.SaveData(qry.sqladd);
                    con.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Image saved sucessfully!");
                    }




                    StID myid = new StID();
                    crystalReportViewer1.SelectionFormula = "{tblperson1.studentnumber} = '" + idNumber.Text + "'";

                    crystalReportViewer1.ReportSource = myid;
                    crystalReportViewer1.RefreshReport();


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
