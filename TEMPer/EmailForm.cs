// Decompiled with JetBrains decompiler
// Type: TEMPer.EmailForm
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TEMPer.Properties;

namespace TEMPer
{
  public class EmailForm : Form
  {
    public MainForm mf;
    private Point myPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox portTB;
    private TextBox smtpTB;
    private TextBox sendPassTB;
    private TextBox sendAccountTB;
    private Label label5;
    private Label label6;
    private Label label8;
    private Label label7;
    private TextBox reciveAccountTB2;
    private TextBox reciveNameTB2;
    private TextBox reciveAccountTB1;
    private TextBox reciveNameTB1;
    private GroupBox groupBox3;
    private Label label9;
    private Label label10;
    private TextBox subjecTB;
    private RichTextBox contentTB;
    private GroupBox groupBox4;
    private RadioButton alarmSend;
    private RadioButton continueSend;
    private NumericUpDown sendInterval;
    private Label label11;
    private GroupBox groupBox5;
    private RadioButton startRtn;
    private RadioButton endRtn;
    private Button saveBtn;
    private Label label12;
    private PictureBox closePic;
    private CheckBox SSLCK;
    private Label label13;

    public EmailForm() => this.InitializeComponent();

    private void EmailForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void EmailForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void EmailForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void EmailForm_Load(object sender, EventArgs e)
    {
      this.sendAccountTB.Text = Settings.Default.SendAccount;
      this.sendPassTB.Text = Settings.Default.SendPass;
      this.smtpTB.Text = Settings.Default.SendSmtp;
      this.portTB.Text = Settings.Default.SendPort;
      this.reciveAccountTB1.Text = Settings.Default.ReciveAccount1;
      this.reciveAccountTB2.Text = Settings.Default.ReciveAccount2;
      this.reciveNameTB1.Text = Settings.Default.ReciveName1;
      this.reciveNameTB2.Text = Settings.Default.ReciveName2;
      this.subjecTB.Text = Settings.Default.Subject;
      this.contentTB.Text = Settings.Default.Content;
      this.sendInterval.Text = string.Concat((object) Settings.Default.SendInterval);
      this.SSLCK.Checked = Settings.Default.EnableSSL;
      if (Settings.Default.SendType == 1)
        this.alarmSend.Checked = true;
      else
        this.continueSend.Checked = true;
      if (Settings.Default.SendStart == 0)
        this.endRtn.Checked = true;
      else
        this.startRtn.Checked = true;
    }

