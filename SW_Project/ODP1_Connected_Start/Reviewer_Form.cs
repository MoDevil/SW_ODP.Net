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

     
    public partial class Reviewer_Form : Form
    {

        DataSet magazinesDS;
        OracleDataAdapter magazinesAdapter;
        int reviewerId;


        public Reviewer_Form(int passedReviewerId, DataSet sharedMagazinesDS)
        {
            InitializeComponent();
            reviewerId = passedReviewerId;
            magazinesDS = sharedMagazinesDS;
            string ordb = "Data Source=orcl; User Id=scott; Password=tiger;";
            string cmdstr = "SELECT magazine_id, magazin_title, magazin_content, writer_id, is_approved FROM magazines";
            magazinesAdapter = new OracleDataAdapter(cmdstr, ordb);
            OracleCommandBuilder builder = new OracleCommandBuilder(magazinesAdapter);
            cbMagazines.SelectedIndexChanged += cbMagazines_SelectedIndexChanged;
            PopulateComboBox();
        }
        void PopulateComboBox()
        {
            cbMagazines.Items.Clear();

            var table = magazinesDS.Tables["magazines"];
            foreach (DataRow row in table.Select("is_approved = 0"))
            {
                int id = Convert.ToInt32(row["magazine_id"]);
                cbMagazines.Items.Add(id);
            }

        }
        private void cbMagazines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMagazines.SelectedItem == null)
            {
                txtContentDisplay.Clear();
                return;
            }

            int id = Convert.ToInt32(cbMagazines.SelectedItem);
            var table = magazinesDS.Tables["magazines"];

            // Fast lookup using primary key
            DataRow[] matches = table.Select($"magazine_id = {id}");
            DataRow row = (matches.Length > 0) ? matches[0] : null;


            if (row != null)
                txtContentDisplay.Text = row["magazin_content"].ToString();
            else
                txtContentDisplay.Clear();


        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (cbMagazines.SelectedItem == null) return;
            int id = Convert.ToInt32(cbMagazines.SelectedItem);

            var table = magazinesDS.Tables["magazines"];
            DataRow[] matches = table.Select($"magazine_id = {id}");
            DataRow row = (matches.Length > 0) ? matches[0] : null;

            if (row != null)
            {
                table.Rows.Remove(row);
                MessageBox.Show($"Magazine {id} rejected (removed from list).", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContentDisplay.Clear();
                PopulateComboBox();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (cbMagazines.SelectedItem == null) return;
            int id = Convert.ToInt32(cbMagazines.SelectedItem);

            var table = magazinesDS.Tables["magazines"];
            DataRow[] matches = table.Select($"magazine_id = {id}");
            DataRow row = (matches.Length > 0) ? matches[0] : null;

            if (row != null)
            {
                // Mark approved in-memory
                row["is_approved"] = 1;

                // Push change to database
                magazinesAdapter.Update(magazinesDS, "magazines");

                // Remove from DataSet
                table.Rows.Remove(row);
                MessageBox.Show($"Magazine {id} approved and saved to DB.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtContentDisplay.Clear();
                PopulateComboBox();
            }
        }
    }
}
