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
    public partial class LOT_Add : Form
    {
        string woid = ""; 
        public static string EQPTID { get; set; }
        public static string PROCID { get; set; }
        int prodQty = 0;
        string proctype = "";
        public LOT_Add()
        {
            InitializeComponent();
            
        }

        private void LOT_Add_Load(object sender, EventArgs e)
        {
            woid = Main_Form.Selected_woid;
            PROCID = Main_Form.PROCID;
            if (PROCID == "M")
                CB_EQPTID.Visible = true;
            else
                CB_EQPTID.Visible = false;

            //CB_EQPTID.Visible = PROCID == "M";

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lot_Add_Click(object sender, EventArgs e)
        {
            if (PROCID == "C")
            {
                EQPTID = "C_CUT";
                proctype = "C";
            }
            else if (PROCID == "P")
            {
                EQPTID = "P_CUT";
                proctype = "P";
            }
            //추가버튼
            int Qty = (LOT_Add_tb.Text == "") ? 0 : Convert.ToInt32(LOT_Add_tb.Text);
            if(CB_EQPTID.SelectedIndex == 0)
            {
                EQPTID = "MX001";
                proctype = "M";
            }
            if(CB_EQPTID.SelectedIndex == 1)
            {
                EQPTID = "MX002";
                proctype = "M";
            }

            if (woid != "")
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
                                        $"(SELECT 'L{proctype}' || TO_CHAR(SYSDATE, 'YYYYMMDD') || TO_CHAR(TO_NUMBER(NVL(TO_CHAR(MAX(SUBSTR(LOTID, 12))), '000')) + 1, 'FM000') FROM LOT) \n" +
                                        $",'E' \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $",TO_CHAR(SYSDATE, 'YY/MM/DD HH24:MI:SS') \n" +
                                        $",'' \n" +
                                        $",'{woid}' \n" +
                                        $",'{Qty}' \n" +
                                        $",'{Qty}' \n" +
                                        $",'{EQPTID}' )\n";

                DBconnection.DB_Connection1(add_lot);

                string add_prodQty = $"UPDATE WORKORDER \n " +
                                                $"SET \n " +
                                                $"PRODQTY = PRODQTY + '{Qty}' \n" +
                                                $"WHERE WOID = '{woid}' \n";

                DBconnection.DB_Connection1(add_prodQty);

                MessageBox.Show("저장되었습니다", "INFORM", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void CB_EQPTID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
