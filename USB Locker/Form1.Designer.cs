namespace USB_Locker
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEnable = new System.Windows.Forms.RadioButton();
            this.rdoDisable = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButtonreadwrite = new System.Windows.Forms.RadioButton();
            this.RadioButtonreadonly = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "请重新插拔所有USB设备";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOK.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(37, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(242, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.rdoEnable);
            this.GroupBox1.Controls.Add(this.rdoDisable);
            this.GroupBox1.Location = new System.Drawing.Point(37, 29);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(300, 103);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "禁用/使能";
            // 
            // rdoEnable
            // 
            this.rdoEnable.AutoSize = true;
            this.rdoEnable.Location = new System.Drawing.Point(14, 69);
            this.rdoEnable.Name = "rdoEnable";
            this.rdoEnable.Size = new System.Drawing.Size(89, 16);
            this.rdoEnable.TabIndex = 2;
            this.rdoEnable.TabStop = true;
            this.rdoEnable.Text = "使能USB端口";
            this.rdoEnable.UseVisualStyleBackColor = true;
            this.rdoEnable.CheckedChanged += new System.EventHandler(this.rdoEnable_CheckedChanged);
            // 
            // rdoDisable
            // 
            this.rdoDisable.AutoSize = true;
            this.rdoDisable.Location = new System.Drawing.Point(14, 35);
            this.rdoDisable.Name = "rdoDisable";
            this.rdoDisable.Size = new System.Drawing.Size(89, 16);
            this.rdoDisable.TabIndex = 2;
            this.rdoDisable.TabStop = true;
            this.rdoDisable.Text = "禁用USB端口";
            this.rdoDisable.UseVisualStyleBackColor = true;
            this.rdoDisable.CheckedChanged += new System.EventHandler(this.rdoDisable_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox2.Controls.Add(this.RadioButtonreadwrite);
            this.GroupBox2.Controls.Add(this.RadioButtonreadonly);
            this.GroupBox2.Location = new System.Drawing.Point(37, 138);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(300, 103);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "读/写";
            // 
            // RadioButtonreadwrite
            // 
            this.RadioButtonreadwrite.AutoSize = true;
            this.RadioButtonreadwrite.Location = new System.Drawing.Point(14, 66);
            this.RadioButtonreadwrite.Name = "RadioButtonreadwrite";
            this.RadioButtonreadwrite.Size = new System.Drawing.Size(167, 16);
            this.RadioButtonreadwrite.TabIndex = 1;
            this.RadioButtonreadwrite.TabStop = true;
            this.RadioButtonreadwrite.Text = "赋予可移动驱动器读写权限";
            this.RadioButtonreadwrite.UseVisualStyleBackColor = true;
            // 
            // RadioButtonreadonly
            // 
            this.RadioButtonreadonly.AutoSize = true;
            this.RadioButtonreadonly.Location = new System.Drawing.Point(14, 30);
            this.RadioButtonreadonly.Name = "RadioButtonreadonly";
            this.RadioButtonreadonly.Size = new System.Drawing.Size(167, 16);
            this.RadioButtonreadonly.TabIndex = 0;
            this.RadioButtonreadonly.TabStop = true;
            this.RadioButtonreadonly.Text = "赋予可移动驱动器只读权限";
            this.RadioButtonreadonly.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "USB Locker";
            this.notifyIcon1.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 298);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "USB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton rdoEnable;
        private System.Windows.Forms.RadioButton rdoDisable;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton RadioButtonreadwrite;
        private System.Windows.Forms.RadioButton RadioButtonreadonly;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

