namespace KA_lb2
{
    partial class mnForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbColRow = new System.Windows.Forms.ComboBox();
            this.cbColColumns = new System.Windows.Forms.ComboBox();
            this.Row = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DataGridView();
            this.dtResult = new System.Windows.Forms.DataGridView();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(603, 67);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbColRow
            // 
            this.cbColRow.FormattingEnabled = true;
            this.cbColRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbColRow.Location = new System.Drawing.Point(603, 28);
            this.cbColRow.Name = "cbColRow";
            this.cbColRow.Size = new System.Drawing.Size(42, 21);
            this.cbColRow.TabIndex = 3;
            // 
            // cbColColumns
            // 
            this.cbColColumns.FormattingEnabled = true;
            this.cbColColumns.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbColColumns.Location = new System.Drawing.Point(664, 28);
            this.cbColColumns.Name = "cbColColumns";
            this.cbColColumns.Size = new System.Drawing.Size(40, 21);
            this.cbColColumns.TabIndex = 4;
            // 
            // Row
            // 
            this.Row.AutoSize = true;
            this.Row.Location = new System.Drawing.Point(600, 12);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(29, 13);
            this.Row.TabIndex = 5;
            this.Row.Text = "Row";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columns";
            // 
            // dtStart
            // 
            this.dtStart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStart.Location = new System.Drawing.Point(13, 28);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(301, 281);
            this.dtStart.TabIndex = 7;
            // 
            // dtResult
            // 
            this.dtResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtResult.Location = new System.Drawing.Point(320, 28);
            this.dtResult.Name = "dtResult";
            this.dtResult.Size = new System.Drawing.Size(277, 281);
            this.dtResult.TabIndex = 8;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(606, 286);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(102, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // mnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 343);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.dtResult);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.cbColColumns);
            this.Controls.Add(this.cbColRow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGenerate);
            this.Name = "mnForm";
            this.Text = "KA_lab2";
            ((System.ComponentModel.ISupportInitialize)(this.dtStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbColRow;
        private System.Windows.Forms.ComboBox cbColColumns;
        private System.Windows.Forms.Label Row;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtStart;
        private System.Windows.Forms.DataGridView dtResult;
        private System.Windows.Forms.Button btnAbout;
    }
}

