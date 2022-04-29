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
    public partial class DEF_Add : Form
    {
        string woid = "";
        //한 번만 실행되게
        private static DataTable dt_right = new DataTable();
        public int DataGridViewRow { get; private set; }

        public DEF_Add()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 작성자 : 유현우
        /// 나가기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DEF_Add_Quit_Click(object sender, EventArgs e)
        {
            //오른쪽 그리드 초기화
            dt_right.Rows.Clear();

            this.Close();
        }

        private void DEF_Add_Load(object sender, EventArgs e)
        {
            woid = Main_Form.Selected_woid;
            
            DBconnection.SetGridDesign(DEF_Grid_Left);
            DBconnection.SetGridDesign(DEF_Grid_Right);

            Data_Load_DEF_Grid_Left();

            
            string[] header1 = new string[] { "LOT코드", "LOT수량" };
            int[] SetColumnWidth_DEF_Grid_left = new int[] { 5, 100 };
            for (int i = 0; i < header1.Length; i++)
            {
                DEF_Grid_Left.Columns[i].HeaderText = $"{header1[i]}";
                DEF_Grid_Left.Columns[i].ReadOnly = true;
                DBconnection.SetColumnWidth(DEF_Grid_Left, i, SetColumnWidth_DEF_Grid_left[i]);
            }
            DEF_Grid_Left.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DEF_Grid_Left.ColumnHeadersHeight = 30;
            

            //우측 그리드 데이터 테이블 컬럼 세팅
            //처음 한 번만 세팅
            if (dt_right.Columns.Count == 0)
            {
                dt_right.Columns.Add("DEFECT_LOTID", typeof(string));
                dt_right.Columns.Add("DEFECTID", typeof(string));
                dt_right.Columns.Add("DEFECTNAME", typeof(string));
                dt_right.Columns.Add("DEFECT_QTY", typeof(decimal));
            }
            
            DEF_Grid_Right.DataSource = dt_right;

            if (DEF_Grid_Right.Rows.Count == 0)
            {
                string[] header2 = new string[] { "불량LOT", "불량코드", "불량원인", "불량수량" };
                int[] SetColumnWidth_DEF_Grid_Right = new int[] { 10, 10, 10, 100 };
                for (int i = 0; i < header2.Length; i++)
                {
                    DEF_Grid_Right.Columns[i].HeaderText = $"{header2[i]}";
                    DEF_Grid_Right.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(DEF_Grid_Right, i, SetColumnWidth_DEF_Grid_Right[i]);
                }
                DEF_Grid_Right.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DEF_Grid_Right.ColumnHeadersHeight = 30;
            }

        }
        /// <summary>
        /// 작성자 : 유현우
        /// 왼쪽 그리드 조회
        /// </summary>
        private void Data_Load_DEF_Grid_Left()
        {
            string sql = $"SELECT LOTID, LOTQTY \n" +
                            $"FROM LOT \n" +
                            $"WHERE WOID = '{woid}' \n" +
                            $" AND LOTID NOT IN (SELECT DEFECT_LOTID FROM DEFECTLOT) \n";
            DBconnection.DB_Connection(sql, DEF_Grid_Left);

        }
        /// <summary>
        /// 작성자 : 유현우
        /// 오른쪽 그리드 조회
        /// </summary>
        /// 
        private void Data_Load_DEF_Grid_Right()
        {
            /*
            string sql = @"SELECT
                            DEFECTLOT.DEFECT_LOTID
                            , DEFECTLOT.DEFECTID
                            , DEFECT.DEFECTNAME 
                            , DEFECTLOT.DEFECT_QTY
                           FROM
                            DEFECTLOT LEFT JOIN DEFECT ON DEFECTLOT.DEFECTID = DEFECT.DEFECTID
                         WHERE 1 != 1";
            DBconnection.DB_Connection(sql, DEF_Grid_Right);
            */
        }
        /// <summary>
        /// 작성자 : 유현우
        /// 불량 원인을 버튼을 통해 누르면 왼쪽 그리드에서 오른쪽 그리드로 옮겨간다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertRGrid(object sender, EventArgs e)
        {
            string DEFECT_CD = string.Empty;
            string DEFECTNAME = string.Empty;

            if (DEF_Grid_Left.Rows.Count == 0)
                return;

            //시작종료
            if ((Button)sender == DEF_StEd)
            {
                DEFECT_CD = "DF002";
                DEFECTNAME = "시작/종료";
                
            }
            //갈라짐
            if ((Button)sender == DEF_Crack) 
            {
                DEFECT_CD = "DF001";
                DEFECTNAME = "갈라짐";
            }
            //색상
            if ((Button)sender == DEF_Color)
            {
                DEFECT_CD = "DF004";
                DEFECTNAME = "색상";
            }
            //기스
            if ((Button)sender == DEF_Scratch)
            {
                DEFECT_CD = "DF003";
                DEFECTNAME = "기스";
            }

            DataRow row = dt_right.NewRow();
            
            row["DEFECT_LOTID"] = DEF_Grid_Left.CurrentRow.Cells["LOTID"].Value;
            row["DEFECTID"] = DEFECT_CD;
            row["DEFECTNAME"] = DEFECTNAME;
            row["DEFECT_QTY"] = DEF_Grid_Left.CurrentRow.Cells["LOTQTY"].Value;

            dt_right.Rows.Add(row);

            DEF_Grid_Left.Rows.RemoveAt(DEF_Grid_Left.CurrentRow.Index);

        }
        /// <summary>
        /// 작성자 : 유현우
        /// 오른쪽 그리드뷰로 넘어간 내용들을 데이터베이스에서도 insert한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DEF_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable LOT = (DataTable)DEF_Grid_Right.DataSource;

                string Insert_query = string.Empty;

                //insert 쿼리문
                if (LOT != null)
                {
                    for (int i = 0; i < LOT.Rows.Count; i++)
                    {
                        Insert_query = @"INSERT INTO DEFECTLOT
                                        VALUES
                                        ('#DEFECT_LOTID', '#DEFECT_QTY', SYSDATE, 'Y', '#DEFECTID')";

                                        Insert_query = Insert_query.Replace("#DEFECT_LOTID", LOT.Rows[i]["DEFECT_LOTID"].ToString());
                                        Insert_query = Insert_query.Replace("#DEFECT_QTY", LOT.Rows[i]["DEFECT_QTY"].ToString());
                                        Insert_query = Insert_query.Replace("#DEFECTID", LOT.Rows[i]["DEFECTID"].ToString());

                        DBconnection.DB_Connection1(Insert_query);

                        
                    }

                    MessageBox.Show("저장되었습니다", "INFORM", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 작성자 : 유현우
        /// DEF_Grid_Right에 ROW를 잘못 추가했을 시 ROW를 삭제할 수 있다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DEF_Save_Cancle_Click(object sender, EventArgs e)
        {
            if (DEF_Grid_Right.Rows.Count == 0)
                return;

            DataTable dt = new DataTable();
            dt = (DataTable)DEF_Grid_Left.DataSource;

            DataRow row = dt.NewRow();

            row["LOTID"] = DEF_Grid_Right.CurrentRow.Cells["DEFECT_LOTID"].Value;
            row["LOTQTY"] = DEF_Grid_Right.CurrentRow.Cells["DEFECT_QTY"].Value;



            dt.Rows.Add(row);

            DEF_Grid_Right.Rows.RemoveAt(DEF_Grid_Right.CurrentRow.Index);
        }

        
    }
}
