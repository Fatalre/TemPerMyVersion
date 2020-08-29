// Decompiled with JetBrains decompiler
// Type: TEMPer.EmailHelp
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TEMPer.Properties;

namespace TEMPer
{
  public class EmailHelp : Form
  {
    private int lastRightPanelVerticalScrollValue = -1;
    private Point myPoint;
    private IContainer components = (IContainer) null;
    private Label label1;
    private Panel panel1;
    private Panel panel2;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label8;
    private Label label7;
    private Label label6;
    private PictureBox pictureBox1;
    private Label label11;
    private Label label12;
    private PictureBox closePic;
    private PictureBox pictureBox2;
    private Panel panel3;
    private Panel panel4;
    private Panel panel6;
    private Panel panel5;
    private LinkLabel linkLabel1;
    private PictureBox pictureBox4;
    private Label label18;
    private Label label17;
    private Label label16;
    private Label label13;
    private PictureBox pictureBox3;
    private LinkLabel linkLabel2;
    private Panel panel7;
    private Label label20;
    private Label label19;
    private Panel panel8;
    private Label label21;
    private LinkLabel linkLabel3;
    private PictureBox pictureBox5;
    private Label label23;
    private Label label26;
    private Label label27;
    private Label label28;
    private Panel panel9;
    private Label label34;
    private LinkLabel linkLabel4;
    private PictureBox pictureBox6;
    private Label label22;
    private Label label31;
    private Label label32;
    private Label label33;
    private PictureBox pictureBox7;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox6;
    private TextBox textBox5;
    private TextBox textBox8;
    private TextBox textBox7;
    private Label label9;

    public EmailHelp()
    {
      this.InitializeComponent();
      this.panel2.MouseWheel += new MouseEventHandler(this.panel2_MouseWheel);
      this.panel7.MouseWheel += new MouseEventHandler(this.panel7_MouseWheel);
      this.panel8.MouseWheel += new MouseEventHandler(this.panel8_MouseWheel);
      this.panel9.MouseWheel += new MouseEventHandler(this.panel9_MouseWheel);
    }

    private void label10_Click(object sender, EventArgs e)
    {
    }

    private void EmailHelp_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void EmailHelp_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void EmailHelp_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void panel2_MouseWheel(object sender, MouseEventArgs e)
    {
      if (!this.panel2.VerticalScroll.Visible || this.panel2.VerticalScroll.Value == 0 && e.Delta > 0 || this.panel2.VerticalScroll.Value == this.lastRightPanelVerticalScrollValue && e.Delta < 0)
        return;
      this.panel2.VerticalScroll.Value += 10;
      this.lastRightPanelVerticalScrollValue = this.panel2.VerticalScroll.Value;
      this.panel2.Refresh();
      this.panel2.Invalidate();
      this.panel2.Update();
    }

    private void panel7_MouseWheel(object sender, MouseEventArgs e)
    {
      if (!this.panel7.VerticalScroll.Visible || this.panel7.VerticalScroll.Value == 0 && e.Delta > 0 || this.panel7.VerticalScroll.Value == this.lastRightPanelVerticalScrollValue && e.Delta < 0)
        return;
      this.panel7.VerticalScroll.Value += 10;
      this.lastRightPanelVerticalScrollValue = this.panel7.VerticalScroll.Value;
      this.panel7.Refresh();
      this.panel7.Invalidate();
      this.panel7.Update();
    }

    private void panel8_MouseWheel(object sender, MouseEventArgs e)
    {
      if (!this.panel8.VerticalScroll.Visible || this.panel8.VerticalScroll.Value == 0 && e.Delta > 0 || this.panel8.VerticalScroll.Value == this.lastRightPanelVerticalScrollValue && e.Delta < 0)
        return;
      this.panel8.VerticalScroll.Value += 10;
      this.lastRightPanelVerticalScrollValue = this.panel8.VerticalScroll.Value;
      this.panel8.Refresh();
      this.panel8.Invalidate();
      this.panel8.Update();
    }

