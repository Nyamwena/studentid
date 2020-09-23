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
using MySql.Data.MySqlClient;

namespace IDs
{
    public partial class printcard : Form
    {
        SQLConfig pro = new SQLConfig();
        public printcard()
        {
            InitializeComponent();

            //pro.strcon.Open();
            
            //pro.sqlselect = "SELECT * FROM tblperson WHERE studentnumber ='" + studentNumber + "'";

            //pro.cmd = new MySqlCommand();
            //pro.cmd.Connection = pro.strcon;
            //pro.cmd.CommandText = pro.sqlselect;
            //pro.da = new MySqlDataAdapter();
            //pro.da.SelectCommand = pro.cmd;
            //pro.dt = new DataTable();
            //pro.da.Fill(pro.dt);

            //StID myid = new StID();


            //myid.Load();
            //myid.SetDataSource(pro.dt);

            //crystalReportViewer1.ReportSource = myid;
            
        }

        private void printcard_Load(object sender, EventArgs e)
        {
            //StID myid = new StID();


            //crystalReportViewer1.SelectionFormula = "{tblperson1.studentnumber} = 'C205918' ";

            //crystalReportViewer1.ReportSource = myid;
            //crystalReportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StID myid = new StID();
            

            crystalReportViewer1.SelectionFormula = "{tblperson1.studentnumber} = '" + txtSearch.Text + "' ";

            crystalReportViewer1.ReportSource = myid;
           crystalReportViewer1.RefreshReport();

        }
    }
}
