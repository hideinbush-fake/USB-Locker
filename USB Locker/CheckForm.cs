using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Locker
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        private bool chkres = false;
       public bool CHKRES
        {
           get { return chkres; }
           set { chkres = value; }
       }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "62960008")
            {
                CHKRES = true;
                Hide();
                Form f=new frmMain();
                f.Show();
            }
            else
            {
                CHKRES = false;
                MessageBox.Show("密码错误！");
            }
        }
        private bool secpsw = false;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                if (secpsw)
                {
                    if (textBox1.Text == DateTime.Now.ToString("MMddHHmm"))
                    {
                        CHKRES = true;
                        Hide();
                        Form f = new frmMain();
                        f.Show();
                        return;
                    }
                    else
                    {

                        CHKRES = false;
                        MessageBox.Show("二级密码错误！");
                        textBox1.Text = "";
                        return;
                    }
                }
                if (textBox1.Text == "62960008")
                {
                    MessageBox.Show("请继续输入二级密码:");
                    textBox1.Text = "";
                    secpsw = true;
                }
                else
                {
                    CHKRES = false;
                    MessageBox.Show("密码错误！");
                    textBox1.Text = "";
                }
            }
        }

       
    }
}
