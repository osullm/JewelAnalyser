using AxTeeChart;
using JewelApp01.Control;
using JewelApp01.Processer;
using System.Windows.Forms;

namespace JewelApp01
{
    partial class Form1 : Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.清除峰位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu_colorBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.寻峰设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保持记录的谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出当前谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开两列数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扣除暗背景谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色带ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工厂设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工厂设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_spectrum = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbx_showCursor = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_xAxis = new System.Windows.Forms.NumericUpDown();
            this.btn_deleteMarks = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_zoomOut = new System.Windows.Forms.Button();
            this.btn_zoomIn = new System.Windows.Forms.Button();
            this.btn_zoomIn2 = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_saveDark = new System.Windows.Forms.Button();
            this.btn_saveReference = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_clearRecords = new System.Windows.Forms.Button();
            this.btn_takeRecord = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btn_spec = new System.Windows.Forms.Button();
            this.btn_Reflect = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btn_findPeak = new System.Windows.Forms.Button();
            this.Chart_spec = new AxTeeChart.AxTChart();
            this.tab_matching = new System.Windows.Forms.TabPage();
            this.Chart_fitting = new AxTeeChart.AxTChart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button16 = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_inqiry = new System.Windows.Forms.TabPage();
            this.tab_modify = new System.Windows.Forms.TabPage();
            this.tab_specList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorBar1 = new JewelApp01.Control.colorBar();
            this.fittingControl1 = new JewelApp01.Control.FittingControl();
            this.addJewDataControl1 = new JewelApp01.Control.AddJewDataControl();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tab_spectrum.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_xAxis)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_spec)).BeginInit();
            this.tab_matching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_fitting)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_inqiry.SuspendLayout();
            this.tab_modify.SuspendLayout();
            this.tab_specList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "成功连接";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Padding = new System.Windows.Forms.Padding(50, 0, 500, 0);
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(550, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "完成检测：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.清除峰位ToolStripMenuItem,
            this.tsMenu_colorBar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            this.contextMenuStrip1.Text = "添加峰位";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "添加峰位";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "删除峰位";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 清除峰位ToolStripMenuItem
            // 
            this.清除峰位ToolStripMenuItem.Name = "清除峰位ToolStripMenuItem";
            this.清除峰位ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除峰位ToolStripMenuItem.Text = "清除峰位";
            this.清除峰位ToolStripMenuItem.Click += new System.EventHandler(this.清除峰位ToolStripMenuItem_Click);
            // 
            // tsMenu_colorBar
            // 
            this.tsMenu_colorBar.CheckOnClick = true;
            this.tsMenu_colorBar.Name = "tsMenu_colorBar";
            this.tsMenu_colorBar.Size = new System.Drawing.Size(148, 22);
            this.tsMenu_colorBar.Text = "显示彩色光谱";
            this.tsMenu_colorBar.Click += new System.EventHandler(this.tsMenu_colorBar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.工厂设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库查询ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.查看ToolStripMenuItem.Text = "数据库查询";
            // 
            // 数据库查询ToolStripMenuItem
            // 
            this.数据库查询ToolStripMenuItem.Name = "数据库查询ToolStripMenuItem";
            this.数据库查询ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据库查询ToolStripMenuItem.Text = "数据库查询";
            this.数据库查询ToolStripMenuItem.Click += new System.EventHandler(this.数据库查询ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数设置ToolStripMenuItem,
            this.寻峰设置ToolStripMenuItem,
            this.保持记录的谱图ToolStripMenuItem,
            this.导出当前谱图ToolStripMenuItem,
            this.打开两列数据ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.工具ToolStripMenuItem.Text = "工  具";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.参数设置ToolStripMenuItem_Click);
            // 
            // 寻峰设置ToolStripMenuItem
            // 
            this.寻峰设置ToolStripMenuItem.Name = "寻峰设置ToolStripMenuItem";
            this.寻峰设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.寻峰设置ToolStripMenuItem.Text = "寻峰设置";
            this.寻峰设置ToolStripMenuItem.Click += new System.EventHandler(this.寻峰设置ToolStripMenuItem_Click);
            // 
            // 保持记录的谱图ToolStripMenuItem
            // 
            this.保持记录的谱图ToolStripMenuItem.Name = "保持记录的谱图ToolStripMenuItem";
            this.保持记录的谱图ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.保持记录的谱图ToolStripMenuItem.Text = "保存拍摄的谱图";
            this.保持记录的谱图ToolStripMenuItem.Click += new System.EventHandler(this.保存记录的谱图ToolStripMenuItem_Click);
            // 
            // 导出当前谱图ToolStripMenuItem
            // 
            this.导出当前谱图ToolStripMenuItem.Name = "导出当前谱图ToolStripMenuItem";
            this.导出当前谱图ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.导出当前谱图ToolStripMenuItem.Text = "保存当前谱图";
            this.导出当前谱图ToolStripMenuItem.Click += new System.EventHandler(this.导出当前数据ToolStripMenuItem_Click);
            // 
            // 打开两列数据ToolStripMenuItem
            // 
            this.打开两列数据ToolStripMenuItem.Name = "打开两列数据ToolStripMenuItem";
            this.打开两列数据ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开两列数据ToolStripMenuItem.Text = "打开两列数据";
            this.打开两列数据ToolStripMenuItem.Click += new System.EventHandler(this.打开两列数据ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.扣除暗背景谱图ToolStripMenuItem,
            this.色带ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 扣除暗背景谱图ToolStripMenuItem
            // 
            this.扣除暗背景谱图ToolStripMenuItem.Name = "扣除暗背景谱图ToolStripMenuItem";
            this.扣除暗背景谱图ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.扣除暗背景谱图ToolStripMenuItem.Text = "扣除暗背景谱图";
            this.扣除暗背景谱图ToolStripMenuItem.Click += new System.EventHandler(this.扣除暗背景谱图ToolStripMenuItem_Click);
            // 
            // 色带ToolStripMenuItem
            // 
            this.色带ToolStripMenuItem.CheckOnClick = true;
            this.色带ToolStripMenuItem.Name = "色带ToolStripMenuItem";
            this.色带ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.色带ToolStripMenuItem.Text = "色带";
            this.色带ToolStripMenuItem.Click += new System.EventHandler(this.色带ToolStripMenuItem_Click);
            // 
            // 工厂设置ToolStripMenuItem
            // 
            this.工厂设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工厂设置ToolStripMenuItem1});
            this.工厂设置ToolStripMenuItem.Name = "工厂设置ToolStripMenuItem";
            this.工厂设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.工厂设置ToolStripMenuItem.Text = "厂家菜单";
            this.工厂设置ToolStripMenuItem.Visible = false;
            // 
            // 工厂设置ToolStripMenuItem1
            // 
            this.工厂设置ToolStripMenuItem1.Name = "工厂设置ToolStripMenuItem1";
            this.工厂设置ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.工厂设置ToolStripMenuItem1.Text = "工厂设置";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl3);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(981, 542);
            this.splitContainer1.SplitterDistance = 625;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 10;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_spectrum);
            this.tabControl2.Controls.Add(this.tab_matching);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(625, 542);
            this.tabControl2.TabIndex = 1;
            // 
            // tab_spectrum
            // 
            this.tab_spectrum.Controls.Add(this.tableLayoutPanel1);
            this.tab_spectrum.Location = new System.Drawing.Point(4, 22);
            this.tab_spectrum.Name = "tab_spectrum";
            this.tab_spectrum.Padding = new System.Windows.Forms.Padding(3);
            this.tab_spectrum.Size = new System.Drawing.Size(617, 516);
            this.tab_spectrum.TabIndex = 0;
            this.tab_spectrum.Text = "光谱图";
            this.tab_spectrum.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Chart_spec, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorBar1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 510);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cbx_showCursor);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.nud_xAxis);
            this.flowLayoutPanel3.Controls.Add(this.btn_deleteMarks);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 480);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(607, 26);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // cbx_showCursor
            // 
            this.cbx_showCursor.AutoSize = true;
            this.cbx_showCursor.Location = new System.Drawing.Point(2, 2);
            this.cbx_showCursor.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_showCursor.Name = "cbx_showCursor";
            this.cbx_showCursor.Size = new System.Drawing.Size(72, 16);
            this.cbx_showCursor.TabIndex = 0;
            this.cbx_showCursor.Text = "显示标记";
            this.cbx_showCursor.UseVisualStyleBackColor = true;
            this.cbx_showCursor.CheckedChanged += new System.EventHandler(this.cbx_showCursor_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = " X轴：";
            // 
            // nud_xAxis
            // 
            this.nud_xAxis.DecimalPlaces = 2;
            this.nud_xAxis.Location = new System.Drawing.Point(126, 3);
            this.nud_xAxis.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_xAxis.Name = "nud_xAxis";
            this.nud_xAxis.Size = new System.Drawing.Size(63, 21);
            this.nud_xAxis.TabIndex = 4;
            this.nud_xAxis.ValueChanged += new System.EventHandler(this.nud_xAxis_ValueChanged);
            // 
            // btn_deleteMarks
            // 
            this.btn_deleteMarks.Location = new System.Drawing.Point(194, 2);
            this.btn_deleteMarks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteMarks.Name = "btn_deleteMarks";
            this.btn_deleteMarks.Size = new System.Drawing.Size(83, 23);
            this.btn_deleteMarks.TabIndex = 6;
            this.btn_deleteMarks.Text = "删除寻峰标记";
            this.btn_deleteMarks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_zoomOut);
            this.flowLayoutPanel1.Controls.Add(this.btn_zoomIn);
            this.flowLayoutPanel1.Controls.Add(this.btn_zoomIn2);
            this.flowLayoutPanel1.Controls.Add(this.splitter4);
            this.flowLayoutPanel1.Controls.Add(this.btn_stop);
            this.flowLayoutPanel1.Controls.Add(this.btn_start);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.btn_saveDark);
            this.flowLayoutPanel1.Controls.Add(this.btn_saveReference);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.btn_clearRecords);
            this.flowLayoutPanel1.Controls.Add(this.btn_takeRecord);
            this.flowLayoutPanel1.Controls.Add(this.splitter3);
            this.flowLayoutPanel1.Controls.Add(this.btn_spec);
            this.flowLayoutPanel1.Controls.Add(this.btn_Reflect);
            this.flowLayoutPanel1.Controls.Add(this.splitter5);
            this.flowLayoutPanel1.Controls.Add(this.btn_findPeak);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_zoomOut
            // 
            this.btn_zoomOut.BackgroundImage = global::JewelApp01.Properties.Resources.minimumImage;
            this.btn_zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomOut.Location = new System.Drawing.Point(2, 2);
            this.btn_zoomOut.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zoomOut.Name = "btn_zoomOut";
            this.btn_zoomOut.Size = new System.Drawing.Size(38, 40);
            this.btn_zoomOut.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_zoomOut, "初始化显示谱图");
            this.btn_zoomOut.UseVisualStyleBackColor = true;
            this.btn_zoomOut.Click += new System.EventHandler(this.btn_zoomOut_Click);
            // 
            // btn_zoomIn
            // 
            this.btn_zoomIn.BackgroundImage = global::JewelApp01.Properties.Resources.maximumImage;
            this.btn_zoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomIn.Location = new System.Drawing.Point(44, 2);
            this.btn_zoomIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zoomIn.Name = "btn_zoomIn";
            this.btn_zoomIn.Size = new System.Drawing.Size(38, 40);
            this.btn_zoomIn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_zoomIn, "适合高度显示谱图");
            this.btn_zoomIn.UseVisualStyleBackColor = true;
            this.btn_zoomIn.Click += new System.EventHandler(this.btn_zoomIn_Click);
            // 
            // btn_zoomIn2
            // 
            this.btn_zoomIn2.BackgroundImage = global::JewelApp01.Properties.Resources.maximum2Image;
            this.btn_zoomIn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zoomIn2.Location = new System.Drawing.Point(86, 2);
            this.btn_zoomIn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zoomIn2.Name = "btn_zoomIn2";
            this.btn_zoomIn2.Size = new System.Drawing.Size(38, 40);
            this.btn_zoomIn2.TabIndex = 1;
            this.btn_zoomIn2.UseVisualStyleBackColor = true;
            this.btn_zoomIn2.Click += new System.EventHandler(this.btn_zoomIn2_Click);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(128, 2);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(13, 40);
            this.splitter4.TabIndex = 8;
            this.splitter4.TabStop = false;
            // 
            // btn_stop
            // 
            this.btn_stop.BackgroundImage = global::JewelApp01.Properties.Resources.stopGettingImage;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Location = new System.Drawing.Point(145, 2);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(38, 40);
            this.btn_stop.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_stop, "暂停采集光谱");
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::JewelApp01.Properties.Resources.continuousGettingImage;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Location = new System.Drawing.Point(187, 2);
            this.btn_start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(38, 40);
            this.btn_start.TabIndex = 0;
            this.btn_start.Tag = "";
            this.toolTip1.SetToolTip(this.btn_start, "连续采集光谱");
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(230, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(13, 38);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // btn_saveDark
            // 
            this.btn_saveDark.BackgroundImage = global::JewelApp01.Properties.Resources.darkImage;
            this.btn_saveDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveDark.Location = new System.Drawing.Point(248, 2);
            this.btn_saveDark.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveDark.Name = "btn_saveDark";
            this.btn_saveDark.Size = new System.Drawing.Size(38, 40);
            this.btn_saveDark.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_saveDark, "当前谱图存为暗");
            this.btn_saveDark.UseVisualStyleBackColor = true;
            this.btn_saveDark.Click += new System.EventHandler(this.btn_saveDark_Click);
            // 
            // btn_saveReference
            // 
            this.btn_saveReference.BackgroundImage = global::JewelApp01.Properties.Resources.referenceImage;
            this.btn_saveReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveReference.Location = new System.Drawing.Point(290, 2);
            this.btn_saveReference.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveReference.Name = "btn_saveReference";
            this.btn_saveReference.Size = new System.Drawing.Size(38, 40);
            this.btn_saveReference.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_saveReference, "当前谱图存为参考");
            this.btn_saveReference.UseVisualStyleBackColor = true;
            this.btn_saveReference.Click += new System.EventHandler(this.btn_saveReference_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(333, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(13, 38);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // btn_clearRecords
            // 
            this.btn_clearRecords.BackgroundImage = global::JewelApp01.Properties.Resources.removeImage;
            this.btn_clearRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clearRecords.Location = new System.Drawing.Point(351, 2);
            this.btn_clearRecords.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearRecords.Name = "btn_clearRecords";
            this.btn_clearRecords.Size = new System.Drawing.Size(38, 40);
            this.btn_clearRecords.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_clearRecords, "删除记录的谱线");
            this.btn_clearRecords.UseVisualStyleBackColor = true;
            this.btn_clearRecords.Click += new System.EventHandler(this.btn_removeRecord_Click);
            // 
            // btn_takeRecord
            // 
            this.btn_takeRecord.BackgroundImage = global::JewelApp01.Properties.Resources.recordImage;
            this.btn_takeRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_takeRecord.Location = new System.Drawing.Point(393, 2);
            this.btn_takeRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btn_takeRecord.Name = "btn_takeRecord";
            this.btn_takeRecord.Size = new System.Drawing.Size(38, 40);
            this.btn_takeRecord.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_takeRecord, "记录谱线");
            this.btn_takeRecord.UseVisualStyleBackColor = true;
            this.btn_takeRecord.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(436, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(13, 38);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btn_spec
            // 
            this.btn_spec.BackgroundImage = global::JewelApp01.Properties.Resources.spectraImage;
            this.btn_spec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_spec.Location = new System.Drawing.Point(454, 2);
            this.btn_spec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_spec.Name = "btn_spec";
            this.btn_spec.Size = new System.Drawing.Size(38, 40);
            this.btn_spec.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_spec, "原始光强谱图");
            this.btn_spec.UseVisualStyleBackColor = true;
            this.btn_spec.Click += new System.EventHandler(this.btn_spec_Click);
            // 
            // btn_Reflect
            // 
            this.btn_Reflect.BackgroundImage = global::JewelApp01.Properties.Resources.reflectanceImage;
            this.btn_Reflect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reflect.Location = new System.Drawing.Point(496, 2);
            this.btn_Reflect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reflect.Name = "btn_Reflect";
            this.btn_Reflect.Size = new System.Drawing.Size(38, 40);
            this.btn_Reflect.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_Reflect, "透过率谱图");
            this.btn_Reflect.UseVisualStyleBackColor = true;
            this.btn_Reflect.Click += new System.EventHandler(this.btn_Reflect_Click);
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(539, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(13, 38);
            this.splitter5.TabIndex = 7;
            this.splitter5.TabStop = false;
            // 
            // btn_findPeak
            // 
            this.btn_findPeak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_findPeak.BackgroundImage")));
            this.btn_findPeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_findPeak.Location = new System.Drawing.Point(557, 2);
            this.btn_findPeak.Margin = new System.Windows.Forms.Padding(2);
            this.btn_findPeak.Name = "btn_findPeak";
            this.btn_findPeak.Size = new System.Drawing.Size(38, 40);
            this.btn_findPeak.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_findPeak, "自动寻峰");
            this.btn_findPeak.UseVisualStyleBackColor = true;
            this.btn_findPeak.Click += new System.EventHandler(this.btn_findPeak_Click);
            // 
            // Chart_spec
            // 
            this.Chart_spec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_spec.Enabled = true;
            this.Chart_spec.Location = new System.Drawing.Point(3, 51);
            this.Chart_spec.Name = "Chart_spec";
            this.Chart_spec.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Chart_spec.OcxState")));
            this.Chart_spec.Size = new System.Drawing.Size(605, 424);
            this.Chart_spec.TabIndex = 0;
            this.Chart_spec.OnMouseUp += new AxTeeChart.ITChartEvents_OnMouseUpEventHandler(this.Chart_spec_OnMouseUp);
            this.Chart_spec.OnCursorToolChange += new AxTeeChart.ITChartEvents_OnCursorToolChangeEventHandler(this.axTChart1_OnCursorToolChange);
            // 
            // tab_matching
            // 
            this.tab_matching.Controls.Add(this.Chart_fitting);
            this.tab_matching.Controls.Add(this.flowLayoutPanel2);
            this.tab_matching.Location = new System.Drawing.Point(4, 22);
            this.tab_matching.Name = "tab_matching";
            this.tab_matching.Padding = new System.Windows.Forms.Padding(3);
            this.tab_matching.Size = new System.Drawing.Size(617, 516);
            this.tab_matching.TabIndex = 1;
            this.tab_matching.Text = "数据库匹配";
            this.tab_matching.UseVisualStyleBackColor = true;
            // 
            // Chart_fitting
            // 
            this.Chart_fitting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart_fitting.Enabled = true;
            this.Chart_fitting.Location = new System.Drawing.Point(3, 32);
            this.Chart_fitting.Name = "Chart_fitting";
            this.Chart_fitting.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Chart_fitting.OcxState")));
            this.Chart_fitting.Size = new System.Drawing.Size(611, 481);
            this.Chart_fitting.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button16);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(611, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(3, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 0;
            this.button16.Text = "显示修改";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(3, 574);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(880, 179);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(872, 153);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(872, 153);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_inqiry);
            this.tabControl1.Controls.Add(this.tab_modify);
            this.tabControl1.Controls.Add(this.tab_specList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 542);
            this.tabControl1.TabIndex = 9;
            // 
            // tab_inqiry
            // 
            this.tab_inqiry.Controls.Add(this.fittingControl1);
            this.tab_inqiry.Location = new System.Drawing.Point(4, 22);
            this.tab_inqiry.Name = "tab_inqiry";
            this.tab_inqiry.Size = new System.Drawing.Size(344, 516);
            this.tab_inqiry.TabIndex = 2;
            this.tab_inqiry.Text = "查询";
            this.tab_inqiry.UseVisualStyleBackColor = true;
            // 
            // tab_modify
            // 
            this.tab_modify.Controls.Add(this.addJewDataControl1);
            this.tab_modify.Location = new System.Drawing.Point(4, 22);
            this.tab_modify.Margin = new System.Windows.Forms.Padding(2);
            this.tab_modify.Name = "tab_modify";
            this.tab_modify.Size = new System.Drawing.Size(344, 516);
            this.tab_modify.TabIndex = 3;
            this.tab_modify.Text = "录入";
            this.tab_modify.UseVisualStyleBackColor = true;
            // 
            // tab_specList
            // 
            this.tab_specList.Controls.Add(this.dataGridView1);
            this.tab_specList.Location = new System.Drawing.Point(4, 22);
            this.tab_specList.Name = "tab_specList";
            this.tab_specList.Padding = new System.Windows.Forms.Padding(3);
            this.tab_specList.Size = new System.Drawing.Size(344, 516);
            this.tab_specList.TabIndex = 0;
            this.tab_specList.Text = "谱线列表";
            this.tab_specList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 15;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(338, 510);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // colorBar1
            // 
            this.colorBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBar1.Location = new System.Drawing.Point(2, 480);
            this.colorBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorBar1.Name = "colorBar1";
            this.colorBar1.Size = new System.Drawing.Size(607, 1);
            this.colorBar1.TabIndex = 3;
            // 
            // fittingControl1
            // 
            this.fittingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fittingControl1.dt_fitting = null;
            this.fittingControl1.Location = new System.Drawing.Point(0, 0);
            this.fittingControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fittingControl1.Name = "fittingControl1";
            this.fittingControl1.processSpec = null;
            this.fittingControl1.Size = new System.Drawing.Size(344, 516);
            this.fittingControl1.TabIndex = 0;
            this.fittingControl1.OnAddLines += new JewelApp01.Processer.AddLinesHander(this.chart_fitting_addLine);
            // 
            // addJewDataControl1
            // 
            this.addJewDataControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addJewDataControl1.Location = new System.Drawing.Point(0, 0);
            this.addJewDataControl1.Margin = new System.Windows.Forms.Padding(2);
            this.addJewDataControl1.Name = "addJewDataControl1";
            this.addJewDataControl1.processSpec = null;
            this.addJewDataControl1.Size = new System.Drawing.Size(344, 516);
            this.addJewDataControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 587);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "JewelAnalyser V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tab_spectrum.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_xAxis)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_spec)).EndInit();
            this.tab_matching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_fitting)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_inqiry.ResumeLayout(false);
            this.tab_modify.ResumeLayout(false);
            this.tab_specList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxTeeChart.AxTChart Chart_spec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_takeRecord;
        private System.Windows.Forms.Button btn_clearRecords;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_spec;
        private System.Windows.Forms.Button btn_Reflect;
        private DataGridView dataGridView1;
        private Button btn_saveDark;
        private TabControl tabControl1;
        private TabPage tab_specList;
        private SplitContainer splitContainer1;
        private TabControl tabControl2;
        private TabPage tab_spectrum;
        private TabPage tab_matching;
        private Button btn_saveReference;
        private Splitter splitter1;
        private Splitter splitter2;
        private Splitter splitter3;
        private ToolTip toolTip1;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private TabControl tabControl3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tab_inqiry;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button16;
        private Button btn_zoomOut;
        private Button btn_zoomIn;
        private AxTChart Chart_fitting;
        private Control.FittingControl fittingControl1;
        private TabPage tab_modify;
        private AddJewDataControl addJewDataControl1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox cbx_showCursor;
        private Label label2;
        private NumericUpDown nud_xAxis;
        private TableLayoutPanel tableLayoutPanel1;
        private Splitter splitter5;
        private Button btn_findPeak;
        private Splitter splitter4;
        private Button btn_deleteMarks;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 查看ToolStripMenuItem;
        private ToolStripMenuItem 数据库查询ToolStripMenuItem;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripMenuItem 参数设置ToolStripMenuItem;
        private ToolStripMenuItem 导出当前谱图ToolStripMenuItem;
        private ToolStripMenuItem 保持记录的谱图ToolStripMenuItem;
        private ToolStripMenuItem 显示ToolStripMenuItem;
        private ToolStripMenuItem 扣除暗背景谱图ToolStripMenuItem;
        private ToolStripMenuItem 寻峰设置ToolStripMenuItem;
        private ToolStripMenuItem 打开两列数据ToolStripMenuItem;
        private ToolStripMenuItem 工厂设置ToolStripMenuItem;
        private ToolStripMenuItem 工厂设置ToolStripMenuItem1;
        private ToolStripMenuItem 色带ToolStripMenuItem;
        private colorBar colorBar1;
        private ToolStripMenuItem tsMenu_colorBar;
        private ToolStripMenuItem 清除峰位ToolStripMenuItem;
        private Button btn_zoomIn2;
        //public event PropertyValueChangedEventHandler PropertyValueChanged;
    }
}