    private void saveBtn_Click(object sender, EventArgs e)
    {
      string text1 = this.sendAccountTB.Text;
      string text2 = this.sendPassTB.Text;
      string text3 = this.smtpTB.Text;
      string text4 = this.portTB.Text;
      string text5 = this.reciveNameTB1.Text;
      string text6 = this.reciveNameTB2.Text;
      string text7 = this.reciveAccountTB1.Text;
      string text8 = this.reciveAccountTB2.Text;
      string text9 = this.subjecTB.Text;
      string text10 = this.contentTB.Text;
      string text11 = this.sendInterval.Text;
      string str1 = Settings.Default.Language == 2 ? "Email state" : "当前邮件状态：";
      string str2;
      if (this.startRtn.Checked)
      {
        str2 = str1 + (Settings.Default.Language == 2 ? "ON" : "开启");
        if (string.IsNullOrEmpty(text1))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The email account cannot be empty" : "发送邮箱账号不能为空");
          return;
        }
        if (string.IsNullOrEmpty(text2))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The mailbox password cannot be empty" : "发送邮箱密码不能为空");
          return;
        }
        if (string.IsNullOrEmpty(text3))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Send mailbox SMTP cannot be empty" : "发送邮箱SMTP不能为空");
          return;
        }
        if (string.IsNullOrEmpty(text4))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The mailbox port cannot be empty" : "发送邮箱端口不能为空");
          return;
        }
        if (string.IsNullOrEmpty(text7) && string.IsNullOrEmpty(text8))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Fill in at least one mailbox" : "接收邮箱至少填写一个");
          return;
        }
      }
      else
        str2 = str1 + (Settings.Default.Language == 2 ? "OFF" : "关闭");
      Settings.Default.SendAccount = text1;
      Settings.Default.SendInterval = int.Parse(text11);
      Settings.Default.SendPass = text2;
      Settings.Default.SendPort = text4;
      Settings.Default.SendSmtp = text3;
      Settings.Default.ReciveName1 = text5;
      Settings.Default.ReciveName2 = text6;
      Settings.Default.ReciveAccount1 = text7;
      Settings.Default.ReciveAccount2 = text8;
      Settings.Default.SendType = this.alarmSend.Checked ? 1 : 2;
      Settings.Default.SendStart = this.startRtn.Checked ? 1 : 0;
      Settings.Default.Subject = text9;
      Settings.Default.Content = text10;
      Settings.Default.Save();
      this.mf.changeEmail(str2);
      int num1 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Set success" : "保存成功");
    }

    private void SSLCK_CheckedChanged(object sender, EventArgs e)
    {
      Settings.Default.EnableSSL = this.SSLCK.Checked;
      Settings.Default.Save();
    }

    private void label13_Click(object sender, EventArgs e) => new EmailHelp().Show();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EmailForm));
      this.panel1 = new Panel();
      this.label13 = new Label();
      this.saveBtn = new Button();
      this.groupBox5 = new GroupBox();
      this.endRtn = new RadioButton();
      this.startRtn = new RadioButton();
      this.groupBox4 = new GroupBox();
      this.label11 = new Label();
      this.sendInterval = new NumericUpDown();
      this.continueSend = new RadioButton();
      this.alarmSend = new RadioButton();
      this.groupBox3 = new GroupBox();
      this.contentTB = new RichTextBox();
      this.label10 = new Label();
      this.subjecTB = new TextBox();
      this.label9 = new Label();
      this.groupBox2 = new GroupBox();
      this.reciveAccountTB2 = new TextBox();
      this.reciveNameTB2 = new TextBox();
      this.reciveAccountTB1 = new TextBox();
      this.reciveNameTB1 = new TextBox();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.groupBox1 = new GroupBox();
      this.SSLCK = new CheckBox();
      this.portTB = new TextBox();
      this.smtpTB = new TextBox();
      this.sendPassTB = new TextBox();
      this.sendAccountTB = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.label12 = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.sendInterval.BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.label13);
      this.panel1.Controls.Add((Control) this.saveBtn);
      this.panel1.Controls.Add((Control) this.groupBox5);
      this.panel1.Controls.Add((Control) this.groupBox4);
      this.panel1.Controls.Add((Control) this.groupBox3);
      this.panel1.Controls.Add((Control) this.groupBox2);
      this.panel1.Controls.Add((Control) this.groupBox1);
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.label13, "label13");
      this.label13.ForeColor = Color.Blue;
      this.label13.Name = "label13";
      this.label13.Click += new EventHandler(this.label13_Click);
      componentResourceManager.ApplyResources((object) this.saveBtn, "saveBtn");
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.UseVisualStyleBackColor = true;
      this.saveBtn.Click += new EventHandler(this.saveBtn_Click);
      componentResourceManager.ApplyResources((object) this.groupBox5, "groupBox5");
      this.groupBox5.Controls.Add((Control) this.endRtn);
      this.groupBox5.Controls.Add((Control) this.startRtn);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.TabStop = false;
      componentResourceManager.ApplyResources((object) this.endRtn, "endRtn");
      this.endRtn.Name = "endRtn";
      this.endRtn.TabStop = true;
      this.endRtn.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.startRtn, "startRtn");
      this.startRtn.Name = "startRtn";
      this.startRtn.TabStop = true;
      this.startRtn.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.groupBox4, "groupBox4");
      this.groupBox4.Controls.Add((Control) this.label11);
      this.groupBox4.Controls.Add((Control) this.sendInterval);
      this.groupBox4.Controls.Add((Control) this.continueSend);
      this.groupBox4.Controls.Add((Control) this.alarmSend);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label11, "label11");
      this.label11.ForeColor = Color.Red;
      this.label11.Name = "label11";
      componentResourceManager.ApplyResources((object) this.sendInterval, "sendInterval");
      this.sendInterval.Maximum = new Decimal(new int[4]
      {
        60,
        0,
        0,
        0
      });
      this.sendInterval.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.sendInterval.Name = "sendInterval";
      this.sendInterval.ReadOnly = true;
      this.sendInterval.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      componentResourceManager.ApplyResources((object) this.continueSend, "continueSend");
      this.continueSend.Name = "continueSend";
      this.continueSend.TabStop = true;
      this.continueSend.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.alarmSend, "alarmSend");
      this.alarmSend.Name = "alarmSend";
      this.alarmSend.TabStop = true;
      this.alarmSend.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.groupBox3, "groupBox3");
      this.groupBox3.Controls.Add((Control) this.contentTB);
      this.groupBox3.Controls.Add((Control) this.label10);
      this.groupBox3.Controls.Add((Control) this.subjecTB);
      this.groupBox3.Controls.Add((Control) this.label9);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.contentTB, "contentTB");
      this.contentTB.BorderStyle = BorderStyle.FixedSingle;
      this.contentTB.Name = "contentTB";
      componentResourceManager.ApplyResources((object) this.label10, "label10");
      this.label10.Name = "label10";
      componentResourceManager.ApplyResources((object) this.subjecTB, "subjecTB");
      this.subjecTB.Name = "subjecTB";
      componentResourceManager.ApplyResources((object) this.label9, "label9");
      this.label9.Name = "label9";
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.Controls.Add((Control) this.reciveAccountTB2);
      this.groupBox2.Controls.Add((Control) this.reciveNameTB2);
      this.groupBox2.Controls.Add((Control) this.reciveAccountTB1);
      this.groupBox2.Controls.Add((Control) this.reciveNameTB1);
      this.groupBox2.Controls.Add((Control) this.label8);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label6);
      this.groupBox2.Controls.Add((Control) this.label5);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      componentResourceManager.ApplyResources((object) this.reciveAccountTB2, "reciveAccountTB2");
      this.reciveAccountTB2.Name = "reciveAccountTB2";
      componentResourceManager.ApplyResources((object) this.reciveNameTB2, "reciveNameTB2");
      this.reciveNameTB2.Name = "reciveNameTB2";
      componentResourceManager.ApplyResources((object) this.reciveAccountTB1, "reciveAccountTB1");
      this.reciveAccountTB1.Name = "reciveAccountTB1";
      componentResourceManager.ApplyResources((object) this.reciveNameTB1, "reciveNameTB1");
      this.reciveNameTB1.Name = "reciveNameTB1";
      componentResourceManager.ApplyResources((object) this.label8, "label8");
      this.label8.Name = "label8";
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.groupBox1, "groupBox1");
      this.groupBox1.Controls.Add((Control) this.SSLCK);
      this.groupBox1.Controls.Add((Control) this.portTB);
      this.groupBox1.Controls.Add((Control) this.smtpTB);
      this.groupBox1.Controls.Add((Control) this.sendPassTB);
      this.groupBox1.Controls.Add((Control) this.sendAccountTB);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.label2);
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      componentResourceManager.ApplyResources((object) this.SSLCK, "SSLCK");
      this.SSLCK.Name = "SSLCK";
      this.SSLCK.UseVisualStyleBackColor = true;
      this.SSLCK.CheckedChanged += new EventHandler(this.SSLCK_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.portTB, "portTB");
      this.portTB.Name = "portTB";
      componentResourceManager.ApplyResources((object) this.smtpTB, "smtpTB");
      this.smtpTB.Name = "smtpTB";
      componentResourceManager.ApplyResources((object) this.sendPassTB, "sendPassTB");
      this.sendPassTB.Name = "sendPassTB";
      componentResourceManager.ApplyResources((object) this.sendAccountTB, "sendAccountTB");
      this.sendAccountTB.Name = "sendAccountTB";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label12, "label12");
      this.label12.ForeColor = Color.White;
      this.label12.Name = "label12";
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Cursor = Cursors.Hand;
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (EmailForm);
      this.Load += new EventHandler(this.EmailForm_Load);
      this.MouseDown += new MouseEventHandler(this.EmailForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.EmailForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.EmailForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.sendInterval.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
