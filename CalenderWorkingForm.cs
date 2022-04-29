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

    public partial class CalenderWorkingForm : Form
    {
        public static string EQPTID { get; set; }

        int delaytime = 5, delay = 2200;
        string Selected_woid = "";
        private string lotid;
        int timer_flag = 0;
        public CalenderWorkingForm()
        {
            InitializeComponent();
        }

        private void CalenderWorkingForm_Load(object sender, EventArgs e)
        {
            Selected_woid = Main_Form.Selected_woid;
            //EQPTID
            EQPTID = "";
            DBconnection.SetGridDesign(CWF_Grid1);
            DBconnection.SetGridDesign(CWF_Grid2);
            //Grid1 내용 조회
            Load_CWF_Grid1();
            Load_CWF_Grid2();
            btn_Stop.Enabled = false;

            //헤더 이름 변경
            if (CWF_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "작업상태", "계획수량", "작업시작일", "작업종료일", "제품코드", "계획수량", "생산수량", "공정", "작업하달일", "등록자", "비고" };
                int[] SetColumnWidth_SWF_Grid1 = new int[] { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    CWF_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    CWF_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(CWF_Grid1, i, SetColumnWidth_SWF_Grid1[i]);
                }
                CWF_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                CWF_Grid1.ColumnHeadersHeight = 30;
            }
        }

        /// <summary>
        /// 작성자 : 유현우
        /// Grid1 데이터 조회
        /// </summary>
        private void Load_CWF_Grid1()
        {
            string sql = $"SELECT * FROM WORKORDER \n" +
                                $"WHERE WOID = '{Selected_woid}' \n";
            DBconnection.DB_Connection(sql, CWF_Grid1);
        }
        /// <summary>
        /// 작성자 : 유현우
        /// Grid2 데이터 조회
        /// </summary>
        private void Load_CWF_Grid2()
        {
            string sql = $"SELECT LOT.LOTID, LOT.LOTSTAT, LOT.LOTCRDTTM, LOT.LOTQTY, EQUIPMENT.EQPTNAME \n" +
                            $"FROM LOT left join EQUIPMENT ON LOT.eqptid = equipment.eqptid \n " +
                            $"WHERE WOID = '{Selected_woid}' AND LOT.LOTID LIKE 'LC%' \n";
            DBconnection.DB_Connection(sql, CWF_Grid2);
        }
        //=======================================================================================================================================================================================
        //======================================================================== 버 튼 ========================================================================================================
        //=======================================================================================================================================================================================
        //나가기 버튼
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //불량 조회
        private void btn_DEF_Search_Click(object sender, EventArgs e)
        {
            DEF_Search def_Search = new DEF_Search();
            def_Search.ShowDialog();
        }
        //작업 종료
        private void btn_End_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE WORKORDER SET WOSTAT = 'WORK_C' WHERE WOID  = '{Selected_woid}'";
            DBconnection.DB_Connection1(sql);
            this.Close();
        }
        //LOT 추가
        private void btn_LOT_Add_Click(object sender, EventArgs e)
        {
            LOT_Add lot_add = new LOT_Add();
            lot_add.ShowDialog();
            Load_CWF_Grid2();
        }
        //LOT 삭제
        private void btn_LOT_Del_Click(object sender, EventArgs e)
        {
            if (CWF_Grid2.RowCount == 0) return;

            if (CWF_Grid2.CurrentRow.Cells["LOTSTAT"].Value.ToString() == "D") return;

            LOT_Del lot_del = new LOT_Del();

            if (lot_del.ShowDialog() == DialogResult.Yes)
            {
                lotid = CWF_Grid2.CurrentRow.Cells["LOTID"].Value.ToString();

                string delete_lot = $" UPDATE LOT SET LOTSTAT = 'D' WHERE LOTID = '{lotid}'";
                DBconnection.DB_Connection1(delete_lot);

                MessageBox.Show("삭제되었습니다.", "INFORM", MessageBoxButtons.OK);

                Load_CWF_Grid2();
            }
        }
        //불량 등록
        private void btn_DEF_Add_Click(object sender, EventArgs e)
        {
            DEF_Add def_add = new DEF_Add();
            def_add.ShowDialog();
        }
        //=======================================================================================================================================================================================
        //======================================================================== 함 수 ========================================================================================================
        //=======================================================================================================================================================================================
        public void Create_Lot()
        {
            int Qty = 100;

            if (Selected_woid != "")
            {
                string add_lot = $"INSERT INTO LOT( \n" +
                                         $"LOTID  \n" +
                                         $", LOTSTAT \n" +
                                         $", LOTCRDTTM \n" +
                                         $", LOTSTDTTM \n" +
                                         $", LOTEDDTTM \n" +
                                         $", WOID \n" +
                                         $", LOTCRQTY \n" +
                                         $", LOTQTY \n" +
                                         $", EQPTID ) \n" +
                                    $"VALUES ( \n" +
                                        $"(SELECT 'LC' || TO_CHAR(SYSDATE, 'YYYYMMDD') || TO_CHAR(TO_NUMBER(NVL(TO_CHAR(MAX(SUBSTR(LOTID, 11))), '000')) + 1, 'FM000') FROM LOT) \n" +
                                        $",'E' \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $",'' \n" +
                                        $",'{Selected_woid}' \n" +
                                        $",'{Qty}' \n" +
                                        $",'{Qty}' \n" +
                                        $",'{EQPTID}' )\n";

                DBconnection.DB_Connection1(add_lot);


                string add_prodQty = $"UPDATE WORKORDER \n " +
                                            $"SET \n " +
                                            $"PRODQTY = PRODQTY + '{Qty}' \n" +
                                            $"WHERE WOID = '{Selected_woid}' \n";

                DBconnection.DB_Connection1(add_prodQty);
            }
        }




        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer_flag = 1;
            EQPTID = "C_CUT";
            Eqptstat_Changed("DOWN");
        }
        // C_CUT 시작 버튼
        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer_flag = 0;
            EQPTID = "C_CUT";
            Eqptstat_Changed("RUN");
            timer1.Start();
        }
        //장비 상태
        private void Eqptstat_Changed(string eqptstat)
        {
            //설비 상태 변경
            string EqptStat = $"UPDATE EQUIPMENT SET EQPTSTATS = '{eqptstat}' WHERE EQPTID='{EQPTID}'";
            DBconnection.DB_Connection1(EqptStat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                Calenger_gif.Visible = true;
                btn_Start.Enabled = false;
                btn_Stop.Enabled = true;
                Delay(delay);
                packaging_gif.Visible = true;
                Delay(delay);
                Calenger_gif.Visible = false;
                packaging_gif.Visible = false;
                Create_Lot();
                Load_CWF_Grid2();

                if (timer_flag == 1)
                    timer1.Stop();
                else if (timer_flag == 0)
                    timer1.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
