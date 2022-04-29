
namespace Final_FUI
{
    partial class PackagingWorkingForm
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
            this.components = new System.ComponentModel.Container();
            this.PWF_Grid1 = new System.Windows.Forms.DataGridView();
            this.PWF_Grid2 = new System.Windows.Forms.DataGridView();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_DEF_Search = new System.Windows.Forms.Button();
            this.btn_DEF_Add = new System.Windows.Forms.Button();
            this.btn_LOT_Del = new System.Windows.Forms.Button();
            this.btn_LOT_Add = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LotMv1_gif = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Packaging3_gif = new System.Windows.Forms.PictureBox();
            this.Packaging2_gif = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Packaging1_png = new System.Windows.Forms.PictureBox();
            this.Packaging3_png = new System.Windows.Forms.PictureBox();
            this.Packaging2_png = new System.Windows.Forms.PictureBox();
            this.LotMv2_gif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PWF_Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWF_Grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotMv1_gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging3_gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging2_gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging1_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging3_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging2_png)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotMv2_gif)).BeginInit();
            this.SuspendLayout();
            // 
            // PWF_Grid1
            // 
            this.PWF_Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PWF_Grid1.Location = new System.Drawing.Point(80, 40);
            this.PWF_Grid1.Name = "PWF_Grid1";
            this.PWF_Grid1.RowHeadersWidth = 51;
            this.PWF_Grid1.RowTemplate.Height = 27;
            this.PWF_Grid1.Size = new System.Drawing.Size(1584, 96);
            this.PWF_Grid1.TabIndex = 1;
            // 
            // PWF_Grid2
            // 
            this.PWF_Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PWF_Grid2.Location = new System.Drawing.Point(80, 664);
            this.PWF_Grid2.Name = "PWF_Grid2";
            this.PWF_Grid2.RowHeadersWidth = 51;
            this.PWF_Grid2.RowTemplate.Height = 27;
            this.PWF_Grid2.Size = new System.Drawing.Size(1440, 384);
            this.PWF_Grid2.TabIndex = 31;
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(1544, 912);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(120, 104);
            this.btn_Quit.TabIndex = 25;
            this.btn_Quit.Text = "나가기";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_End
            // 
            this.btn_End.Location = new System.Drawing.Point(1544, 184);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(120, 104);
            this.btn_End.TabIndex = 26;
            this.btn_End.Text = "작업 종료";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_DEF_Search
            // 
            this.btn_DEF_Search.Location = new System.Drawing.Point(1544, 760);
            this.btn_DEF_Search.Name = "btn_DEF_Search";
            this.btn_DEF_Search.Size = new System.Drawing.Size(120, 104);
            this.btn_DEF_Search.TabIndex = 27;
            this.btn_DEF_Search.Text = "불량 조회";
            this.btn_DEF_Search.UseVisualStyleBackColor = true;
            this.btn_DEF_Search.Click += new System.EventHandler(this.btn_DEF_Search_Click);
            // 
            // btn_DEF_Add
            // 
            this.btn_DEF_Add.Location = new System.Drawing.Point(1544, 616);
            this.btn_DEF_Add.Name = "btn_DEF_Add";
            this.btn_DEF_Add.Size = new System.Drawing.Size(120, 104);
            this.btn_DEF_Add.TabIndex = 28;
            this.btn_DEF_Add.Text = "불량 등록";
            this.btn_DEF_Add.UseVisualStyleBackColor = true;
            this.btn_DEF_Add.Click += new System.EventHandler(this.btn_DEF_Add_Click);
            // 
            // btn_LOT_Del
            // 
            this.btn_LOT_Del.Location = new System.Drawing.Point(1544, 472);
            this.btn_LOT_Del.Name = "btn_LOT_Del";
            this.btn_LOT_Del.Size = new System.Drawing.Size(120, 104);
            this.btn_LOT_Del.TabIndex = 29;
            this.btn_LOT_Del.Text = "LOT 삭제";
            this.btn_LOT_Del.UseVisualStyleBackColor = true;
            this.btn_LOT_Del.Click += new System.EventHandler(this.btn_LOT_Del_Click);
            // 
            // btn_LOT_Add
            // 
            this.btn_LOT_Add.Location = new System.Drawing.Point(1544, 328);
            this.btn_LOT_Add.Name = "btn_LOT_Add";
            this.btn_LOT_Add.Size = new System.Drawing.Size(120, 104);
            this.btn_LOT_Add.TabIndex = 30;
            this.btn_LOT_Add.Text = "LOT 추가";
            this.btn_LOT_Add.UseVisualStyleBackColor = true;
            this.btn_LOT_Add.Click += new System.EventHandler(this.btn_LOT_Add_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(208, 192);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 80);
            this.btn_Start.TabIndex = 32;
            this.btn_Start.Text = "시작";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(344, 192);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(120, 80);
            this.btn_Stop.TabIndex = 33;
            this.btn_Stop.Text = "종료";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LotMv1_gif
            // 
            this.LotMv1_gif.Image = global::Final_FUI.Properties.Resources.LOT이동;
            this.LotMv1_gif.Location = new System.Drawing.Point(384, 512);
            this.LotMv1_gif.Name = "LotMv1_gif";
            this.LotMv1_gif.Size = new System.Drawing.Size(104, 18);
            this.LotMv1_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LotMv1_gif.TabIndex = 52;
            this.LotMv1_gif.TabStop = false;
            this.LotMv1_gif.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox6.Location = new System.Drawing.Point(1088, 536);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(136, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox5.Location = new System.Drawing.Point(944, 536);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(136, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox4.Location = new System.Drawing.Point(800, 536);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox2.Location = new System.Drawing.Point(512, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox1.Location = new System.Drawing.Point(368, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Packaging3_gif
            // 
            this.Packaging3_gif.Image = global::Final_FUI.Properties.Resources.지게차1;
            this.Packaging3_gif.Location = new System.Drawing.Point(1232, 456);
            this.Packaging3_gif.Name = "Packaging3_gif";
            this.Packaging3_gif.Size = new System.Drawing.Size(168, 128);
            this.Packaging3_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Packaging3_gif.TabIndex = 45;
            this.Packaging3_gif.TabStop = false;
            this.Packaging3_gif.Visible = false;
            // 
            // Packaging2_gif
            // 
            this.Packaging2_gif.Image = global::Final_FUI.Properties.Resources.포장_패키징;
            this.Packaging2_gif.Location = new System.Drawing.Point(728, 248);
            this.Packaging2_gif.Name = "Packaging2_gif";
            this.Packaging2_gif.Size = new System.Drawing.Size(144, 280);
            this.Packaging2_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Packaging2_gif.TabIndex = 43;
            this.Packaging2_gif.TabStop = false;
            this.Packaging2_gif.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_FUI.Properties.Resources.컨베이어;
            this.pictureBox3.Location = new System.Drawing.Point(656, 536);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // Packaging1_png
            // 
            this.Packaging1_png.Image = global::Final_FUI.Properties.Resources.LOT;
            this.Packaging1_png.Location = new System.Drawing.Point(184, 488);
            this.Packaging1_png.Name = "Packaging1_png";
            this.Packaging1_png.Size = new System.Drawing.Size(160, 96);
            this.Packaging1_png.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Packaging1_png.TabIndex = 35;
            this.Packaging1_png.TabStop = false;
            // 
            // Packaging3_png
            // 
            this.Packaging3_png.Image = global::Final_FUI.Properties.Resources.지게차_좌;
            this.Packaging3_png.Location = new System.Drawing.Point(1248, 472);
            this.Packaging3_png.Name = "Packaging3_png";
            this.Packaging3_png.Size = new System.Drawing.Size(136, 104);
            this.Packaging3_png.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Packaging3_png.TabIndex = 46;
            this.Packaging3_png.TabStop = false;
            // 
            // Packaging2_png
            // 
            this.Packaging2_png.Image = global::Final_FUI.Properties.Resources.프레스1;
            this.Packaging2_png.Location = new System.Drawing.Point(728, 248);
            this.Packaging2_png.Name = "Packaging2_png";
            this.Packaging2_png.Size = new System.Drawing.Size(144, 280);
            this.Packaging2_png.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Packaging2_png.TabIndex = 44;
            this.Packaging2_png.TabStop = false;
            // 
            // LotMv2_gif
            // 
            this.LotMv2_gif.Image = global::Final_FUI.Properties.Resources.LOT이동;
            this.LotMv2_gif.Location = new System.Drawing.Point(512, 512);
            this.LotMv2_gif.Name = "LotMv2_gif";
            this.LotMv2_gif.Size = new System.Drawing.Size(104, 18);
            this.LotMv2_gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LotMv2_gif.TabIndex = 53;
            this.LotMv2_gif.TabStop = false;
            this.LotMv2_gif.Visible = false;
            // 
            // PackagingWorkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 1010);
            this.Controls.Add(this.LotMv1_gif);
            this.Controls.Add(this.LotMv2_gif);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Packaging3_gif);
            this.Controls.Add(this.Packaging2_gif);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Packaging1_png);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.PWF_Grid2);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_DEF_Search);
            this.Controls.Add(this.btn_DEF_Add);
            this.Controls.Add(this.btn_LOT_Del);
            this.Controls.Add(this.btn_LOT_Add);
            this.Controls.Add(this.PWF_Grid1);
            this.Controls.Add(this.Packaging3_png);
            this.Controls.Add(this.Packaging2_png);
            this.Name = "PackagingWorkingForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PackagingWorkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PWF_Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWF_Grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotMv1_gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging3_gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging2_gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging1_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging3_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Packaging2_png)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotMv2_gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PWF_Grid1;
        private System.Windows.Forms.DataGridView PWF_Grid2;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_DEF_Search;
        private System.Windows.Forms.Button btn_DEF_Add;
        private System.Windows.Forms.Button btn_LOT_Del;
        private System.Windows.Forms.Button btn_LOT_Add;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Packaging1_png;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Packaging2_gif;
        private System.Windows.Forms.PictureBox Packaging2_png;
        private System.Windows.Forms.PictureBox Packaging3_gif;
        private System.Windows.Forms.PictureBox Packaging3_png;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox LotMv1_gif;
        private System.Windows.Forms.PictureBox LotMv2_gif;
    }
}