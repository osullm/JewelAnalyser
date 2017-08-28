namespace JewelApp01.Product
{
    partial class Form_factorySetting
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
            this.lbl_reCount = new System.Windows.Forms.Label();
            this.dgv_searchRe = new System.Windows.Forms.DataGridView();
            this.clm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_JewClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_creator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置为厂家谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置为客户谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改谱图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchRe)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_reCount
            // 
            this.lbl_reCount.AutoSize = true;
            this.lbl_reCount.Location = new System.Drawing.Point(25, 182);
            this.lbl_reCount.Name = "lbl_reCount";
            this.lbl_reCount.Size = new System.Drawing.Size(82, 15);
            this.lbl_reCount.TabIndex = 18;
            this.lbl_reCount.Text = "查找结果：";
            // 
            // dgv_searchRe
            // 
            this.dgv_searchRe.AllowUserToAddRows = false;
            this.dgv_searchRe.AllowUserToDeleteRows = false;
            this.dgv_searchRe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_searchRe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_searchRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_ID,
            this.clm_Name,
            this.clm_JewClass,
            this.clm_AddTime,
            this.clm_Creator,
            this.clm_Remark});
            this.dgv_searchRe.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_searchRe.Location = new System.Drawing.Point(220, 12);
            this.dgv_searchRe.MultiSelect = false;
            this.dgv_searchRe.Name = "dgv_searchRe";
            this.dgv_searchRe.RowHeadersVisible = false;
            this.dgv_searchRe.RowTemplate.Height = 27;
            this.dgv_searchRe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_searchRe.Size = new System.Drawing.Size(557, 483);
            this.dgv_searchRe.TabIndex = 17;
            this.dgv_searchRe.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_searchRe_CellMouseDown);
            // 
            // clm_ID
            // 
            this.clm_ID.HeaderText = "ID";
            this.clm_ID.Name = "clm_ID";
            // 
            // clm_Name
            // 
            this.clm_Name.HeaderText = "Name";
            this.clm_Name.Name = "clm_Name";
            // 
            // clm_JewClass
            // 
            this.clm_JewClass.HeaderText = "JewClass";
            this.clm_JewClass.Name = "clm_JewClass";
            // 
            // clm_AddTime
            // 
            this.clm_AddTime.HeaderText = "AddTime";
            this.clm_AddTime.Name = "clm_AddTime";
            // 
            // clm_Creator
            // 
            this.clm_Creator.HeaderText = "Creator";
            this.clm_Creator.Name = "clm_Creator";
            // 
            // clm_Remark
            // 
            this.clm_Remark.HeaderText = "Remark";
            this.clm_Remark.Name = "clm_Remark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "创建者：";
            // 
            // cbx_creator
            // 
            this.cbx_creator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_creator.FormattingEnabled = true;
            this.cbx_creator.Location = new System.Drawing.Point(92, 124);
            this.cbx_creator.Name = "cbx_creator";
            this.cbx_creator.Size = new System.Drawing.Size(121, 23);
            this.cbx_creator.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "类目：";
            // 
            // cbx_class
            // 
            this.cbx_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Location = new System.Drawing.Point(92, 79);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(121, 23);
            this.cbx_class.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "关键字：";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(95, 27);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(119, 25);
            this.txt_key.TabIndex = 11;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(92, 228);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 34);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除谱图ToolStripMenuItem,
            this.修改谱图ToolStripMenuItem,
            this.导出谱图ToolStripMenuItem,
            this.设置为客户谱图ToolStripMenuItem,
            this.设置为厂家谱图ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 162);
            // 
            // 设置为厂家谱图ToolStripMenuItem
            // 
            this.设置为厂家谱图ToolStripMenuItem.Name = "设置为厂家谱图ToolStripMenuItem";
            this.设置为厂家谱图ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.设置为厂家谱图ToolStripMenuItem.Text = "设置为厂家数据";
            // 
            // 设置为客户谱图ToolStripMenuItem
            // 
            this.设置为客户谱图ToolStripMenuItem.Name = "设置为客户谱图ToolStripMenuItem";
            this.设置为客户谱图ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.设置为客户谱图ToolStripMenuItem.Text = "设置为客户数据";
            this.设置为客户谱图ToolStripMenuItem.Click += new System.EventHandler(this.设置为客户谱图ToolStripMenuItem_Click);
            // 
            // 导出谱图ToolStripMenuItem
            // 
            this.导出谱图ToolStripMenuItem.Name = "导出谱图ToolStripMenuItem";
            this.导出谱图ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.导出谱图ToolStripMenuItem.Text = "导出数据";
            this.导出谱图ToolStripMenuItem.Click += new System.EventHandler(this.导出谱图ToolStripMenuItem_Click);
            // 
            // 删除谱图ToolStripMenuItem
            // 
            this.删除谱图ToolStripMenuItem.Name = "删除谱图ToolStripMenuItem";
            this.删除谱图ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.删除谱图ToolStripMenuItem.Text = "删除数据";
            this.删除谱图ToolStripMenuItem.Click += new System.EventHandler(this.删除谱图ToolStripMenuItem_Click);
            // 
            // 修改谱图ToolStripMenuItem
            // 
            this.修改谱图ToolStripMenuItem.Name = "修改谱图ToolStripMenuItem";
            this.修改谱图ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.修改谱图ToolStripMenuItem.Text = "修改数据";
            this.修改谱图ToolStripMenuItem.Click += new System.EventHandler(this.修改谱图ToolStripMenuItem_Click);
            // 
            // Form_factorySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 507);
            this.Controls.Add(this.lbl_reCount);
            this.Controls.Add(this.dgv_searchRe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_creator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_class);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.btn_search);
            this.Name = "Form_factorySetting";
            this.Text = "Form_factorySetting";
            this.Load += new System.EventHandler(this.Form_factorySetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchRe)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reCount;
        private System.Windows.Forms.DataGridView dgv_searchRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_JewClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_creator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置为厂家谱图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置为客户谱图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出谱图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除谱图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改谱图ToolStripMenuItem;
    }
}