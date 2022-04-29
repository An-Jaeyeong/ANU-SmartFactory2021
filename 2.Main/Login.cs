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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 작성자 : 안재영
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //select_query에 쿼리문을 저장
            string sel_login_qry = $"select count(*) from employee where EMPID = '" + IDtextBox.Text + "' and EMPPASSWORD='" + PWDtextBox.Text + "'";

            //select_ID로 조회된 결과를 data_Table에 return값을 저장함
            DataTable data_Table = DBconnection.DB_Connection(sel_login_qry);

            if (data_Table.Rows[0][0].ToString() == "1")
            {
                Main_Form main = new Main_Form(); // 새 폼 생성
                main.Owner = this; // 현재 폼이 새 폼의 주인격
                main.Show(); // 새 폼 보여주기
                this.Visible = false; // 기존 폼 닫기
            }
        }

        
    }
}
