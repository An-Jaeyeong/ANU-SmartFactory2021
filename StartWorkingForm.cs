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
    public partial class StartWorkingForm : Form
    {
        public static string EQPTID { get; set; }

        Size orj_s1, orj_s2, orj_s3, orj_s4, orj_s5, orj_p1, orj_m1, orj_m2, orj_mx1, orj_mx2, orj_p2, orj_c1, orj_p3;
        int delaytime = 5, delay = 22;
        string Selected_woid = "";
        string CurrQty;
        int timer_flag = 0;
        private string lotid;
        public StartWorkingForm()
        {
            InitializeComponent();
        }


        private void StartWokingForm_Load(object sender, EventArgs e)
        {
            //WOID
            Selected_woid = Main_Form.Selected_woid;
            //EQPTID
            EQPTID ="";
            DBconnection.SetGridDesign(SWF_Grid1);
            DBconnection.SetGridDesign(SWF_Grid2);
            //Grid1 내용 조회
            Load_SWF_Grid1();
            Load_SWF_Grid2();
            
            //헤더 이름 변경
            if (SWF_Grid1.Rows.Count > 0)
            {
                string[] header = new string[] { "작업지시코드", "작업상태", "계획수량", "작업시작일", "작업종료일", "제품코드", "계획수량", "생산수량", "공정", "작업하달일", "등록자", "비고" };
                int[] SetColumnWidth_SWF_Grid1 = new int[] { 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 80 };
                for (int i = 0; i < header.Length; i++)
                {
                    SWF_Grid1.Columns[i].HeaderText = $"{header[i]}";
                    SWF_Grid1.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(SWF_Grid1, i, SetColumnWidth_SWF_Grid1[i]);
                }
                SWF_Grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                SWF_Grid1.ColumnHeadersHeight = 30;
            }

            if (SWF_Grid2.Rows.Count >= 0)
            {
                string[] header = new string[] { "LOT코드", "상태", "생산시간", "수량", "설비" };
                int[] SetColumnWidth_SWF_Grid2 = new int[] { 20, 7, 28, 10, 75 };
                for (int i = 0; i < header.Length; i++)
                {
                    SWF_Grid2.Columns[i].HeaderText = $"{header[i]}";
                    SWF_Grid2.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(SWF_Grid2, i, SetColumnWidth_SWF_Grid2[i]);
                }
                SWF_Grid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                SWF_Grid2.ColumnHeadersHeight = 30;
            }
            //저장소 현재량 조회
            Select_store("SL001");
            silo1_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL002");
            silo2_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL003");
            silo3_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL004");
            silo4_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL005");
            silo5_Qty.Text = "저장량: " + CurrQty;
            Select_store("MX001");
            mx001_Qty.Text = "저장량: " + CurrQty;
            Select_store("MX002");
            mx002_Qty.Text = "저장량: " + CurrQty;

            //ProdWeight = Convert.ToInt32(WoGrid.Rows[0].Cells[2].Value.ToString());

            //애니메이션
            orj_s1 = s1.Size;
            orj_s2 = s2.Size;
            orj_s3 = s3.Size;
            orj_s4 = s4.Size;
            orj_s5 = s5.Size;
            orj_p1 = p1.Size;
            orj_m1 = m1.Size;
            orj_m2 = m2.Size;
            
            Clear_PictureBox_All();

            //작업지시서 상태가 종료일 때 버튼 사용 금지
            Inquiry_Wostat();
            timer1.Interval = 3000;
            

        }
        //=========================================================== 버튼 =========================================================================================================
        //나가기 버튼
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            timer_flag = 1;
            this.Close();
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
            LOT_Add.PROCID = "M";
            lot_add.ShowDialog();
            Load_SWF_Grid2();
        }
        //불량 등록
        private void btn_DEF_Add_Click(object sender, EventArgs e)
        {
            DEF_Add def_add = new DEF_Add();
            def_add.ShowDialog();
        }
        //불량 조회
        private void btn_DEF_Search_Click(object sender, EventArgs e)
        {
            DEF_Search def_Search = new DEF_Search();
            def_Search.ShowDialog();
        }
        //원자재 조회
        private void btn_STO_Search_Click(object sender, EventArgs e)
        {
            STO_Search sto_search = new STO_Search();
            sto_search.ShowDialog();
        }
        //LOT 삭제
        private void btn_LOT_Del_Click(object sender, EventArgs e)
        {
            if (SWF_Grid2.RowCount == 0) return;

            if (SWF_Grid2.CurrentRow.Cells["LOTSTAT"].Value.ToString() == "D") return;

            LOT_Del lot_del = new LOT_Del();

            if (lot_del.ShowDialog() == DialogResult.Yes)
            {
                lotid = SWF_Grid2.CurrentRow.Cells["LOTID"].Value.ToString();

                string delete_lot = $" UPDATE LOT SET LOTSTAT = 'D' WHERE LOTID = '{lotid}'";
                DBconnection.DB_Connection1(delete_lot);

                MessageBox.Show("삭제되었습니다.", "INFORM", MessageBoxButtons.OK);

                Load_SWF_Grid2();
            }
        }
        // MX001 배합시작 버튼
        private void btn_Start1_Click(object sender, EventArgs e)
        {
            timer_flag = 0;
            EQPTID = "MX001";
            Eqptstat_Changed("RUN");
            timer1.Start();
            btn_Start1.Enabled = false;
            btn_Start2.Enabled = false;
        }
        // MX002 배합시작 버튼
        private void btn_Start2_Click(object sender, EventArgs e)
        {
            timer_flag = 0;
            EQPTID = "MX002";
            Eqptstat_Changed("RUN");
            timer1.Start();
            btn_Start1.Enabled = false;
            btn_Start2.Enabled = false;
        }
        //// MX001 배합중지 버튼
        private void btn_Stop1_Click(object sender, EventArgs e)
        {
            timer_flag = 1;
            EQPTID = "MX001";
            Eqptstat_Changed("DOWN");
        }
        //// MX002 배합중지 버튼 
        private void btn_Stop2_Click(object sender, EventArgs e)
        {
            timer_flag = 1;
            EQPTID = "MX002";
            Eqptstat_Changed("DOWN");
        }
        //=========================================================== 함수 ======================================================
        //PictureBox의 값을 초기화하여 처음에 안보이게 한다.
        public void Clear_PictureBox(PictureBox pbox)
        {
            pbox.Width = 0;
            pbox.Height = 0;
        }
        /// <summary>
        /// 픽처박스 초기값 설정
        /// </summary>
        public void Clear_PictureBox_All()
        {
            Clear_PictureBox(s1);
            Clear_PictureBox(s2);
            Clear_PictureBox(s3);
            Clear_PictureBox(s4);
            Clear_PictureBox(s5);
            Clear_PictureBox(p1);
            Clear_PictureBox(m1);
            Clear_PictureBox(m2);
        }
        //워크오더 상태 조회 "WORK_C"나 "WORK_S"이면배합 시작 버튼을 비활성화 한다.
        private void Inquiry_Wostat()
        {
            string wostat = SWF_Grid1.Rows[0].Cells["WOSTAT"].Value.ToString();
            if (wostat == "WORK_C")
            {
                btn_Start1.Enabled = false;
                btn_Start2.Enabled = false;
                btn_Stop1.Enabled = false;
                btn_Stop2.Enabled = false;
            }
            else if (wostat == "WORK_S")
            {
                btn_Start1.Enabled = false;
                btn_Start2.Enabled = false;
                btn_Stop1.Enabled = false;
                btn_Stop2.Enabled = false;
            }
        }
        /// <summary>
        /// 작성자 : 유현우
        /// Grid1 데이터 조회
        /// </summary>
        private void Load_SWF_Grid1()
        {
            string sql = $"SELECT * FROM WORKORDER \n" +
                                $"WHERE WOID = '{Selected_woid}' \n";
            DBconnection.DB_Connection(sql, SWF_Grid1);
        }
        
        /// <summary>
        /// 작성자 : 유현우
        /// Grid2 데이터 조회
        /// </summary>
        private void Load_SWF_Grid2()
        {
            string sql = $"SELECT LOT.LOTID, LOT.LOTSTAT, LOT.LOTCRDTTM, LOT.LOTQTY, EQUIPMENT.EQPTNAME \n" +
                            $"FROM LOT left join EQUIPMENT ON LOT.eqptid = equipment.eqptid \n "+
                            $"WHERE WOID = '{Selected_woid}' AND LOT.LOTID LIKE 'LM%' \n";
            DBconnection.DB_Connection(sql, SWF_Grid2);
        }
        //PictureBox가 위에서 아래로 늘어나는 것처럼
        private void UpToDown(PictureBox pbox, Size sz)
        {
            pbox.Width = sz.Width;

            for (int i = 0; i <= sz.Height; i++)
            {
                pbox.Height = i;
                Delay(delaytime);
            }
        }
        //PictureBox가 왼쪽에서 오른쪽으로 늘어나는 것처럼
        private void LeftToRight(PictureBox pbox, Size sz, int StopWidth = 0, Point point = new Point(), int delay = 0)
        {
            pbox.Height = sz.Height;
            for (int i = 0; i <= sz.Width; i++)
            {
                if (!point.IsEmpty)
                    pbox.Location = point;
                if (StopWidth > 0 && StopWidth < i)
                    continue;
                if (delay != 0)
                    delaytime = delay;
                pbox.Width = i;
                Delay(delaytime - 1);
            }
        }
        //PictureBox가 오른쪽에서 왼쪽으로 늘어나는 것처럼
        private void RightToLeft(PictureBox pbox, Size sz, int StopWidth = 0, Point point = new Point())
        {
            pbox.Height = sz.Height;
            for (int i = 0; i < StopWidth; i++)
            {
                if (!point.IsEmpty)
                    pbox.Location = new Point(point.X - i, point.Y);
                if (StopWidth > 0 && StopWidth < i)
                    continue;
                pbox.Width = i;
                Delay(delaytime);
            }
        }
        
        //장비 상태
        private void Eqptstat_Changed(string eqptstat)
        {
            //설비 상태 변경
            string EqptStat = $"UPDATE EQUIPMENT SET EQPTSTATS = '{eqptstat}' WHERE EQPTID='{EQPTID}'";
            DBconnection.DB_Connection1(EqptStat);
        }

        //사일로의 저장량 표시
        private void Select_store(string StoreID)
        {
            string Select_Store = $"SELECT CURRQTY FROM STORE_STORAGE WHERE STORID='{StoreID}' ";
            DataTable data_Table = DBconnection.DB_Connection(Select_Store);
            if (data_Table.Rows.Count > 0)
                CurrQty = data_Table.Rows[0][0].ToString();
        }
        /// <summary>
        /// 작성자 : 유현우
        /// LOT 추가
        /// </summary>
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
                                        $"(SELECT 'LM' || TO_CHAR(SYSDATE, 'YYYYMMDD') || TO_CHAR(TO_NUMBER(NVL(TO_CHAR(MAX(SUBSTR(LOTID, 11))), '000')) + 1, 'FM000') FROM LOT) \n" +
                                        $",'E' \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $", SYSDATE + 1/1440 \n" +
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
        private void Update_store(char pm, int Qty, string StoreID)
        {
            string Mixing = $"UPDATE STORE_STORAGE SET CURRQTY = CURRQTY {pm} {Qty} WHERE STORID='{StoreID}' ";
            DBconnection.DB_Connection(Mixing);
        }
        //좌표찾기
        private void Form_VVIP_TOOLs_Move(object sender, EventArgs e)
        {

            var cursor = Control.MousePosition;
            textBox1.Text = string.Format("{0},{1},{2}", textBox1.Location.X, textBox1.Location.Y, textBox1.Width);

        }
        private void Timer_Check()
        {
            if (timer_flag == 0) ;

        }
        private void Check_Store_CurrQty()
        {
            Select_store("SL001");
            silo1_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL002");
            silo2_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL003");
            silo3_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL004");
            silo4_Qty.Text = "저장량: " + CurrQty;
            Select_store("SL005");
            silo5_Qty.Text = "저장량: " + CurrQty;
            Select_store("MX001");
            silo5_Qty.Text = "저장량: " + CurrQty;
            Select_store("MX002");
            silo5_Qty.Text = "저장량: " + CurrQty;
            int silo1_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int silo2_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int silo3_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int silo4_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int silo5_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int mx001_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            int mx002_currQty = Convert.ToInt32((silo1_Qty.Text).Substring(4));
            if (silo1_currQty <= 50 || silo2_currQty <= 50 || silo3_currQty <= 50 || silo4_currQty <= 50 || silo5_currQty <= 50 || mx001_currQty >= 1000 || mx002_currQty >= 1000)
            {
                timer1.Stop();
                if (silo1_currQty <= 50)
                {
                    MessageBox.Show("저장소 SILO#1의 원재료가 부족합니다.");
                }
                else if (silo2_currQty <= 50)
                {
                    MessageBox.Show("저장소 SILO#2의 원재료가 부족합니다.");
                }
                else if (silo3_currQty <= 50)
                {
                    MessageBox.Show("저장소 SILO#3의 원재료가 부족합니다.");
                }
                else if (silo4_currQty <= 50)
                {
                    MessageBox.Show("저장소 SILO#4가 원재료가 부족합니다. ");
                }
                else if (mx001_currQty >= 1000)
                {
                    MessageBox.Show("저장소 MIX의 저장공간이 가득찼습니다. ");
                }
                else if (mx002_currQty >= 1000)
                {
                    MessageBox.Show("저장소 MX002의 저장공간이 가득찼습니다 ");
                }
                if (EQPTID == "MX001")
                {
                    btn_Start1.Enabled = true;
                }
                else if (EQPTID == "MX002")
                {
                    btn_Start2.Enabled = true;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                if (EQPTID == "MX001")
                {
                    //사일로 1호
                    Silo1_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL001");
                    Select_store("SL001");
                    silo1_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX001");
                    Select_store("MX001");
                    mx001_Qty.Text = "저장량: " + CurrQty;
                    S1_Mixing1_Ani();
                    Silo1_gif.Visible = false;

                    
                    

                    //사일로 2호
                    Silo2_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL002");
                    Select_store("SL002");
                    silo2_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX001");
                    Select_store("MX001");
                    mx001_Qty.Text = "저장량: " + CurrQty;
                    S2_Mixing1_Ani();
                    Silo2_gif.Visible = false;

                    

                    //사일로 3호
                    Silo3_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL003");
                    Select_store("SL003");
                    silo3_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX001");
                    Select_store("MX001");
                    mx001_Qty.Text = "저장량: " + CurrQty;
                    S3_Mixing1_Ani();
                    Silo3_gif.Visible = false;

                    

                    //사일로 4호
                    Silo4_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL004");
                    Select_store("SL004");
                    silo4_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX001");
                    Select_store("MX001");
                    mx001_Qty.Text = "저장량: " + CurrQty;
                    S4_Mixing1_Ani();
                    Silo4_gif.Visible = false;

                    

                    //사일로 5호
                    Silo5_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL005");
                    Select_store("SL005");
                    silo5_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX001");
                    Select_store("MX001");
                    mx001_Qty.Text = "저장량: " + CurrQty;
                    S5_Mixing1_Ani();
                    Silo5_gif.Visible = false;

                    

                    //배합 1호
                    Mixing1_gif.Visible = true;
                    mixing_start1.Visible = true;
                    Delay(delay);
                    mixing_start1.Visible = false;
                    mixing_finisih1.Visible = true;
                    Delay(delay);
                    mixing_finisih1.Visible = false;
                    dispose1.Visible = true;
                    Delay(delay);
                    dispose1.Visible = false;
                    Mixing1_gif.Visible = false;


                    Create_Lot();
                    Load_SWF_Grid2();
                    btn_Start1.Enabled = true;
                    btn_Start2.Enabled = true;
                    Clear_PictureBox_All();
                }
                else if (EQPTID == "MX002")
                {
                    //사일로 1호
                    Silo1_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL001");
                    Select_store("SL001");
                    silo1_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX002");
                    Select_store("MX002");
                    mx002_Qty.Text = "저장량: " + CurrQty;
                    S1_Mixing2_Ani();
                    Silo1_gif.Visible = false;

                    

                    //사일로 2호
                    Silo2_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL002");
                    Select_store("SL002");
                    silo2_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX002");
                    Select_store("MX002");
                    mx002_Qty.Text = "저장량: " + CurrQty;
                    S2_Mixing2_Ani();
                    Silo2_gif.Visible = false;

                    

                    //사일로 3호
                    Silo3_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL003");
                    Select_store("SL003");
                    silo3_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX002");
                    Select_store("MX002");
                    mx002_Qty.Text = "저장량: " + CurrQty;
                    S3_Mixing2_Ani();
                    Silo3_gif.Visible = false;

                    

                    //사일로 4호
                    Silo4_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL004");
                    Select_store("SL004");
                    silo4_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX002");
                    Select_store("MX002");
                    mx002_Qty.Text = "저장량: " + CurrQty;
                    S4_Mixing2_Ani();
                    Silo4_gif.Visible = false;

                    

                    //사일로 5호
                    Silo5_gif.Visible = true;
                    Delay(delay);
                    Update_store('-', 20, "SL005");
                    Select_store("SL005");
                    silo5_Qty.Text = "저장량: " + CurrQty;
                    Update_store('+', 20, "MX002");
                    Select_store("MX002");
                    mx002_Qty.Text = "저장량: " + CurrQty;
                    S5_Mixing2_Ani();
                    Silo5_gif.Visible = false;

                    


                    //배합 2호
                    Mixing2_gif.Visible = true;
                    mixing_start2.Visible = true;
                    Delay(delay);
                    mixing_start2.Visible = false;
                    mixing_finisih2.Visible = true;
                    Delay(delay);
                    mixing_finisih2.Visible = false;
                    dispose2.Visible = true;
                    Delay(delay);
                    dispose2.Visible = false;
                    Mixing2_gif.Visible = false;

                   

                    Create_Lot();
                    Load_SWF_Grid2();
                    btn_Start1.Enabled = true;
                    btn_Start2.Enabled = true;
                    Clear_PictureBox_All();
                }
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
        //============================== 배합기 1호로 ================================================================ 
        //사일로 1호 애니메이션
        public void S1_Mixing1_Ani()
        {
            UpToDown(s1, orj_s1);
            LeftToRight(p1, orj_p1, 182, new Point(126, 429));
            UpToDown(m1, orj_m1);
            Delay(delay);
            Clear_PictureBox_All();
        }

        //사일로 2호 애니메이션
        public void S2_Mixing1_Ani()
        {
            UpToDown(s2, orj_s2);
            LeftToRight(p1, orj_p1, 50, new Point(259, 429));
            UpToDown(m1, orj_m1);
            Delay(delay);
            Clear_PictureBox_All();
        }

        //사일로 3호 애니메이션
        public void S3_Mixing1_Ani()
        {
            UpToDown(s3, orj_s3);
            RightToLeft(p1, orj_p1, 112, new Point(406, 429));
            UpToDown(m1, orj_m1);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //사일로 4호 애니메이션
        public void S4_Mixing1_Ani()
        {
            UpToDown(s4, orj_s4);
            RightToLeft(p1, orj_p1, 246, new Point(539, 429));
            UpToDown(m1, orj_m1);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //사일로 5호 애니메이션
        public void S5_Mixing1_Ani()
        {
            UpToDown(s5, orj_s5);
            RightToLeft(p1, orj_p1, 378, new Point(672, 429));
            UpToDown(m1, orj_m1);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //============================== 배합기 2호로 ================================================================
        //사일로 1호 애니메이션
        public void S1_Mixing2_Ani()
        {
            UpToDown(s1, orj_s1);
            LeftToRight(p1, orj_p1, 386, new Point(126, 429));
            UpToDown(m2, orj_m2);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //사일로 2호 애니메이션
        public void S2_Mixing2_Ani()
        {
            UpToDown(s2, orj_s2);
            LeftToRight(p1, orj_p1, 252, new Point(259, 429));
            UpToDown(m2, orj_m2);
            Delay(delay);
            Clear_PictureBox_All();
        }

        //사일로 3호 애니메이션
        public void S3_Mixing2_Ani()
        {
            UpToDown(s3, orj_s3);
            LeftToRight(p1, orj_p1, 120, new Point(392, 429));
            UpToDown(m2, orj_m2);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //사일로 4호 애니메이션
        public void S4_Mixing2_Ani()
        {
            UpToDown(s4, orj_s4);
            RightToLeft(p1, orj_p1, 42, new Point(539, 429));
            UpToDown(m2, orj_m2);
            Delay(delay);
            Clear_PictureBox_All();
        }
        //사일로 5호 애니메이션
        public void S5_Mixing2_Ani()
        {
            UpToDown(s5, orj_s5);
            RightToLeft(p1, orj_p1, 176, new Point(672, 429));
            UpToDown(m2, orj_m2);
            Delay(delay);
            Clear_PictureBox_All();
        }
        
    }
}
