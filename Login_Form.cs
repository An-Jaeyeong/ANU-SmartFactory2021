using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Oracle.ManagedDataAccess.Client;


namespace Final_FUI
{



    public partial class Login_Form : Form
    {
        

            public Login_Form()
            {
                InitializeComponent();
            }
           
            private void txtuser_Enter(object sender, EventArgs e)
            {
                if (txtuser.Text == "USUARIO")
                {
                    txtuser.Text = "";
                    txtuser.ForeColor = Color.LightGray;
                }
            }

            private void txtuser_Leave(object sender, EventArgs e)
            {
                if (txtuser.Text == "")
                {
                    txtuser.Text = "Usuario";
                    txtuser.ForeColor = Color.Silver;
                }
            }

            private void txtpass_Enter(object sender, EventArgs e)
            {
                if (txtpass.Text == "CONTRASENA")
                {
                    txtpass.Text = "";
                    txtpass.ForeColor = Color.LightGray;
                    txtpass.UseSystemPasswordChar = true;
                }
            }

            private void txtpass_Leave(object sender, EventArgs e)
            {
                if (txtpass.Text == "")
                {
                    txtpass.Text = "Contraseña";
                    txtpass.ForeColor = Color.Silver;
                    txtpass.UseSystemPasswordChar = false;
                }
            }

         
        private void btnlogin_Click(object sender, EventArgs e)
        {
       

           // select_query에 쿼리문을 저장
           string sel_login_qry = $"select count(*) from employee where EMPID = '" + txtuser.Text + "' and EMPPASSWORD='" + txtpass.Text + "'";

           // select_ID로 조회된 결과를 data_Table에 return값을 저장함
            DataTable data_Table = DBconnection.DB_Connection(sel_login_qry);

            if (data_Table.Rows[0][0].ToString() == "1")
            {
                Main_Form main = new Main_Form(); // 새 폼 생성
                main.Owner = this; // 현재 폼이 새 폼의 주인격
                main.Show(); // 새 폼 보여주기
                this.Visible = false; // 기존 폼 닫기
            }
            else
            {
                MessageBox.Show("로그인 정보가 일치하지 않습니다.");
                txtuser.Text = string.Empty;
                txtpass.Text = string.Empty;

            }
         

        }
    
        

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