    private void panel9_MouseWheel(object sender, MouseEventArgs e)
    {
      if (!this.panel9.VerticalScroll.Visible || this.panel9.VerticalScroll.Value == 0 && e.Delta > 0 || this.panel9.VerticalScroll.Value == this.lastRightPanelVerticalScrollValue && e.Delta < 0)
        return;
      this.panel9.VerticalScroll.Value += 10;
      this.lastRightPanelVerticalScrollValue = this.panel9.VerticalScroll.Value;
      this.panel9.Refresh();
      this.panel9.Invalidate();
      this.panel9.Update();
    }

    private void panel2_MouseClick(object sender, MouseEventArgs e) => this.panel2.Focus();

    private void panel2_MouseHover(object sender, EventArgs e) => this.panel2.Focus();

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e) => this.panel2.Focus();

    private void pictureBox2_MouseMove(object sender, MouseEventArgs e) => this.panel2.Focus();

    private void label2_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = true;
      this.panel7.Visible = false;
      this.panel8.Visible = false;
      this.panel9.Visible = false;
    }

    private void panel3_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = true;
      this.panel7.Visible = false;
      this.panel8.Visible = false;
      this.panel9.Visible = false;
    }

    private void EmailHelp_Load(object sender, EventArgs e)
    {
      if (Settings.Default.Language == 2)
      {
        this.panel2.Visible = false;
        this.panel3.Visible = false;
        this.label2.Visible = false;
      }
      else
      {
        this.panel2.Visible = true;
        this.panel3.Visible = true;
        this.label2.Visible = true;
      }
      this.label2.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
    }

    private void label3_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = false;
      this.panel7.Visible = true;
      this.panel8.Visible = false;
      this.panel9.Visible = false;
    }

    private void panel4_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = false;
      this.panel7.Visible = true;
      this.panel8.Visible = false;
      this.panel9.Visible = false;
    }

    private void label4_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel6.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = false;
      this.panel7.Visible = false;
      this.panel8.Visible = true;
      this.panel9.Visible = false;
    }

    private void panel6_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel6.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.label5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel5.BackColor = Color.FromArgb(242, 240, 241);
      this.panel2.Visible = false;
      this.panel7.Visible = false;
      this.panel8.Visible = true;
      this.panel9.Visible = false;
    }

    private void label5_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel2.Visible = false;
      this.panel7.Visible = false;
      this.panel8.Visible = false;
      this.panel9.Visible = true;
    }

    private void panel5_Click(object sender, EventArgs e)
    {
      this.label2.BackColor = Color.FromArgb(242, 240, 241);
      this.panel3.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label3.BackColor = Color.FromArgb(242, 240, 241);
      this.panel4.BackColor = Color.FromArgb(242, 240, 241);
      this.label4.BackColor = Color.FromArgb(242, 240, 241);
      this.panel6.BackColor = Color.FromArgb(242, 240, 241);
      this.label5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel5.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel2.Visible = false;
      this.panel7.Visible = false;
      this.panel8.Visible = false;
      this.panel9.Visible = true;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://mail.qq.com/");

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://mail.163.com/");

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://outlook.live.com/");

    private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://mail.google.com/");

    private void panel7_MouseMove(object sender, MouseEventArgs e) => this.panel7.Focus();

    private void panel7_MouseHover(object sender, EventArgs e) => this.panel7.Focus();

    private void panel8_MouseHover(object sender, EventArgs e) => this.panel8.Focus();

    private void panel8_MouseMove(object sender, MouseEventArgs e) => this.panel8.Focus();

    private void panel9_MouseHover(object sender, EventArgs e) => this.panel9.Focus();

    private void panel9_MouseMove(object sender, MouseEventArgs e) => this.panel9.Focus();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EmailHelp));
      this.label1 = new Label();
      this.panel1 = new Panel();
      this.panel3 = new Panel();
      this.label2 = new Label();
      this.panel6 = new Panel();
      this.label4 = new Label();
      this.panel4 = new Panel();
      this.label3 = new Label();
      this.panel5 = new Panel();
      this.label5 = new Label();
      this.panel2 = new Panel();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.linkLabel1 = new LinkLabel();
      this.pictureBox2 = new PictureBox();
      this.label11 = new Label();
      this.label8 = new Label();
      this.label7 = new Label();
      this.label6 = new Label();
      this.pictureBox1 = new PictureBox();
      this.label12 = new Label();
      this.closePic = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.label18 = new Label();
      this.label17 = new Label();
      this.label16 = new Label();
      this.label13 = new Label();
      this.pictureBox3 = new PictureBox();
      this.linkLabel2 = new LinkLabel();
      this.panel7 = new Panel();
      this.textBox4 = new TextBox();
      this.textBox3 = new TextBox();
      this.label20 = new Label();
      this.label19 = new Label();
      this.panel8 = new Panel();
      this.label9 = new Label();
      this.textBox6 = new TextBox();
      this.textBox5 = new TextBox();
      this.label21 = new Label();
      this.linkLabel3 = new LinkLabel();
      this.pictureBox5 = new PictureBox();
      this.label23 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label28 = new Label();
      this.panel9 = new Panel();
      this.textBox8 = new TextBox();
      this.textBox7 = new TextBox();
      this.label34 = new Label();
      this.linkLabel4 = new LinkLabel();
      this.pictureBox6 = new PictureBox();
      this.label22 = new Label();
      this.label31 = new Label();
      this.label32 = new Label();
      this.label33 = new Label();
      this.pictureBox7 = new PictureBox();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.closePic).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      this.panel7.SuspendLayout();
      this.panel8.SuspendLayout();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      this.panel9.SuspendLayout();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      ((ISupportInitialize) this.pictureBox7).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      this.panel1.BackColor = SystemColors.Control;
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.panel6);
      this.panel1.Controls.Add((Control) this.panel4);
      this.panel1.Controls.Add((Control) this.panel5);
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.Name = "panel1";
      this.panel3.Controls.Add((Control) this.label2);
      componentResourceManager.ApplyResources((object) this.panel3, "panel3");
      this.panel3.Name = "panel3";
      this.panel3.Click += new EventHandler(this.panel3_Click);
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.ForeColor = Color.DodgerBlue;
      this.label2.Name = "label2";
      this.label2.Click += new EventHandler(this.label2_Click);
      this.panel6.Controls.Add((Control) this.label4);
      componentResourceManager.ApplyResources((object) this.panel6, "panel6");
      this.panel6.Name = "panel6";
      this.panel6.Click += new EventHandler(this.panel6_Click);
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.ForeColor = Color.DodgerBlue;
      this.label4.Name = "label4";
      this.label4.Click += new EventHandler(this.label4_Click);
      this.panel4.Controls.Add((Control) this.label3);
      componentResourceManager.ApplyResources((object) this.panel4, "panel4");
      this.panel4.Name = "panel4";
      this.panel4.Click += new EventHandler(this.panel4_Click);
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.ForeColor = Color.DodgerBlue;
      this.label3.Name = "label3";
      this.label3.Click += new EventHandler(this.label3_Click);
      this.panel5.Controls.Add((Control) this.label5);
      componentResourceManager.ApplyResources((object) this.panel5, "panel5");
      this.panel5.Name = "panel5";
      this.panel5.Click += new EventHandler(this.panel5_Click);
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.ForeColor = Color.DodgerBlue;
      this.label5.Name = "label5";
      this.label5.Click += new EventHandler(this.label5_Click);
      componentResourceManager.ApplyResources((object) this.panel2, "panel2");
      this.panel2.BackColor = SystemColors.ControlLightLight;
      this.panel2.Controls.Add((Control) this.textBox2);
      this.panel2.Controls.Add((Control) this.textBox1);
      this.panel2.Controls.Add((Control) this.linkLabel1);
      this.panel2.Controls.Add((Control) this.pictureBox2);
      this.panel2.Controls.Add((Control) this.label11);
      this.panel2.Controls.Add((Control) this.label8);
      this.panel2.Controls.Add((Control) this.label7);
      this.panel2.Controls.Add((Control) this.label6);
      this.panel2.Controls.Add((Control) this.pictureBox1);
      this.panel2.Name = "panel2";
      this.panel2.MouseClick += new MouseEventHandler(this.panel2_MouseClick);
      this.textBox2.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox2, "textBox2");
      this.textBox2.Name = "textBox2";
      this.textBox1.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox1, "textBox1");
      this.textBox1.Name = "textBox1";
      componentResourceManager.ApplyResources((object) this.linkLabel1, "linkLabel1");
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.TabStop = true;
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      componentResourceManager.ApplyResources((object) this.pictureBox2, "pictureBox2");
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.TabStop = false;
      this.pictureBox2.MouseMove += new MouseEventHandler(this.pictureBox2_MouseMove);
      componentResourceManager.ApplyResources((object) this.label11, "label11");
      this.label11.Name = "label11";
      componentResourceManager.ApplyResources((object) this.label8, "label8");
      this.label8.Name = "label8";
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.label6, "label6");
      this.label6.Name = "label6";
      componentResourceManager.ApplyResources((object) this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseMove += new MouseEventHandler(this.pictureBox1_MouseMove);
      componentResourceManager.ApplyResources((object) this.label12, "label12");
      this.label12.ForeColor = Color.White;
      this.label12.Name = "label12";
      this.closePic.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this.pictureBox4, "pictureBox4");
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label18, "label18");
      this.label18.Name = "label18";
      componentResourceManager.ApplyResources((object) this.label17, "label17");
      this.label17.Name = "label17";
      componentResourceManager.ApplyResources((object) this.label16, "label16");
      this.label16.Name = "label16";
      componentResourceManager.ApplyResources((object) this.label13, "label13");
      this.label13.Name = "label13";
      componentResourceManager.ApplyResources((object) this.pictureBox3, "pictureBox3");
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.linkLabel2, "linkLabel2");
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.TabStop = true;
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      componentResourceManager.ApplyResources((object) this.panel7, "panel7");
      this.panel7.BackColor = SystemColors.ControlLightLight;
      this.panel7.Controls.Add((Control) this.textBox4);
      this.panel7.Controls.Add((Control) this.textBox3);
      this.panel7.Controls.Add((Control) this.label20);
      this.panel7.Controls.Add((Control) this.label19);
      this.panel7.Controls.Add((Control) this.linkLabel2);
      this.panel7.Controls.Add((Control) this.pictureBox3);
      this.panel7.Controls.Add((Control) this.label13);
      this.panel7.Controls.Add((Control) this.label16);
      this.panel7.Controls.Add((Control) this.label17);
      this.panel7.Controls.Add((Control) this.label18);
      this.panel7.Controls.Add((Control) this.pictureBox4);
      this.panel7.Name = "panel7";
      this.panel7.MouseHover += new EventHandler(this.panel7_MouseHover);
      this.panel7.MouseMove += new MouseEventHandler(this.panel7_MouseMove);
      this.textBox4.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox4, "textBox4");
      this.textBox4.Name = "textBox4";
      this.textBox3.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox3, "textBox3");
      this.textBox3.Name = "textBox3";
      componentResourceManager.ApplyResources((object) this.label20, "label20");
      this.label20.Name = "label20";
      componentResourceManager.ApplyResources((object) this.label19, "label19");
      this.label19.Name = "label19";
      componentResourceManager.ApplyResources((object) this.panel8, "panel8");
      this.panel8.BackColor = SystemColors.ControlLightLight;
      this.panel8.Controls.Add((Control) this.label9);
      this.panel8.Controls.Add((Control) this.textBox6);
      this.panel8.Controls.Add((Control) this.textBox5);
      this.panel8.Controls.Add((Control) this.label21);
      this.panel8.Controls.Add((Control) this.linkLabel3);
      this.panel8.Controls.Add((Control) this.pictureBox5);
      this.panel8.Controls.Add((Control) this.label23);
      this.panel8.Controls.Add((Control) this.label26);
      this.panel8.Controls.Add((Control) this.label27);
      this.panel8.Controls.Add((Control) this.label28);
      this.panel8.Name = "panel8";
      this.panel8.MouseHover += new EventHandler(this.panel8_MouseHover);
      this.panel8.MouseMove += new MouseEventHandler(this.panel8_MouseMove);
      componentResourceManager.ApplyResources((object) this.label9, "label9");
      this.label9.ForeColor = Color.DeepPink;
      this.label9.Name = "label9";
      this.textBox6.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox6, "textBox6");
      this.textBox6.Name = "textBox6";
      this.textBox5.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox5, "textBox5");
      this.textBox5.Name = "textBox5";
      componentResourceManager.ApplyResources((object) this.label21, "label21");
      this.label21.ForeColor = Color.DeepPink;
      this.label21.Name = "label21";
      componentResourceManager.ApplyResources((object) this.linkLabel3, "linkLabel3");
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.TabStop = true;
      this.linkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
      componentResourceManager.ApplyResources((object) this.pictureBox5, "pictureBox5");
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label23, "label23");
      this.label23.Name = "label23";
      componentResourceManager.ApplyResources((object) this.label26, "label26");
      this.label26.Name = "label26";
      componentResourceManager.ApplyResources((object) this.label27, "label27");
      this.label27.Name = "label27";
      componentResourceManager.ApplyResources((object) this.label28, "label28");
      this.label28.Name = "label28";
      componentResourceManager.ApplyResources((object) this.panel9, "panel9");
      this.panel9.BackColor = SystemColors.ControlLightLight;
      this.panel9.Controls.Add((Control) this.textBox8);
      this.panel9.Controls.Add((Control) this.textBox7);
      this.panel9.Controls.Add((Control) this.label34);
      this.panel9.Controls.Add((Control) this.linkLabel4);
      this.panel9.Controls.Add((Control) this.pictureBox6);
      this.panel9.Controls.Add((Control) this.label22);
      this.panel9.Controls.Add((Control) this.label31);
      this.panel9.Controls.Add((Control) this.label32);
      this.panel9.Controls.Add((Control) this.label33);
      this.panel9.Controls.Add((Control) this.pictureBox7);
      this.panel9.Name = "panel9";
      this.panel9.MouseHover += new EventHandler(this.panel9_MouseHover);
      this.panel9.MouseMove += new MouseEventHandler(this.panel9_MouseMove);
      this.textBox8.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox8, "textBox8");
      this.textBox8.Name = "textBox8";
      this.textBox7.BorderStyle = BorderStyle.None;
      componentResourceManager.ApplyResources((object) this.textBox7, "textBox7");
      this.textBox7.Name = "textBox7";
      componentResourceManager.ApplyResources((object) this.label34, "label34");
      this.label34.Name = "label34";
      componentResourceManager.ApplyResources((object) this.linkLabel4, "linkLabel4");
      this.linkLabel4.Name = "linkLabel4";
      this.linkLabel4.TabStop = true;
      this.linkLabel4.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
      componentResourceManager.ApplyResources((object) this.pictureBox6, "pictureBox6");
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label22, "label22");
      this.label22.Name = "label22";
      componentResourceManager.ApplyResources((object) this.label31, "label31");
      this.label31.Name = "label31";
      componentResourceManager.ApplyResources((object) this.label32, "label32");
      this.label32.Name = "label32";
      componentResourceManager.ApplyResources((object) this.label33, "label33");
      this.label33.Name = "label33";
      componentResourceManager.ApplyResources((object) this.pictureBox7, "pictureBox7");
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.TabStop = false;
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.panel8);
      this.Controls.Add((Control) this.panel9);
      this.Controls.Add((Control) this.panel7);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (EmailHelp);
      this.Load += new EventHandler(this.EmailHelp_Load);
      this.MouseDown += new MouseEventHandler(this.EmailHelp_MouseDown);
      this.MouseMove += new MouseEventHandler(this.EmailHelp_MouseMove);
      this.MouseUp += new MouseEventHandler(this.EmailHelp_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.closePic).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      ((ISupportInitialize) this.pictureBox6).EndInit();
      ((ISupportInitialize) this.pictureBox7).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
