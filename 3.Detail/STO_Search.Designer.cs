
namespace Final_FUI
{
    partial class STO_Search
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_STO_Quit = new System.Windows.Forms.Button();
            this.M_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.M_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_STO_Quit
            // 
            this.btn_STO_Quit.Location = new System.Drawing.Point(928, 432);
            this.btn_STO_Quit.Name = "btn_STO_Quit";
            this.btn_STO_Quit.Size = new System.Drawing.Size(272, 88);
            this.btn_STO_Quit.TabIndex = 0;
            this.btn_STO_Quit.Text = "나가기";
            this.btn_STO_Quit.UseVisualStyleBackColor = true;
            this.btn_STO_Quit.Click += new System.EventHandler(this.btn_STO_Quit_Click);
            // 
            // M_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.M_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.M_Chart.Legends.Add(legend1);
            this.M_Chart.Location = new System.Drawing.Point(32, 32);
            this.M_Chart.Name = "M_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.M_Chart.Series.Add(series1);
            this.M_Chart.Size = new System.Drawing.Size(832, 448);
            this.M_Chart.TabIndex = 1;
            this.M_Chart.Text = "Material_Chart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 112);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // STO_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.M_Chart);
            this.Controls.Add(this.btn_STO_Quit);
            this.Name = "STO_Search";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.STO_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.M_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_STO_Quit;
        private System.Windows.Forms.DataVisualization.Charting.Chart M_Chart;
        private System.Windows.Forms.Button button1;
    }
}