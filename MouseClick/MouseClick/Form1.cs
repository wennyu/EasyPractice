using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        //修改練習自 https://www.youtube.com/watch?v=j2HL_tZqqVQ

        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++;
            Timeslabel1.Text = "你已經點了……" + times + "次";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;
            Timeslabel1.Text = "你已經點了……" + times + "次";
        }
    }
}
