
namespace Final_FUI
{
    partial class LOT_Add
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
            this.LOT_Add_tb = new System.Windows.Forms.TextBox();
            this.btn_Lot_Add = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.CB_EQPTID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(64, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT 추가";
            // 
            // LOT_Add_tb
            // 
            this.LOT_Add_tb.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LOT_Add_tb.Location = new System.Drawing.Point(272, 96);
            this.LOT_Add_tb.Name = "LOT_Add_tb";
            this.LOT_Add_tb.Size = new System.Drawing.Size(448, 53);
            this.LOT_Add_tb.TabIndex = 1;
            // 
            // btn_Lot_Add
            // 
            this.btn_Lot_Add.Location = new System.Drawing.Point(240, 224);
            this.btn_Lot_Add.Name = "btn_Lot_Add";
            this.btn_Lot_Add.Size = new System.Drawing.Size(224, 88);
            this.btn_Lot_Add.TabIndex = 2;
            this.btn_Lot_Add.Text = "추가";
            this.btn_Lot_Add.UseVisualStyleBackColor = true;
            this.btn_Lot_Add.Click += new System.EventHandler(this.btn_Lot_Add_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(496, 224);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(224, 88);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.Text = "나가기";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // CB_EQPTID
            // 
            this.CB_EQPTID.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CB_EQPTID.FormattingEnabled = true;
            this.CB_EQPTID.Items.AddRange(new object[] {
            "MX001",
            "MX002"});
            this.CB_EQPTID.Location = new System.Drawing.Point(72, 24);
            this.CB_EQPTID.Name = "CB_EQPTID";
            this.CB_EQPTID.Size = new System.Drawing.Size(121, 31);
            this.CB_EQPTID.TabIndex = 3;
            this.CB_EQPTID.SelectedIndexChanged += new System.EventHandler(this.CB_EQPTID_SelectedIndexChanged);
            // 
            // LOT_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 341);
            this.Controls.Add(this.CB_EQPTID);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_Lot_Add);
            this.Controls.Add(this.LOT_Add_tb);
            this.Controls.Add(this.label1);
            this.Name = "LOT_Add";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LOT_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LOT_Add_tb;
        private System.Windows.Forms.Button btn_quit;
        public System.Windows.Forms.Button btn_Lot_Add;
        private System.Windows.Forms.ComboBox CB_EQPTID;
    }
}