
namespace Final_FUI
{
    partial class Main_Form
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
            this.btn_Main = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_Diary = new System.Windows.Forms.Button();
            this.btn_Wostart = new System.Windows.Forms.Button();
            this.btn_WoStop = new System.Windows.Forms.Button();
            this.btn_Process = new System.Windows.Forms.Button();
            this.Main_Grid1 = new System.Windows.Forms.DataGridView();
            this.WorkOrder = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Main_Combobox = new System.Windows.Forms.ComboBox();
            this.btn_WoRestart = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Main
            // 
            this.btn_Main.Location = new System.Drawing.Point(744, 40);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(120, 50);
            this.btn_Main.TabIndex = 0;
            this.btn_Main.Text = "메인";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(872, 40);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(120, 50);
            this.btn_Status.TabIndex = 1;
            this.btn_Status.Text = "생산현황";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Diary
            // 
            this.btn_Diary.Location = new System.Drawing.Point(1000, 40);
            this.btn_Diary.Name = "btn_Diary";
            this.btn_Diary.Size = new System.Drawing.Size(120, 50);
            this.btn_Diary.TabIndex = 1;
            this.btn_Diary.Text = "일지";
            this.btn_Diary.UseVisualStyleBackColor = true;
            this.btn_Diary.Click += new System.EventHandler(this.btn_Diary_Click);
            // 
            // btn_Wostart
            // 
            this.btn_Wostart.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Wostart.Location = new System.Drawing.Point(48, 328);
            this.btn_Wostart.Name = "btn_Wostart";
            this.btn_Wostart.Size = new System.Drawing.Size(150, 60);
            this.btn_Wostart.TabIndex = 0;
            this.btn_Wostart.Text = "작업시작";
            this.btn_Wostart.UseVisualStyleBackColor = false;
            this.btn_Wostart.Click += new System.EventHandler(this.btn_Wostart_Click);
            // 
            // btn_WoStop
            // 
            this.btn_WoStop.Location = new System.Drawing.Point(48, 408);
            this.btn_WoStop.Name = "btn_WoStop";
            this.btn_WoStop.Size = new System.Drawing.Size(150, 60);
            this.btn_WoStop.TabIndex = 1;
            this.btn_WoStop.Text = "작업중지";
            this.btn_WoStop.UseVisualStyleBackColor = true;
            this.btn_WoStop.Click += new System.EventHandler(this.btn_WoStop_Click);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(48, 568);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(150, 60);
            this.btn_Process.TabIndex = 1;
            this.btn_Process.Text = "공정";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // Main_Grid1
            // 
            this.Main_Grid1.AllowUserToAddRows = false;
            this.Main_Grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_Grid1.Location = new System.Drawing.Point(224, 184);
            this.Main_Grid1.Name = "Main_Grid1";
            this.Main_Grid1.RowHeadersWidth = 51;
            this.Main_Grid1.RowTemplate.Height = 27;
            this.Main_Grid1.Size = new System.Drawing.Size(1480, 792);
            this.Main_Grid1.TabIndex = 2;
            this.Main_Grid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_Grid1_CellDoubleClick);
            this.Main_Grid1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Main_Grid1_CellFormatting);
            // 
            // WorkOrder
            // 
            this.WorkOrder.AutoSize = true;
            this.WorkOrder.Location = new System.Drawing.Point(232, 152);
            this.WorkOrder.Name = "WorkOrder";
            this.WorkOrder.Size = new System.Drawing.Size(67, 15);
            this.WorkOrder.TabIndex = 3;
            this.WorkOrder.Text = "작업지시";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(320, 144);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.DateTimePicker1.TabIndex = 4;
            this.DateTimePicker1.Value = new System.DateTime(2021, 8, 11, 14, 12, 0, 0);
            // 
            // Main_Combobox
            // 
            this.Main_Combobox.FormattingEnabled = true;
            this.Main_Combobox.Items.AddRange(new object[] {
            "배합",
            "카렌다",
            "패키징"});
            this.Main_Combobox.Location = new System.Drawing.Point(56, 56);
            this.Main_Combobox.Name = "Main_Combobox";
            this.Main_Combobox.Size = new System.Drawing.Size(121, 23);
            this.Main_Combobox.TabIndex = 5;
            this.Main_Combobox.Text = "배합";
            this.Main_Combobox.SelectedIndexChanged += new System.EventHandler(this.Main_Combobox_SelectedIndexChanged);
            // 
            // btn_WoRestart
            // 
            this.btn_WoRestart.Location = new System.Drawing.Point(48, 488);
            this.btn_WoRestart.Name = "btn_WoRestart";
            this.btn_WoRestart.Size = new System.Drawing.Size(150, 60);
            this.btn_WoRestart.TabIndex = 6;
            this.btn_WoRestart.Text = "재시작";
            this.btn_WoRestart.UseVisualStyleBackColor = true;
            this.btn_WoRestart.Click += new System.EventHandler(this.btn_WoRestart_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(216, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 45);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CustomFormat = "";
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new System.Drawing.Point(536, 144);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.DateTimePicker2.TabIndex = 8;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(48, 648);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 60);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1015);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_WoRestart);
            this.Controls.Add(this.Main_Combobox);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.WorkOrder);
            this.Controls.Add(this.Main_Grid1);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.btn_WoStop);
            this.Controls.Add(this.btn_Diary);
            this.Controls.Add(this.btn_Wostart);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.btn_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "메인폼";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_Diary;
        private System.Windows.Forms.Button btn_Wostart;
        private System.Windows.Forms.Button btn_WoStop;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.DataGridView Main_Grid1;
        private System.Windows.Forms.Label WorkOrder;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.ComboBox Main_Combobox;
        private System.Windows.Forms.Button btn_WoRestart;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker DateTimePicker2;
        private System.Windows.Forms.Button btn_Exit;
    }
}