namespace JewelApp01.Product
{
    partial class SqlData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlData));
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_creator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_searchRe = new System.Windows.Forms.DataGridView();
            this.clm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_JewClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_factoryState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.导出到光谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_reCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.axTChart1 = new AxTeeChart.AxTChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchRe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(76, 191);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(63, 27);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(79, 30);
            this.txt_key.Margin = new System.Windows.Forms.Padding(2);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(90, 21);
            this.txt_key.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键字：";
            // 
            // cbx_class
            // 
            this.cbx_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(76, 72);
            this.cbx_class.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(92, 20);
            this.cbx_class.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "类目：";
            // 
            // cbx_creator
            // 
            this.cbx_creator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_creator.FormattingEnabled = true;
            this.cbx_creator.Location = new System.Drawing.Point(76, 108);
            this.cbx_creator.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_creator.Name = "cbx_creator";
            this.cbx_creator.Size = new System.Drawing.Size(92, 20);
            this.cbx_creator.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "创建者：";
            // 
            // dgv_searchRe
            // 
            this.dgv_searchRe.AllowUserToAddRows = false;
            this.dgv_searchRe.AllowUserToDeleteRows = false;
            this.dgv_searchRe.AllowUserToResizeRows = false;
            this.dgv_searchRe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_searchRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ID,
            this.clm_Name,
            this.clm_JewClass,
            this.clm_AddTime,
            this.clm_Creator,
            this.clm_Remark,
            this.clm_factoryState});
            this.dgv_searchRe.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_searchRe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_searchRe.Location = new System.Drawing.Point(227, 2);
            this.dgv_searchRe.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_searchRe.MultiSelect = false;
            this.dgv_searchRe.Name = "dgv_searchRe";
            this.dgv_searchRe.RowHeadersVisible = false;
            this.dgv_searchRe.RowTemplate.Height = 27;
            this.dgv_searchRe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_searchRe.Size = new System.Drawing.Size(331, 219);
            this.dgv_searchRe.TabIndex = 8;
            this.dgv_searchRe.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_searchRe_CellMouseDown);
            this.dgv_searchRe.SelectionChanged += new System.EventHandler(this.dgv_searchRe_SelectionChanged);
            // 
            // clm_ID
            // 
            this.clm_ID.HeaderText = "ID";
            this.clm_ID.Name = "clm_ID";
            this.clm_ID.ReadOnly = true;
            // 
            // clm_Name
            // 
            this.clm_Name.HeaderText = "Name";
            this.clm_Name.Name = "clm_Name";
            this.clm_Name.ReadOnly = true;
            // 
            // clm_JewClass
            // 
            this.clm_JewClass.HeaderText = "JewClass";
            this.clm_JewClass.Name = "clm_JewClass";
            this.clm_JewClass.ReadOnly = true;
            // 
            // clm_AddTime
            // 
            this.clm_AddTime.HeaderText = "AddTime";
            this.clm_AddTime.Name = "clm_AddTime";
            this.clm_AddTime.ReadOnly = true;
            // 
            // clm_Creator
            // 
            this.clm_Creator.HeaderText = "Creator";
            this.clm_Creator.Name = "clm_Creator";
            this.clm_Creator.ReadOnly = true;
            // 
            // clm_Remark
            // 
            this.clm_Remark.HeaderText = "Remark";
            this.clm_Remark.Name = "clm_Remark";
            this.clm_Remark.ReadOnly = true;
            // 
            // clm_factoryState
            // 
            this.clm_factoryState.HeaderText = "FactoryState";
            this.clm_factoryState.Name = "clm_factoryState";
            this.clm_factoryState.ReadOnly = true;
            this.clm_factoryState.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.导出到光谱图ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "删除数据";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "修改数据";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem3.Text = "导出数据";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 导出到光谱图ToolStripMenuItem
            // 
            this.导出到光谱图ToolStripMenuItem.Name = "导出到光谱图ToolStripMenuItem";
            this.导出到光谱图ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导出到光谱图ToolStripMenuItem.Text = "加入光谱图";
            this.导出到光谱图ToolStripMenuItem.Click += new System.EventHandler(this.导出到光谱图ToolStripMenuItem_Click);
            // 
            // lbl_reCount
            // 
            this.lbl_reCount.AutoSize = true;
            this.lbl_reCount.Location = new System.Drawing.Point(26, 154);
            this.lbl_reCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_reCount.Name = "lbl_reCount";
            this.lbl_reCount.Size = new System.Drawing.Size(65, 12);
            this.lbl_reCount.TabIndex = 9;
            this.lbl_reCount.Text = "查找结果：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_searchRe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 223);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbl_reCount);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.cbx_class);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_creator);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(221, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索设置";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.axTChart1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(974, 568);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // axTChart1
            // 
            this.axTChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTChart1.Enabled = true;
            this.axTChart1.Location = new System.Drawing.Point(3, 230);
            this.axTChart1.Name = "axTChart1";
            this.axTChart1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTChart1.OcxState")));
            this.axTChart1.Size = new System.Drawing.Size(968, 335);
            this.axTChart1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(638, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(329, 217);
            this.dataGridView1.TabIndex = 10;
            // 
            // column1
            // 
            this.column1.HeaderText = "真标记";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // column2
            // 
            this.column2.HeaderText = "伪标记";
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            // 
            // SqlData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 587);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SqlData";
            this.Text = "SqlData";
            this.Load += new System.EventHandler(this.SqlData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchRe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Label label1;
        private AxTeeChart.AxTChart axTChart1;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_creator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_searchRe;
        private System.Windows.Forms.Label lbl_reCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_JewClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_factoryState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem 导出到光谱图ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
    }
}