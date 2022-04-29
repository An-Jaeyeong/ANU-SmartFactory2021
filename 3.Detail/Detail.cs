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
    public partial class Detail : Form
    {
        string woid = "";
        private string lotid;

        public static string Selected_lotid { get; set; }
        public Detail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 작성자 : 유현우
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Detail_Load(object sender, EventArgs e)
        {
                woid = Main_Form.Selected_woid;

                Detail_Data_Load_Detail_Grid1();
                Detail_Data_Load_Detail_Grid2();
                DBconnection.SetGridDesign(Detail_Grid1);
                DBconnection.SetGridDesign(Detail_Grid2);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(350, 150);

            if (Detail_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "작업상태", "계획수량", "작업시작일", "작업종료일", "제품코드", "계획수량", "생산수량", "PROCID", "작업하달일", "INSESER", "비고" };
                int[] SetColumnWidth_Detail_Grid1 = new int[] { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    Detail_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    Detail_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Detail_Grid1, i, SetColumnWidth_Detail_Grid1[i]);
                }
                Detail_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Detail_Grid1.ColumnHeadersHeight = 30;
            }

            if (Detail_Grid2.Rows.Count > 0)
            {
                string[] header = new string[] { "LOTID", "LOT상태", "불량원인" };
                int[] SetColumnWidth_Detail_Grid2 = new int[] { 20, 20, 100 };
                for (int i = 0; i < header.Length; i++)
                {
                    Detail_Grid2.Columns[i].HeaderText = $"{header[i]}";
                    Detail_Grid2.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(Detail_Grid2, i, SetColumnWidth_Detail_Grid2[i]);
                }
                Detail_Grid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Detail_Grid2.ColumnHeadersHeight = 30;
            }
        }
        /// <summary>
        /// 데이터그리드뷰1에 DB내용 조회
        /// </summary>
        public void Detail_Data_Load_Detail_Grid1()
        {
            try
            {
                string sql = $"SELECT * FROM WORKORDER \n" +
                                $"WHERE WOID = '{woid}' \n";
                DBconnection.DB_Connection(sql, Detail_Grid1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 작성자 : 유현우
        /// 데이터그리드뷰2에 DB내용 조회
        /// </summary>
        public void Detail_Data_Load_Detail_Grid2()
        {
            try
            {
                string sql = $"SELECT \n" +
                                $"lot.lotid \n" +
                                $",lot.lotstat \n" +
                                $",defectlot.defectid \n" +
                                $"FROM lot \n" +
                                $"LEFT JOIN defectlot ON lot.lotid = defectlot.defect_lotid \n" +
                                $"WHERE WOID = '{woid}' \n";

                DBconnection.DB_Connection(sql, Detail_Grid2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 작성자 : 유현우
        /// 나가기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 작성자 : 유현우
        /// 작업 종료 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_End_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE WORKORDER SET WOSTAT = '완료' WHERE WOID  = '{woid}'";
            DBconnection.DB_Connection1(sql);
        }


        ///// <summary>
        ///// 작성자 : 유현우
        ///// 재고 조회 버튼
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btn_STO_Search_Click(object sender, EventArgs e)
        {
            STO_Search sto_search = new STO_Search();
            sto_search.ShowDialog();
        }
        ///// <summary>
        ///// 작성자 : 유현우
        ///// 불량 조회 버튼
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btn_DEF_Search_Click(object sender, EventArgs e)
        {
            DEF_Search def_search = new DEF_Search();
            def_search.ShowDialog();
        }
        ///// <summary>
        ///// 작성자 : 유현우
        ///// 불량 등록 버튼
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btn_DEF_Add_Click(object sender, EventArgs e)
        {
            DEF_Add def_add = new DEF_Add();
            def_add.ShowDialog();
        }
        ///// <summary>
        ///// 작성자 : 유현우
        ///// LOT 삭제 버튼
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btn_LOT_Del_Click(object sender, EventArgs e)
        {
            if (Detail_Grid2.RowCount == 0) return;

            if (Detail_Grid2.CurrentRow.Cells["LOTSTAT"].Value.ToString() == "D") return;
            
            LOT_Del lot_del = new LOT_Del();

            if (lot_del.ShowDialog() == DialogResult.Yes)
            {
                lotid = Detail_Grid2.CurrentRow.Cells["LOTID"].Value.ToString();

                string delete_lot = $" UPDATE LOT SET LOTSTAT = 'D' WHERE LOTID = '{lotid}'";
                DBconnection.DB_Connection1(delete_lot);

                MessageBox.Show("삭제되었습니다.", "INFORM", MessageBoxButtons.OK);

                Detail_Data_Load_Detail_Grid2();
            }

            
        }
        ///// <summary>
        ///// 작성자 : 유현우
        ///// LOT 추가 버튼
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void btn_LOT_Add_Click(object sender, EventArgs e)
        {
            LOT_Add lot_add = new LOT_Add();
            lot_add.ShowDialog();
        }

    }
}
