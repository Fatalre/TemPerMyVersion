using AxTeeChart;
using AxWMPLib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using TEMPer.Properties;
using System.Management;
using System.Collections.Generic;

namespace TEMPer
{
  public class MainForm : Form
  {
    private const int Guying_HTLEFT = 10;
    private const int Guying_HTRIGHT = 11;
    private const int Guying_HTTOP = 12;
    private const int Guying_HTTOPLEFT = 13;
    private const int Guying_HTTOPRIGHT = 14;
    private const int Guying_HTBOTTOM = 15;
    private const int Guying_HTBOTTOMLEFT = 16;
    private const int Guying_HTBOTTOMRIGHT = 17;
    private IContainer components = (IContainer) null;
    private Panel titlePanel;
    private Label setLabel;
    private PictureBox pictureBox1;
    private Label emailLabel;
    private Label remoteLabel;
    private Panel mainPanel;
    private Panel dataPanel1;
    private Label data1;
    private Label dataMax1;
    private Label dataAvg1;
    private Label dataMin1;
    private Panel dataPanel4;
    private Label dataMin4;
    private Label dataAvg4;
    private Label dataMax4;
    private Label data4;
    private Panel dataPanel3;
    private Label dataMin3;
    private Label dataAvg3;
    private Label dataMax3;
    private Label data3;
    private Panel dataPanel2;
    private Label dataMin2;
    private Label dataAvg2;
    private Label dataMax2;
    private Label data2;
    private Button logButton;
    private Button curveButton;
    private AxTChart chart;
    private System.Windows.Forms.Timer timer;
    private Label label11;
    private Label label13;
    private Label label12;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label19;
    private Label label18;
    private Label label17;
    private Label label22;
    private Label label21;
    private Label label20;
    public AxWindowsMediaPlayer axWindowsMediaPlayer1;
    private CheckBox threeCkb;
    private Panel nagvationPanel;
    private Panel panel1;
    private Button unitBtn;
    private Button emailBtn;
    private Button remoteBtn;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Panel emailTipPanel;
    private Label label5;
    private Label sendCount;
    private Label introduceLabel;
    private Label aboutLabel;
    private NotifyIcon notifyIcon1;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem 退出ToolStripMenuItem;
    private PictureBox pictureBox2;
    private PictureBox pictureBox6;
    private PictureBox pictureBox5;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private DataGridView dataTable;
    private PictureBox pictureBox7;
    private PictureBox minPB;
    private PictureBox closePic;
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    private DataGridViewTextBoxColumn Column4;
    private DataGridViewTextBoxColumn Column5;
    private DataGridViewTextBoxColumn Column6;
    private DataGridViewTextBoxColumn Column7;
    private AutoSizeFormClass asc = new AutoSizeFormClass();
    private float X;
    private float Y;
    private Point myPoint;
    private int timeIndex = 0;
    private int emailIndex = 1;
    private bool isStartRead = true;
    public static int[] vids = new int[3]
    {
      16701,
      3141,
      6790
    };
    public static int[] pids = new int[4]
    {
      8455,
      29698,
      29697,
      57381
    };
    private byte[] bCommondGetVersion = new byte[9]
    {
      (byte) 0,
      (byte) 1,
      (byte) 134,
      byte.MaxValue,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private byte[] comamandSensor = new byte[9]
    {
      (byte) 0,
      (byte) 1,
      (byte) 135,
      (byte) 238,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private byte[] bCommondGetCalibration = new byte[9]
    {
      (byte) 0,
      (byte) 1,
      (byte) 130,
      (byte) 119,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private byte[] bCommandReadTemper = new byte[9]
    {
      (byte) 0,
      (byte) 1,
      (byte) 128,
      (byte) 51,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int dataIndex = 0;
    private StringBuilder emailContinueSb = new StringBuilder();
    private string unnit = Settings.Default.set;
    private int totalCount = 0;
    private int successCount = 0;
    private int isureMailCount = 0;
    private RemoteForm rf;
    private string NamePwd;
    Boolean NeedToDevice = true;
    int temp;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      this.titlePanel = new Panel();
      this.minPB = new PictureBox();
      this.closePic = new PictureBox();
      this.pictureBox7 = new PictureBox();
      this.pictureBox6 = new PictureBox();
      this.pictureBox5 = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.remoteLabel = new Label();
      this.emailLabel = new Label();
      this.setLabel = new Label();
      this.mainPanel = new Panel();
      this.emailTipPanel = new Panel();
      this.sendCount = new Label();
      this.label5 = new Label();
      this.remoteBtn = new Button();
      this.emailBtn = new Button();
      this.unitBtn = new Button();
      this.threeCkb = new CheckBox();
      this.axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
      this.chart = new AxTChart();
      this.curveButton = new Button();
      this.logButton = new Button();
      this.dataTable = new DataGridView();
      this.Column1 = new DataGridViewTextBoxColumn();
      this.Column2 = new DataGridViewTextBoxColumn();
      this.Column3 = new DataGridViewTextBoxColumn();
      this.Column4 = new DataGridViewTextBoxColumn();
      this.Column5 = new DataGridViewTextBoxColumn();
      this.Column6 = new DataGridViewTextBoxColumn();
      this.Column7 = new DataGridViewTextBoxColumn();
      this.dataPanel4 = new Panel();
      this.label4 = new Label();
      this.label22 = new Label();
      this.label21 = new Label();
      this.label20 = new Label();
      this.dataMin4 = new Label();
      this.dataAvg4 = new Label();
      this.dataMax4 = new Label();
      this.data4 = new Label();
      this.dataPanel3 = new Panel();
      this.label3 = new Label();
      this.label19 = new Label();
      this.label18 = new Label();
      this.label17 = new Label();
      this.dataMin3 = new Label();
      this.dataAvg3 = new Label();
      this.dataMax3 = new Label();
      this.data3 = new Label();
      this.dataPanel2 = new Panel();
      this.label2 = new Label();
      this.label16 = new Label();
      this.label15 = new Label();
      this.label14 = new Label();
      this.dataMin2 = new Label();
      this.dataAvg2 = new Label();
      this.dataMax2 = new Label();
      this.data2 = new Label();
      this.dataPanel1 = new Panel();
      this.label1 = new Label();
      this.label13 = new Label();
      this.label12 = new Label();
      this.label11 = new Label();
      this.dataMin1 = new Label();
      this.dataAvg1 = new Label();
      this.dataMax1 = new Label();
      this.data1 = new Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.nagvationPanel = new Panel();
      this.aboutLabel = new Label();
      this.introduceLabel = new Label();
      this.panel1 = new Panel();
      this.notifyIcon1 = new NotifyIcon(this.components);
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.退出ToolStripMenuItem = new ToolStripMenuItem();
      this.titlePanel.SuspendLayout();
      ((ISupportInitialize) this.minPB).BeginInit();
      ((ISupportInitialize) this.closePic).BeginInit();
      ((ISupportInitialize) this.pictureBox7).BeginInit();
      ((ISupportInitialize) this.pictureBox6).BeginInit();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.mainPanel.SuspendLayout();
      this.emailTipPanel.SuspendLayout();
      this.axWindowsMediaPlayer1.BeginInit();
      this.chart.BeginInit();
      ((ISupportInitialize) this.dataTable).BeginInit();
      this.dataPanel4.SuspendLayout();
      this.dataPanel3.SuspendLayout();
      this.dataPanel2.SuspendLayout();
      this.dataPanel1.SuspendLayout();
      this.nagvationPanel.SuspendLayout();
      this.panel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.titlePanel.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.titlePanel, "titlePanel");
      this.titlePanel.Controls.Add((Control) this.minPB);
      this.titlePanel.Controls.Add((Control) this.closePic);
      this.titlePanel.Controls.Add((Control) this.pictureBox7);
      this.titlePanel.Controls.Add((Control) this.pictureBox6);
      this.titlePanel.Controls.Add((Control) this.pictureBox5);
      this.titlePanel.Controls.Add((Control) this.pictureBox4);
      this.titlePanel.Controls.Add((Control) this.pictureBox3);
      this.titlePanel.Controls.Add((Control) this.pictureBox2);
      this.titlePanel.Controls.Add((Control) this.pictureBox1);
      this.titlePanel.Name = "titlePanel";
      this.titlePanel.Paint += new PaintEventHandler(this.titlePanel_Paint);
      this.titlePanel.MouseDown += new MouseEventHandler(this.titlePanel_MouseDown);
      this.titlePanel.MouseMove += new MouseEventHandler(this.titlePanel_MouseMove);
      this.titlePanel.MouseUp += new MouseEventHandler(this.titlePanel_MouseUp);
      componentResourceManager.ApplyResources((object) this.minPB, "minPB");
      this.minPB.Name = "minPB";
      this.minPB.TabStop = false;
      this.minPB.Click += new EventHandler(this.minPB_Click);
      componentResourceManager.ApplyResources((object) this.closePic, "closePic");
      this.closePic.Name = "closePic";
      this.closePic.TabStop = false;
      this.closePic.Click += new EventHandler(this.closePic_Click);
      this.pictureBox7.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox7, "pictureBox7");
      this.pictureBox7.Name = "pictureBox7";
      this.pictureBox7.TabStop = false;
      this.pictureBox6.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox6, "pictureBox6");
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.TabStop = false;
      this.pictureBox5.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox5, "pictureBox5");
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.TabStop = false;
      this.pictureBox4.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox4, "pictureBox4");
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.TabStop = false;
      this.pictureBox3.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox3, "pictureBox3");
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.TabStop = false;
      this.pictureBox2.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this.pictureBox2, "pictureBox2");
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.TabStop = false;
      componentResourceManager.ApplyResources((object) this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      this.remoteLabel.Cursor = Cursors.Hand;
      this.remoteLabel.ForeColor = Color.Black;
      componentResourceManager.ApplyResources((object) this.remoteLabel, "remoteLabel");
      this.remoteLabel.Name = "remoteLabel";
      this.remoteLabel.Click += new EventHandler(this.remoteLabel_Click);
      this.emailLabel.Cursor = Cursors.Hand;
      this.emailLabel.ForeColor = Color.Black;
      componentResourceManager.ApplyResources((object) this.emailLabel, "emailLabel");
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Click += new EventHandler(this.emailLabel_Click);
      componentResourceManager.ApplyResources((object) this.setLabel, "setLabel");
      this.setLabel.Cursor = Cursors.Hand;
      this.setLabel.ForeColor = Color.Black;
      this.setLabel.Name = "setLabel";
      this.setLabel.Click += new EventHandler(this.setLabel_Click);
      this.mainPanel.Controls.Add((Control) this.emailTipPanel);
      this.mainPanel.Controls.Add((Control) this.remoteBtn);
      this.mainPanel.Controls.Add((Control) this.emailBtn);
      this.mainPanel.Controls.Add((Control) this.unitBtn);
      this.mainPanel.Controls.Add((Control) this.threeCkb);
      this.mainPanel.Controls.Add((Control) this.axWindowsMediaPlayer1);
      this.mainPanel.Controls.Add((Control) this.chart);
      this.mainPanel.Controls.Add((Control) this.curveButton);
      this.mainPanel.Controls.Add((Control) this.logButton);
      this.mainPanel.Controls.Add((Control) this.dataTable);
      this.mainPanel.Controls.Add((Control) this.dataPanel4);
      this.mainPanel.Controls.Add((Control) this.dataPanel3);
      this.mainPanel.Controls.Add((Control) this.dataPanel2);
      this.mainPanel.Controls.Add((Control) this.dataPanel1);
      componentResourceManager.ApplyResources((object) this.mainPanel, "mainPanel");
      this.mainPanel.Name = "mainPanel";
      componentResourceManager.ApplyResources((object) this.emailTipPanel, "emailTipPanel");
      this.emailTipPanel.BackColor = Color.White;
      this.emailTipPanel.Controls.Add((Control) this.sendCount);
      this.emailTipPanel.Controls.Add((Control) this.label5);
      this.emailTipPanel.Name = "emailTipPanel";
      this.emailTipPanel.Paint += new PaintEventHandler(this.emailTipPanel_Paint);
      componentResourceManager.ApplyResources((object) this.sendCount, "sendCount");
      this.sendCount.Name = "sendCount";
      componentResourceManager.ApplyResources((object) this.label5, "label5");
      this.label5.Name = "label5";
      componentResourceManager.ApplyResources((object) this.remoteBtn, "remoteBtn");
      this.remoteBtn.BackColor = Color.White;
      this.remoteBtn.Cursor = Cursors.Hand;
      this.remoteBtn.FlatAppearance.BorderColor = Color.Silver;
      this.remoteBtn.Name = "remoteBtn";
      this.remoteBtn.Tag = (object) "2";
      this.remoteBtn.UseVisualStyleBackColor = false;
      componentResourceManager.ApplyResources((object) this.emailBtn, "emailBtn");
      this.emailBtn.BackColor = Color.White;
      this.emailBtn.Cursor = Cursors.Hand;
      this.emailBtn.FlatAppearance.BorderColor = Color.Silver;
      this.emailBtn.Name = "emailBtn";
      this.emailBtn.Tag = (object) "2";
      this.emailBtn.UseVisualStyleBackColor = false;
      componentResourceManager.ApplyResources((object) this.unitBtn, "unitBtn");
      this.unitBtn.BackColor = Color.White;
      this.unitBtn.Cursor = Cursors.Hand;
      this.unitBtn.FlatAppearance.BorderColor = Color.Silver;
      this.unitBtn.Name = "unitBtn";
      this.unitBtn.Tag = (object) "2";
      this.unitBtn.UseVisualStyleBackColor = false;
      componentResourceManager.ApplyResources((object) this.threeCkb, "threeCkb");
      this.threeCkb.Name = "threeCkb";
      this.threeCkb.UseVisualStyleBackColor = true;
      this.threeCkb.Click += new EventHandler(this.threeCkb_Click);
      componentResourceManager.ApplyResources((object) this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
      this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
      this.axWindowsMediaPlayer1.OcxState = (AxHost.State) componentResourceManager.GetObject("axWindowsMediaPlayer1.OcxState");
      componentResourceManager.ApplyResources((object) this.chart, "chart");
      this.chart.Name = "chart";
      this.chart.OcxState = (AxHost.State) componentResourceManager.GetObject("chart.OcxState");
      this.curveButton.BackColor = Color.White;
      this.curveButton.Cursor = Cursors.Hand;
      this.curveButton.FlatAppearance.BorderColor = Color.Silver;
      componentResourceManager.ApplyResources((object) this.curveButton, "curveButton");
      this.curveButton.Name = "curveButton";
      this.curveButton.Tag = (object) "2";
      this.curveButton.UseVisualStyleBackColor = false;
      this.curveButton.Click += new EventHandler(this.button_change_Click);
      this.logButton.BackColor = Color.FromArgb(62, 160, 228);
      this.logButton.FlatAppearance.BorderColor = Color.Silver;
      componentResourceManager.ApplyResources((object) this.logButton, "logButton");
      this.logButton.Name = "logButton";
      this.logButton.Tag = (object) "1";
      this.logButton.UseVisualStyleBackColor = false;
      this.logButton.Click += new EventHandler(this.button_change_Click);
      this.dataTable.AllowUserToResizeColumns = false;
      this.dataTable.AllowUserToResizeRows = false;
      this.dataTable.BackgroundColor = Color.FromArgb(242, 243, 244);
      this.dataTable.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("微软雅黑", 9f);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = Color.Transparent;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.False;
      this.dataTable.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      componentResourceManager.ApplyResources((object) this.dataTable, "dataTable");
      this.dataTable.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7);
      this.dataTable.Name = "dataTable";
      this.dataTable.ReadOnly = true;
      this.dataTable.RowHeadersVisible = false;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataTable.RowsDefaultCellStyle = gridViewCellStyle2;
      this.dataTable.RowTemplate.Height = 23;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Column1.DefaultCellStyle = gridViewCellStyle3;
      componentResourceManager.ApplyResources((object) this.Column1, "Column1");
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
      componentResourceManager.ApplyResources((object) this.Column2, "Column2");
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      componentResourceManager.ApplyResources((object) this.Column3, "Column3");
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      componentResourceManager.ApplyResources((object) this.Column4, "Column4");
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      componentResourceManager.ApplyResources((object) this.Column5, "Column5");
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      componentResourceManager.ApplyResources((object) this.Column6, "Column6");
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      componentResourceManager.ApplyResources((object) this.Column7, "Column7");
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.dataPanel4.BackColor = Color.White;
      this.dataPanel4.Controls.Add((Control) this.label4);
      this.dataPanel4.Controls.Add((Control) this.label22);
      this.dataPanel4.Controls.Add((Control) this.label21);
      this.dataPanel4.Controls.Add((Control) this.label20);
      this.dataPanel4.Controls.Add((Control) this.dataMin4);
      this.dataPanel4.Controls.Add((Control) this.dataAvg4);
      this.dataPanel4.Controls.Add((Control) this.dataMax4);
      this.dataPanel4.Controls.Add((Control) this.data4);
      componentResourceManager.ApplyResources((object) this.dataPanel4, "dataPanel4");
      this.dataPanel4.Name = "dataPanel4";
      componentResourceManager.ApplyResources((object) this.label4, "label4");
      this.label4.ForeColor = Color.Blue;
      this.label4.Name = "label4";
      componentResourceManager.ApplyResources((object) this.label22, "label22");
      this.label22.Name = "label22";
      componentResourceManager.ApplyResources((object) this.label21, "label21");
      this.label21.Name = "label21";
      componentResourceManager.ApplyResources((object) this.label20, "label20");
      this.label20.Name = "label20";
      componentResourceManager.ApplyResources((object) this.dataMin4, "dataMin4");
      this.dataMin4.Name = "dataMin4";
      componentResourceManager.ApplyResources((object) this.dataAvg4, "dataAvg4");
      this.dataAvg4.Name = "dataAvg4";
      componentResourceManager.ApplyResources((object) this.dataMax4, "dataMax4");
      this.dataMax4.Name = "dataMax4";
      this.data4.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.data4, "data4");
      this.data4.Name = "data4";
      this.data4.Tag = (object) "4";
      this.data4.Click += new EventHandler(this.data_alarm_Click);
      this.dataPanel3.BackColor = Color.White;
      this.dataPanel3.Controls.Add((Control) this.label3);
      this.dataPanel3.Controls.Add((Control) this.label19);
      this.dataPanel3.Controls.Add((Control) this.label18);
      this.dataPanel3.Controls.Add((Control) this.label17);
      this.dataPanel3.Controls.Add((Control) this.dataMin3);
      this.dataPanel3.Controls.Add((Control) this.dataAvg3);
      this.dataPanel3.Controls.Add((Control) this.dataMax3);
      this.dataPanel3.Controls.Add((Control) this.data3);
      componentResourceManager.ApplyResources((object) this.dataPanel3, "dataPanel3");
      this.dataPanel3.Name = "dataPanel3";
      componentResourceManager.ApplyResources((object) this.label3, "label3");
      this.label3.ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
      this.label3.Name = "label3";
      componentResourceManager.ApplyResources((object) this.label19, "label19");
      this.label19.Name = "label19";
      componentResourceManager.ApplyResources((object) this.label18, "label18");
      this.label18.Name = "label18";
      componentResourceManager.ApplyResources((object) this.label17, "label17");
      this.label17.Name = "label17";
      componentResourceManager.ApplyResources((object) this.dataMin3, "dataMin3");
      this.dataMin3.Name = "dataMin3";
      componentResourceManager.ApplyResources((object) this.dataAvg3, "dataAvg3");
      this.dataAvg3.Name = "dataAvg3";
      componentResourceManager.ApplyResources((object) this.dataMax3, "dataMax3");
      this.dataMax3.Name = "dataMax3";
      this.data3.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.data3, "data3");
      this.data3.Name = "data3";
      this.data3.Tag = (object) "3";
      this.data3.Click += new EventHandler(this.data_alarm_Click);
      this.dataPanel2.BackColor = Color.White;
      this.dataPanel2.Controls.Add((Control) this.label2);
      this.dataPanel2.Controls.Add((Control) this.label16);
      this.dataPanel2.Controls.Add((Control) this.label15);
      this.dataPanel2.Controls.Add((Control) this.label14);
      this.dataPanel2.Controls.Add((Control) this.dataMin2);
      this.dataPanel2.Controls.Add((Control) this.dataAvg2);
      this.dataPanel2.Controls.Add((Control) this.dataMax2);
      this.dataPanel2.Controls.Add((Control) this.data2);
      componentResourceManager.ApplyResources((object) this.dataPanel2, "dataPanel2");
      this.dataPanel2.Name = "dataPanel2";
      componentResourceManager.ApplyResources((object) this.label2, "label2");
      this.label2.ForeColor = Color.Green;
      this.label2.Name = "label2";
      componentResourceManager.ApplyResources((object) this.label16, "label16");
      this.label16.Name = "label16";
      componentResourceManager.ApplyResources((object) this.label15, "label15");
      this.label15.Name = "label15";
      componentResourceManager.ApplyResources((object) this.label14, "label14");
      this.label14.Name = "label14";
      componentResourceManager.ApplyResources((object) this.dataMin2, "dataMin2");
      this.dataMin2.Name = "dataMin2";
      componentResourceManager.ApplyResources((object) this.dataAvg2, "dataAvg2");
      this.dataAvg2.Name = "dataAvg2";
      componentResourceManager.ApplyResources((object) this.dataMax2, "dataMax2");
      this.dataMax2.Name = "dataMax2";
      this.data2.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.data2, "data2");
      this.data2.Name = "data2";
      this.data2.Tag = (object) "2";
      this.data2.Click += new EventHandler(this.data_alarm_Click);
      this.dataPanel1.BackColor = Color.White;
      this.dataPanel1.Controls.Add((Control) this.label1);
      this.dataPanel1.Controls.Add((Control) this.label13);
      this.dataPanel1.Controls.Add((Control) this.label12);
      this.dataPanel1.Controls.Add((Control) this.label11);
      this.dataPanel1.Controls.Add((Control) this.dataMin1);
      this.dataPanel1.Controls.Add((Control) this.dataAvg1);
      this.dataPanel1.Controls.Add((Control) this.dataMax1);
      this.dataPanel1.Controls.Add((Control) this.data1);
      componentResourceManager.ApplyResources((object) this.dataPanel1, "dataPanel1");
      this.dataPanel1.Name = "dataPanel1";
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.ForeColor = Color.Red;
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.label13, "label13");
      this.label13.Name = "label13";
      componentResourceManager.ApplyResources((object) this.label12, "label12");
      this.label12.Name = "label12";
      componentResourceManager.ApplyResources((object) this.label11, "label11");
      this.label11.Name = "label11";
      componentResourceManager.ApplyResources((object) this.dataMin1, "dataMin1");
      this.dataMin1.Name = "dataMin1";
      componentResourceManager.ApplyResources((object) this.dataAvg1, "dataAvg1");
      this.dataAvg1.Name = "dataAvg1";
      componentResourceManager.ApplyResources((object) this.dataMax1, "dataMax1");
      this.dataMax1.Name = "dataMax1";
      this.data1.Cursor = Cursors.Hand;
      componentResourceManager.ApplyResources((object) this.data1, "data1");
      this.data1.Name = "data1";
      this.data1.Tag = (object) "1";
      this.data1.Click += new EventHandler(this.data_alarm_Click);
      this.timer.Interval = 1000;
      this.timer.Tick += new EventHandler(this.timer_Tick);
      this.nagvationPanel.Controls.Add((Control) this.aboutLabel);
      this.nagvationPanel.Controls.Add((Control) this.introduceLabel);
      this.nagvationPanel.Controls.Add((Control) this.setLabel);
      this.nagvationPanel.Controls.Add((Control) this.remoteLabel);
      this.nagvationPanel.Controls.Add((Control) this.emailLabel);
      componentResourceManager.ApplyResources((object) this.nagvationPanel, "nagvationPanel");
      this.nagvationPanel.Name = "nagvationPanel";
      this.nagvationPanel.Paint += new PaintEventHandler(this.nagvationPanel_Paint);
      this.aboutLabel.Cursor = Cursors.Hand;
      this.aboutLabel.ForeColor = Color.Black;
      componentResourceManager.ApplyResources((object) this.aboutLabel, "aboutLabel");
      this.aboutLabel.Name = "aboutLabel";
      this.aboutLabel.Click += new EventHandler(this.aboutLabel_Click);
      this.introduceLabel.Cursor = Cursors.Hand;
      this.introduceLabel.ForeColor = Color.Black;
      componentResourceManager.ApplyResources((object) this.introduceLabel, "introduceLabel");
      this.introduceLabel.Name = "introduceLabel";
      this.introduceLabel.Click += new EventHandler(this.introduceLabel_Click);
      this.panel1.BackColor = Color.FromArgb(242, 243, 244);
      this.panel1.Controls.Add((Control) this.mainPanel);
      this.panel1.Controls.Add((Control) this.nagvationPanel);
      componentResourceManager.ApplyResources((object) this.panel1, "panel1");
      this.panel1.Name = "panel1";
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      componentResourceManager.ApplyResources((object) this.notifyIcon1, "notifyIcon1");
      this.notifyIcon1.DoubleClick += new EventHandler(this.notifyIcon1_DoubleClick);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.退出ToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      componentResourceManager.ApplyResources((object) this.contextMenuStrip1, "contextMenuStrip1");
      this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
      this.退出ToolStripMenuItem.Click += new EventHandler(this.退出ToolStripMenuItem_Click);
      this.AutoScaleMode = AutoScaleMode.None;
      this.BackColor = Color.FromArgb(62, 160, 228);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.titlePanel);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (MainForm);
      this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new EventHandler(this.MainForm_Load);
      this.SizeChanged += new EventHandler(this.MainForm_SizeChanged);
      this.Resize += new EventHandler(this.MainForm_Resize);
      this.titlePanel.ResumeLayout(false);
      ((ISupportInitialize) this.minPB).EndInit();
      ((ISupportInitialize) this.closePic).EndInit();
      ((ISupportInitialize) this.pictureBox7).EndInit();
      ((ISupportInitialize) this.pictureBox6).EndInit();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.mainPanel.ResumeLayout(false);
      this.mainPanel.PerformLayout();
      this.emailTipPanel.ResumeLayout(false);
      this.emailTipPanel.PerformLayout();
      this.axWindowsMediaPlayer1.EndInit();
      this.chart.EndInit();
      ((ISupportInitialize) this.dataTable).EndInit();
      this.dataPanel4.ResumeLayout(false);
      this.dataPanel4.PerformLayout();
      this.dataPanel3.ResumeLayout(false);
      this.dataPanel3.PerformLayout();
      this.dataPanel2.ResumeLayout(false);
      this.dataPanel2.PerformLayout();
      this.dataPanel1.ResumeLayout(false);
      this.dataPanel1.PerformLayout();
      this.nagvationPanel.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public MainForm()
    {
      this.setLanguage();
      try
      {
        this.InitializeComponent();
      }
      catch (Exception ex)
      {
        int num1 = (int) MessageBox.Show(ex.ToString());
        int num2 = (int) MessageBox.Show(ex.StackTrace);
      }
            //this.InitializeComponent();
        }

    public void setLanguage()
    {
      if (Settings.Default.Language == 2)
        SetLanguage.SetLang("en", (Form) this, typeof (MainForm));
      else
        SetLanguage.SetLang("zh-CHS", (Form) this, typeof (MainForm));
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.X = (float) this.Width;
      this.Y = (float) this.Height;
      this.setTag((Control) this);
      this.asc.controllInitializeSize((Control) this);
      if (Settings.Default.Language == 1)
        this.unitBtn.Text = "Ед. изм. темп: " + Settings.Default.set;
      else
        this.unitBtn.Text = "Temp unit : " + Settings.Default.set;
      if (string.IsNullOrEmpty(Settings.Default.FilePath))
      {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCsensor/TEMPer/Data";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        Settings.Default.FilePath = path;
        Settings.Default.Save();
      }
      if (string.IsNullOrEmpty(Settings.Default.SoundPath))
      {
        Settings.Default.SoundPath = Environment.CurrentDirectory + "\\music\\alert.wav";
        Settings.Default.Save();
      }
      if (Settings.Default.SendStart == 1)
      {
        this.emailBtn.Visible = false;
        this.emailTipPanel.Visible = true;
      }
      this.clearData();
      this.timer.Start();
    }

    private void setTag(Control cons)
    {
      foreach (Control control in (ArrangedElementCollection) cons.Controls)
        control.Tag = (object) (control.Width.ToString() + ":" + (object) control.Height + ":" + (object) control.Left + ":" + (object) control.Top + ":" + (object) control.Font.Size);
    }

    public void clearData()
    {
      this.dataTable.Rows.Clear();
      for (int index = 0; index < 17; ++index)
        this.dataTable.Rows.Add();
      this.chart.Series(0).Clear();
      this.chart.Series(1).Clear();
      this.chart.Series(2).Clear();
      this.chart.Series(3).Clear();
            if (Settings.Default.Language == 1)
            {
                this.data1.Text = "ждем";
                this.data2.Text = "ждем";
                this.data3.Text = "ждем";
                this.data4.Text = "ждем";
                this.dataAvg1.Text = "ждем";
                this.dataAvg2.Text = "ждем";
                this.dataAvg3.Text = "ждем";
                this.dataAvg4.Text = "ждем";
                this.dataMax1.Text = "ждем";
                this.dataMax2.Text = "ждем";
                this.dataMax3.Text = "ждем";
                this.dataMax4.Text = "ждем";
                this.dataMin1.Text = "ждем";
                this.dataMin2.Text = "ждем";
                this.dataMin3.Text = "ждем";
                this.dataMin4.Text = "ждем";
                this.dataIndex = 0;
            }
            else
            {
                this.data1.Text = "wait";
                this.data2.Text = "wait";
                this.data3.Text = "wait";
                this.data4.Text = "wait";
                this.dataAvg1.Text = "wait";
                this.dataAvg2.Text = "wait";
                this.dataAvg3.Text = "wait";
                this.dataAvg4.Text = "wait";
                this.dataMax1.Text = "wait";
                this.dataMax2.Text = "wait";
                this.dataMax3.Text = "wait";
                this.dataMax4.Text = "wait";
                this.dataMin1.Text = "wait";
                this.dataMin2.Text = "wait";
                this.dataMin3.Text = "wait";
                this.dataMin4.Text = "wait";
                this.dataIndex = 0;
            }
    }

    private void titlePanel_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void titlePanel_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.myPoint.X, this.myPoint.Y);
      this.DesktopLocation = mousePosition;
    }

    private void titlePanel_MouseDown(object sender, MouseEventArgs e) => this.myPoint = new Point(-e.X, -e.Y);

    private void timer_Tick(object sender, EventArgs e)
    {
      PubMethod.isOpen = this.openDevice();
      if (PubMethod.isOpen && string.IsNullOrEmpty(PubMethod.version))
      {
        this.isStartRead = false;
        this.timer.Stop();
        this.getVersion();
      }
      else if (!PubMethod.isOpen && !string.IsNullOrEmpty(PubMethod.version))
        PubMethod.version = "";
      if (PubMethod.isRead && this.timeIndex % Settings.Default.Interval == 0 && this.isStartRead)
        this.readData();
      if (Settings.Default.SendType == 2 && Settings.Default.SendStart == 1 && PubMethod.isOpen)
      {
        ++this.emailIndex;
        if (this.emailIndex % (Settings.Default.SendInterval * 60) == 0 && this.emailIndex > 0)
        {
          this.startSend(this.emailContinueSb.ToString());
          this.emailContinueSb.Remove(0, this.emailContinueSb.Length);
          this.emailIndex = 0;
        }
      }
      ++this.timeIndex;
    }

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }

        class USBDeviceInfo
        {
            public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
            {
                this.DeviceID = deviceID;
                this.PnpDeviceID = pnpDeviceID;
                this.Description = description;
            }
            public string DeviceID { get; private set; }
            public string PnpDeviceID { get; private set; }
            public string Description { get; private set; }
        }

        private bool openDevice()
    {
            if (NeedToDevice == true)
            {
                var usbDevices = GetUSBDevices();
                for (int index1 = 0; index1 < MainForm.pids.Length; ++index1)
                {
                    for (int index2 = 0; index2 < MainForm.vids.Length; ++index2)
                    { 
                        PubMethod.pDevice = RDing.OpenUSBDevice(MainForm.vids[index2], MainForm.pids[index1]);
                        if (PubMethod.pDevice.ToInt32() != -1)
                        {

                            PubMethod.inputLength = RDing.GetInputLength(PubMethod.pDevice);
                            PubMethod.outputLength = RDing.GetOutputLength(PubMethod.pDevice);
                            return PubMethod.inputLength != (ushort)9 || PubMethod.outputLength != (ushort)9 || true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
    }

    private void getVersion()
    {
      if (PubMethod.isOpen)
      {
        if (!RDing.WriteUSB(PubMethod.pDevice, this.bCommondGetVersion, (uint) PubMethod.outputLength, ref PubMethod.lpNumberOfBytesWritten))
          return;
        Thread.Sleep(50);
        byte[] numArray1 = new byte[9];
        if (RDing.ReadUSB(PubMethod.pDevice, numArray1, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden))
        {
          string str1 = Encoding.ASCII.GetString(numArray1, 1, 8);
          byte[] numArray2 = new byte[9];
          Thread.Sleep(100);
          RDing.ReadUSB(PubMethod.pDevice, numArray2, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden);
          string str2 = Encoding.ASCII.GetString(numArray2, 1, 8).Trim();
          if (str2.Contains("M12") || str2.Length < 8)
          {
            str1 += str2;
          }
          else
          {
            for (int index = 0; index < str1.Length && (int) str1[index] != (int) str2[index]; ++index)
              str1 += str2[index].ToString();
          }
          PubMethod.version = str1;
        }
        if (PubMethod.version.Contains("TEMPerX") || PubMethod.version.Contains("TEMPerGold"))
        {
          PubMethod.type = 6;
          this.readSensorType();
        }
        else if (PubMethod.version.Contains("TEMPer1F_H1"))
          PubMethod.type = 1;
        else if (PubMethod.version.Contains("TEMPer1F"))
          PubMethod.type = 2;
        else if (PubMethod.version.Contains("TEMPer2_M12"))
          PubMethod.type = 3;
        else if (PubMethod.version.Contains("TEMPerF"))
          PubMethod.type = 4;
        else if (PubMethod.version.Contains("TEMPerHum"))
          PubMethod.type = 5;
        if (PubMethod.type != 6)
          this.getCalib();
      }
      else
      {
        if (!PubMethod.isLogin)
          return;
        string str = IpDAL.sendOrder("ReadVersion>", PubMethod.reciveSocket);
        if (!string.IsNullOrEmpty(str))
        {
          PubMethod.version = str;
          if (PubMethod.version.Contains("TEMPerX"))
          {
            PubMethod.type = 6;
            this.readSensorType();
          }
          else if (PubMethod.version.Contains("TEMPer1F_H1"))
            PubMethod.type = 1;
          else if (PubMethod.version.Contains("TEMPer1F"))
            PubMethod.type = 2;
          else if (PubMethod.version.Contains("TEMPer2_M12"))
            PubMethod.type = 3;
          else if (PubMethod.version.Contains("TEMPerF"))
            PubMethod.type = 4;
          else if (PubMethod.version.Contains("TEMPerHum"))
            PubMethod.type = 5;
          if (PubMethod.type != 6)
            this.getCalib();
        }
      }
    }

    private void readSensorType()
    {
      if (PubMethod.isOpen)
      {
        if (!RDing.WriteUSB(PubMethod.pDevice, this.comamandSensor, (uint) PubMethod.outputLength, ref PubMethod.lpNumberOfBytesWritten))
          return;
        Thread.Sleep(50);
        byte[] pBuffer = new byte[9];
        if (RDing.ReadUSB(PubMethod.pDevice, pBuffer, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden) && pBuffer[1] == (byte) 135)
        {
          PubMethod.innerSensor = (int) pBuffer[2];
          PubMethod.outerSensor = (int) pBuffer[3];
          if (PubMethod.innerSensor > 0 || PubMethod.outerSensor > 0)
            this.getCalib();
        }
      }
      else
      {
        if (!PubMethod.isLogin)
          return;
        string str = IpDAL.sendOrder("ReadSensorType>", PubMethod.reciveSocket);
        if (!string.IsNullOrEmpty(str))
        {
          string[] strArray = str.Split(',');
          if (strArray.Length == 2)
          {
            PubMethod.innerSensor = PubMethod.getStringInteger(strArray[0]);
            PubMethod.outerSensor = PubMethod.getStringInteger(strArray[1]);
            if (PubMethod.innerSensor > 0 || PubMethod.outerSensor > 0)
              this.getCalib();
          }
        }
      }
    }

    private void getCalib()
    {
      if (PubMethod.isOpen)
      {
        if (RDing.WriteUSB(PubMethod.pDevice, this.bCommondGetCalibration, (uint) PubMethod.outputLength, ref PubMethod.lpNumberOfBytesWritten))
        {
          Thread.Sleep(50);
          byte[] pBuffer = new byte[9];
          if (RDing.ReadUSB(PubMethod.pDevice, pBuffer, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden) && pBuffer[1] == (byte) 130)
          {
            switch (PubMethod.type)
            {
              case 1:
                PubMethod.calib3 = this.getReciveData(pBuffer[3]);
                PubMethod.calib4 = this.getReciveData(pBuffer[4]);
                break;
              case 2:
                PubMethod.calib3 = this.getReciveData(pBuffer[3]);
                break;
              case 3:
                PubMethod.calib1 = this.getReciveData(pBuffer[3]);
                PubMethod.calib3 = this.getReciveData(pBuffer[4]);
                break;
              case 4:
                PubMethod.calib1 = this.getReciveData(pBuffer[3]);
                break;
              case 5:
                PubMethod.calib1 = this.getReciveData(pBuffer[3]);
                PubMethod.calib2 = this.getReciveData(pBuffer[4]);
                break;
              case 6:
                PubMethod.calib1 = this.getReciveData(pBuffer[3]);
                PubMethod.calib2 = this.getReciveData(pBuffer[4]);
                PubMethod.calib3 = this.getReciveData(pBuffer[5]);
                PubMethod.calib4 = this.getReciveData(pBuffer[6]);
                break;
            }
            this.clearData();
            this.initForm();
          }
        }
      }
      else if (PubMethod.isLogin)
      {
        string str = IpDAL.sendOrder("ReadCalib>", PubMethod.reciveSocket);
        if (!string.IsNullOrEmpty(str))
        {
          string[] strArray = str.Split(',');
          if (strArray.Length == 4)
          {
            PubMethod.calib1 = double.Parse(strArray[0]);
            PubMethod.calib2 = double.Parse(strArray[1]);
            PubMethod.calib3 = double.Parse(strArray[2]);
            PubMethod.calib4 = double.Parse(strArray[3]);
            this.clearData();
            this.initForm();
          }
        }
      }
      this.timer.Start();
      this.isStartRead = true;
    }

    private double getReciveData(byte b) => PubMethod.type != 6 ? (b > (byte) 127 ? (double) (-1 * (256 - (int) b) * (int) b) : (double) (int) ((double) b * (1.0 / 16.0))) : (b <= (byte) 127 ? (double) b / 10.0 : ((double) b - 256.0) / 10.0);

    private void initForm()
    {
      this.pictureBox2.Image = Image.FromFile("images/TEMPer.png");
      this.pictureBox4.Image = Image.FromFile("images/TEMPer1F.png");
      this.pictureBox5.Image = Image.FromFile("images/TEMPer1F_H1.png");
      this.pictureBox3.Image = Image.FromFile("images/TEMPer2.png");
      this.pictureBox6.Image = Image.FromFile("images/TEMPerHUM.png");
      this.pictureBox7.Image = Image.FromFile("images/TEMPerX.PNG");
      switch (PubMethod.type)
      {
        case 1:
          this.chart.Series(0).ShowInLegend = false;
          this.chart.Series(1).ShowInLegend = false;
          this.pictureBox5.Image = Image.FromFile("images/TEMPer1F_H1_1.png");
          break;
        case 2:
          this.chart.Series(0).ShowInLegend = false;
          this.chart.Series(1).ShowInLegend = false;
          this.chart.Series(3).ShowInLegend = false;
          this.pictureBox4.Image = Image.FromFile("images/TEMPer1F_1.png");
          break;
        case 3:
          this.chart.Series(1).ShowInLegend = false;
          this.chart.Series(3).ShowInLegend = false;
          this.pictureBox3.Image = Image.FromFile("images/TEMPer2_1.png");
          break;
        case 4:
          this.chart.Series(2).ShowInLegend = false;
          this.chart.Series(1).ShowInLegend = false;
          this.chart.Series(3).ShowInLegend = false;
          this.pictureBox2.Image = Image.FromFile("images/TEMPer_1.png");
          break;
        case 5:
          this.chart.Series(2).ShowInLegend = false;
          this.chart.Series(3).ShowInLegend = false;
          this.pictureBox6.Image = Image.FromFile("images/TEMPerHUM_1.png");
          break;
        case 6:
          if (PubMethod.innerSensor > 0)
          {
            if (PubMethod.innerSensor != 64)
              this.chart.Series(1).ShowInLegend = false;
          }
          else
          {
            this.chart.Series(0).ShowInLegend = false;
            this.chart.Series(1).ShowInLegend = false;
          }
          if (PubMethod.outerSensor > 0)
          {
            if (PubMethod.outerSensor != 4)
              this.chart.Series(3).ShowInLegend = false;
          }
          else
          {
            this.chart.Series(2).ShowInLegend = false;
            this.chart.Series(3).ShowInLegend = false;
          }
          this.pictureBox7.Image = Image.FromFile("images/TEMPerX_1.PNG");
          break;
      }
      this.mainPanel.Visible = true;
      PubMethod.isRead = true;
    }

    private void readData()
    {
      try
      {
        if (PubMethod.isOpen)
        {
          if (!RDing.WriteUSB(PubMethod.pDevice, this.bCommandReadTemper, (uint) PubMethod.outputLength, ref PubMethod.lpNumberOfBytesWritten))
            return;
          Thread.Sleep(50);
          byte[] pBuffer = new byte[18];
          if (RDing.ReadUSB(PubMethod.pDevice, pBuffer, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden))
          {
            PubMethod.data1 = pBuffer[3] <= (byte) 128 ? ((double) Convert.ToInt32(pBuffer[3]) + (double) ((int) pBuffer[4] >> 4 & 15) * (1.0 / 16.0)).ToString("F2") : (-1.0 * ((double) Convert.ToInt32(256 - (int) pBuffer[3]) + (double) (~((int) pBuffer[4] >> 4 & 15) + 1) * (1.0 / 16.0))).ToString("F2");
            if (PubMethod.type == 2)
              PubMethod.data3 = pBuffer[3] <= (byte) 128 ? ((double) Convert.ToInt32(pBuffer[3]) + (double) ((int) pBuffer[4] >> 4 & 15) * (1.0 / 16.0)).ToString("F2") : (-1.0 * ((double) Convert.ToInt32(256 - (int) pBuffer[3]) + (double) (~((int) pBuffer[4] >> 4 & 15) + 1) * (1.0 / 16.0))).ToString("F2");
            if (PubMethod.type == 3)
              PubMethod.data3 = pBuffer[5] <= (byte) 128 || pBuffer[5] >= byte.MaxValue ? ((double) Convert.ToInt32(pBuffer[5]) + (double) ((int) pBuffer[6] >> 4 & 15) * (1.0 / 16.0)).ToString("F2") : (-1.0 * ((double) Convert.ToInt32(256 - (int) pBuffer[5]) + (double) (~((int) pBuffer[6] >> 4 & 15) + 1) * (1.0 / 16.0))).ToString("F2");
            if (PubMethod.type == 1)
            {
              double num1 = 0.0;
              if (PubMethod.version.Contains("TEMPer1F_H1V1.5"))
              {
                double int32 = (double) Convert.ToInt32((int) pBuffer[5] * 256 + (int) pBuffer[6]);
                double num2 = ((double) Convert.ToInt32((int) pBuffer[3] * 256 + (int) pBuffer[4]) * 1.07 - 4685.0) / 100.0;
                PubMethod.data4 = ((int32 * 3.05 - 600.0) / 100.0).ToString("F2");
                PubMethod.data3 = num2.ToString("F2");
              }
              else
              {
                double num2 = (double) (Convert.ToInt32(pBuffer[5]) * 256 + (int) pBuffer[6]);
                double num3 = -2.8E-06 * num2 * num2 + 0.0405 * num2 - 4.0;
                double num4 = (num1 - 25.0) * (0.01 + 8E-05 * num2) + num3;
                if (num4 > 100.0)
                  num4 = 100.0;
                if (num4 < 0.1)
                  num4 = 0.1;
                double num5 = Convert.ToDouble((double) ((int) pBuffer[3] * 256 + (int) pBuffer[4]) * 0.01 - 40.0);
                PubMethod.data4 = num4.ToString("F2");
                PubMethod.data3 = num5.ToString("F2");
              }
            }
            if (PubMethod.type == 5)
            {
              if (PubMethod.version.Contains("TEMPerHumM12V1.0") || PubMethod.version.Contains("TEMPerHumM12V1.1"))
              {
                double num1 = (double) ((int) pBuffer[3] * 256 + (int) pBuffer[4]) / 32.0 - 50.0;
                double x = (double) ((int) pBuffer[5] * 256 + (int) pBuffer[6]) / 16.0 - 24.0;
                double num2 = x + Math.Pow(x, 2.0) * 0.00393 - x * 0.4008 + 4.7844;
                if (num1 > 15.0 && num1 < 50.0)
                  num2 += (num1 - 30.0) * (num2 * 0.00237 + 0.193);
                PubMethod.data1 = num1.ToString("F2");
                PubMethod.data2 = num2.ToString("F2");
              }
              else
              {
                PubMethod.data1 = ((double) ((int) pBuffer[3] * 256 + (int) pBuffer[4]) * 175.0 / 65536.0 - 46.85).ToString("F2");
                PubMethod.data2 = ((double) ((int) pBuffer[5] * 256 + (int) pBuffer[6]) * 125.0 / 65536.0 - 6.0).ToString("F2");
              }
            }
            if (PubMethod.type == 6)
            {
              if (PubMethod.innerSensor > 0)
              {
                PubMethod.data1 = this.parseByteToData((int) pBuffer[3] * 256 + (int) pBuffer[4]).ToString("F2");
                PubMethod.data2 = this.parseByteToData((int) pBuffer[5] * 256 + (int) pBuffer[6]).ToString("F2");
                if (PubMethod.outerSensor > 0)
                {
                  Thread.Sleep(50);
                  if (RDing.ReadUSB(PubMethod.pDevice, pBuffer, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden))
                  {
                    PubMethod.data3 = this.parseByteToData((int) pBuffer[3] * 256 + (int) pBuffer[4]).ToString("F2");
                    PubMethod.data4 = this.parseByteToData((int) pBuffer[5] * 256 + (int) pBuffer[6]).ToString("F2");
                  }
                }
              }
              else if (PubMethod.outerSensor > 0)
              {
                PubMethod.data3 = this.parseByteToData((int) pBuffer[3] * 256 + (int) pBuffer[4]).ToString("F2");
                PubMethod.data4 = this.parseByteToData((int) pBuffer[5] * 256 + (int) pBuffer[6]).ToString("F2");
              }
            }
            if (Settings.Default.Unit == 2)
            {
              double num = PubMethod.getCurveData(PubMethod.data1) * 1.8 + 32.0;
              PubMethod.data1 = num.ToString("F2");
              num = PubMethod.getCurveData(PubMethod.data3) * 1.8 + 32.0;
              PubMethod.data3 = num.ToString("F2");
            }
            this.fillData();
          }
        }
        else
        {
          if (!PubMethod.isLogin)
            return;
          string str = IpDAL.sendOrder("ReadData>", PubMethod.reciveSocket);
          if (!string.IsNullOrEmpty(str) && !str.Contains("Disconnect"))
          {
            string[] strArray = str.Split(',');
            if (strArray.Length == 4)
            {
              PubMethod.data1 = strArray[0];
              PubMethod.data2 = strArray[1];
              PubMethod.data3 = strArray[2];
              PubMethod.data4 = strArray[3];
              this.fillData();
            }
          }
        }
      }
      catch
      {
      }
    }

    private double parseByteToData(int b) => b <= (int) short.MaxValue ? (double) b / 100.0 : ((double) b - 65536.0) / 100.0;

    private void fillData()
    {
      switch (PubMethod.type)
      {
        case 1:
          this.data3.Text = PubMethod.getStringDouble(PubMethod.data3);
          this.data4.Text = PubMethod.getStringDouble(PubMethod.data4);
          this.dataMax3.Text = PubMethod.getMaxData(PubMethod.data3, this.dataMax3.Text);
          this.dataMin3.Text = PubMethod.getMinData(PubMethod.data3, this.dataMin3.Text);
          this.dataAvg3.Text = PubMethod.getAvgData(PubMethod.data3, this.dataAvg3.Text, this.dataIndex);
          this.dataMax4.Text = PubMethod.getMaxData(PubMethod.data4, this.dataMax4.Text);
          this.dataMin4.Text = PubMethod.getMinData(PubMethod.data4, this.dataMin4.Text);
          this.dataAvg4.Text = PubMethod.getAvgData(PubMethod.data4, this.dataAvg4.Text, this.dataIndex);
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + PubMethod.data3 + "\r" + PubMethod.data4 + "\n");
            break;
          }
          break;
        case 2:
          this.data3.Text = PubMethod.getStringDouble(PubMethod.data3);
          this.dataMax3.Text = PubMethod.getMaxData(PubMethod.data3, this.dataMax3.Text);
          this.dataMin3.Text = PubMethod.getMinData(PubMethod.data3, this.dataMin3.Text);
          this.dataAvg3.Text = PubMethod.getAvgData(PubMethod.data3, this.dataAvg3.Text, this.dataIndex);
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + PubMethod.data3 + "\n");
            break;
          }
          break;
        case 3:
          this.data1.Text = PubMethod.getStringDouble(PubMethod.data1);
          this.data3.Text = PubMethod.getStringDouble(PubMethod.data3);
          this.dataMax1.Text = PubMethod.getMaxData(PubMethod.data1, this.dataMax1.Text);
          this.dataMin1.Text = PubMethod.getMinData(PubMethod.data1, this.dataMin1.Text);
          this.dataAvg1.Text = PubMethod.getAvgData(PubMethod.data1, this.dataAvg1.Text, this.dataIndex);
          this.dataMax3.Text = PubMethod.getMaxData(PubMethod.data3, this.dataMax3.Text);
          this.dataMin3.Text = PubMethod.getMinData(PubMethod.data3, this.dataMin3.Text);
          this.dataAvg3.Text = PubMethod.getAvgData(PubMethod.data3, this.dataAvg3.Text, this.dataIndex);
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + PubMethod.data1 + "\r" + PubMethod.data3 + "\n");
            break;
          }
          break;
        case 4:
          this.data1.Text = PubMethod.getStringDouble(PubMethod.data1);
          this.dataMax1.Text = PubMethod.getMaxData(PubMethod.data1, this.dataMax1.Text);
          this.dataMin1.Text = PubMethod.getMinData(PubMethod.data1, this.dataMin1.Text);
          this.dataAvg1.Text = PubMethod.getAvgData(PubMethod.data1, this.dataAvg1.Text, this.dataIndex);
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + PubMethod.data1 + "\n");
            break;
          }
          break;
        case 5:
          this.data1.Text = PubMethod.getStringDouble(PubMethod.data1);
          this.data2.Text = PubMethod.getStringDouble(PubMethod.data2);
          this.dataMax1.Text = PubMethod.getMaxData(PubMethod.data1, this.dataMax1.Text);
          this.dataMin1.Text = PubMethod.getMinData(PubMethod.data1, this.dataMin1.Text);
          this.dataAvg1.Text = PubMethod.getAvgData(PubMethod.data1, this.dataAvg1.Text, this.dataIndex);
          this.dataMax2.Text = PubMethod.getMaxData(PubMethod.data2, this.dataMax2.Text);
          this.dataMin2.Text = PubMethod.getMinData(PubMethod.data2, this.dataMin2.Text);
          this.dataAvg2.Text = PubMethod.getAvgData(PubMethod.data2, this.dataAvg2.Text, this.dataIndex);
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + PubMethod.data1 + "\r" + PubMethod.data2 + "\n");
            break;
          }
          break;
        case 6:
          StringBuilder stringBuilder = new StringBuilder();
          if (PubMethod.innerSensor > 0)
          {
            this.data1.Text = PubMethod.getStringDouble(PubMethod.data1);
            this.dataMax1.Text = PubMethod.getMaxData(PubMethod.data1, this.dataMax1.Text);
            this.dataMin1.Text = PubMethod.getMinData(PubMethod.data1, this.dataMin1.Text);
            this.dataAvg1.Text = PubMethod.getAvgData(PubMethod.data1, this.dataAvg1.Text, this.dataIndex);
            stringBuilder.Append(PubMethod.data1 + "\r");
            if (PubMethod.innerSensor == 64)
            {
              this.data2.Text = PubMethod.getStringDouble(PubMethod.data2);
              this.dataMax2.Text = PubMethod.getMaxData(PubMethod.data2, this.dataMax2.Text);
              this.dataMin2.Text = PubMethod.getMinData(PubMethod.data2, this.dataMin2.Text);
              this.dataAvg2.Text = PubMethod.getAvgData(PubMethod.data2, this.dataAvg2.Text, this.dataIndex);
              stringBuilder.Append(PubMethod.data2 + "\r");
            }
          }
          if (PubMethod.outerSensor > 0)
          {
            this.data3.Text = PubMethod.getStringDouble(PubMethod.data3);
            this.dataMax3.Text = PubMethod.getMaxData(PubMethod.data3, this.dataMax3.Text);
            this.dataMin3.Text = PubMethod.getMinData(PubMethod.data3, this.dataMin3.Text);
            this.dataAvg3.Text = PubMethod.getAvgData(PubMethod.data3, this.dataAvg3.Text, this.dataIndex);
            stringBuilder.Append(PubMethod.data3 + "\r");
            if (PubMethod.outerSensor == 4)
            {
              this.data4.Text = PubMethod.getStringDouble(PubMethod.data4);
              this.dataMax4.Text = PubMethod.getMaxData(PubMethod.data4, this.dataMax4.Text);
              this.dataMin4.Text = PubMethod.getMinData(PubMethod.data4, this.dataMin4.Text);
              this.dataAvg4.Text = PubMethod.getAvgData(PubMethod.data4, this.dataAvg4.Text, this.dataIndex);
              stringBuilder.Append(PubMethod.data4);
            }
          }
          if (Settings.Default.SendStart == 1 && Settings.Default.SendType == 2)
          {
            this.emailContinueSb.Append(PubMethod.getTime() + "\r" + stringBuilder.ToString() + "\n");
            break;
          }
          break;
      }
      if (this.dataIndex % 2 == 0)
      {
        switch (PubMethod.type)
        {
          case 1:
            this.data3.ForeColor = Color.Orange;
            this.data4.ForeColor = Color.Orange;
            break;
          case 2:
            this.data3.ForeColor = Color.Orange;
            break;
          case 3:
            this.data1.ForeColor = Color.Orange;
            this.data3.ForeColor = Color.Orange;
            break;
          case 4:
            this.data1.ForeColor = Color.Orange;
            break;
          case 5:
            this.data1.ForeColor = Color.Orange;
            this.data2.ForeColor = Color.Orange;
            break;
          case 6:
            if (PubMethod.innerSensor > 0)
            {
              this.data1.ForeColor = Color.Orange;
              if (PubMethod.innerSensor == 64)
                this.data2.ForeColor = Color.Orange;
            }
            if (PubMethod.outerSensor > 0)
            {
              this.data3.ForeColor = Color.Orange;
              if (PubMethod.outerSensor == 4)
                this.data4.ForeColor = Color.Orange;
              break;
            }
            break;
        }
      }
      else
      {
        this.data1.ForeColor = Color.Black;
        this.data2.ForeColor = Color.Black;
        this.data3.ForeColor = Color.Black;
        this.data4.ForeColor = Color.Black;
      }
      this.fillTable();
      this.fillCurve();
      this.saveFile();
      ++this.dataIndex;
    }

    private void panel_url_Click(object sender, EventArgs e) => Process.Start(((Control) sender).Tag.ToString());

    private void label_url_Click(object sender, EventArgs e) => Process.Start(((Control) sender).Tag.ToString());

    private void pictureBox_url_Click(object sender, EventArgs e) => Process.Start(((Control) sender).Tag.ToString());

    private void button_change_Click(object sender, EventArgs e)
    {
      if (((Control) sender).Tag.ToString() == "1")
      {
        this.dataTable.Visible = true;
        this.chart.Visible = false;
        this.logButton.BackColor = Color.FromArgb(62, 160, 228);
        this.curveButton.BackColor = Color.White;
        this.logButton.Cursor = Cursors.Default;
        this.curveButton.Cursor = Cursors.Hand;
        this.threeCkb.Visible = false;
      }
      else
      {
        this.dataTable.Visible = false;
        this.chart.Visible = true;
        this.logButton.BackColor = Color.White;
        this.curveButton.BackColor = Color.FromArgb(62, 160, 228);
        this.curveButton.Cursor = Cursors.Default;
        this.logButton.Cursor = Cursors.Hand;
        this.threeCkb.Visible = true;
      }
    }

    private void fillTable()
    {
      string str1 = this.checkAlarm();
      string str2 = "";
      string stringDouble1 = PubMethod.getStringDouble(PubMethod.data1);
      string stringDouble2 = PubMethod.getStringDouble(PubMethod.data2);
      string stringDouble3 = PubMethod.getStringDouble(PubMethod.data3);
      string stringDouble4 = PubMethod.getStringDouble(PubMethod.data4);
      if (!(stringDouble1 == "error"))
        stringDouble1 += Settings.Default.set;
      if (!(stringDouble2 == "error"))
        stringDouble2 += "%RH";
      if (!(stringDouble3 == "error"))
        stringDouble3 += Settings.Default.set;
      if (!(stringDouble4 == "error"))
        stringDouble4 += "%RH";
      switch (PubMethod.type)
      {
        case 1:
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|||" + stringDouble3 + "|" + stringDouble4 + "|" + str1;
          break;
        case 2:
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|||" + stringDouble3 + "||" + str1;
          break;
        case 3:
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|" + stringDouble1 + "||" + stringDouble3 + "||" + str1;
          break;
        case 4:
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|" + stringDouble1 + "||||" + str1;
          break;
        case 5:
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|" + stringDouble1 + "|" + stringDouble2 + "|||" + str1;
          break;
        case 6:
          StringBuilder stringBuilder = new StringBuilder();
          if (PubMethod.innerSensor > 0)
          {
            stringBuilder.Append(stringDouble1 + "|");
            if (PubMethod.innerSensor == 64)
              stringBuilder.Append(stringDouble2 + "|");
            else
              stringBuilder.Append("|");
          }
          else
            stringBuilder.Append("||");
          if (PubMethod.outerSensor > 0)
          {
            stringBuilder.Append(stringDouble3 + "|");
            if (PubMethod.outerSensor == 4)
              stringBuilder.Append(stringDouble4 + "|");
            else
              stringBuilder.Append("|");
          }
          else
            stringBuilder.Append("||");
          str2 = (this.dataIndex + 1).ToString() + "|" + PubMethod.getTime() + "|" + stringBuilder.ToString() + str1;
          break;
      }
      if (string.IsNullOrEmpty(str2))
        return;
      string[] strArray = str2.Split('|');
      if (this.dataIndex < 17)
      {
        DataGridViewRow row = this.dataTable.Rows[this.dataIndex];
        for (int index = 0; index < strArray.Length; ++index)
          row.Cells[index].Value = (object) strArray[index];
      }
      else
        this.dataTable.Rows.Add((object[]) strArray);
      this.dataTable.Columns[0].Width = 40;
      this.dataTable.Columns[1].Width = 200;
      this.dataTable.Columns[2].Width = 100;
      this.dataTable.Columns[3].Width = 100;
      this.dataTable.Columns[4].Width = 100;
      this.dataTable.Columns[5].Width = 100;
      this.dataTable.Focus();
      this.dataTable.FirstDisplayedScrollingRowIndex = this.dataTable.Rows[this.dataTable.Rows.Count - 1].Index;
    }

    private string checkAlarm()
    {
      StringBuilder stringBuilder = new StringBuilder();
      switch (PubMethod.type)
      {
        case 1:
          if (PubMethod.getCurveData(PubMethod.data3) > Settings.Default.tempUpper3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit : " : (object) "Внешняя температура превышает верхний предел, текущий верхний предел：").ToString() + (object) Settings.Default.tempUpper3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? "Outer tempe exceeds the upper limit, current upper limit : " : "Внешняя температура превышает верхний предел, текущий верхний предел：") + (Settings.Default.tempUpper3 + (double) Settings.Default.Language == 2.0 ? ", current temp : " : ", текущая температура：") + PubMethod.data3);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data3) < Settings.Default.tempLower3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел: ").ToString() + (object) Settings.Default.tempLower3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел: ").ToString() + (object) Settings.Default.tempLower3 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object)", текущая температура：") + PubMethod.data3);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data4) > Settings.Default.tempUpper4)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer hum exceeds the upper limit, current upper limit : " : (object) "Внешняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper4 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer hum exceeds the upper limit, current upper limit : " : (object) "Внешняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper4 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность：") + PubMethod.data4);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data4) < Settings.Default.tempLower4)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer hum below limit, current lower limit : " : (object) "Внешняя влажность ниже лимита, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower4 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer hum below limit, current lower limit : " : (object) "Внешняя влажность ниже лимита, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower4 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность：") + PubMethod.data4);
            this.playSound();
            break;
          }
          break;
        case 2:
          if (PubMethod.getCurveData(PubMethod.data3) > Settings.Default.tempUpper3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit : " : (object) "Наружная температура превышает верхний предел, текущий верхний предел: ").ToString() + (object) Settings.Default.tempUpper3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit : " : (object) "Наружная температура превышает верхний предел, текущий верхний предел: ").ToString() + (object) Settings.Default.tempUpper3 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data3);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data3) < Settings.Default.tempLower3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел: ").ToString() + (object) Settings.Default.tempLower3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел: ").ToString() + (object) Settings.Default.tempLower3 + (Settings.Default.Language == 2 ? (object) "Search" : (object) ",, current temp : ：") + PubMethod.data3);
            this.playSound();
            break;
          }
          break;
        case 3:
          if (PubMethod.getCurveData(PubMethod.data1) > Settings.Default.tempUpper1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data1) < Settings.Default.tempLower1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data3) > Settings.Default.tempUpper3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit :" : (object) "Наружная температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit :" : (object) "Наружная температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper3 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data3);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data3) < Settings.Default.tempLower3)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower3 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower3 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data3);
            this.playSound();
            break;
          }
          break;
        case 4:
          if (PubMethod.getCurveData(PubMethod.data1) > Settings.Default.tempUpper1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data1) < Settings.Default.tempLower1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
            break;
          }
          break;
        case 5:
          if (PubMethod.getCurveData(PubMethod.data1) > Settings.Default.tempUpper1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data1) < Settings.Default.tempLower1)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data2) > Settings.Default.tempUpper2)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner hum exceeds upper limit, current upper limit : " : (object) "Внутренняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper2 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner hum exceeds upper limit, current upper limit : " : (object) "Внутренняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper2 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность:") + PubMethod.data2);
            this.playSound();
          }
          if (PubMethod.getCurveData(PubMethod.data2) < Settings.Default.tempLower2)
          {
            stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner hum below limit, current lower limit : " : (object) "Внутренняя влажность ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower2 + ";");
            if (Settings.Default.SendType == 1)
              this.startSend((Settings.Default.Language == 2 ? (object) "Inner hum below limit, current lower limit : " : (object) "Внутренняя влажность ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower2 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность:") + PubMethod.data2);
            this.playSound();
            break;
          }
          break;
        case 6:
          if (PubMethod.innerSensor > 0)
          {
            if (PubMethod.getCurveData(PubMethod.data1) > Settings.Default.tempUpper1)
            {
              stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + ";");
              if (Settings.Default.SendType == 1)
                this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp exceeds upper limit, current upper limit : " : (object) "Внутренняя температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
              this.playSound();
            }
            if (PubMethod.getCurveData(PubMethod.data1) < Settings.Default.tempLower1)
            {
              stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + ";");
              if (Settings.Default.SendType == 1)
                this.startSend((Settings.Default.Language == 2 ? (object) "Inner temp below limit, current lower limit : " : (object) "Внутренняя температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower1 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data1);
              this.playSound();
            }
            if (PubMethod.innerSensor == 64)
            {
              if (PubMethod.getCurveData(PubMethod.data2) > Settings.Default.tempUpper2)
              {
                stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner hum exceeds upper limit, current upper limit : " : (object) "Внутренняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper2 + ";");
                if (Settings.Default.SendType == 1)
                  this.startSend((Settings.Default.Language == 2 ? (object) "Inner hum exceeds upper limit, current upper limit : " : (object) "Внутренняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper2 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность:") + PubMethod.data2);
                this.playSound();
              }
              if (PubMethod.getCurveData(PubMethod.data2) < Settings.Default.tempLower2)
              {
                stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Inner hum below limit, current lower limit : " : (object) "Внутренняя влажность ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower2 + ";");
                if (Settings.Default.SendType == 1)
                  this.startSend((Settings.Default.Language == 2 ? (object) "Inner hum below limit, current lower limit : " : (object) "Внутренняя влажность ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower2 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность:") + PubMethod.data2);
                this.playSound();
              }
            }
          }
          if (PubMethod.outerSensor > 0)
          {
            if (PubMethod.getCurveData(PubMethod.data3) > Settings.Default.tempUpper3)
            {
              stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer tempe exceeds the upper limit, current upper limit : " : (object) "Наружная температура превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper3 + ";");
              if (Settings.Default.SendType == 1)
                this.startSend((Settings.Default.Language == 2 ? "Outer tempe exceeds the upper limit, current upper limit : " : "Наружная температура превышает верхний предел, текущий верхний предел:") + (Settings.Default.tempUpper3 + (double) Settings.Default.Language == 2.0 ? ", current temp : " : ", текущая температура:") + PubMethod.data3);
              this.playSound();
            }
            if (PubMethod.getCurveData(PubMethod.data3) < Settings.Default.tempLower3)
            {
              stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower3 + ";");
              if (Settings.Default.SendType == 1)
                this.startSend((Settings.Default.Language == 2 ? (object) "Outer temp below limit, current lower limit : " : (object) "Наружная температура ниже предела, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower3 + (Settings.Default.Language == 2 ? (object) ", current temp : " : (object) ", текущая температура:") + PubMethod.data3);
              this.playSound();
            }
            if (PubMethod.outerSensor == 4)
            {
              if (PubMethod.getCurveData(PubMethod.data4) > Settings.Default.tempUpper4)
              {
                stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer hum exceeds the upper limit, current upper limit : " : (object) "Внешняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper4 + ";");
                if (Settings.Default.SendType == 1)
                  this.startSend((Settings.Default.Language == 2 ? (object) "Outer hum exceeds the upper limit, current upper limit : " : (object) "Внешняя влажность превышает верхний предел, текущий верхний предел:").ToString() + (object) Settings.Default.tempUpper4 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ",当前湿度：") + PubMethod.data4);
                this.playSound();
              }
              if (PubMethod.getCurveData(PubMethod.data4) < Settings.Default.tempLower4)
              {
                stringBuilder.Append((Settings.Default.Language == 2 ? (object) "Outer hum below limit, current lower limit : " : (object) "Внешняя влажность ниже лимита, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower4 + ";");
                if (Settings.Default.SendType == 1)
                  this.startSend((Settings.Default.Language == 2 ? (object) "Outer hum below limit, current lower limit : " : (object) "Внешняя влажность ниже лимита, текущий нижний предел:").ToString() + (object) Settings.Default.tempLower4 + (Settings.Default.Language == 2 ? (object) ", current hum : " : (object) ", текущая влажность:") + PubMethod.data4);
                this.playSound();
              }
            }
            break;
          }
          break;
      }
      return stringBuilder.ToString();
    }

    private void fillCurve()
    {
      switch (PubMethod.type)
      {
        case 1:
          this.chart.Series(2).Add(PubMethod.getCurveData(PubMethod.data3), PubMethod.getMille(), 0U);
          this.chart.Series(3).Add(PubMethod.getCurveData(PubMethod.data4), PubMethod.getMille(), 0U);
          break;
        case 2:
          this.chart.Series(2).Add(PubMethod.getCurveData(PubMethod.data1), PubMethod.getMille(), 0U);
          break;
        case 3:
          this.chart.Series(0).Add(PubMethod.getCurveData(PubMethod.data1), PubMethod.getMille(), 0U);
          this.chart.Series(2).Add(PubMethod.getCurveData(PubMethod.data3), PubMethod.getMille(), 0U);
          break;
        case 4:
          this.chart.Series(0).Add(PubMethod.getCurveData(PubMethod.data1), PubMethod.getMille(), 0U);
          break;
        case 5:
          this.chart.Series(0).Add(PubMethod.getCurveData(PubMethod.data1), PubMethod.getMille(), 0U);
          this.chart.Series(1).Add(PubMethod.getCurveData(PubMethod.data2), PubMethod.getMille(), 0U);
          break;
        case 6:
          if (PubMethod.innerSensor > 0)
          {
            this.chart.Series(0).Add(PubMethod.getCurveData(PubMethod.data1), PubMethod.getMille(), 0U);
            if (PubMethod.innerSensor == 64)
              this.chart.Series(1).Add(PubMethod.getCurveData(PubMethod.data2), PubMethod.getMille(), 0U);
          }
          if (PubMethod.outerSensor > 0)
          {
            this.chart.Series(2).Add(PubMethod.getCurveData(PubMethod.data3), PubMethod.getMille(), 0U);
            if (PubMethod.outerSensor == 4)
              this.chart.Series(3).Add(PubMethod.getCurveData(PubMethod.data4), PubMethod.getMille(), 0U);
          }
          break;
      }
      double num1 = -50000.0;
      double num2 = 50000.0;
      for (int seriesIndex = 0; seriesIndex < this.chart.SeriesCount; ++seriesIndex)
      {
        if (this.chart.Series(seriesIndex).YValues.Maximum > num1)
          num1 = this.chart.Series(seriesIndex).YValues.Maximum;
        if (this.chart.Series(seriesIndex).YValues.Minimum < num2)
          num2 = this.chart.Series(seriesIndex).YValues.Minimum;
      }
      double num3 = num1 - num2;
      this.chart.Axis.Left.SetMinMax(num2 - num3, num1 + num3);
    }

    private void saveFile()
    {
      string filePath = Settings.Default.FilePath;
      string str1 = "";
      string str2 = "";
      string str3 = "";
      string stringDouble1 = PubMethod.getStringDouble(PubMethod.data1);
      string stringDouble2 = PubMethod.getStringDouble(PubMethod.data2);
      string stringDouble3 = PubMethod.getStringDouble(PubMethod.data3);
      string stringDouble4 = PubMethod.getStringDouble(PubMethod.data4);
      if (!(stringDouble1 == "error"))
        stringDouble1 += this.unnit;
      if (!(stringDouble2 == "error"))
        stringDouble2 += "%RH";
      if (!(stringDouble3 == "error"))
        stringDouble3 += this.unnit;
      if (!(stringDouble4 == "error"))
        stringDouble4 += "%RH";
      switch (PubMethod.type)
      {
        case 1:
          str1 = PubMethod.getTime() + "," + stringDouble3 + "," + stringDouble4;
          str2 = "TEMPer1F_H1";
          str3 = "Time,Temperature,Humidity\n";
          break;
        case 2:
          str1 = PubMethod.getTime() + "," + stringDouble1;
          str2 = "TEMPer1F";
          str3 = "Time,Temperature\n";
          break;
        case 3:
          str1 = PubMethod.getTime() + "," + stringDouble1 + "," + stringDouble3;
          str2 = "TEMPer2";
          str3 = "Time,Inner Temperature,Outer Temperature\n";
          break;
        case 4:
          str1 = PubMethod.getTime() + "," + stringDouble1;
          str2 = "TEMPerGold";
          str3 = "Time,Temperature\n";
          break;
        case 5:
          str1 = PubMethod.getTime() + "," + stringDouble1 + "," + stringDouble2;
          str2 = "TEMPerHUM";
          str3 = "Time,Temperature,Humidity\n";
          break;
        case 6:
          str2 = "TEMPerX";
          str1 = PubMethod.getTime() + ",";
          string str4 = "Time,";
          if (PubMethod.innerSensor > 0)
          {
            str1 = str1 + stringDouble1 + ",";
            str4 += "InnerTemp,";
            if (PubMethod.innerSensor == 64)
            {
              str1 = str1 + stringDouble2 + ",";
              str4 += "InnerHum,";
            }
          }
          if (PubMethod.outerSensor > 0)
          {
            str1 = str1 + stringDouble3 + ",";
            str4 += "OuterTemp,";
            if (PubMethod.outerSensor == 4)
            {
              str1 += stringDouble4;
              str4 += "OuterHum,";
            }
          }
          str3 = str4 + "\n";
          break;
      }
      string path = filePath + "/" + str2;
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      FileInfo[] files = new DirectoryInfo(path).GetFiles();
      string str5 = Settings.Default.FileType != 1 ? ".txt" : ".csv";
      StreamWriter streamWriter;
      if (files.Length == 0 || !Directory.Exists(path + "1" + str5))
      {
        streamWriter = new StreamWriter(path + (object) 1 + str5, true);
        str1 = str3 + str1;
      }
      else if (PubMethod.getFileRowNum(path + "/" + (object) files.Length + str5) > Settings.Default.FileMax + 1)
      {
        streamWriter = new StreamWriter(path + (object) (files.Length + 1) + str5, true);
        str1 = str3 + str1;
      }
      else
        streamWriter = new StreamWriter(path + (object) files.Length + str5, true);
      streamWriter.WriteLine(str1);
      streamWriter.Close();
      streamWriter.Dispose();
    }

    private void setLabel_Click(object sender, EventArgs e)
    {
      int num = (int) new SetForm() { mf = this }.ShowDialog();
    }

    private void data_alarm_Click(object sender, EventArgs e)
    {
      int num = (int) new AlarmForm(((Control) sender).Tag.ToString())
      {
        mf = this
      }.ShowDialog();
    }

    public bool setCalib(byte[] bs)
    {
      if (RDing.WriteUSB(PubMethod.pDevice, bs, (uint) PubMethod.outputLength, ref PubMethod.lpNumberOfBytesWritten))
      {
        Thread.Sleep(50);
        byte[] pBuffer = new byte[9];
        if (RDing.ReadUSB(PubMethod.pDevice, pBuffer, (uint) PubMethod.inputLength, ref PubMethod.lpNumberOfBytesReaden) && pBuffer[4] == (byte) 85)
          return true;
      }
      return false;
    }

    private void playSound()
    {
      if (Settings.Default.SoundAlarm != 1)
        return;
      if (!string.IsNullOrEmpty(Settings.Default.SoundPath))
      {
        try
        {
          this.axWindowsMediaPlayer1.URL = Settings.Default.SoundPath;
          this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        catch
        {
        }
      }
    }

    private void startSend(string str)
    {
      if (Settings.Default.SendStart != 1)
        return;
      new Thread(new ParameterizedThreadStart(this.sendEamil)).Start((object) str);
    }

    private void sendEamil(object obj)
    {
      try
      {
        if (Settings.Default.SendStart != 1)
          return;
        MailMessage message = new MailMessage();
        string sendAccount = Settings.Default.SendAccount;
        message.From = new MailAddress(sendAccount);
        if (!string.IsNullOrEmpty(Settings.Default.ReciveAccount1))
          message.To.Add(Settings.Default.ReciveAccount1);
        if (!string.IsNullOrEmpty(Settings.Default.ReciveAccount2))
          message.To.Add(Settings.Default.ReciveAccount2);
        message.Subject = string.IsNullOrEmpty(Settings.Default.Subject) ? "Alarm Email" : Settings.Default.Subject;
        message.Body = Settings.Default.Content + "\n" + obj;
        message.BodyEncoding = Encoding.UTF8;
        message.IsBodyHtml = true;
        message.Priority = MailPriority.High;
        SmtpClient smtpClient = new SmtpClient(Settings.Default.SendSmtp, int.Parse(Settings.Default.SendPort));
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.UseDefaultCredentials = true;
        smtpClient.EnableSsl = Settings.Default.EnableSSL;
        try
        {
          ++this.totalCount;
          smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(sendAccount, Settings.Default.SendPass);
          smtpClient.Send(message);
          ++this.successCount;
        }
        catch (Exception ex)
        {
          MainForm mainForm = this;
          this.Invoke(new Action ( delegate()
          {
            ++mainForm.isureMailCount;
            if (mainForm.isureMailCount > 1)
              return;
            mainForm.reportEmailIssure((Settings.Default.Language == 2 ? "detail to see: " : "Детали ошибки: ") + ex.ToString());
          }));
        }
        finally
        {
          this.Invoke(new Action ( delegate()
          {
            this.sendCount.Text = string.Concat((object) this.successCount);
          }));
        }
      }
      catch (Exception ex)
      {
      }
    }

    public static void SendMailUse(
      string from,
      string to,
      string pas,
      string serverhost,
      string port)
    {
      int port1 = int.Parse(port);
      SmtpClient smtpClient = new SmtpClient(serverhost, port1);
      smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
      smtpClient.EnableSsl = false;
      smtpClient.UseDefaultCredentials = true;
      smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(from, pas);
      string address = from;
      string addresses = to;
      string str1 = "Вы украли мое имя, затем этот номер для тестирования, хахахахаха";
      string str2 = "Проверить содержание письма 5";
      MailMessage message = new MailMessage();
      message.From = new MailAddress(address, "xyf");
      message.To.Add(addresses);
      message.Subject = str1;
      message.Body = str2;
      message.BodyEncoding = Encoding.UTF8;
      message.IsBodyHtml = true;
      message.Priority = MailPriority.High;
      try
      {
        smtpClient.Send(message);
        Console.WriteLine("Успешно отправлено");
        int num = (int) MessageBox.Show("Success");
      }
      catch (SmtpException ex)
      {
        int num1 = (int) MessageBox.Show(ex.Message);
        int num2 = (int) MessageBox.Show(ex.StackTrace);
        Console.WriteLine(ex.Message, (object)"Ошибка отправки почты");
      }
    }

    private void reportEmailIssure(string issure)
    {
      int num1 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "fail to send email " : "Не удалось отправить почту!");
      int num2 = (int) MessageBox.Show(issure);
    }

    private void emailLabel_Click(object sender, EventArgs e)
    {
      int num = (int) new EmailForm() { mf = this }.ShowDialog();
    }

    private void remoteLabel_Click(object sender, EventArgs e)
    {
      this.rf = new RemoteForm();
      this.rf.mf = this;
      int num = (int) this.rf.ShowDialog();
    }

    private void threeCkb_Click(object sender, EventArgs e) => this.chart.Aspect.View3D = ((CheckBox) sender).Checked;

    private void nagvationPanel_Paint(object sender, PaintEventArgs e)
    {
      Panel panel = (Panel) sender;
      e.Graphics.DrawLine(new Pen(Color.FromArgb(204, 204, 204)), panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
    }

    public void uploadDevice()
    {
      PubMethod.sendSocket = IpDAL.GetSocket("120.24.211.240", 16000);
      if (!PubMethod.sendSocket.Connected)
        return;
      PubMethod.sendSocket.BeginReceive(PubMethod.buffer, 0, PubMethod.buffer.Length, SocketFlags.None, new AsyncCallback(this.ReceiveCallBack), (object) PubMethod.sendSocket);
    }

    public void ReceiveCallBack(IAsyncResult result)
    {
      Socket asyncState = (Socket) result.AsyncState;
      try
      {
        if (!asyncState.Connected)
          return;
        int num1 = asyncState.EndReceive(result);
        result.AsyncWaitHandle.Close();
        if (num1 > 0)
        {
          string str = Encoding.ASCII.GetString(PubMethod.buffer);
          if (str.Contains("call pcsensor!"))
            IpDAL.returnOrder("enter config state", asyncState);
          else if (str.Contains("display configs!"))
          {
            IpDAL.returnOrder("device MAC:00-0B-3C-6D-FF-AA\r\ndevice ipaddress:192.168.1.188\r\ndevice netmask:255.255.255.0\r\ndevice gateway:192.168.1.2\r\nhost ipaddress:120.24.211.240\r\nconnection type:tcp\r\nhost port:16000\r\nuser name:" + PubMethod.loginName + "\r\nuser password:" + PubMethod.loginPass + "\r\nfirmware:TEMPer", asyncState);
            if (this.rf != null)
              this.Invoke(new Action( delegate()
              {
                this.rf.Close();
              }));
            int num2 = (int) MessageBox.Show(Settings.Default.Language == 2 ? "Upload success" : "上传成功");
          }
          else if (str.Contains("ReadVersion>"))
            IpDAL.returnOrder(PubMethod.version, asyncState);
          else if (str.Contains("ReadSensorType>"))
            IpDAL.returnOrder(PubMethod.innerSensor.ToString() + "," + (object) PubMethod.outerSensor, asyncState);
          else if (str.Contains("ReadCalib>"))
            IpDAL.returnOrder(PubMethod.calib1.ToString() + "," + (object) PubMethod.calib2 + "," + (object) PubMethod.calib3 + "," + (object) PubMethod.calib4, asyncState);
          else if (str.Contains("ReadData>"))
          {
            if (PubMethod.isOpen)
              IpDAL.returnOrder(PubMethod.data1 + "," + PubMethod.data2 + "," + PubMethod.data3 + "," + PubMethod.data4, asyncState);
            else
              IpDAL.returnOrder("Disconnect", asyncState);
          }
          else if (str.Contains("SetCalib:"))
          {
            string s1 = str.Substring(str.IndexOf(",") + 1);
            string s2 = str.Substring(str.IndexOf(":") + 1, str.IndexOf(","));
            int num2 = int.Parse(s1);
            if (this.setCalib(PubMethod.getCailbByte(int.Parse(s2), (double) num2)))
              IpDAL.returnOrder("OK", asyncState);
            else
              IpDAL.returnOrder("Fail", asyncState);
          }
          PubMethod.buffer = new byte[1024];
          asyncState.BeginReceive(PubMethod.buffer, 0, PubMethod.buffer.Length, SocketFlags.None, new AsyncCallback(this.ReceiveCallBack), (object) asyncState);
        }
      }
      catch (SocketException ex)
      {
      }
    }

    public void searchDevice()
    {
      this.NamePwd = ProtocolKeys.UserName + ProtocolKeys.ColonSign + PubMethod.loginName + ProtocolKeys.ReturnWrap + ProtocolKeys.Password + ProtocolKeys.ColonSign + PubMethod.loginPass + ProtocolKeys.ReturnWrap + ProtocolKeys.ResetLogin + ProtocolKeys.ColonSign + ProtocolKeys.ResetLogin;
      ThreadPool.QueueUserWorkItem((WaitCallback) (o => this.ConnectServer()));
    }

    private void ConnectServer()
    {
      IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("120.24.211.240"), 16000);
      Socket clienttest = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
      clienttest.BeginConnect((EndPoint) ipEndPoint, (AsyncCallback) null, (object) clienttest).AsyncWaitHandle.WaitOne(10000, true);
      Thread.Sleep(1000);
      if (clienttest.Connected)
      {
        try
        {
          clienttest.ReceiveTimeout = 2000;
          clienttest.SendTimeout = 2000;
          byte[] numArray = new byte[clienttest.ReceiveBufferSize];
          int count1 = clienttest.Receive(numArray);
          if (Encoding.ASCII.GetString(numArray, 0, count1) != "call pcsensor!")
            return;
          byte[] buffer = new byte[1]{ (byte) 101 };
          clienttest.Send(buffer, buffer.Length, SocketFlags.None);
          Thread.Sleep(500);
          int count2 = clienttest.Receive(numArray);
          if (Encoding.ASCII.GetString(numArray, 0, count2) != "display configs!")
            return;
          byte[] bytes = Encoding.Default.GetBytes(this.NamePwd);
          clienttest.Send(bytes, bytes.Length, SocketFlags.None);
          Thread.Sleep(1500);
          int count3 = clienttest.Receive(numArray);
          AssemblyInDataParser assemblyInDataParser = new AssemblyInDataParser();
          assemblyInDataParser.DecodeProtocolText(Encoding.UTF8.GetString(numArray, 0, count3));
          string devicesIp = "";
          assemblyInDataParser.GetValue(ProtocolKeys.RemotDeviceIp, ref devicesIp);
          if (devicesIp != "")
            this.Invoke(new Action( delegate()
            {
              PubMethod.reciveSocket = clienttest;
              PubMethod.reciveIp = devicesIp;
              if (this.rf != null && this.rf != null)
                this.Invoke(new Action( delegate()
                {
                  this.rf.Close();
                }));
              this.getVersion();
              int num = (int) MessageBox.Show(Settings.Default.Language == 2 ? "End of the search" : "Конец поиска");
            }));
        }
        catch
        {
          clienttest.Shutdown(SocketShutdown.Both);
          clienttest.Close();
          GC.Collect();
          GC.Collect();
        }
      }
    }

    public void changeUnit(string str) => this.unitBtn.Text = str;

    public void changeEmail(string str) => this.emailBtn.Text = str;

    public void changeRemote(string str) => this.remoteBtn.Text = str;

    private void emailBtn_MouseMove(object sender, MouseEventArgs e) => this.emailTipPanel.Visible = true;

    private void emailBtn_MouseLeave(object sender, EventArgs e) => this.emailTipPanel.Visible = false;

    private void introduceLabel_Click(object sender, EventArgs e)
    {
      int num = (int) new IntroduceForm().ShowDialog();
    }

    private void aboutLabel_Click(object sender, EventArgs e)
    {
      int num = (int) new AboutForm().ShowDialog();
    }

    private void closePic_Click(object sender, EventArgs e)
    {
      if (Settings.Default.CloseOperate == 1)
      {
        this.Close();
      }
      else
      {
        this.Hide();
        this.notifyIcon1.ShowBalloonTip(1000, " ", Settings.Default.Language == 2 ? "The interface is hidden to the tray" : "Интерфейс скрыт в трее", ToolTipIcon.None);
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (Settings.Default.CloseOperate != 2)
        ;
    }

    private void notifyIcon1_DoubleClick(object sender, EventArgs e) => this.Visible = true;

    private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

    private void minPB_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void emailTipPanel_Paint(object sender, PaintEventArgs e)
    {
      Panel panel = (Panel) sender;
      e.Graphics.DrawLine(new Pen(Color.FromArgb(204, 204, 204)), panel.Width - 1, panel.Height - 1, 0, panel.Height - 1);
      e.Graphics.DrawLine(new Pen(Color.FromArgb(204, 204, 204)), 0, 0, 0, panel.Height - 1);
      e.Graphics.DrawLine(new Pen(Color.FromArgb(204, 204, 204)), panel.Width - 1, panel.Height - 1, panel.Width - 1, 0);
      e.Graphics.DrawLine(new Pen(Color.FromArgb(204, 204, 204)), panel.Width - 1, 0, 0, 0);
    }

    protected override void WndProc(ref System.Windows.Forms.Message m)
    {
      switch (m.Msg)
      {
        case 132:
          base.WndProc(ref m);
          Point client = this.PointToClient(new Point((int) m.LParam & (int) ushort.MaxValue, (int) m.LParam >> 16 & (int) ushort.MaxValue));
          if (client.X <= 5)
          {
            if (client.Y <= 5)
            {
              m.Result = (IntPtr) 13;
              break;
            }
            if (client.Y >= this.ClientSize.Height - 5)
            {
              m.Result = (IntPtr) 16;
              break;
            }
            m.Result = (IntPtr) 10;
            break;
          }
          if (client.X >= this.ClientSize.Width - 5)
          {
            if (client.Y <= 5)
            {
              m.Result = (IntPtr) 14;
              break;
            }
            if (client.Y >= this.ClientSize.Height - 5)
            {
              m.Result = (IntPtr) 17;
              break;
            }
            m.Result = (IntPtr) 11;
            break;
          }
          if (client.Y <= 5)
          {
            m.Result = (IntPtr) 12;
            break;
          }
          if (client.Y < this.ClientSize.Height - 5)
            break;
          m.Result = (IntPtr) 15;
          break;
        case 513:
          m.Msg = 161;
          m.LParam = IntPtr.Zero;
          m.WParam = new IntPtr(2);
          base.WndProc(ref m);
          break;
        default:
          base.WndProc(ref m);
          break;
      }
    }

    private void MainForm_Resize(object sender, EventArgs e) => this.setControls((float) this.Width / this.X, (float) this.Height / this.Y, (Control) this);

    private void setControls(float newX, float newY, Control cons)
    {
      foreach (Control control in (ArrangedElementCollection) cons.Controls)
      {
        if (control.Tag != null)
        {
          string[] strArray = control.Tag.ToString().Split(':');
          float num1 = Convert.ToSingle(strArray[0]) * newX;
          control.Width = (int) num1;
          float num2 = Convert.ToSingle(strArray[1]) * newY;
          control.Height = (int) num2;
          float num3 = Convert.ToSingle(strArray[2]) * newX;
          control.Left = (int) num3;
          float num4 = Convert.ToSingle(strArray[3]) * newY;
          control.Top = (int) num4;
          float emSize = Convert.ToSingle(strArray[4]) * newY;
          control.Font = new Font(control.Font.Name, emSize, control.Font.Style, control.Font.Unit);
        }
      }
    }

    private void titlePanel_Paint(object sender, PaintEventArgs e)
    {
    }

    private void MainForm_SizeChanged(object sender, EventArgs e) => this.asc.controlAutoSize((Control) this);
  }
}
