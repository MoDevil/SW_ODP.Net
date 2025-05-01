namespace ODP1_Connected_Start
{
    partial class Reviewer_Form
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
            this.cbMagazines = new System.Windows.Forms.ComboBox();
            this.txtContentDisplay = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMagazines
            // 
            this.cbMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbMagazines.FormattingEnabled = true;
            this.cbMagazines.Location = new System.Drawing.Point(981, 12);
            this.cbMagazines.Name = "cbMagazines";
            this.cbMagazines.Size = new System.Drawing.Size(121, 37);
            this.cbMagazines.TabIndex = 0;
            // 
            // txtContentDisplay
            // 
            this.txtContentDisplay.Location = new System.Drawing.Point(77, 104);
            this.txtContentDisplay.Multiline = true;
            this.txtContentDisplay.Name = "txtContentDisplay";
            this.txtContentDisplay.ReadOnly = true;
            this.txtContentDisplay.Size = new System.Drawing.Size(825, 318);
            this.txtContentDisplay.TabIndex = 1;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnApprove.Location = new System.Drawing.Point(1189, 370);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(130, 52);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReject.Location = new System.Drawing.Point(1189, 290);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(130, 52);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // Reviewer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 522);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtContentDisplay);
            this.Controls.Add(this.cbMagazines);
            this.Name = "Reviewer_Form";
            this.Text = "Reviewer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMagazines;
        private System.Windows.Forms.TextBox txtContentDisplay;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}