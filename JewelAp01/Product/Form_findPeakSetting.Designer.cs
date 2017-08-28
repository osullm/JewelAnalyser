namespace JewelApp01.Product
{
    partial class Form_findPeakSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.nud_smoothWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_peakWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbx_Derection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_threshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_smoothWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peakWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threshold)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "平滑宽度：";
            // 
            // nud_smoothWidth
            // 
            this.nud_smoothWidth.Location = new System.Drawing.Point(138, 30);
            this.nud_smoothWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_smoothWidth.Name = "nud_smoothWidth";
            this.nud_smoothWidth.Size = new System.Drawing.Size(90, 21);
            this.nud_smoothWidth.TabIndex = 2;
            this.nud_smoothWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "寻峰宽度：";
            // 
            // nud_peakWidth
            // 
            this.nud_peakWidth.Location = new System.Drawing.Point(138, 75);
            this.nud_peakWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_peakWidth.Name = "nud_peakWidth";
            this.nud_peakWidth.Size = new System.Drawing.Size(90, 21);
            this.nud_peakWidth.TabIndex = 2;
            this.nud_peakWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "方    向：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbx_Derection
            // 
            this.cbx_Derection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Derection.FormattingEnabled = true;
            this.cbx_Derection.Items.AddRange(new object[] {
            "凹峰",
            "突峰",
            "双向"});
            this.cbx_Derection.Location = new System.Drawing.Point(138, 165);
            this.cbx_Derection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbx_Derection.Name = "cbx_Derection";
            this.cbx_Derection.Size = new System.Drawing.Size(92, 20);
            this.cbx_Derection.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "阈    值：";
            // 
            // nud_threshold
            // 
            this.nud_threshold.Location = new System.Drawing.Point(140, 120);
            this.nud_threshold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_threshold.Name = "nud_threshold";
            this.nud_threshold.Size = new System.Drawing.Size(90, 21);
            this.nud_threshold.TabIndex = 2;
            this.nud_threshold.Tag = "";
            this.nud_threshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form_findPeakSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 290);
            this.ControlBox = false;
            this.Controls.Add(this.cbx_Derection);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nud_threshold);
            this.Controls.Add(this.nud_peakWidth);
            this.Controls.Add(this.nud_smoothWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_findPeakSetting";
            this.Text = "Form_findPeakSetting";
            this.Load += new System.EventHandler(this.Form_findPeakSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_smoothWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peakWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_smoothWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_peakWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbx_Derection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_threshold;
    }
}