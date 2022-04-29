using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_FUI
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }
        private void Status_Load(object sender, EventArgs e)
        {
            DBconnection.SetGridDesign(Status_Grid1);
            Status_Data_Load_Status_Grid1();
            if (Status_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "제품코드", "계획수량", "생산수량", "불량수량", "작업하달일", "작업시작일", "요구마감일", "작업종료일", "작업상태" };
                int[] SetColumnWidth_Status_Grid1 = new int[] { 30, 30, 30, 30, 30, 30, 30, 30, 30, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    Status_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    Status_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Status_Grid1, i, SetColumnWidth_Status_Grid1[i]);
                }
                Status_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Status_Grid1.ColumnHeadersHeight = 30;
            }
        }
        /// <summary>
        /// 작성자 : 안재영
        /// WORKORDER에 있는 컬럼을 Status_Grid1안에 불러온다
        /// </summary>
        private void Status_Data_Load_Status_Grid1()
        {
            DateTime date1 = DateTimePicker1.Value;
            DateTime date2 = DateTimePicker2.Value;

            try
            {
                string sql = $"SELECT W.WOID \n" +
                            $", W.PRODID \n" +
                            $", W.PLANQTY \n" +
                            $", W.PRODQTY \n" +
                            $", SUM(DL.DEFECT_QTY) AS \n" +
                            $", W.DLVDT \n" +
                            $", W.WOSTDTTM \n" +
                            $", W.PLANDTTM \n" +
                            $", W.WOEDDTTM \n" +
                            $", CASE WOSTAT WHEN 'WORK_P' THEN '진행중' WHEN 'WORK_S' THEN '중지' WHEN 'WORK_W' THEN '대기' WHEN 'WORK_C' THEN '완료' END AS WOSTAT \n" +
                            $"FROM WORKORDER W \n" +
                            $"LEFT JOIN DEFECTLOT DL ON W.WOID = DL.DEFECT_LOTID \n";
                
                if (Status_Combobox.SelectedIndex == 0) //배합
                {
                    sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.WOID LIKE 'WM%' \n";
                }
                if (Status_Combobox.SelectedIndex == 1) //카렌다
                {
                    sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.WOID LIKE 'WC%' \n";
                }
                if (Status_Combobox.SelectedIndex == 2) //패키징, 성형
                {
                    sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.WOID LIKE 'WP%' \n";
                }

                sql += "GROUP BY W.WOID, W.PRODID, W.PLANQTY, W.PRODQTY, DL.DEFECT_QTY, W.DLVDT, W.WOSTDTTM, W.PLANDTTM, W.WOEDDTTM, W.WOSTAT \n" +
                            $"ORDER BY DECODE(WOSTAT,'진행중',1,'중지',2,'대기',3,'완료',4), W.WOID ";

                DBconnection dbconnection = new DBconnection();
                DBconnection.DB_Connection(sql, Status_Grid1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 페이지 입니다.");
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Owner = this;
            main.Show();
            this.Visible = false;
        }

        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.Owner = this;
            diary.Show();
            this.Visible = false;
        }

        private void Status_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status_Data_Load_Status_Grid1();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Status_Data_Load_Status_Grid1();
        }

        private void Status_Grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Status_Grid1.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            if (Status_Grid1.Rows[e.RowIndex].Cells[9].Value.ToString() == "진행중")
            {
                e.CellStyle.BackColor = Color.Orange;
                //e.CellStyle.ForeColor = Color.Black;
            }
            else if (Status_Grid1.Rows[e.RowIndex].Cells[9].Value.ToString() == "중지")
            {
                e.CellStyle.BackColor = Color.Red;
                //e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
                //e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
