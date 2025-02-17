using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bai8_pheptinhcoban
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtso1.Text);
            double so2 = double.Parse(txtso2.Text);
            if (rdbCỘNG.Checked)
            {
                txtKQ.Text = (so1 + so2).ToString();
            }
            if (rdbTRỪ.Checked)
            {
                txtKQ.Text = (so1 - so2).ToString();
            }
            if (rdbNHAN.Checked)
            {
                txtKQ.Text = (so1 * so2).ToString();
            }
            if (rdbCHIA.Checked)
            {
                if (so2 == 0)
                {
                    txtKQ.Text = "không chia được cho 0";
                }
                else
                {
                    txtKQ.Text = (so1 / so2).ToString();
                }
            }
        }
    }
}