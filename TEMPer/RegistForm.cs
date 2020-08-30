// Decompiled with JetBrains decompiler
// Type: TEMPer.RegistForm
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using TEMPer.Properties;

namespace TEMPer
{
  public class RegistForm : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Label label2;
    private TextBox textBox1;
    private Label label7;
    private Label label6;
    private Panel panel7;
    private TextBox textBox6;
    private Panel panel6;
    private TextBox textBox5;
    private Label label5;
    private Label label4;
    private Panel panel5;
    private TextBox textBox4;
    private Label label3;
    private Panel panel4;
    private TextBox textBox3;
    private Panel panel3;
    private TextBox textBox2;
    private Button button1;
    private PictureBox closePic;
    private bool isSuccess = false;
    private Point myPoint;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (RegistForm));
      this.panel1 = new Panel();
      this.button1 = new Button();
      this.label7 = new Label();
      this.label6 = new Label();
      this.panel7 = new Panel();
      this.textBox6 = new TextBox();
      this.panel6 = new Panel();
      this.textBox5 = new TextBox();
      this.label5 = new Label();
      this.label4 = new Label();
      this.panel5 = new Panel();
      this.textBox4 = new TextBox();
      this.label3 = new Label();
      this.panel4 = new Panel();
      this.textBox3 = new TextBox();
      this.panel3 = new Panel();
      this.textBox2 = new TextBox();
      this.label2 = new Label();
      this.panel2 = new Panel();
      this.textBox1 = new TextBox();
      this.label1 = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.panel7);
      this.panel1.Controls.Add((Control) this.panel6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.panel5);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.panel4);
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.panel2);
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.button1, "button1");
      this.button1.Name = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      this.panel7.BackColor = Color.White;
      this.panel7.Controls.Add((Control) this.textBox6);
      componentResourceManager.ApplyResources((object) this.panel7, "panel7");
      this.panel7.Name = "panel7";
      this.textBox6.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox6, "textBox6");
      this.textBox6.Name = "textBox6";
      this.panel6.BackColor = Color.White;
      this.panel6.Controls.Add((Control) this.textBox5);
      componentResourceManager.ApplyResources((object) this.panel6, "panel6");
      this.panel6.Name = "panel6";
      this.textBox5.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox5, "textBox5");
      this.textBox5.Name = "textBox5";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      this.panel5.BackColor = Color.White;
      this.panel5.Controls.Add((Control) this.textBox4);
      componentResourceManager.ApplyResources((object) this.panel5, "panel5");
      this.panel5.Name = "panel5";
      this.textBox4.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox4, "textBox4");
      this.textBox4.Name = "textBox4";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      this.panel4.BackColor = Color.White;
      this.panel4.Controls.Add((Control) this.textBox3);
      componentResourceManager.ApplyResources((object) this.panel4, "panel4");
      this.panel4.Name = "panel4";
      this.textBox3.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox3, "textBox3");
      this.textBox3.Name = "textBox3";
      this.panel3.BackColor = Color.White;
      this.panel3.Controls.Add((Control) this.textBox2);
      componentResourceManager.ApplyResources((object) this.panel3, "panel3");
      this.panel3.Name = "panel3";
      this.textBox2.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox2, "textBox2");
      this.textBox2.Name = "textBox2";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      this.panel2.BackColor = Color.White;
      this.panel2.Controls.Add((Control) this.textBox1);
      componentResourceManager.ApplyResources((object) this.panel2, "panel2");
      this.panel2.Name = "panel2";
      this.textBox1.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
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
      this.Name = nameof (RegistForm);
      this.FormClosed += new FormClosedEventHandler(this.RegistForm_FormClosed);
      this.Load += new EventHandler(this.RegistForm_Load);
      this.MouseDown += new MouseEventHandler(this.RegistForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.RegistForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.RegistForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public RegistForm() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      string user = this.textBox1.Text;
      string pass = this.textBox2.Text;
      string text = this.textBox3.Text;
      string name = this.textBox4.Text;
      string tel = this.textBox5.Text;
      string company = this.textBox6.Text;
      if (user.Length < 5)
      {
        int num1 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "User name length at least five" : "Имя пользователя должно быть не менее 5 символов.");
      }
      else if (!Regex.IsMatch(user, "^[a-zA-Z0-9_]{5,16}$"))
      {
        int num2 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "User name only allow alphanumeric underline combination" : "Имя пользователя допускает только буквенно-цифровые комбинации и подчеркивания.");
      }
      else if (pass.Length < 5)
      {
        int num3 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Password length is at least five" : "Длина пароля не менее 5 символов");
      }
      else if (text.Length < 5)
      {
        int num4 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Confirm password length at least five" : "Подтвердите, что пароль состоит не менее чем из 5 символов.");
      }
      else if (text != pass)
      {
        int num5 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The original password input error" : "Две записи пароля несовместимы");
      }
      else if (name.Length == 0)
      {
        int num6 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Please fill in your name" : "Пожалуйста, введите ваше имя");
      }
      else if (!Regex.IsMatch(tel, "^[0-9]{8,12}$"))
      {
        int num7 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Please fill in the correct contact way" : "Пожалуйста, введите правильную контактную информацию");
      }
      else if (company.Length == 0)
      {
        int num8 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Please fill in the company" : "Пожалуйста, заполните компанию");
      }
      else
        ThreadPool.QueueUserWorkItem((WaitCallback) (o =>
        {
          string str = HttpPostHelp.PostSend("http://120.24.211.240/WebRemoteAsmx/u/ServiceUserLogin.asmx/Registered", new Dictionary<string, string>()
          {
            {
              "ServiceUserLogin",
              DESEncrypt.Encrypt("www.pcsensor.com")
            },
            {
              "UserEmail",
              DESEncrypt.Encrypt(user)
            },
            {
              "UserPwd",
              DESEncrypt.Encrypt(pass)
            },
            {
              "Name",
              DESEncrypt.Encrypt(name)
            },
            {
              "Phone",
              DESEncrypt.Encrypt(tel)
            },
            {
              "CompanyName",
              DESEncrypt.Encrypt(company)
            },
            {
              "DateTime",
              DESEncrypt.Encrypt(DateTime.Now.ToString())
            }
          });
          if (str == null)
          {
            int num9 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Unable to connect to the server registration, overtime!" : "Время регистрации истекло, невозможно подключиться к серверу!");
          }
          else if (str == ProtocolRegisteredKey.Error.ToString())
          {
            int num10 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Please submit the correct information!" : "Пожалуйста, отправьте правильную информацию!");
          }
          else if (str == ProtocolRegisteredKey.Success.ToString())
            this.Invoke(new Action( delegate()
            {
              this.isSuccess = true;
              this.Close();
            }));
          else if (str == ProtocolRegisteredKey.Exist.ToString())
          {
            int num11 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "The user name has been registered! " : "Имя пользователя уже зарегистрировано!");
          }
          else
          {
            int num12 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Connect to the server error! " : "Ошибка сервера подключения!");
          }
        }));
    }

    private void RegistForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (!this.isSuccess)
        return;
      int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Registered successfully!" : "Вы успешно зарегистрировались!");
    }

    private void RegistForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void RegistForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void RegistForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void RegistForm_Load(object sender, EventArgs e)
    {
    }
  }
}
