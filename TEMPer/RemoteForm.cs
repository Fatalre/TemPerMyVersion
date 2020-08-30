// Decompiled with JetBrains decompiler
// Type: TEMPer.RemoteForm
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TEMPer.Properties;

namespace TEMPer
{
  public class RemoteForm : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private PictureBox closePic;
    private TextBox accountTB;
    private CheckBox remberCkb;
    private Panel panel3;
    private TextBox passTB;
    private Button loginBtn;
    private Label label2;
    private Label label3;
    private Label label4;
    private Panel panel2;
    private LinkLabel linkLabel1;
    private Label tipLabel;
    private Label loginedLabel;
    private Label loginNameLabel;
    private Button exitBtn;
    public MainForm mf;
    private Point myPoint;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RemoteForm));
      this.panel1 = new Panel();
      this.exitBtn = new Button();
      this.tipLabel = new Label();
      this.loginNameLabel = new Label();
      this.loginedLabel = new Label();
      this.linkLabel1 = new LinkLabel();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.loginBtn = new Button();
      this.remberCkb = new CheckBox();
      this.panel3 = new Panel();
      this.passTB = new TextBox();
      this.panel2 = new Panel();
      this.accountTB = new TextBox();
      this.label1 = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.exitBtn);
      this.panel1.Controls.Add((Control) this.tipLabel);
      this.panel1.Controls.Add((Control) this.loginNameLabel);
      this.panel1.Controls.Add((Control) this.loginedLabel);
      this.panel1.Controls.Add((Control) this.linkLabel1);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.loginBtn);
      this.panel1.Controls.Add((Control) this.remberCkb);
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.panel2);
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.exitBtn, "exitBtn");
      this.exitBtn.Name = "exitBtn";
      this.exitBtn.UseVisualStyleBackColor = true;
      this.exitBtn.Click += new EventHandler(this.exitBtn_Click);
      componentResourceManager.ApplyResources((object) this.tipLabel, "tipLabel");
      this.tipLabel.Name = "tipLabel";
      componentResourceManager.ApplyResources((object) this.loginNameLabel, "loginNameLabel");
      this.loginNameLabel.Name = "loginNameLabel";
      componentResourceManager.ApplyResources((object) this.loginedLabel, "loginedLabel");
      this.loginedLabel.Name = "loginedLabel";
      componentResourceManager.ApplyResources((object) this.linkLabel1, "linkLabel1");
      this.linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.TabStop = true;
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.loginBtn, "loginBtn");
      this.loginBtn.Name = "loginBtn";
      this.loginBtn.UseVisualStyleBackColor = true;
      this.loginBtn.Click += new EventHandler(this.loginBtn_Click);
      componentResourceManager.ApplyResources((object) this.remberCkb, "remberCkb");
      this.remberCkb.Name = "remberCkb";
      this.remberCkb.UseVisualStyleBackColor = true;
      this.remberCkb.Click += new EventHandler(this.remberCkb_Click);
      this.panel3.BackColor = Color.White;
      this.panel3.Controls.Add((Control) this.passTB);
      componentResourceManager.ApplyResources((object) this.panel3, "panel3");
      this.panel3.Name = "panel3";
      this.passTB.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.passTB, "passTB");
      this.passTB.Name = "passTB";
      this.panel2.BackColor = Color.White;
      this.panel2.Controls.Add((Control) this.accountTB);
      componentResourceManager.ApplyResources((object) this.panel2, "panel2");
      this.panel2.Name = "panel2";
      this.accountTB.BorderStyle = BorderStyle.None;
      this.accountTB.ForeColor = Color.Black;
      componentResourceManager.ApplyResources((object) this.accountTB, "accountTB");
      this.accountTB.Name = "accountTB";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.ForeColor = Color.White;
      this.label1.Name = "label1";
      this.closePic.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (RemoteForm);
      this.Load += new EventHandler(this.RemoteForm_Load);
      this.MouseDown += new MouseEventHandler(this.RemoteForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.RemoteForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.RemoteForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public RemoteForm() => this.InitializeComponent();

    private void RemoteForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void RemoteForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void RemoteForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void loginBtn_Click(object sender, EventArgs e)
    {
      if (PubMethod.isLogin)
      {
        if (PubMethod.isOpen)
        {
          this.loginBtn.Text = Settings.Default.Language == 2 ? "Uploading..." : "Загрузка...";
          new Thread(new ThreadStart(this.mf.uploadDevice)).Start();
        }
        else
        {
          new Thread(new ThreadStart(this.mf.searchDevice)).Start();
          this.loginBtn.Text = Settings.Default.Language == 2 ? "Searching..." : "Поиск...";
        }
        this.loginBtn.Enabled = false;
        this.exitBtn.Enabled = false;
      }
      else
      {
        string text1 = this.accountTB.Text;
        string text2 = this.passTB.Text;
        if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
        {
          int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Noy null" : "Не может быть пустым");
        }
        else
        {
          this.accountTB.ReadOnly = true;
          this.passTB.ReadOnly = true;
          this.panel2.BackColor = this.accountTB.BackColor;
          this.panel3.BackColor = this.passTB.BackColor;
          this.loginBtn.Text = Settings.Default.Language == 2 ? "Loging.." : "Загрузка...";
          this.loginBtn.Enabled = false;
          new Thread(new ParameterizedThreadStart(this.login))
          {
            IsBackground = true
          }.Start((object) new string[2]{ text1, text2 });
        }
      }
    }

    private void login(object obj)
    {
      string[] logs = (string[]) obj;
      string str = HttpPostHelp.PostSend("http://120.24.211.240/WebRemoteAsmx/u/ServiceUserLogin.asmx/Login", new Dictionary<string, string>()
      {
        {
          "ServiceUserLogin",
          DESEncrypt.Encrypt("www.pcsensor.com")
        },
        {
          "UserEmail",
          DESEncrypt.Encrypt(logs[0])
        },
        {
          "UserPwd",
          DESEncrypt.Encrypt(logs[1])
        },
        {
          "DateTime",
          DateTime.Now.ToString()
        }
      });
      if (str == null)
      {
        if (str != null)
          return;
        this.backUnLogin();
      }
      else if (str == ProtocolLoginKey.Error.ToString())
      {
        int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Please submit the correct information!" : "Пожалуйста, отправьте правильную информацию!");
        this.backUnLogin();
      }
      else if (str == ProtocolLoginKey.Success.ToString())
        this.Invoke(new Action( delegate()
        {
          if (this.remberCkb.Checked)
          {
            Settings.Default.UserName = logs[0];
            Settings.Default.PassWord = logs[1];
          }
          Settings.Default.IsRember = this.remberCkb.Checked;
          Settings.Default.Save();
          PubMethod.loginName = logs[0];
          PubMethod.loginPass = logs[1];
          PubMethod.isLogin = true;
          this.mf.changeRemote(Settings.Default.Language == 2 ? "Remote state : ON" : "Текущий удаленный статус: включен");
          this.loginSuccess();
        }));
      else if (str == ProtocolLoginKey.PwdError.ToString())
      {
        int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The user name or password error!" : "Неправильное имя пользователя или пароль!");
        this.backUnLogin();
      }
      else if (str == ProtocolLoginKey.NoExist.ToString())
      {
        int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "User name does not exist!" : "Имя пользователя не существует!");
        this.backUnLogin();
      }
      else
      {
        int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Connect to the server error!" : "Ошибка сервера подключения!");
        this.backUnLogin();
      }
    }

    private void backUnLogin() => this.Invoke(new Action( delegate()
    {
      this.accountTB.ReadOnly = false;
      this.passTB.ReadOnly = false;
      this.panel2.BackColor = Color.White;
      this.panel3.BackColor = Color.White;
      this.loginBtn.Enabled = true;
      this.loginBtn.Text = Settings.Default.Language == 2 ? "Login" : "Логин";
    }));

    private void remberCkb_Click(object sender, EventArgs e)
    {
    }

    private void RemoteForm_Load(object sender, EventArgs e)
    {
      if (Settings.Default.IsRember)
      {
        this.remberCkb.Checked = true;
        this.accountTB.Text = Settings.Default.UserName;
        this.passTB.Text = Settings.Default.PassWord;
      }
      if (PubMethod.isOpen)
        this.tipLabel.Text = Settings.Default.Language == 2 ? "Detected that you have connected the device \n and upload the device to the server?" : "Обнаружено, что вы подключены к устройству, вы хотите загрузить устройство на сервер?";
      else
        this.tipLabel.Text = Settings.Default.Language == 2 ? "Did not detect your connection device,\n do you search the equipment on the server?" : "Ваше подключенное устройство не обнаружено. Вы ищете устройства на сервере?";
      if (!PubMethod.isLogin)
        return;
      this.loginSuccess();
    }

    private void loginSuccess()
    {
      this.label3.Visible = false;
      this.label4.Visible = false;
      this.panel2.Visible = false;
      this.panel3.Visible = false;
      this.remberCkb.Visible = false;
      this.label2.Visible = false;
      this.linkLabel1.Visible = false;
      this.loginedLabel.Visible = true;
      this.loginNameLabel.Text = PubMethod.loginName;
      this.loginNameLabel.Visible = true;
      this.tipLabel.Visible = true;
      if (PubMethod.isOpen)
        this.loginBtn.Text = Settings.Default.Language == 2 ? "Upload" : "Загрузка";
      else
        this.loginBtn.Text = Settings.Default.Language == 2 ? "Search" : "Поиск";
      this.loginBtn.Enabled = true;
      this.exitBtn.Visible = true;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num = (int) new RegistForm().ShowDialog();
    }

    private void exitBtn_Click(object sender, EventArgs e) => this.exitLogin();

    private void exitLogin()
    {
      this.backUnLogin();
      this.label3.Visible = true;
      this.label4.Visible = true;
      this.panel2.Visible = true;
      this.panel3.Visible = true;
      this.remberCkb.Visible = true;
      this.label2.Visible = true;
      this.linkLabel1.Visible = true;
      this.loginedLabel.Visible = false;
      this.loginNameLabel.Text = "";
      this.loginNameLabel.Visible = false;
      this.tipLabel.Visible = false;
      this.loginBtn.Text = Settings.Default.Language == 2 ? "Login" : "Логин";
      this.loginBtn.Enabled = true;
      this.exitBtn.Visible = false;
      this.accountTB.Text = "";
      this.passTB.Text = "";
      PubMethod.isLogin = false;
      PubMethod.loginName = "";
      PubMethod.loginPass = "";
      this.mf.changeRemote(Settings.Default.Language == 2 ? "Remote state : OFF" : "Текущий удаленный статус: выключен");
    }
  }
}
