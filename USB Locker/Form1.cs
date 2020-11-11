using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;
using System.Windows.Forms;

namespace USB_Locker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        RegistryKey Regkey, RegKey2;
        Int32 rValue, rsvalue, Gvalue, tvalue;
        string Regpath = "System\\CurrentControlSet\\Services\\USBSTOR";
        string ReadAndWriteRegPath2 = "System\\CurrentControlSet\\Control";
        string ReadAndWriteRegPath = "System\\CurrentControlSet\\Control\\StorageDevicePolicies";
        ContextMenu notifyContextMenu = new ContextMenu();
        Icon ico = USB_Locker.Properties.Resources._228184139232189189;
        

       

      

        private void RadioButtonreadonly_CheckedChanged(object sender, EventArgs e)
        {
            rsvalue = 1;
        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            isAdmin = IsUserAnAdmin();
            if (isAdmin == false)
            {
                MessageBox.Show("You don't have proper privileges level to make changes, administrators privileges are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                notifyContextMenu.MenuItems.Add(0, new MenuItem("显示界面"));
                notifyContextMenu.MenuItems.Add(1, new MenuItem("退出"));
                notifyContextMenu.MenuItems[0].Click += Item1_Click;
                notifyContextMenu.MenuItems[1].Click += Item2_Click;
                this.notifyIcon1.ContextMenu = notifyContextMenu;
                Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
                Gvalue = Convert.ToInt32(Regkey.GetValue("Start"));
                //check the current state of the usb/whether is enabled or disabled
                if (Gvalue == 3)
                {
                    rdoEnable.Checked = true;
                }
                else if (Gvalue == 4)
                {
                    rdoDisable.Checked = true;
                }
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                try
                {
                    tvalue = Convert.ToInt32(RegKey2.GetValue("WriteProtect"));
                    if (tvalue == 1)
                    {
                        RadioButtonreadonly.Checked = true;
                    }
                    else if (tvalue == 0)
                    {
                        RadioButtonreadwrite.Checked = true;
                    }
                }
                catch (NullReferenceException) { }
                rdoEnable.Checked = true;
                RadioButtonreadwrite.Checked = true;
                btnOK.PerformClick();
            }
        }

       

        private void RadioButtonreadwrite_CheckedChanged(object sender, EventArgs e)
        {
            rsvalue = 0;
        }
        bool isAdmin;
        [DllImport("shell32")]
        static extern bool IsUserAnAdmin();

        private void rdoDisable_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox2.Enabled = false;
            rValue = 4;
        }

        private void rdoEnable_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox2.Enabled = true;
            rValue = 3;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Regkey = Registry.LocalMachine.OpenSubKey(Regpath, true);
            Regkey.SetValue("Start", rValue);
            if (GroupBox2.Enabled == true)
            {
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath2, true);
                RegKey2.CreateSubKey("StorageDevicePolicies");
                RegKey2 = Registry.LocalMachine.OpenSubKey(ReadAndWriteRegPath, true);
                RegKey2.SetValue("WriteProtect", rsvalue);
            }
            if ((rValue == 3) && (rsvalue == 1))
            {
                MessageBox.Show("USB 端口已启用，权限为只读");
            }
            else if ((rValue == 3) && (rsvalue == 0))
            {
                MessageBox.Show("USB 端口已启用，权限为读写");
            }
            else
            {
                MessageBox.Show("USB 端口已禁用");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            rdoDisable.Checked = true;
            btnOK.PerformClick();
            Environment.Exit(0);
        }

        private void Item2_Click(object sender, EventArgs e)//退出
        {
            this.Close();
        }

        private void Item1_Click(object sender, EventArgs e)//显示主界面
        {
            //还原窗体显示 
            WindowState = FormWindowState.Normal;
            //激活窗体并给予它焦点 
            this.Activate();
            //任务栏区显示图标 
            this.ShowInTaskbar = true;
            //托盘区图标隐藏 
            notifyIcon1.Visible = false;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //托盘显示图标等于托盘图标对象 
                //注意notifyIcon1是控件的名字而不是对象的名字 
                notifyIcon1.Icon = ico;
                //隐藏任务栏区图标 
                this.ShowInTaskbar = false;
                //图标显示在托盘区 
                notifyIcon1.Visible = true;
            }
        }

    }
}