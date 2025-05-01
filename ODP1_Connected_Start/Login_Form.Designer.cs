namespace ODP1_Connected_Start
{
    partial class Login_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Email_T = new System.Windows.Forms.TextBox();
            this.Password_T = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(336, 209);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(80, 29);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email:";
            // 
            // Email_T
            // 
            this.Email_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_T.Location = new System.Drawing.Point(422, 211);
            this.Email_T.Name = "Email_T";
            this.Email_T.Size = new System.Drawing.Size(154, 28);
            this.Email_T.TabIndex = 2;
            // 
            // Password_T
            // 
            this.Password_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_T.Location = new System.Drawing.Point(878, 211);
            this.Password_T.Name = "Password_T";
            this.Password_T.Size = new System.Drawing.Size(154, 28);
            this.Password_T.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(746, 209);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(126, 29);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(501, 363);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(142, 42);
            this.Back_button.TabIndex = 5;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Button.Location = new System.Drawing.Point(764, 363);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(142, 42);
            this.Next_Button.TabIndex = 6;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 605);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Password_T);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email_T);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox Email_T;
        private System.Windows.Forms.TextBox Password_T;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next_Button;
    }
}