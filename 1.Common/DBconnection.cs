using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;

namespace Final_FUI
{
    class DBconnection
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        //static void Main()
        //{
        //    Application.SetHighDpiMode(HighDpiMode.SystemAware);
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Login());
        //}
        static public void SetGridDesign(DataGridView Grid)
        {

            Grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Grid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Grid.BackgroundColor = Color.White;
            Grid.EnableHeadersVisualStyles = false;
            Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid.Font = new Font("Fixsys", 12, FontStyle.Regular);
            Grid.ReadOnly = true;
            Grid.AllowUserToAddRows = false;

        }
        static public void SetColumnWidth(DataGridView dataGridView, int IndexCol, int widthCol)
        {
            dataGridView.Columns[IndexCol].Width = widthCol;
            
        }

        static public void DB_Connection(string sql, DataGridView gridView)
        {
            OracleDataAdapter adapter = new OracleDataAdapter(sql, DBHelper.DBconn);
            DataTable data_table = new DataTable();
            adapter.Fill(data_table);
            gridView.DataSource = data_table;
        }
        /// <summary>
        /// SELECT 전용
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        static public DataTable DB_Connection(string sql)
        {
            OracleDataAdapter adapter = new OracleDataAdapter(sql, DBHelper.DBconn);
            DataTable data_table = new DataTable();
            adapter.Fill(data_table);
            return data_table;
        }
        /// <summary>
        /// INSERT/UPDATE 전용
        /// </summary>
        /// <param name="sql"></param>
        static public void DB_Connection1(string sql)
        {
            OracleCommand cmd = new OracleCommand(sql, DBHelper.DBconn);
            cmd.ExecuteNonQuery();

        }
    }
}
