namespace JewelApp01.Control
{
    partial class AddJewDataControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.lbl_chooseClass = new System.Windows.Forms.Label();
            this.btn_addJewData = new System.Windows.Forms.Button();
            this.btn_classManager = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_peopleManager = new System.Windows.Forms.Button();
            this.rtb_remark = new System.Windows.Forms.RichTextBox();
            this.cbx_people = new System.Windows.Forms.ComboBox();
            this.dgv_sign = new System.Windows.Forms.DataGridView();
            this.clum_realSample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clum_unreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenu_sign = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sign)).BeginInit();
            this.ctxMenu_sign.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_class
            // 
            this.cbx_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(71, 2);
            this.cbx_class.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(92, 20);
            this.cbx_class.TabIndex = 0;
            // 
            // lbl_chooseClass
            // 
            this.lbl_chooseClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_chooseClass.AutoSize = true;
            this.lbl_chooseClass.Location = new System.Drawing.Point(2, 8);
            this.lbl_chooseClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chooseClass.Name = "lbl_chooseClass";
            this.lbl_chooseClass.Size = new System.Drawing.Size(65, 12);
            this.lbl_chooseClass.TabIndex = 1;
            this.lbl_chooseClass.Text = "选择类目：";
            // 
            // btn_addJewData
            // 
            this.btn_addJewData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addJewData.Location = new System.Drawing.Point(123, 432);
            this.btn_addJewData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addJewData.Name = "btn_addJewData";
            this.btn_addJewData.Size = new System.Drawing.Size(74, 30);
            this.btn_addJewData.TabIndex = 3;
            this.btn_addJewData.Text = "添加";
            this.btn_addJewData.UseVisualStyleBackColor = true;
            this.btn_addJewData.Click += new System.EventHandler(this.btn_addJewData_Click);
            // 
            // btn_classManager
            // 
            this.btn_classManager.Location = new System.Drawing.Point(167, 2);
            this.btn_classManager.Margin = new System.Windows.Forms.Padding(2);
            this.btn_classManager.Name = "btn_classManager";
            this.btn_classManager.Size = new System.Drawing.Size(80, 25);
            this.btn_classManager.TabIndex = 4;
            this.btn_classManager.Text = "管理类目";
            this.btn_classManager.UseVisualStyleBackColor = true;
            this.btn_classManager.Click += new System.EventHandler(this.btn_classManager_Click);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_name.Location = new System.Drawing.Point(71, 2);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(76, 21);
            this.txt_name.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(2, 6);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 12);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "样品名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "录 入 人：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "备注：";
            // 
            // btn_peopleManager
            // 
            this.btn_peopleManager.Location = new System.Drawing.Point(167, 2);
            this.btn_peopleManager.Margin = new System.Windows.Forms.Padding(2);
            this.btn_peopleManager.Name = "btn_peopleManager";
            this.btn_peopleManager.Size = new System.Drawing.Size(80, 25);
            this.btn_peopleManager.TabIndex = 4;
            this.btn_peopleManager.Text = "管理人员";
            this.btn_peopleManager.UseVisualStyleBackColor = true;
            this.btn_peopleManager.Click += new System.EventHandler(this.btn_peopleManager_Click);
            // 
            // rtb_remark
            // 
            this.rtb_remark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_remark.Location = new System.Drawing.Point(2, 142);
            this.rtb_remark.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_remark.Name = "rtb_remark";
            this.rtb_remark.Size = new System.Drawing.Size(316, 116);
            this.rtb_remark.TabIndex = 6;
            this.rtb_remark.Text = "";
            // 
            // cbx_people
            // 
            this.cbx_people.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_people.FormattingEnabled = true;
            this.cbx_people.Location = new System.Drawing.Point(71, 2);
            this.cbx_people.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_people.Name = "cbx_people";
            this.cbx_people.Size = new System.Drawing.Size(92, 20);
            this.cbx_people.TabIndex = 0;
            // 
            // dgv_sign
            // 
            this.dgv_sign.AllowUserToAddRows = false;
            this.dgv_sign.AllowUserToDeleteRows = false;
            this.dgv_sign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clum_realSample,
            this.clum_unreal});
            this.dgv_sign.ContextMenuStrip = this.ctxMenu_sign;
            this.dgv_sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sign.Location = new System.Drawing.Point(3, 263);
            this.dgv_sign.Name = "dgv_sign";
            this.dgv_sign.RowHeadersVisible = false;
            this.dgv_sign.RowTemplate.Height = 23;
            this.dgv_sign.Size = new System.Drawing.Size(314, 161);
            this.dgv_sign.TabIndex = 7;
            // 
            // clum_realSample
            // 
            this.clum_realSample.HeaderText = "真品标记";
            this.clum_realSample.Name = "clum_realSample";
            // 
            // clum_unreal
            // 
            this.clum_unreal.HeaderText = "伪品标记";
            this.clum_unreal.Name = "clum_unreal";
            // 
            // ctxMenu_sign
            // 
            this.ctxMenu_sign.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加行ToolStripMenuItem,
            this.删除行ToolStripMenuItem});
            this.ctxMenu_sign.Name = "ctxMenu_sign";
            this.ctxMenu_sign.Size = new System.Drawing.Size(113, 48);
            // 
            // 添加行ToolStripMenuItem
            // 
            this.添加行ToolStripMenuItem.Name = "添加行ToolStripMenuItem";
            this.添加行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.添加行ToolStripMenuItem.Text = "添加行";
            this.添加行ToolStripMenuItem.Click += new System.EventHandler(this.添加行ToolStripMenuItem_Click);
            // 
            // 删除行ToolStripMenuItem
            // 
            this.删除行ToolStripMenuItem.Name = "删除行ToolStripMenuItem";
            this.删除行ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除行ToolStripMenuItem.Text = "删除行";
            this.删除行ToolStripMenuItem.Click += new System.EventHandler(this.删除行ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_sign, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_addJewData, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rtb_remark, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 539);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_name);
            this.flowLayoutPanel1.Controls.Add(this.txt_name);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl_chooseClass);
            this.flowLayoutPanel2.Controls.Add(this.cbx_class);
            this.flowLayoutPanel2.Controls.Add(this.btn_classManager);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cbx_people);
            this.flowLayoutPanel3.Controls.Add(this.btn_peopleManager);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 73);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(314, 29);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // AddJewDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddJewDataControl";
            this.Size = new System.Drawing.Size(320, 539);
            this.Load += new System.EventHandler(this.AddJewDataControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sign)).EndInit();
            this.ctxMenu_sign.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label lbl_chooseClass;
        private System.Windows.Forms.Button btn_addJewData;
        private System.Windows.Forms.Button btn_classManager;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_peopleManager;
        private System.Windows.Forms.RichTextBox rtb_remark;
        private System.Windows.Forms.ComboBox cbx_people;
        private System.Windows.Forms.DataGridView dgv_sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn clum_realSample;
        private System.Windows.Forms.DataGridViewTextBoxColumn clum_unreal;
        private System.Windows.Forms.ContextMenuStrip ctxMenu_sign;
        private System.Windows.Forms.ToolStripMenuItem 添加行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除行ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
