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
    public partial class STO_Search : Form
    {
        public STO_Search()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }

        private void btn_STO_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void STO_Search_Load(object sender, EventArgs e)
        {

        }

        private void Material_Chart()
        {
            string sql = $"SELECT to_char(LT.LOTSTDTTM, 'yy/mm/dd') \n"
                       + $",NVL(SUM(LT.LOTQTY), 0) \n"
                       + $",NVL(SUM(DL.DEFECT_QTY), 0) \n"
                       + $",DECODE(NVL(SUM(LT.LOTQTY), 0), 0, 0, TRUNC(NVL(SUM(DL.DEFECT_QTY), 0) / NVL(SUM(LT.LOTQTY), 0), 3)) \n"
                       + $"FROM      LOT LT \n"
                       + $"LEFT JOIN DEFECTLOT DL \n"
                       + $"ON(LT.LOTID = DL.DEFECT_LOTID) \n"
                       + $"GROUP BY to_char(LT.LOTSTDTTM, 'yy/mm/dd') \n"
                       + $"HAVING to_char(LT.LOTSTDTTM, 'yy/mm/dd') != 'NULL' \n"
                       + $"ORDER BY to_char(LT.LOTSTDTTM, 'yy/mm/dd') \n";
            DataTable DT = new DataTable();

            DT = DBconnection.DB_Connection(sql);

            M_Chart.Series["원자재1"].Points.Clear();
            M_Chart.Series["원자재2"].Points.Clear();
            M_Chart.Series["원자재3"].Points.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                M_Chart.Series["원자재1"].Points.Add(Convert.ToDouble(DT.Rows[i][1].ToString()));
                M_Chart.Series["원자재2"].Points.Add(Convert.ToDouble(DT.Rows[i][2].ToString()));
                M_Chart.Series["원자재3"].Points.Add(Convert.ToDouble(DT.Rows[i][3].ToString()) * 100);
            }
        }
    }
}
