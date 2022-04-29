
namespace Final_FUI
{
    partial class Diary
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
            this.Diary_Grid1 = new System.Windows.Forms.DataGridView();
            this.Diary_Grid2 = new System.Windows.Forms.DataGridView();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Main = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_Diary = new System.Windows.Forms.Button();
            this.oracleConnection1 = new Oracle.ManagedDataAccess.Client.OracleConnection();
            this.Diary_Combobox = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Diary_Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diary_Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // Diary_Grid1
            // 
            this.Diary_Grid1.AllowUserToAddRows = false;
            this.Diary_Grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diary_Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Diary_Grid1.Location = new System.Drawing.Point(112, 160);
            this.Diary_Grid1.Name = "Diary_Grid1";
            this.Diary_Grid1.RowHeadersWidth = 51;
            this.Diary_Grid1.RowTemplate.Height = 27;
            this.Diary_Grid1.Size = new System.Drawing.Size(1552, 464);
            this.Diary_Grid1.TabIndex = 0;
            this.Diary_Grid1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Diary_Grid1_CellMouseClick);
            // 
            // Diary_Grid2
            // 
            this.Diary_Grid2.AllowUserToAddRows = false;
            this.Diary_Grid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diary_Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Diary_Grid2.Location = new System.Drawing.Point(112, 648);
            this.Diary_Grid2.Name = "Diary_Grid2";
            this.Diary_Grid2.RowHeadersWidth = 51;
            this.Diary_Grid2.RowTemplate.Height = 27;
            this.Diary_Grid2.Size = new System.Drawing.Size(1552, 328);
            this.Diary_Grid2.TabIndex = 1;
            this.Diary_Grid2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Diary_Grid2_CellFormatting);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(112, 120);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.DateTimePicker1.TabIndex = 2;
            this.DateTimePicker1.Value = new System.DateTime(2021, 8, 11, 14, 12, 0, 0);
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(688, 40);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(120, 50);
            this.btn_Main.TabIndex = 3;
            this.btn_Main.Text = "메인";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(816, 40);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(120, 50);
            this.btn_Status.TabIndex = 4;
            this.btn_Status.Text = "생산현황";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Diary
            // 
            this.btn_Diary.Location = new System.Drawing.Point(944, 40);
            this.btn_Diary.Name = "btn_Diary";
            this.btn_Diary.Size = new System.Drawing.Size(120, 50);
            this.btn_Diary.TabIndex = 5;
            this.btn_Diary.Text = "일지";
            this.btn_Diary.UseVisualStyleBackColor = true;
            this.btn_Diary.Click += new System.EventHandler(this.btn_Diary_Click);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ChunkMigrationConnectionTimeout = "120";
            // 
            // Diary_Combobox
            // 
            this.Diary_Combobox.FormattingEnabled = true;
            this.Diary_Combobox.Items.AddRange(new object[] {
            "배합",
            "카렌다",
            "패키징"});
            this.Diary_Combobox.Location = new System.Drawing.Point(112, 40);
            this.Diary_Combobox.Name = "Diary_Combobox";
            this.Diary_Combobox.Size = new System.Drawing.Size(121, 23);
            this.Diary_Combobox.TabIndex = 6;
            this.Diary_Combobox.Text = "배합";
            this.Diary_Combobox.SelectedIndexChanged += new System.EventHandler(this.Diary_Combobox_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(248, 32);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 48);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new System.Drawing.Point(328, 120);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.DateTimePicker2.TabIndex = 8;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1019);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Diary_Combobox);
            this.Controls.Add(this.btn_Diary);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Diary_Grid2);
            this.Controls.Add(this.Diary_Grid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "일지";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Diary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diary_Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diary_Grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Diary_Grid1;
        private System.Windows.Forms.DataGridView Diary_Grid2;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_Diary;
        private Oracle.ManagedDataAccess.Client.OracleConnection oracleConnection1;
        private System.Windows.Forms.ComboBox Diary_Combobox;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
    }
}