using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Login_Form : Form
    {
        OracleConnection conn;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        public static int User_id;
        public static string User_name;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Back_button_Click(object sender, EventArgs e)
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
            cmd.CommandText = "GetRow";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("Email", OracleDbType.Varchar2).Value = Email_T.Text;
            cmd.Parameters.Add("Password", OracleDbType.Varchar2).Value = Password_T.Text;
            cmd.Parameters.Add("Id", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("Name", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            User_id = ((OracleDecimal)cmd.Parameters["Id"].Value).ToInt32();
            User_name = cmd.Parameters["Name"].Value.ToString();
            MessageBox.Show("Name: " + User_name + "  ID: " + User_id);

            Welcome_Form welcomeForm = Application.OpenForms.OfType<Welcome_Form>().FirstOrDefault();
            if (welcomeForm != null)
            {
                welcomeForm.Close();
            }
        }
    }
}
