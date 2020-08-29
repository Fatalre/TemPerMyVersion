// Decompiled with JetBrains decompiler
// Type: TEMPer.IntroduceForm
// Assembly: TEMPer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0178A0CF-D577-468C-82A6-F9AFBCC94525
// Assembly location: D:\Program\Tempr\TEMPer.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TEMPer
{
  public class IntroduceForm : Form
  {
    private Point myPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private PictureBox closePic;
    private Label label2;
    private Label label3;

    public IntroduceForm() => this.InitializeComponent();

    private void IntroduceForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void IntroduceForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void IntroduceForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (IntroduceForm));
      this.panel1 = new Panel();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label1 = new Label();
      this.closePic = new PictureBox();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.label3);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.ForeColor = Color.White;
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Cursor = Cursors.Hand;
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
      this.Name = nameof (IntroduceForm);
      this.MouseDown += new MouseEventHandler(this.IntroduceForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.IntroduceForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.IntroduceForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
