
namespace Final_FUI
{
    partial class LOT_Del
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
            this.btn_Lot_Del = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F);
            this.label1.Location = new System.Drawing.Point(280, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT 삭제";
            // 
            // btn_Lot_Del
            // 
            this.btn_Lot_Del.Location = new System.Drawing.Point(120, 208);
            this.btn_Lot_Del.Name = "btn_Lot_Del";
            this.btn_Lot_Del.Size = new System.Drawing.Size(224, 88);
            this.btn_Lot_Del.TabIndex = 2;
            this.btn_Lot_Del.Text = "삭제";
            this.btn_Lot_Del.UseVisualStyleBackColor = true;
            this.btn_Lot_Del.Click += new System.EventHandler(this.btn_Lot_Del_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(408, 208);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(224, 88);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "나가기";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // LOT_Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 341);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_Lot_Del);
            this.Controls.Add(this.label1);
            this.Name = "LOT_Del";
            this.Text = "LOT_Del";
            this.Load += new System.EventHandler(this.LOT_Del_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Lot_Del;
        private System.Windows.Forms.Button btn_quit;
    }
}