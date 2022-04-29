
namespace Final_FUI
{
    partial class DEF_Add
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
            this.DEF_Grid_Left = new System.Windows.Forms.DataGridView();
            this.DEF_Grid_Right = new System.Windows.Forms.DataGridView();
            this.DEF_StEd = new System.Windows.Forms.Button();
            this.DEF_Color = new System.Windows.Forms.Button();
            this.DEF_Crack = new System.Windows.Forms.Button();
            this.DEF_Scratch = new System.Windows.Forms.Button();
            this.DEF_Add_Quit = new System.Windows.Forms.Button();
            this.DEF_Save = new System.Windows.Forms.Button();
            this.DEF_Save_Cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Grid_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Grid_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // DEF_Grid_Left
            // 
            this.DEF_Grid_Left.AllowUserToAddRows = false;
            this.DEF_Grid_Left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEF_Grid_Left.Location = new System.Drawing.Point(56, 40);
            this.DEF_Grid_Left.Name = "DEF_Grid_Left";
            this.DEF_Grid_Left.ReadOnly = true;
            this.DEF_Grid_Left.RowHeadersWidth = 51;
            this.DEF_Grid_Left.RowTemplate.Height = 27;
            this.DEF_Grid_Left.Size = new System.Drawing.Size(424, 256);
            this.DEF_Grid_Left.TabIndex = 0;
            // 
            // DEF_Grid_Right
            // 
            this.DEF_Grid_Right.AllowUserToAddRows = false;
            this.DEF_Grid_Right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEF_Grid_Right.Location = new System.Drawing.Point(624, 40);
            this.DEF_Grid_Right.Name = "DEF_Grid_Right";
            this.DEF_Grid_Right.RowHeadersWidth = 51;
            this.DEF_Grid_Right.RowTemplate.Height = 27;
            this.DEF_Grid_Right.Size = new System.Drawing.Size(560, 256);
            this.DEF_Grid_Right.TabIndex = 1;
            // 
            // DEF_StEd
            // 
            this.DEF_StEd.Location = new System.Drawing.Point(56, 328);
            this.DEF_StEd.Name = "DEF_StEd";
            this.DEF_StEd.Size = new System.Drawing.Size(288, 88);
            this.DEF_StEd.TabIndex = 2;
            this.DEF_StEd.Text = "시작/종료";
            this.DEF_StEd.UseVisualStyleBackColor = true;
            this.DEF_StEd.Click += new System.EventHandler(this.InsertRGrid);
            // 
            // DEF_Color
            // 
            this.DEF_Color.Location = new System.Drawing.Point(56, 432);
            this.DEF_Color.Name = "DEF_Color";
            this.DEF_Color.Size = new System.Drawing.Size(288, 88);
            this.DEF_Color.TabIndex = 2;
            this.DEF_Color.Text = "색상";
            this.DEF_Color.UseVisualStyleBackColor = true;
            this.DEF_Color.Click += new System.EventHandler(this.InsertRGrid);
            // 
            // DEF_Crack
            // 
            this.DEF_Crack.Location = new System.Drawing.Point(376, 328);
            this.DEF_Crack.Name = "DEF_Crack";
            this.DEF_Crack.Size = new System.Drawing.Size(288, 88);
            this.DEF_Crack.TabIndex = 2;
            this.DEF_Crack.Text = "갈라짐";
            this.DEF_Crack.UseVisualStyleBackColor = true;
            this.DEF_Crack.Click += new System.EventHandler(this.InsertRGrid);
            // 
            // DEF_Scratch
            // 
            this.DEF_Scratch.Location = new System.Drawing.Point(376, 432);
            this.DEF_Scratch.Name = "DEF_Scratch";
            this.DEF_Scratch.Size = new System.Drawing.Size(288, 88);
            this.DEF_Scratch.TabIndex = 2;
            this.DEF_Scratch.Text = "기스";
            this.DEF_Scratch.UseVisualStyleBackColor = true;
            this.DEF_Scratch.Click += new System.EventHandler(this.InsertRGrid);
            // 
            // DEF_Add_Quit
            // 
            this.DEF_Add_Quit.Location = new System.Drawing.Point(912, 432);
            this.DEF_Add_Quit.Name = "DEF_Add_Quit";
            this.DEF_Add_Quit.Size = new System.Drawing.Size(272, 88);
            this.DEF_Add_Quit.TabIndex = 2;
            this.DEF_Add_Quit.Text = "나가기";
            this.DEF_Add_Quit.UseVisualStyleBackColor = true;
            this.DEF_Add_Quit.Click += new System.EventHandler(this.DEF_Add_Quit_Click);
            // 
            // DEF_Save
            // 
            this.DEF_Save.Location = new System.Drawing.Point(912, 328);
            this.DEF_Save.Name = "DEF_Save";
            this.DEF_Save.Size = new System.Drawing.Size(272, 88);
            this.DEF_Save.TabIndex = 2;
            this.DEF_Save.Text = "저장";
            this.DEF_Save.UseVisualStyleBackColor = true;
            this.DEF_Save.Click += new System.EventHandler(this.DEF_Save_Click);
            // 
            // DEF_Save_Cancle
            // 
            this.DEF_Save_Cancle.Location = new System.Drawing.Point(488, 40);
            this.DEF_Save_Cancle.Name = "DEF_Save_Cancle";
            this.DEF_Save_Cancle.Size = new System.Drawing.Size(128, 88);
            this.DEF_Save_Cancle.TabIndex = 3;
            this.DEF_Save_Cancle.Text = "되돌리기";
            this.DEF_Save_Cancle.UseVisualStyleBackColor = true;
            this.DEF_Save_Cancle.Click += new System.EventHandler(this.DEF_Save_Cancle_Click);
            // 
            // DEF_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 545);
            this.Controls.Add(this.DEF_Save_Cancle);
            this.Controls.Add(this.DEF_Add_Quit);
            this.Controls.Add(this.DEF_Scratch);
            this.Controls.Add(this.DEF_Color);
            this.Controls.Add(this.DEF_Save);
            this.Controls.Add(this.DEF_Crack);
            this.Controls.Add(this.DEF_StEd);
            this.Controls.Add(this.DEF_Grid_Right);
            this.Controls.Add(this.DEF_Grid_Left);
            this.Name = "DEF_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DEF_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Grid_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Grid_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DEF_Grid_Left;
        private System.Windows.Forms.DataGridView DEF_Grid_Right;
        private System.Windows.Forms.Button DEF_StEd;
        private System.Windows.Forms.Button DEF_Color;
        private System.Windows.Forms.Button DEF_Crack;
        private System.Windows.Forms.Button DEF_Scratch;
        private System.Windows.Forms.Button DEF_Add_Quit;
        private System.Windows.Forms.Button DEF_Save;
        private System.Windows.Forms.Button DEF_Save_Cancle;
    }
}