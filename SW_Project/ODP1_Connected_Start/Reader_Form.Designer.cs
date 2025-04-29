namespace ODP1_Connected_Start
{
    partial class Reader_Form
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
            this.Search = new System.Windows.Forms.Label();
            this.Search_T = new System.Windows.Forms.TextBox();
            this.Facorites = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Magazine_to_read = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(241, 40);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 29);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search by Title:";
            // 
            // Search_T
            // 
            this.Search_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_T.Location = new System.Drawing.Point(441, 42);
            this.Search_T.Name = "Search_T";
            this.Search_T.Size = new System.Drawing.Size(203, 28);
            this.Search_T.TabIndex = 1;
            // 
            // Facorites
            // 
            this.Facorites.AutoSize = true;
            this.Facorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facorites.Location = new System.Drawing.Point(723, 42);
            this.Facorites.Name = "Facorites";
            this.Facorites.Size = new System.Drawing.Size(161, 29);
            this.Facorites.TabIndex = 2;
            this.Facorites.Text = "Favorites List:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(884, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Magazine_to_read
            // 
            this.Magazine_to_read.AutoSize = true;
            this.Magazine_to_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Magazine_to_read.Location = new System.Drawing.Point(41, 130);
            this.Magazine_to_read.Name = "Magazine_to_read";
            this.Magazine_to_read.Size = new System.Drawing.Size(123, 29);
            this.Magazine_to_read.TabIndex = 4;
            this.Magazine_to_read.Text = "Magazine:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 306);
            this.dataGridView1.TabIndex = 5;
            // 
            // Reader_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Magazine_to_read);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Facorites);
            this.Controls.Add(this.Search_T);
            this.Controls.Add(this.Search);
            this.Name = "Reader_Form";
            this.Text = "Reader_Form";
            this.Load += new System.EventHandler(this.Reader_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox Search_T;
        private System.Windows.Forms.Label Facorites;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Magazine_to_read;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}