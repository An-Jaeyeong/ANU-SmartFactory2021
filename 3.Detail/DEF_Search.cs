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
    public partial class DEF_Search : Form
    {
        public DEF_Search()
        {
            InitializeComponent();
        }

        private void DEF_Search_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DEF_Search_Load(object sender, EventArgs e)
        {
            Data_Load_DEF_Search_Grid();
            DBconnection.SetGridDesign(DEF_Search_Grid);

            if (DEF_Search_Grid.Rows.Count >= 0)
            {
                string[] header = new string[] { "불량LOT", "불량수량", "불량발생시간", "불량코드", "불량원인" };
                int[] SetColumnWidth_DEF_Search_Grid = new int[] { 10, 10, 10, 10, 100 };
                for (int i = 0; i < header.Length; i++)
                {
                    DEF_Search_Grid.Columns[i].HeaderText = $"{header[i]}";
                    DEF_Search_Grid.Columns[i].ReadOnly = true;
                    DBconnection.SetColumnWidth(DEF_Search_Grid, i, SetColumnWidth_DEF_Search_Grid[i]);
                }
                DEF_Search_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DEF_Search_Grid.ColumnHeadersHeight = 30;
            }

        }

        private void Data_Load_DEF_Search_Grid()
        {
            try
            {
                string sql = $"SELECT DL.DEFECT_LOTID, DL.DEFECT_QTY, DL.DEFECT_DTTM, DL.DEFECTID, D.DEFECTNAME \n"+
                                $"FROM DEFECTLOT DL LEFT JOIN DEFECT D ON DL.DEFECTID = D.DEFECTID \n";

                DBconnection.DB_Connection(sql, DEF_Search_Grid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
