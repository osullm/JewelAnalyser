namespace JewelApp01.Product
{
    partial class SettingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_InterTime = new System.Windows.Forms.NumericUpDown();
            this.numeric_average = new System.Windows.Forms.NumericUpDown();
            this.numeric_boxcar = new System.Windows.Forms.NumericUpDown();
            this.numeric_minWave = new System.Windows.Forms.NumericUpDown();
            this.numeric_maxWave = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_InterTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_average)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_boxcar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_minWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxWave)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.16425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.83575F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numeric_InterTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numeric_average, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numeric_boxcar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numeric_minWave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numeric_maxWave, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "检测时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "平均次数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(2, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "平滑次数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(2, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "最小波长：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "最大波长：";
            // 
            // numeric_InterTime
            // 
            this.numeric_InterTime.Location = new System.Drawing.Point(120, 2);
            this.numeric_InterTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_InterTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numeric_InterTime.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeric_InterTime.Name = "numeric_InterTime";
            this.numeric_InterTime.Size = new System.Drawing.Size(90, 21);
            this.numeric_InterTime.TabIndex = 1;
            this.numeric_InterTime.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numeric_average
            // 
            this.numeric_average.Location = new System.Drawing.Point(120, 34);
            this.numeric_average.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_average.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_average.Name = "numeric_average";
            this.numeric_average.Size = new System.Drawing.Size(90, 21);
            this.numeric_average.TabIndex = 1;
            // 
            // numeric_boxcar
            // 
            this.numeric_boxcar.Location = new System.Drawing.Point(120, 66);
            this.numeric_boxcar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_boxcar.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeric_boxcar.Name = "numeric_boxcar";
            this.numeric_boxcar.Size = new System.Drawing.Size(90, 21);
            this.numeric_boxcar.TabIndex = 1;
            // 
            // numeric_minWave
            // 
            this.numeric_minWave.Location = new System.Drawing.Point(120, 98);
            this.numeric_minWave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_minWave.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numeric_minWave.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric_minWave.Name = "numeric_minWave";
            this.numeric_minWave.Size = new System.Drawing.Size(90, 21);
            this.numeric_minWave.TabIndex = 1;
            this.numeric_minWave.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // numeric_maxWave
            // 
            this.numeric_maxWave.Location = new System.Drawing.Point(120, 130);
            this.numeric_maxWave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeric_maxWave.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_maxWave.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numeric_maxWave.Name = "numeric_maxWave";
            this.numeric_maxWave.Size = new System.Drawing.Size(90, 21);
            this.numeric_maxWave.TabIndex = 1;
            this.numeric_maxWave.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(2, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "检测模式：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "同步模式",
            "软触发",
            "高位触发",
            "硬件触发"});
            this.comboBox1.Location = new System.Drawing.Point(120, 162);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "确  定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "关  闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_InterTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_average)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_boxcar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_minWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxWave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_InterTime;
        private System.Windows.Forms.NumericUpDown numeric_average;
        private System.Windows.Forms.NumericUpDown numeric_boxcar;
        private System.Windows.Forms.NumericUpDown numeric_minWave;
        private System.Windows.Forms.NumericUpDown numeric_maxWave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}