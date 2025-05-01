using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{

    public partial class Welcome_Form : Form
    {

        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Sign_Up_Form sign_Up_Form = new Sign_Up_Form();
            this.Hide();
            sign_Up_Form.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            this.Hide();
            login_Form.Show();
        }
    }
}
