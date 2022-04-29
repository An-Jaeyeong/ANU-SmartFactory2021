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
    public partial class Diary : Form
    {
        //string woid = ""; 
        public Diary()
        {
            InitializeComponent();
        }
        private void Diary_Load(object sender, EventArgs e)
        {
            DBconnection.SetGridDesign(Diary_Grid1);
            DBconnection.SetGridDesign(Diary_Grid2);
            Diary_Data_Load_Diary_Grid1();
            if (Diary_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "제품코드", "제품명", "설비", "계획수량", "생산수량", "불량수량", "작업하달일", "작업시작일", "요구마감일", "작업종료일", "작업상태" };
                int[] SetColumnWidth_Diary_Grid1 = new int[] { 25, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    Diary_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    Diary_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Diary_Grid1, i, SetColumnWidth_Diary_Grid1[i]);
                }
                Diary_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Diary_Grid1.ColumnHeadersHeight = 30;
            }
            
            //Diary_Data_Load_Diary_Grid2();
        }

        /// <summary>
        /// 작성자 : 안재영
        /// WORKORDER에 있는 컬럼을 Diary_Grid1안에 불러온다
        /// </summary>
        private void Diary_Data_Load_Diary_Grid1()
        {
            //woid = Main_Form.Selected_woid;

            DateTime date1 = DateTimePicker1.Value;
            DateTime date2 = DateTimePicker2.Value;

            try
            {
                string sql = $"SELECT W.WOID  \n" +
                            $", W.PRODID \n" +
                            $", P.PRODNAME  \n" +
                            $", E.EQPTID  \n" +
                            $", W.PLANQTY  \n" +
                            $", W.PRODQTY  \n" +
                            $", SUM(DL.DEFECT_QTY)  \n" +
                            $", W.DLVDT  \n" +
                            $", W.WOSTDTTM  \n" +
                            $", W.PLANDTTM  \n" +
                            $", W.WOEDDTTM  \n" +
                            $", CASE WOSTAT WHEN 'WORK_C' THEN '완료' END WOSTAT \n" +
                            $"FROM WORKORDER W \n" +
                            $"LEFT JOIN PRODUCT P ON W.PRODID = P.PRODID \n" +
                            $"LEFT JOIN EQUIPMENT E ON W.PROCID = E.PROCID \n" +
                            $"LEFT JOIN DEFECTLOT DL ON W.WOID = DL.DEFECT_LOTID \n";

                if (Diary_Combobox.SelectedIndex == 0) //배합
                {
                    sql += $" WHERE W.WOEDDTTM BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.WOSTAT = 'WORK_C' AND (E.EQPTID = 'MX001' OR E.EQPTID = 'MX002') \n"; // W.WOSTAT이 WORK_C 그리고 E.EQPTID가 MX001 또는 MX002일 때 조회
                }
                if (Diary_Combobox.SelectedIndex == 1) //카렌다
                {
                    sql += $" WHERE W.WOEDDTTM BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND W.WOSTAT = 'WORK_C' AND E.EQPTID = 'C_CUT' \n";
                }
                if (Diary_Combobox.SelectedIndex == 2) //패키징, 성형
                {
                    sql += $" WHERE W.WOEDDTTM BETWEEN '{date1.Year}/{date1.Month}/{date1.Day}' AND TO_DATE('{date2.Year}/{date2.Month}/{date2.Day}')+1 AND  W.WOSTAT = 'WORK_C' AND E.EQPTID = 'P_CUT' \n";
                }

                sql += "GROUP BY W.WOID, W.PRODID, P.PRODNAME, E.EQPTID, W.PLANQTY, W.PRODQTY, DL.DEFECT_QTY, W.DLVDT, W.WOSTDTTM, W.PLANDTTM, W.WOEDDTTM, W.WOSTAT \n";

                DBconnection dbconnection = new DBconnection();
                DBconnection.DB_Connection(sql, Diary_Grid1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 작성자 : 안재영
        /// LOT에 있는 컬럼을 Diary_Grid2안에 불러온다
        /// </summary>
        //private void Diary_Data_Load_Diary_Grid2()
        //{
        //    DateTime date1 = DateTimePicker1.Value;
        //    DateTime date2 = DateTimePicker2.Value;

        //    try
        //    {
        //        string sql = $"SELECT L.LOTID LOT코드 \n" +
        //                    $", L.LOTSTDTTM 시작시간 \n" +
        //                    $", L.LOTEDDTTM 종료시간 \n" +
        //                    $", CASE WHEN DEFECT_QTY > 0 THEN 'Y' WHEN DEFECT_QTY = 0 THEN 'N' END 불량여부 \n" +
        //                    $"FROM LOT L \n" +
        //                    $"LEFT JOIN DEFECTLOT DL ON L.LOTID = DL.DEFECT_LOTID \n";
        //        if (Diary_Combobox.SelectedIndex == 0) //배합
        //        {
        //            sql += " WHERE L.LOTID LIKE 'LM%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' \n "; // L.LOTID가 LM으로 시작하고 L.LOTEDDTTM이 NULL 값이 아닐 때 조회
        //            sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["작업지시코드"].Value.ToString());
        //        }
        //        if (Diary_Combobox.SelectedIndex == 1) //카렌다
        //        {
        //            sql += " WHERE L.LOTID LIKE 'LC%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' \n ";
        //            sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["작업지시코드"].Value.ToString());
        //        }
        //        if (Diary_Combobox.SelectedIndex == 2) //패키징, 성형
        //        {
        //            sql += " WHERE L.LOTID LIKE 'LP%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' \n";
        //            sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["작업지시코드"].Value.ToString());
        //        }

        //        sql += $"GROUP BY L.LOTID, L.LOTSTDTTM, L.LOTEDDTTM, DL.DEFECT_QTY \n" +
        //              $"ORDER BY L.LOTID \n";

        //        DBconnection dbconnection = new DBconnection();
        //        DBconnection.DB_Connection(sql, Diary_Grid2);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Diary_Grid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Diary_Grid2.Rows.Count > 0)
            {
                string[] header = new string[] { "LOT코드", "시작시간", "종료시간", "불량여부" };
                int[] SetColumnWidth_Diary_Grid2 = new int[] { 30, 30, 30, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    Diary_Grid2.Columns[i].HeaderText = $"{header[i]}";
                    Diary_Grid2.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Diary_Grid2, i, SetColumnWidth_Diary_Grid2[i]);
                }
                Diary_Grid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Diary_Grid2.ColumnHeadersHeight = 30;
            }

            DBconnection.SetGridDesign(Diary_Grid2);

            DateTime date1 = DateTimePicker1.Value;
            DateTime date2 = DateTimePicker2.Value;

            try
            {
                string sql = $"SELECT L.LOTID  \n" +
                            $", L.LOTSTDTTM  \n" +
                            $", L.LOTEDDTTM  \n" +
                            $", CASE WHEN DEFECT_QTY > 0 THEN 'Y' WHEN DEFECT_QTY = 0 THEN 'N' END DEFECT_QTY \n" +
                            $"FROM LOT L \n" +
                            $"LEFT JOIN DEFECTLOT DL ON L.LOTID = DL.DEFECT_LOTID \n";

                if (Diary_Combobox.SelectedIndex == 0) //배합
                {
                    sql += " WHERE L.LOTID LIKE 'LM%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' AND EQPTID = '#EQPTID' \n "; // L.LOTID가 LM으로 시작하고 L.LOTEDDTTM이 NULL 값이 아닐 때 조회
                    sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["WOID"].Value.ToString());
                    sql = sql.Replace("#EQPTID", Diary_Grid1.CurrentRow.Cells["EQPTID"].Value.ToString());
                }
                if (Diary_Combobox.SelectedIndex == 1) //카렌다
                {
                    sql += " WHERE L.LOTID LIKE 'LC%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' \n ";
                    sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["WOID"].Value.ToString());
                    sql = sql.Replace("#EQPTID", Diary_Grid1.CurrentRow.Cells["EQPTID"].Value.ToString());
                }
                if (Diary_Combobox.SelectedIndex == 2) //패키징, 성형
                {
                    sql += " WHERE L.LOTID LIKE 'LP%' AND L.LOTEDDTTM IS NOT NULL AND WOID = '#WOID' \n";
                    sql = sql.Replace("#WOID", Diary_Grid1.CurrentRow.Cells["WOID"].Value.ToString());
                    sql = sql.Replace("#EQPTID", Diary_Grid1.CurrentRow.Cells["EQPTID"].Value.ToString());
                }

                sql += $"GROUP BY L.LOTID, L.LOTSTDTTM, L.LOTEDDTTM, DL.DEFECT_QTY \n" +
                      $"ORDER BY L.LOTID \n";

                DBconnection dbconnection = new DBconnection();
                DBconnection.DB_Connection(sql, Diary_Grid2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_Diary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 페이지입니다.");
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Owner = this;
            main.Show();
            this.Visible = false;
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Owner = this;
            status.Show();
            this.Visible = false;
        }

        private void Diary_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diary_Data_Load_Diary_Grid1();
            //Diary_Data_Load_Diary_Grid2();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Diary_Data_Load_Diary_Grid1();
            //Diary_Data_Load_Diary_Grid2();
        }

        private void Diary_Grid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Diary_Grid2.Rows[e.RowIndex].Cells[0].Value == null)
                return;

            if (Diary_Grid2.Rows[e.RowIndex].Cells[3].Value.ToString() == "Y")
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
