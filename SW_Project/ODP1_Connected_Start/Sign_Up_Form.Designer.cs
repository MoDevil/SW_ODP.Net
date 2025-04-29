namespace ODP1_Connected_Start
{
    partial class Sign_Up_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpForm = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Email_T = new System.Windows.Forms.TextBox();
            this.Password_T = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserName_T = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Sign_as = new System.Windows.Forms.Label();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Sign_as_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SignUpForm
            // 
            this.SignUpForm.AutoSize = true;
            this.SignUpForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpForm.Location = new System.Drawing.Point(608, 9);
            this.SignUpForm.Name = "SignUpForm";
            this.SignUpForm.Size = new System.Drawing.Size(237, 65);
            this.SignUpForm.TabIndex = 0;
            this.SignUpForm.Text = "Sign UP";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(167, 136);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(80, 29);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            // 
            // Email_T
            // 
            this.Email_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_T.Location = new System.Drawing.Point(242, 138);
            this.Email_T.Name = "Email_T";
            this.Email_T.Size = new System.Drawing.Size(157, 28);
            this.Email_T.TabIndex = 2;
            // 
            // Password_T
            // 
            this.Password_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_T.Location = new System.Drawing.Point(661, 136);
            this.Password_T.Name = "Password_T";
            this.Password_T.Size = new System.Drawing.Size(157, 28);
            this.Password_T.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(541, 136);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 29);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // UserName_T
            // 
            this.UserName_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_T.Location = new System.Drawing.Point(1132, 137);
            this.UserName_T.Name = "UserName_T";
            this.UserName_T.Size = new System.Drawing.Size(157, 28);
            this.UserName_T.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(1001, 135);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(135, 29);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "UserName:";
            // 
            // Sign_as
            // 
            this.Sign_as.AutoSize = true;
            this.Sign_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_as.Location = new System.Drawing.Point(302, 250);
            this.Sign_as.Name = "Sign_as";
            this.Sign_as.Size = new System.Drawing.Size(97, 26);
            this.Sign_as.TabIndex = 7;
            this.Sign_as.Text = "Sign_as:";
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(513, 412);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(133, 35);
            this.Back_Button.TabIndex = 11;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Button.Location = new System.Drawing.Point(785, 412);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(133, 35);
            this.Next_Button.TabIndex = 12;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Sign_as_box
            // 
            this.Sign_as_box.Location = new System.Drawing.Point(418, 252);
            this.Sign_as_box.Name = "Sign_as_box";
            this.Sign_as_box.Size = new System.Drawing.Size(121, 24);
            this.Sign_as_box.TabIndex = 0;
            // 
            // Sign_Up_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 610);
            this.Controls.Add(this.Sign_as_box);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Sign_as);
            this.Controls.Add(this.UserName_T);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password_T);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email_T);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.SignUpForm);
            this.Name = "Sign_Up_Form";
            this.Text = "Sign_Up_Form";
            this.Load += new System.EventHandler(this.Sign_Up_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpForm;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Email_T;
        private System.Windows.Forms.TextBox Password_T;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox UserName_T;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Sign_as;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.ComboBox Sign_as_box;
    }
}