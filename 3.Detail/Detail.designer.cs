
namespace Final_FUI
{
    partial class Detail
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
            this.Detail_Grid1 = new System.Windows.Forms.DataGridView();
            this.Detail_Grid2 = new System.Windows.Forms.DataGridView();
            this.btn_LOT_Add = new System.Windows.Forms.Button();
            this.btn_LOT_Del = new System.Windows.Forms.Button();
            this.btn_DEF_Add = new System.Windows.Forms.Button();
            this.btn_DEF_Search = new System.Windows.Forms.Button();
            this.btn_STO_Search = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // Detail_Grid1
            // 
            this.Detail_Grid1.AllowUserToAddRows = false;
            this.Detail_Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail_Grid1.Location = new System.Drawing.Point(8, 24);
            this.Detail_Grid1.Name = "Detail_Grid1";
            this.Detail_Grid1.RowHeadersWidth = 51;
            this.Detail_Grid1.RowTemplate.Height = 27;
            this.Detail_Grid1.Size = new System.Drawing.Size(1088, 120);
            this.Detail_Grid1.TabIndex = 0;
            // 
            // Detail_Grid2
            // 
            this.Detail_Grid2.AllowUserToAddRows = false;
            this.Detail_Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail_Grid2.Location = new System.Drawing.Point(8, 160);
            this.Detail_Grid2.Name = "Detail_Grid2";
            this.Detail_Grid2.RowHeadersWidth = 51;
            this.Detail_Grid2.RowTemplate.Height = 27;
            this.Detail_Grid2.Size = new System.Drawing.Size(1088, 192);
            this.Detail_Grid2.TabIndex = 0;
            // 
            // btn_LOT_Add
            // 
            this.btn_LOT_Add.Location = new System.Drawing.Point(8, 360);
            this.btn_LOT_Add.Name = "btn_LOT_Add";
            this.btn_LOT_Add.Size = new System.Drawing.Size(264, 88);
            this.btn_LOT_Add.TabIndex = 1;
            this.btn_LOT_Add.Text = "LOT 추가";
            this.btn_LOT_Add.UseVisualStyleBackColor = true;
            this.btn_LOT_Add.Click += new System.EventHandler(this.btn_LOT_Add_Click);
            // 
            // btn_LOT_Del
            // 
            this.btn_LOT_Del.Location = new System.Drawing.Point(8, 456);
            this.btn_LOT_Del.Name = "btn_LOT_Del";
            this.btn_LOT_Del.Size = new System.Drawing.Size(264, 88);
            this.btn_LOT_Del.TabIndex = 1;
            this.btn_LOT_Del.Text = "LOT 삭제";
            this.btn_LOT_Del.UseVisualStyleBackColor = true;
            this.btn_LOT_Del.Click += new System.EventHandler(this.btn_LOT_Del_Click);
            // 
            // btn_DEF_Add
            // 
            this.btn_DEF_Add.Location = new System.Drawing.Point(296, 360);
            this.btn_DEF_Add.Name = "btn_DEF_Add";
            this.btn_DEF_Add.Size = new System.Drawing.Size(264, 88);
            this.btn_DEF_Add.TabIndex = 1;
            this.btn_DEF_Add.Text = "불량 등록";
            this.btn_DEF_Add.UseVisualStyleBackColor = true;
            this.btn_DEF_Add.Click += new System.EventHandler(this.btn_DEF_Add_Click);
            // 
            // btn_DEF_Search
            // 
            this.btn_DEF_Search.Location = new System.Drawing.Point(296, 456);
            this.btn_DEF_Search.Name = "btn_DEF_Search";
            this.btn_DEF_Search.Size = new System.Drawing.Size(264, 88);
            this.btn_DEF_Search.TabIndex = 1;
            this.btn_DEF_Search.Text = "불량 조회";
            this.btn_DEF_Search.UseVisualStyleBackColor = true;
            this.btn_DEF_Search.Click += new System.EventHandler(this.btn_DEF_Search_Click);
            // 
            // btn_STO_Search
            // 
            this.btn_STO_Search.Location = new System.Drawing.Point(584, 360);
            this.btn_STO_Search.Name = "btn_STO_Search";
            this.btn_STO_Search.Size = new System.Drawing.Size(264, 88);
            this.btn_STO_Search.TabIndex = 1;
            this.btn_STO_Search.Text = "재고 조회";
            this.btn_STO_Search.UseVisualStyleBackColor = true;
            this.btn_STO_Search.Click += new System.EventHandler(this.btn_STO_Search_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(584, 456);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(264, 88);
            this.btn_End.TabIndex = 1;
            this.btn_End.Text = "작업 종료";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(872, 456);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(216, 88);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "나가기";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 553);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_DEF_Search);
            this.Controls.Add(this.btn_LOT_Del);
            this.Controls.Add(this.btn_STO_Search);
            this.Controls.Add(this.btn_DEF_Add);
            this.Controls.Add(this.btn_LOT_Add);
            this.Controls.Add(this.Detail_Grid2);
            this.Controls.Add(this.Detail_Grid1);
            this.Name = "Detail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_Grid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Detail_Grid2;
        private System.Windows.Forms.Button btn_LOT_Add;
        private System.Windows.Forms.Button btn_LOT_Del;
        private System.Windows.Forms.Button btn_DEF_Add;
        private System.Windows.Forms.Button btn_DEF_Search;
        private System.Windows.Forms.Button btn_STO_Search;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.DataGridView Detail_Grid1;
    }
}