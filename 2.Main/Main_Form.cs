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
    public partial class Main_Form : Form
    {
        public static string Selected_woid { get; set; }
        public static string PROCID { get; set; }

        public Main_Form()
        {
            InitializeComponent();
        }       
        /// <summary>
        /// 작성자 : 안재영
        /// Main_Form 로드 SetGridDesign에 있는 함수 호출, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Form_Load(object sender, EventArgs e)
        {
            PROCID = "";
            DBconnection.SetGridDesign(Main_Grid1);
            Main_Data_Load_Main_Grid1();
            if (Main_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "제품코드", "계획수량", "생산수량", "불량수량", "완료수량", "작업하달일", "공정", "작업상태" };
                int[] SetColumnWidth_Main_Grid1 = new int[] { 20, 20, 20, 20, 20, 20, 20, 20, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    Main_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    Main_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Main_Grid1, i, SetColumnWidth_Main_Grid1[i]);
                }
                Main_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Main_Grid1.ColumnHeadersHeight = 30;
            }
            
        }
       
        /// <summary>S
        /// 작성자 : 안재영
        /// WORKORDER에 있는 컬럼을 Main_Grid안에 불러온다
        /// </summary>
        private void Main_Data_Load_Main_Grid1()
        {
            DateTime date1 = DateTimePicker1.Value;
            DateTime date2 = DateTimePicker2.Value;

            string sql = $"SELECT W.WOID \n" +
                       $", W.PRODID \n" +
                       $", W.PLANQTY \n" +
                       $", W.PRODQTY \n" +
                       $", SUM(DL.DEFECT_QTY) \n" +
                       $", SUM(L.LOTQTY) \n" +
                       $", W.DLVDT \n" +
                       $", W.PROCID \n" +
                       $", CASE WOSTAT WHEN 'WORK_P' THEN '진행중' WHEN 'WORK_S' THEN '중지' WHEN 'WORK_W' THEN '대기' WHEN 'WORK_C' THEN '완료' END WOSTAT \n" +
                       $"FROM WORKORDER W \n" +
                       $"LEFT JOIN LOT L ON W.WOID = L.WOID \n" +
                       $"LEFT JOIN DEFECTLOT DL ON L.LOTID = DL.DEFECT_LOTID \n";

            if (Main_Combobox.SelectedIndex == 0) //배합
            {
                sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.PROCID = 'M' \n";
                
            }
            if (Main_Combobox.SelectedIndex == 1) //카렌다
            {
                sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.PROCID = 'C' \n";
            }
            if (Main_Combobox.SelectedIndex == 2) //패키징, 성형
            {
                sql += $" WHERE W.DLVDT BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.PROCID = 'P' \n";
            }

            sql += $"GROUP BY W.WOID, W.PRODID, W.PLANQTY, W.PRODQTY, W.DLVDT, W.WOSTAT, W.PROCID \n" +
                    $"ORDER BY DECODE(WOSTAT,'진행중',1,'중지',2,'대기',3,'완료',4), W.WOID \n"; // 줄의 우선순위

            DBconnection dbconnection = new DBconnection();
            DBconnection.DB_Connection(sql, Main_Grid1);
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 페이지입니다.");
        }
        /// <summary>
        /// 작성자 : 안재영
        /// 작업상태가 대기인 작업을 진행중으로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Wostart_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE WORKORDER SET WOSTAT = 'WORK_P', WOSTDTTM = SYSDATE WHERE WOID = " +
                "'"+Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString()+"'"; // WOID를 기준으로 WOSTAT 현재 값을 변경
            DBconnection.DB_Connection1(sql);

            Main_Data_Load_Main_Grid1();

        }
        /// <summary>
        /// 작성자 : 안재영
        /// 작업 상태가 진행중인 작업을 중지로 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WoStop_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE WORKORDER SET WOSTAT = 'WORK_S' WHERE WOID = " +
                "'"+Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString()+"'";
            DBconnection.DB_Connection1(sql);
        }

        private void btn_WoRestart_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE WORKORDER SET WOSTAT = 'WORK_P' WHERE WOID = " +
                "'"+Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString()+"'";
            DBconnection.DB_Connection1(sql);
        }

        /// <summary>
        /// 작성자 : 안재영
        /// 상세정보 버튼 클릭 시 detail 페이지 열기
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void btn_Process_Click(object sender, EventArgs e)
        {
            Selected_woid = Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString();
            PROCID = Main_Grid1.CurrentRow.Cells["PROCID"].Value.ToString();
            if (Main_Grid1.RowCount == 0)
            {
                MessageBox.Show("작업지시가 없습니다.", "INFORM", MessageBoxButtons.OK);
            }
            else if (Main_Grid1.RowCount != 0)
            {
                Selected_woid = Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString();
                
                if (PROCID == "M")
                {
                    StartWorkingForm startworkingform = new StartWorkingForm();
                    startworkingform.ShowDialog();
                }
                else if (PROCID == "C")
                {
                    CalenderWorkingForm calenderworkingform = new CalenderWorkingForm();
                    calenderworkingform.ShowDialog();
                }
                else if (PROCID == "P")
                {
                    PackagingWorkingForm packagingworkingform = new PackagingWorkingForm();
                    packagingworkingform.ShowDialog();
                }
            }
        }
        /// <summary>
        /// 작성자 : 안재영
        /// 조회버튼 클릭 시 Main_Data_Load_Main_Grid1 DB에서 수정된 값 새로고침
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Main_Data_Load_Main_Grid1();
        }
        /// <summary>
        /// 작성자 : 안재영
        /// 생산현황 버튼 클릭 시 생산현황 페이지 열림
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Status_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Owner = this;
            status.Show();
            this.Visible = false;
        }

        private void btn_Diary_Click(object sender, EventArgs e)
        {
            Diary diary = new Diary();
            diary.Owner = this;
            diary.Show();
            this.Visible = false;
        }

        private void Main_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main_Data_Load_Main_Grid1();
        }

        private void Main_Grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_woid = Main_Grid1.CurrentRow.Cells["WOID"].Value.ToString();
            PROCID = Main_Grid1.CurrentRow.Cells["PROCID"].Value.ToString();
            if (PROCID == "M")
            {
                StartWorkingForm startworkingform = new StartWorkingForm();
                startworkingform.ShowDialog();
            }
            else if (PROCID == "C")
            {
                CalenderWorkingForm calenderworkingform = new CalenderWorkingForm();
                calenderworkingform.ShowDialog();
            }
            else if (PROCID == "P")
            {
                PackagingWorkingForm packagingworkingform = new PackagingWorkingForm();
                packagingworkingform.ShowDialog();
            }
            
            Main_Data_Load_Main_Grid1();

        }
        private void Main_Grid1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Main_Grid1.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            if (Main_Grid1.Rows[e.RowIndex].Cells[8].Value.ToString() == "진행중")
            {
                e.CellStyle.BackColor = Color.Orange;
                //e.CellStyle.ForeColor = Color.Black;
            }
            else if (Main_Grid1.Rows[e.RowIndex].Cells[8].Value.ToString() == "중지")
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
