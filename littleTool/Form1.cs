using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace littleTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text=textBox1.Text;
            int start = int.Parse(textBox2.Text);
            int end = int.Parse(textBox3.Text);
            int step = int.Parse(textBox4.Text);
            int a=-1,b=0;
            for (var i = 0; i < text.Length; i++) {
                if (a < 0)
                {
                    if (text[i] <= '9' && text[i] >= '0')
                    {
                        a = i;

                        continue;
                    }
                }else 
                if (!(text[i] <= '9' && text[i] >= '0'))
                {
                    b = i;
                    break;
                }
            }
            if (a > 0 && b == 0) {
                b = text.Length;
            }
            if (a < 0) {
                a = text.Length;
                b = text.Length;
            }
            
            String a1 = text.Substring(0, a);
            String a2 = text.Substring(b);
            StringBuilder builder = new StringBuilder();
            if (start > end)
                for (var i = start; i >= end; i -= step)
                {
                    builder.Append(a1 + i + a2 + "\r\n");
                }
            else {
                for (var i = start; i <= end; i += step)
                {
                    builder.Append(a1 + i + a2 + "\r\n");
                }
            }
            textBox5.Text = builder.ToString();
        }
    }
}
