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
    public partial class LOT_Del : Form
    {
        string lotid = "";
        int prodQty = 0;

        public object Detail_Grid2 { get; private set; }
        public object Detail_Grid1 { get; private set; }

        public LOT_Del()
        {
            InitializeComponent();
        }

        private void LOT_Del_Load(object sender, EventArgs e)
        {
            lotid = Detail.Selected_lotid;

            Detail detail = new Detail();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lot_Del_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }


    }
}
