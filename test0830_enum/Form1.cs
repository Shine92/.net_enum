using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0830_enum {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        enum TSeason {
            Spring = 1,
            Summer = 2,
            Winter = 3
        }
        private void button1_Click(object sender, EventArgs e) {

            
            int x = (int)TSeason.Spring;
            button1.Text = x.ToString();
            //button1.Text = TSeason.Spring.ToString();  //列舉內的文字
            //button1.Text = Convert.ToInt32(TSeason.Spring).ToString(); //列舉內的位置
        }
    }
}
