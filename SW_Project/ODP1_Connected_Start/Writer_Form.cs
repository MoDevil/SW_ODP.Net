using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace ODP1_Connected_Start
{
    public partial class Writer_Form : Form
    {
        DataSet magazinesDS;
        OracleDataAdapter magazinesAdapter;
        int writerId;
        public Writer_Form(int passedWriterId)
        {
            InitializeComponent();
            writerId = passedWriterId;
            string ordb = "Data Source=orcl; User Id=scott; Password=tiger;";
            string cmdstr = "SELECT magazine_id, magazin_title, magazin_content, writer_id, is_approved FROM magazines";
            magazinesAdapter = new OracleDataAdapter(cmdstr, ordb);
            OracleCommandBuilder builder = new OracleCommandBuilder(magazinesAdapter);
            magazinesDS = new DataSet();
            magazinesAdapter.Fill(magazinesDS, "magazines");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = magazinesDS.Tables["magazines"];
            object maxObj = table.Compute("MAX(magazine_id)", "");
            int currentMax = (maxObj == DBNull.Value) ? 0 : Convert.ToInt32(maxObj);
            int nextId = currentMax + 1;


            DataRow newRow = table.NewRow();
            newRow["magazine_id"] = nextId;
            newRow["magazin_title"] = txtTitle.Text.Trim();
            newRow["magazin_content"] = txtContent.Text.Trim();
            newRow["writer_id"] = writerId;
            newRow["is_approved"] = 0;

            table.Rows.Add(newRow);

            MessageBox.Show($"Submitted in-memory as ID {nextId}.\nAwaiting reviewer approval.",
                           "Submission Recorded",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            txtTitle.Clear();
            txtContent.Clear();
            var reviewerForm = new Reviewer_Form(5, magazinesDS);
            reviewerForm.Show();
        }
    }
}
