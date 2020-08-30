// Decompiled with JetBrains decompiler
// Type: TEMPer.AlarmForm
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
  public class AlarmForm : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label titleLabel;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private NumericUpDown lowerValue;
    private NumericUpDown upperValue;
    private NumericUpDown calibValue;
    private Label label7;
    private Label label6;
    private Button sureBtn;
    private PictureBox closePic;
    private int tag = 0;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AlarmForm));
      this.panel1 = new Panel();
      this.sureBtn = new Button();
      this.label7 = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.lowerValue = new NumericUpDown();
      this.upperValue = new NumericUpDown();
      this.calibValue = new NumericUpDown();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.titleLabel = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      this.lowerValue.BeginInit();
      this.upperValue.BeginInit();
      this.calibValue.BeginInit();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.sureBtn);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.lowerValue);
      this.panel1.Controls.Add((Control) this.upperValue);
      this.panel1.Controls.Add((Control) this.calibValue);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.Name = "panel1";
      this.sureBtn.BackColor = Color.FromArgb(62, 160, 228);
      this.sureBtn.FlatAppearance.BorderSize = 0;
      componentResourceManager.ApplyResources((object) this.sureBtn, "sureBtn");
      this.sureBtn.Name = "sureBtn";
      this.sureBtn.UseVisualStyleBackColor = false;
      this.sureBtn.Click += new EventHandler(this.sureBtn_Click);
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.ForeColor = Color.Red;
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.ForeColor = Color.Red;
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.ForeColor = Color.Red;
      this.label5.Name = "label5";
      this.lowerValue.DecimalPlaces = 1;
      componentResourceManager.ApplyResources((object) this.lowerValue, "lowerValue");
      this.lowerValue.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.lowerValue.Minimum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      this.lowerValue.Name = "lowerValue";
      this.upperValue.DecimalPlaces = 1;
      componentResourceManager.ApplyResources((object) this.upperValue, "upperValue");
      this.upperValue.Maximum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        0
      });
      this.upperValue.Minimum = new Decimal(new int[4]
      {
        1000,
        0,
        0,
        int.MinValue
      });
      this.upperValue.Name = "upperValue";
      this.calibValue.DecimalPlaces = 1;
      componentResourceManager.ApplyResources((object) this.calibValue, "calibValue");
      this.calibValue.Maximum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        0
      });
      this.calibValue.Minimum = new Decimal(new int[4]
      {
        8,
        0,
        0,
        int.MinValue
      });
      this.calibValue.Name = "calibValue";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.titleLabel, "titleLabel");
      this.titleLabel.ForeColor = Color.White;
      this.titleLabel.Name = "titleLabel";
      this.closePic.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.titleLabel);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (AlarmForm);
      this.Load += new EventHandler(this.AlarmForm_Load);
      this.MouseDown += new MouseEventHandler(this.AlarmForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.AlarmForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.AlarmForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.lowerValue.EndInit();
      this.upperValue.EndInit();
      this.calibValue.EndInit();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public AlarmForm(string tagStr)
    {
      this.InitializeComponent();
      this.tag = int.Parse(tagStr);
    }

    private void AlarmForm_Load(object sender, EventArgs e)
    {
      switch (this.tag)
      {
        case 1:
          this.titleLabel.Text = Settings.Default.Language == 2 ? "Inner temp" : "Внутренняя температура";
          this.calibValue.Text = string.Concat((object) PubMethod.calib1);
          this.upperValue.Text = string.Concat((object) Settings.Default.tempUpper1);
          this.lowerValue.Text = string.Concat((object) Settings.Default.tempLower1);
          break;
        case 2:
          this.titleLabel.Text = Settings.Default.Language == 2 ? "Inner hum" : "Внутренняя влажность";
          this.calibValue.Text = string.Concat((object) PubMethod.calib2);
          this.upperValue.Text = string.Concat((object) Settings.Default.tempUpper2);
          this.lowerValue.Text = string.Concat((object) Settings.Default.tempLower2);
          break;
        case 3:
          this.titleLabel.Text = Settings.Default.Language == 2 ? "Outer temp" : "Наружная температура";
          this.calibValue.Text = string.Concat((object) PubMethod.calib3);
          this.upperValue.Text = string.Concat((object) Settings.Default.tempUpper3);
          this.lowerValue.Text = string.Concat((object) Settings.Default.tempLower3);
          break;
        case 4:
          this.titleLabel.Text = Settings.Default.Language == 2 ? "Outer hum" : "Внешняя влажность";
          this.calibValue.Text = string.Concat((object) PubMethod.calib4);
          this.upperValue.Text = string.Concat((object) Settings.Default.tempUpper4);
          this.lowerValue.Text = string.Concat((object) Settings.Default.tempLower4);
          break;
      }
    }

    private void AlarmForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void AlarmForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void AlarmForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void sureBtn_Click(object sender, EventArgs e)
    {
      double d = double.Parse(this.calibValue.Text);
      if (this.mf.setCalib(PubMethod.getCailbByte(this.tag, d)))
      {
        double num1 = double.Parse(this.upperValue.Text);
        double num2 = double.Parse(this.lowerValue.Text);
        switch (this.tag)
        {
          case 1:
            Settings.Default.tempUpper1 = num1;
            Settings.Default.tempLower1 = num2;
            PubMethod.calib1 = (double) (int) d;
            break;
          case 2:
            Settings.Default.tempUpper2 = num1;
            Settings.Default.tempLower2 = num2;
            PubMethod.calib2 = (double) (int) d;
            break;
          case 3:
            Settings.Default.tempUpper3 = num1;
            Settings.Default.tempLower3 = num2;
            PubMethod.calib3 = (double) (int) d;
            break;
          case 4:
            Settings.Default.tempUpper4 = num1;
            Settings.Default.tempLower4 = num2;
            PubMethod.calib4 = (double) (int) d;
            break;
        }
        Settings.Default.Save();
        this.Close();
      }
      else
      {
        int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Set fail" : "Ошибка установки");
      }
    }
  }
}
