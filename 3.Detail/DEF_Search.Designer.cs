
namespace Final_FUI
{
    partial class DEF_Search
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
            this.DEF_Search_Grid = new System.Windows.Forms.DataGridView();
            this.DEF_Search_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Search_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DEF_Search_Grid
            // 
            this.DEF_Search_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEF_Search_Grid.Location = new System.Drawing.Point(40, 48);
            this.DEF_Search_Grid.Name = "DEF_Search_Grid";
            this.DEF_Search_Grid.RowHeadersWidth = 51;
            this.DEF_Search_Grid.RowTemplate.Height = 27;
            this.DEF_Search_Grid.Size = new System.Drawing.Size(1024, 320);
            this.DEF_Search_Grid.TabIndex = 0;
            // 
            // DEF_Search_Quit
            // 
            this.DEF_Search_Quit.Location = new System.Drawing.Point(800, 440);
            this.DEF_Search_Quit.Name = "DEF_Search_Quit";
            this.DEF_Search_Quit.Size = new System.Drawing.Size(264, 88);
            this.DEF_Search_Quit.TabIndex = 1;
            this.DEF_Search_Quit.Text = "나가기";
            this.DEF_Search_Quit.UseVisualStyleBackColor = true;
            this.DEF_Search_Quit.Click += new System.EventHandler(this.DEF_Search_Quit_Click);
            // 
            // DEF_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 553);
            this.Controls.Add(this.DEF_Search_Quit);
            this.Controls.Add(this.DEF_Search_Grid);
            this.Name = "DEF_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEF_Search";
            this.Load += new System.EventHandler(this.DEF_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEF_Search_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DEF_Search_Grid;
        private System.Windows.Forms.Button DEF_Search_Quit;
    }
}