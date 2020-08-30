// Decompiled with JetBrains decompiler
// Type: TEMPer.SetForm
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
  public class SetForm : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Label label4;
    private Label label5;
    private Label label7;
    private Label label10;
    private Label label9;
    private RadioButton chineseRtn;
    private NumericUpDown interval;
    private PictureBox closePic;
    private Label label11;
    private RadioButton englishRtn;
    private RadioButton ssdRtn;
    private RadioButton hsdRtn;
    private RadioButton csvRtn;
    private RadioButton txtRtn;
    private Label label12;
    private NumericUpDown rowMax;
    private TextBox filePathTB;
    private Button fileBtn;
    private RadioButton onRtn;
    private RadioButton offRtn;
    private RadioButton minRtn;
    private RadioButton closeRtn;
    private Button soundBtn;
    private TextBox soundPathTB;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private GroupBox groupBox4;
    private GroupBox groupBox5;
    private GroupBox groupBox6;
    private FolderBrowserDialog folderBrowserDialog1;
    private OpenFileDialog openFileDialog1;
    private Panel tipPanel;
    private TextBox textBox1;
    private Timer timer1;
    private CheckBox AutoRunCBX;
    public MainForm mf;
    private Point myPoint;
    private bool isFirst = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SetForm));
      this.panel1 = new Panel();
      this.AutoRunCBX = new CheckBox();
      this.tipPanel = new Panel();
      this.textBox1 = new TextBox();
      this.groupBox6 = new GroupBox();
      this.closeRtn = new RadioButton();
      this.minRtn = new RadioButton();
      this.groupBox5 = new GroupBox();
      this.label9 = new Label();
      this.onRtn = new RadioButton();
      this.offRtn = new RadioButton();
      this.label10 = new Label();
      this.soundPathTB = new TextBox();
      this.soundBtn = new Button();
      this.groupBox4 = new GroupBox();
      this.interval = new NumericUpDown();
      this.label11 = new Label();
      this.groupBox3 = new GroupBox();
      this.label7 = new Label();
      this.csvRtn = new RadioButton();
      this.txtRtn = new RadioButton();
      this.label12 = new Label();
      this.label4 = new Label();
      this.rowMax = new NumericUpDown();
      this.label5 = new Label();
      this.filePathTB = new TextBox();
      this.fileBtn = new Button();
      this.groupBox2 = new GroupBox();
      this.ssdRtn = new RadioButton();
      this.hsdRtn = new RadioButton();
      this.groupBox1 = new GroupBox();
      this.chineseRtn = new RadioButton();
      this.englishRtn = new RadioButton();
      this.label1 = new Label();
      this.closePic = new PictureBox();
      this.folderBrowserDialog1 = new FolderBrowserDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.timer1 = new Timer(this.components);
      this.panel1.SuspendLayout();
      this.tipPanel.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.interval.BeginInit();
      this.groupBox3.SuspendLayout();
      this.rowMax.BeginInit();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((ISupportInitialize) this.closePic).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.AutoRunCBX);
      this.panel1.Controls.Add((Control) this.tipPanel);
      this.panel1.Controls.Add((Control) this.groupBox6);
      this.panel1.Controls.Add((Control) this.groupBox5);
      this.panel1.Controls.Add((Control) this.groupBox4);
      this.panel1.Controls.Add((Control) this.groupBox3);
      this.panel1.Controls.Add((Control) this.groupBox2);
      this.panel1.Controls.Add((Control) this.groupBox1);
      this.panel1.Name = "panel1";
      componentResourceManager.ApplyResources((object) this.AutoRunCBX, "AutoRunCBX");
      this.AutoRunCBX.Name = "AutoRunCBX";
      this.AutoRunCBX.UseVisualStyleBackColor = true;
      this.AutoRunCBX.CheckedChanged += new EventHandler(this.AutoRunCBX_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.tipPanel, "tipPanel");
      this.tipPanel.BackColor = Color.FromArgb(62, 160, 228);
      this.tipPanel.Controls.Add((Control) this.textBox1);
      this.tipPanel.Name = "tipPanel";
      componentResourceManager.ApplyResources((object) this.textBox1, "textBox1");
      this.textBox1.BackColor = Color.FromArgb(62, 160, 228);
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.ForeColor = Color.White;
      this.textBox1.Name = "textBox1";
      componentResourceManager.ApplyResources((object) this.groupBox6, "groupBox6");
      this.groupBox6.Controls.Add((Control) this.closeRtn);
      this.groupBox6.Controls.Add((Control) this.minRtn);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.TabStop = false;
      componentResourceManager.ApplyResources((object) this.closeRtn, "closeRtn");
      this.closeRtn.Name = "closeRtn";
      this.closeRtn.TabStop = true;
      this.closeRtn.Tag = (object) "1";
      this.closeRtn.UseVisualStyleBackColor = true;
      this.closeRtn.Click += new EventHandler(this.close_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.minRtn, "minRtn");
      this.minRtn.Name = "minRtn";
      this.minRtn.TabStop = true;
      this.minRtn.Tag = (object) "2";
      this.minRtn.UseVisualStyleBackColor = true;
      this.minRtn.Click += new EventHandler(this.close_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.groupBox5, "groupBox5");
      this.groupBox5.Controls.Add((Control) this.label9);
      this.groupBox5.Controls.Add((Control) this.onRtn);
      this.groupBox5.Controls.Add((Control) this.offRtn);
      this.groupBox5.Controls.Add((Control) this.label10);
      this.groupBox5.Controls.Add((Control) this.soundPathTB);
      this.groupBox5.Controls.Add((Control) this.soundBtn);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label9, "label9");
      this.label9.Name = "label9";
      componentResourceManager.ApplyResources((object) this.onRtn, "onRtn");
      this.onRtn.Name = "onRtn";
      this.onRtn.TabStop = true;
      this.onRtn.Tag = (object) "1";
      this.onRtn.UseVisualStyleBackColor = true;
      this.onRtn.Click += new EventHandler(this.sound_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.offRtn, "offRtn");
      this.offRtn.Name = "offRtn";
      this.offRtn.TabStop = true;
      this.offRtn.Tag = (object) "2";
      this.offRtn.UseVisualStyleBackColor = true;
      this.offRtn.Click += new EventHandler(this.sound_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.label10, "label10");
      this.label10.Name = "label10";
      componentResourceManager.ApplyResources((object) this.soundPathTB, "soundPathTB");
      this.soundPathTB.Name = "soundPathTB";
      componentResourceManager.ApplyResources((object) this.soundBtn, "soundBtn");
      this.soundBtn.Name = "soundBtn";
      this.soundBtn.UseVisualStyleBackColor = true;
      this.soundBtn.Click += new EventHandler(this.soundBtn_Click);
      componentResourceManager.ApplyResources((object) this.groupBox4, "groupBox4");
      this.groupBox4.Controls.Add((Control) this.interval);
      this.groupBox4.Controls.Add((Control) this.label11);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.TabStop = false;
      componentResourceManager.ApplyResources((object) this.interval, "interval");
      this.interval.Maximum = new Decimal(new int[4]
      {
        300,
        0,
        0,
        0
      });
      this.interval.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.interval.Name = "interval";
      this.interval.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.interval.ValueChanged += new EventHandler(this.interval_ValueChanged);
      componentResourceManager.ApplyResources((object) this.label11, "label11");
      this.label11.ForeColor = Color.Red;
      this.label11.Name = "label11";
      componentResourceManager.ApplyResources((object) this.groupBox3, "groupBox3");
      this.groupBox3.Controls.Add((Control) this.label7);
      this.groupBox3.Controls.Add((Control) this.csvRtn);
      this.groupBox3.Controls.Add((Control) this.txtRtn);
      this.groupBox3.Controls.Add((Control) this.label12);
      this.groupBox3.Controls.Add((Control) this.label4);
      this.groupBox3.Controls.Add((Control) this.rowMax);
      this.groupBox3.Controls.Add((Control) this.label5);
      this.groupBox3.Controls.Add((Control) this.filePathTB);
      this.groupBox3.Controls.Add((Control) this.fileBtn);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.TabStop = false;
      componentResourceManager.ApplyResources((object) this.label7, "label7");
      this.label7.Name = "label7";
      componentResourceManager.ApplyResources((object) this.csvRtn, "csvRtn");
      this.csvRtn.Name = "csvRtn";
      this.csvRtn.TabStop = true;
      this.csvRtn.Tag = (object) "1";
      this.csvRtn.UseVisualStyleBackColor = true;
      this.csvRtn.Click += new EventHandler(this.filetype_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.txtRtn, "txtRtn");
      this.txtRtn.Name = "txtRtn";
      this.txtRtn.TabStop = true;
      this.txtRtn.Tag = (object) "2";
      this.txtRtn.UseVisualStyleBackColor = true;
      this.txtRtn.Click += new EventHandler(this.filetype_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.label12, "label12");
      this.label12.ForeColor = Color.Red;
      this.label12.Name = "label12";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.rowMax, "rowMax");
      this.rowMax.Maximum = new Decimal(new int[4]
      {
        50000,
        0,
        0,
        0
      });
      this.rowMax.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.rowMax.Name = "rowMax";
      this.rowMax.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.rowMax.ValueChanged += new EventHandler(this.rowMax_ValueChanged);
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.filePathTB, "filePathTB");
      this.filePathTB.Name = "filePathTB";
      this.filePathTB.TextChanged += new EventHandler(this.filePathTB_TextChanged);
      componentResourceManager.ApplyResources((object) this.fileBtn, "fileBtn");
      this.fileBtn.Name = "fileBtn";
      this.fileBtn.UseVisualStyleBackColor = true;
      this.fileBtn.Click += new EventHandler(this.fileBtn_Click);
      componentResourceManager.ApplyResources((object) this.groupBox2, "groupBox2");
      this.groupBox2.Controls.Add((Control) this.ssdRtn);
      this.groupBox2.Controls.Add((Control) this.hsdRtn);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.TabStop = false;
      componentResourceManager.ApplyResources((object) this.ssdRtn, "ssdRtn");
      this.ssdRtn.Name = "ssdRtn";
      this.ssdRtn.TabStop = true;
      this.ssdRtn.Tag = (object) "1";
      this.ssdRtn.UseVisualStyleBackColor = true;
      this.ssdRtn.Click += new EventHandler(this.unit_Click);
      componentResourceManager.ApplyResources((object) this.hsdRtn, "hsdRtn");
      this.hsdRtn.Name = "hsdRtn";
      this.hsdRtn.TabStop = true;
      this.hsdRtn.Tag = (object) "2";
      this.hsdRtn.UseVisualStyleBackColor = true;
      this.hsdRtn.Click += new EventHandler(this.unit_Click);
      componentResourceManager.ApplyResources((object) this.groupBox1, "groupBox1");
      this.groupBox1.Controls.Add((Control) this.chineseRtn);
      this.groupBox1.Controls.Add((Control) this.englishRtn);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.TabStop = false;
      componentResourceManager.ApplyResources((object) this.chineseRtn, "chineseRtn");
      this.chineseRtn.Name = "chineseRtn";
      this.chineseRtn.TabStop = true;
      this.chineseRtn.Tag = (object) "1";
      this.chineseRtn.UseVisualStyleBackColor = true;
      this.chineseRtn.MouseClick += new MouseEventHandler(this.laguage_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.englishRtn, "englishRtn");
      this.englishRtn.Name = "englishRtn";
      this.englishRtn.TabStop = true;
      this.englishRtn.Tag = (object) "2";
      this.englishRtn.UseVisualStyleBackColor = true;
      this.englishRtn.MouseClick += new MouseEventHandler(this.laguage_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.ForeColor = Color.White;
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Cursor = Cursors.Hand;
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      componentResourceManager.ApplyResources((object) this.folderBrowserDialog1, "folderBrowserDialog1");
      this.openFileDialog1.FileName = "AudioFile";
      componentResourceManager.ApplyResources((object) this.openFileDialog1, "openFileDialog1");
      this.timer1.Interval = 1000;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(62, 160, 228);
      this.Controls.Add((Control) this.closePic);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (SetForm);
      this.Load += new EventHandler(this.SetForm_Load);
      this.MouseDown += new MouseEventHandler(this.SetForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.SetForm_MouseMove);
      this.MouseUp += new MouseEventHandler(this.SetForm_MouseUp);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tipPanel.ResumeLayout(false);
      this.tipPanel.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.interval.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.rowMax.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((ISupportInitialize) this.closePic).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public SetForm() => this.InitializeComponent();

    private void SetForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void SetForm_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void SetForm_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void closePic_Click(object sender, EventArgs e) => this.Close();

    private void SetForm_Load(object sender, EventArgs e)
    {
      this.isFirst = true;
      this.interval.Text = string.Concat((object) Settings.Default.Interval);
      if (Settings.Default.Language == 1)
        this.chineseRtn.Checked = true;
      else
        this.englishRtn.Checked = true;
      if (Settings.Default.Unit == 1)
        this.ssdRtn.Checked = true;
      else
        this.hsdRtn.Checked = true;
      if (Settings.Default.CloseOperate == 1)
        this.closeRtn.Checked = true;
      else
        this.minRtn.Checked = true;
      if (Settings.Default.FileType == 1)
        this.csvRtn.Checked = true;
      else
        this.txtRtn.Checked = true;
      if (Settings.Default.SoundAlarm == 1)
        this.onRtn.Checked = true;
      else
        this.offRtn.Checked = true;
      this.AutoRunCBX.Checked = Settings.Default.isAutoRun;
      this.rowMax.Text = string.Concat((object) Settings.Default.FileMax);
      this.filePathTB.Text = Settings.Default.FilePath;
      this.soundPathTB.Text = Settings.Default.SoundPath;
      this.isFirst = false;
    }

    private void unit_Click(object sender, EventArgs e)
    {
      int num = int.Parse(((Control) sender).Tag.ToString());
      Settings.Default.Unit = num;
      Settings.Default.Save();
      this.mf.clearData();
      string str1 = Settings.Default.Language == 2 ? "Temp unit : " : "Текущая единица измерения температуры：";
      string str2;
      if (num == 1)
      {
        str2 = str1 + "°C";
        Settings.Default.set = "°C";
        Settings.Default.Save();
      }
      else
      {
        str2 = str1 + "°F";
        Settings.Default.set = "°F";
        Settings.Default.Save();
      }
      this.mf.changeUnit(str2);
      this.showTip();
    }

    private void close_CheckedChanged(object sender, EventArgs e)
    {
      Settings.Default.CloseOperate = int.Parse(((Control) sender).Tag.ToString());
      Settings.Default.Save();
      this.showTip();
    }

    private void filetype_CheckedChanged(object sender, EventArgs e)
    {
      Settings.Default.FileType = int.Parse(((Control) sender).Tag.ToString());
      Settings.Default.Save();
      this.showTip();
    }

    private void sound_CheckedChanged(object sender, EventArgs e)
    {
      Settings.Default.SoundAlarm = int.Parse(((Control) sender).Tag.ToString());
      Settings.Default.Save();
      this.showTip();
    }

    private void interval_ValueChanged(object sender, EventArgs e)
    {
      Settings.Default.Interval = (int) this.interval.Value;
      Settings.Default.Save();
      this.showTip();
    }

    private void showTip()
    {
      if (this.isFirst)
        return;
      this.tipPanel.Visible = true;
      this.textBox1.Text = "Успешно установлен";
      this.timer1.Start();
    }

    private void fileBtn_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      string selectedPath = this.folderBrowserDialog1.SelectedPath;
      this.filePathTB.Text = selectedPath;
      Settings.Default.FilePath = selectedPath;
      Settings.Default.Save();
      this.showTip();
    }

    private void soundBtn_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.Filter = "Аудио|*.mp3;*.wma;";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      string fileName = this.openFileDialog1.FileName;
      this.soundPathTB.Text = fileName;
      Settings.Default.SoundPath = fileName;
      Settings.Default.Save();
      this.showTip();
    }

    private void laguage_CheckedChanged(object sender, MouseEventArgs e)
    {
      int num = int.Parse(((Control) sender).Tag.ToString());
      Settings.Default.Language = num;
      Settings.Default.Save();
      MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
      if (MessageBox.Show(Settings.Default.Language == 2 ? "Switch can lead to restart the software, are you sure you want to switch?" : "Переключение приведет к перезапуску программного обеспечения. Вы действительно хотите переключиться?", Settings.Default.Language == 2 ? "Language" : "Русский(машинный перевод)", buttons) == DialogResult.OK)
      {
        Settings.Default.Language = num;
        Settings.Default.Save();
        Application.Restart();
      }
      else if (Settings.Default.Language == 2)
        this.englishRtn.Checked = true;
      else
        this.chineseRtn.Checked = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.tipPanel.Visible = false;
      this.timer1.Stop();
    }

    private void rowMax_ValueChanged(object sender, EventArgs e)
    {
      Settings.Default.FileMax = (int) this.rowMax.Value;
      Settings.Default.Save();
      this.showTip();
    }

    private void filePathTB_TextChanged(object sender, EventArgs e)
    {
    }

    private void AutoRunCBX_CheckedChanged(object sender, EventArgs e)
    {
      if (this.AutoRunCBX.Checked)
      {
        Settings.Default.isAutoRun = true;
        PubMethod.SetAutoRun(Application.ExecutablePath, true);
      }
      else
      {
        Settings.Default.isAutoRun = false;
        PubMethod.SetAutoRun(Application.ExecutablePath, false);
      }
      Settings.Default.Save();
    }
  }
}
