namespace database_connectivity
{
    partial class search
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
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.rd_name = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.grd_std_data = new System.Windows.Forms.DataGridView();
            this.lbl_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_std_data)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Location = new System.Drawing.Point(301, 54);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(150, 17);
            this.rd_no.TabIndex = 0;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "Search Using Roll Number";
            this.rd_no.UseVisualStyleBackColor = true;
            this.rd_no.CheckedChanged += new System.EventHandler(this.rd_no_CheckedChanged);
            // 
            // rd_name
            // 
            this.rd_name.AutoSize = true;
            this.rd_name.Location = new System.Drawing.Point(538, 54);
            this.rd_name.Name = "rd_name";
            this.rd_name.Size = new System.Drawing.Size(120, 17);
            this.rd_name.TabIndex = 1;
            this.rd_name.TabStop = true;
            this.rd_name.Text = "Search Using Name";
            this.rd_name.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(371, 109);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(251, 20);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(459, 178);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // grd_std_data
            // 
            this.grd_std_data.AllowUserToAddRows = false;
            this.grd_std_data.AllowUserToDeleteRows = false;
            this.grd_std_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_std_data.Location = new System.Drawing.Point(116, 224);
            this.grd_std_data.Name = "grd_std_data";
            this.grd_std_data.Size = new System.Drawing.Size(739, 120);
            this.grd_std_data.TabIndex = 4;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.Red;
            this.lbl_message.Location = new System.Drawing.Point(436, 395);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 5;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 537);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.grd_std_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.rd_name);
            this.Controls.Add(this.rd_no);
            this.Name = "search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.grd_std_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.RadioButton rd_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView grd_std_data;
        private System.Windows.Forms.Label lbl_message;
    }
}