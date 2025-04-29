using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ODP1_Connected_Start
{
    public partial class Sign_Up_Form : Form
    {
        OracleConnection conn;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        static int incremetla_id = 1;
        public Sign_Up_Form()
        {
            InitializeComponent();
        }
        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {
            Sign_as_box.Items.Add("Reader");
            Sign_as_box.Items.Add("Writer");
            Sign_as_box.Items.Add("Reviewer");
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Welcome_Form welcomeForm = Application.OpenForms.OfType<Welcome_Form>().FirstOrDefault();

            if (welcomeForm != null)
            {
                welcomeForm.Show();
                this.Close();
            }
            else
            {
                // If Welcome form was closed, create a new instance
                Welcome_Form newWelcomeForm = new Welcome_Form();
                newWelcomeForm.Show();
                this.Close();
            }
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into users values(:id, :userName,:email, :password, :sign_as)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", incremetla_id++);
            cmd.Parameters.Add("userName", UserName_T.Text.ToString());
            cmd.Parameters.Add("email", Email_T.Text.ToString());
            cmd.Parameters.Add("Password", Password_T.Text.ToString());
            cmd.Parameters.Add("sign_as", Sign_as_box.SelectedItem.ToString());
            OracleDataReader r = cmd.ExecuteReader();

            Welcome_Form welcomeForm = Application.OpenForms.OfType<Welcome_Form>().FirstOrDefault();
            if (welcomeForm != null)
            {
                welcomeForm.Close();
            }
        }
    }
}
