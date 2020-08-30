// Decompiled with JetBrains decompiler
// Type: TEMPer.AboutForm
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TEMPer.Properties;

namespace TEMPer
{
  public class AboutForm : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label softLabel;
    private Label fireLabel;
    private Label label8;
    private Label label7;
    private Label label9;
    private Label label10;
    private Label label11;
    private PictureBox closePic;
    private LinkLabel checkVersion;
    private Point myPoint;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AboutForm));
      this.panel1 = new Panel();
      this.checkVersion = new LinkLabel();
      this.label10 = new Label();
      this.label9 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.fireLabel = new Label();
      this.softLabel = new Label();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.label11 = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.checkVersion);
      this.panel1.Controls.Add((Control) this.label10);
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.label8);
      this.panel1.Controls.Add((Control) this.label7);
      this.panel1.Controls.Add((Control) this.fireLabel);
      this.panel1.Controls.Add((Control) this.softLabel);
      this.panel1.Controls.Add((Control) this.label6);
      this.panel1.Controls.Add((Control) this.label5);
      this.panel1.Controls.Add((Control) this.label4);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.checkVersion, "checkVersion");
      this.checkVersion.LinkBehavior = LinkBehavior.NeverUnderline;
      this.checkVersion.Name = "checkVersion";
      this.checkVersion.TabStop = true;
      this.checkVersion.LinkClicked += new LinkLabelLinkClickedEventHandler(this.checkVersion_LinkClicked);
      componentResourceManager.ApplyResources((object) this.label10, "label10");
      this.label10.Name = "label10";
      componentResourceManager.ApplyResources((object) this.label9, "label9");
      this.label9.Name = "label9";
      componentResourceManager.ApplyResources((object) this.label8, "label8");
      this.label8.Name = "label8";
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.fireLabel, "fireLabel");
      this.fireLabel.Name = "fireLabel";
      componentResourceManager.ApplyResources((object) this.softLabel, "softLabel");
      this.softLabel.Name = "softLabel";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label11, "label11");
      this.label11.ForeColor = Color.White;
      this.label11.Name = "label11";
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Cursor = Cursors.Hand;
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (AboutForm);
      this.Load += new EventHandler(this.AboutForm_Load);
      this.MouseDown += new MouseEventHandler(this.AboutForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.AboutForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.AboutForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public AboutForm() => this.InitializeComponent();

    private void AboutForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void AboutForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void AboutForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void AboutForm_Load(object sender, EventArgs e)
    {
      this.softLabel.Text = "TEMPer V26.2 Руссификатор by Fatalre";
      this.fireLabel.Text = PubMethod.version;
    }

    private void checkVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (PubMethod.HasUpdate())
      {
        if (MessageBox.Show(Settings.Default.Language == 2 ? "Program detects a new version, whether the update immediately?" : "Программа определяет новую версию, нужно ли ее сразу обновлять?", "", MessageBoxButtons.YesNo) != DialogResult.Yes || !File.Exists(Application.StartupPath + "/RDingWebUpdate.exe"))
          return;
        Process.Start(Application.StartupPath + "/RDingWebUpdate.exe");
        Environment.Exit(0);
      }
      else
      {
        int num = (int) MessageBox.Show(this.label11.Text + "," + (Settings.Default.Language == 2 ? "This version is the latest version！" : "Это последняя версия!"));
      }
    }
  }
}
