namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbProb1 = new System.Windows.Forms.Label();
            this.lbProb2 = new System.Windows.Forms.Label();
            this.lbProb3 = new System.Windows.Forms.Label();
            this.lbProb4 = new System.Windows.Forms.Label();
            this.lbProb5 = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbAv = new System.Windows.Forms.Label();
            this.lbVar = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbProb1 = new System.Windows.Forms.NumericUpDown();
            this.tbProb2 = new System.Windows.Forms.NumericUpDown();
            this.tbProb3 = new System.Windows.Forms.NumericUpDown();
            this.tbProb4 = new System.Windows.Forms.NumericUpDown();
            this.tbNum = new System.Windows.Forms.NumericUpDown();
            this.tbProb5 = new System.Windows.Forms.TextBox();
            this.btResult = new System.Windows.Forms.Button();
            this.lbChi = new System.Windows.Forms.Label();
            this.tbVar = new System.Windows.Forms.TextBox();
            this.tbAv = new System.Windows.Forms.TextBox();
            this.tbCompare = new System.Windows.Forms.TextBox();
            this.tbChi = new System.Windows.Forms.TextBox();
            this.lbAvErr = new System.Windows.Forms.Label();
            this.lbVarErr = new System.Windows.Forms.Label();
            this.tbVarErr = new System.Windows.Forms.TextBox();
            this.tbAvErr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProb1
            // 
            this.lbProb1.AutoSize = true;
            this.lbProb1.Location = new System.Drawing.Point(91, 78);
            this.lbProb1.Name = "lbProb1";
            this.lbProb1.Size = new System.Drawing.Size(155, 20);
            this.lbProb1.TabIndex = 0;
            this.lbProb1.Text = "Probability of event 1";
            // 
            // lbProb2
            // 
            this.lbProb2.AutoSize = true;
            this.lbProb2.Location = new System.Drawing.Point(91, 119);
            this.lbProb2.Name = "lbProb2";
            this.lbProb2.Size = new System.Drawing.Size(155, 20);
            this.lbProb2.TabIndex = 1;
            this.lbProb2.Text = "Probability of event 2";
            // 
            // lbProb3
            // 
            this.lbProb3.AutoSize = true;
            this.lbProb3.Location = new System.Drawing.Point(91, 161);
            this.lbProb3.Name = "lbProb3";
            this.lbProb3.Size = new System.Drawing.Size(155, 20);
            this.lbProb3.TabIndex = 2;
            this.lbProb3.Text = "Probability of event 3";
            // 
            // lbProb4
            // 
            this.lbProb4.AutoSize = true;
            this.lbProb4.Location = new System.Drawing.Point(91, 205);
            this.lbProb4.Name = "lbProb4";
            this.lbProb4.Size = new System.Drawing.Size(155, 20);
            this.lbProb4.TabIndex = 3;
            this.lbProb4.Text = "Probability of event 4";
            // 
            // lbProb5
            // 
            this.lbProb5.AutoSize = true;
            this.lbProb5.Location = new System.Drawing.Point(91, 253);
            this.lbProb5.Name = "lbProb5";
            this.lbProb5.Size = new System.Drawing.Size(155, 20);
            this.lbProb5.TabIndex = 4;
            this.lbProb5.Text = "Probability of event 5";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(91, 313);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(134, 20);
            this.lbNum.TabIndex = 5;
            this.lbNum.Text = "Number of events";
            // 
            // lbAv
            // 
            this.lbAv.AutoSize = true;
            this.lbAv.Location = new System.Drawing.Point(482, 429);
            this.lbAv.Name = "lbAv";
            this.lbAv.Size = new System.Drawing.Size(68, 20);
            this.lbAv.TabIndex = 6;
            this.lbAv.Text = "Average";
            // 
            // lbVar
            // 
            this.lbVar.AutoSize = true;
            this.lbVar.Location = new System.Drawing.Point(482, 467);
            this.lbVar.Name = "lbVar";
            this.lbVar.Size = new System.Drawing.Size(72, 20);
            this.lbVar.TabIndex = 7;
            this.lbVar.Text = "Varience";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(486, 56);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(516, 340);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // tbProb1
            // 
            this.tbProb1.DecimalPlaces = 2;
            this.tbProb1.Location = new System.Drawing.Point(314, 76);
            this.tbProb1.Name = "tbProb1";
            this.tbProb1.Size = new System.Drawing.Size(120, 26);
            this.tbProb1.TabIndex = 9;
            this.tbProb1.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            // 
            // tbProb2
            // 
            this.tbProb2.DecimalPlaces = 2;
            this.tbProb2.Location = new System.Drawing.Point(314, 117);
            this.tbProb2.Name = "tbProb2";
            this.tbProb2.Size = new System.Drawing.Size(120, 26);
            this.tbProb2.TabIndex = 10;
            this.tbProb2.Value = new decimal(new int[] {
            24,
            0,
            0,
            131072});
            // 
            // tbProb3
            // 
            this.tbProb3.DecimalPlaces = 2;
            this.tbProb3.Location = new System.Drawing.Point(314, 159);
            this.tbProb3.Name = "tbProb3";
            this.tbProb3.Size = new System.Drawing.Size(120, 26);
            this.tbProb3.TabIndex = 11;
            this.tbProb3.Value = new decimal(new int[] {
            17,
            0,
            0,
            131072});
            // 
            // tbProb4
            // 
            this.tbProb4.DecimalPlaces = 2;
            this.tbProb4.Location = new System.Drawing.Point(314, 203);
            this.tbProb4.Name = "tbProb4";
            this.tbProb4.Size = new System.Drawing.Size(120, 26);
            this.tbProb4.TabIndex = 12;
            this.tbProb4.Value = new decimal(new int[] {
            31,
            0,
            0,
            131072});
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(314, 311);
            this.tbNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(120, 26);
            this.tbNum.TabIndex = 13;
            this.tbNum.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbProb5
            // 
            this.tbProb5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProb5.Location = new System.Drawing.Point(314, 250);
            this.tbProb5.Multiline = true;
            this.tbProb5.Name = "tbProb5";
            this.tbProb5.Size = new System.Drawing.Size(120, 23);
            this.tbProb5.TabIndex = 14;
            this.tbProb5.Text = "auto";
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(161, 449);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(163, 57);
            this.btResult.TabIndex = 15;
            this.btResult.Text = "Show result";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // lbChi
            // 
            this.lbChi.AutoSize = true;
            this.lbChi.Location = new System.Drawing.Point(482, 509);
            this.lbChi.Name = "lbChi";
            this.lbChi.Size = new System.Drawing.Size(32, 20);
            this.lbChi.TabIndex = 16;
            this.lbChi.Text = "Chi";
            // 
            // tbVar
            // 
            this.tbVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVar.Location = new System.Drawing.Point(571, 464);
            this.tbVar.Name = "tbVar";
            this.tbVar.Size = new System.Drawing.Size(100, 19);
            this.tbVar.TabIndex = 17;
            // 
            // tbAv
            // 
            this.tbAv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAv.Location = new System.Drawing.Point(571, 426);
            this.tbAv.Name = "tbAv";
            this.tbAv.Size = new System.Drawing.Size(100, 19);
            this.tbAv.TabIndex = 18;
            // 
            // tbCompare
            // 
            this.tbCompare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompare.Location = new System.Drawing.Point(677, 506);
            this.tbCompare.Name = "tbCompare";
            this.tbCompare.Size = new System.Drawing.Size(224, 19);
            this.tbCompare.TabIndex = 19;
            // 
            // tbChi
            // 
            this.tbChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbChi.Location = new System.Drawing.Point(571, 506);
            this.tbChi.Name = "tbChi";
            this.tbChi.Size = new System.Drawing.Size(100, 19);
            this.tbChi.TabIndex = 20;
            // 
            // lbAvErr
            // 
            this.lbAvErr.AutoSize = true;
            this.lbAvErr.Location = new System.Drawing.Point(685, 429);
            this.lbAvErr.Name = "lbAvErr";
            this.lbAvErr.Size = new System.Drawing.Size(44, 20);
            this.lbAvErr.TabIndex = 21;
            this.lbAvErr.Text = "Error";
            // 
            // lbVarErr
            // 
            this.lbVarErr.AutoSize = true;
            this.lbVarErr.Location = new System.Drawing.Point(685, 467);
            this.lbVarErr.Name = "lbVarErr";
            this.lbVarErr.Size = new System.Drawing.Size(44, 20);
            this.lbVarErr.TabIndex = 22;
            this.lbVarErr.Text = "Error";
            // 
            // tbVarErr
            // 
            this.tbVarErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVarErr.Location = new System.Drawing.Point(745, 464);
            this.tbVarErr.Name = "tbVarErr";
            this.tbVarErr.Size = new System.Drawing.Size(100, 19);
            this.tbVarErr.TabIndex = 23;
            // 
            // tbAvErr
            // 
            this.tbAvErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAvErr.Location = new System.Drawing.Point(745, 426);
            this.tbAvErr.Name = "tbAvErr";
            this.tbAvErr.Size = new System.Drawing.Size(100, 19);
            this.tbAvErr.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 556);
            this.Controls.Add(this.tbAvErr);
            this.Controls.Add(this.tbVarErr);
            this.Controls.Add(this.lbVarErr);
            this.Controls.Add(this.lbAvErr);
            this.Controls.Add(this.tbChi);
            this.Controls.Add(this.tbCompare);
            this.Controls.Add(this.tbAv);
            this.Controls.Add(this.tbVar);
            this.Controls.Add(this.lbChi);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.tbProb5);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.tbProb4);
            this.Controls.Add(this.tbProb3);
            this.Controls.Add(this.tbProb2);
            this.Controls.Add(this.tbProb1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbVar);
            this.Controls.Add(this.lbAv);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbProb5);
            this.Controls.Add(this.lbProb4);
            this.Controls.Add(this.lbProb3);
            this.Controls.Add(this.lbProb2);
            this.Controls.Add(this.lbProb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProb1;
        private System.Windows.Forms.Label lbProb2;
        private System.Windows.Forms.Label lbProb3;
        private System.Windows.Forms.Label lbProb4;
        private System.Windows.Forms.Label lbProb5;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbAv;
        private System.Windows.Forms.Label lbVar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown tbProb1;
        private System.Windows.Forms.NumericUpDown tbProb2;
        private System.Windows.Forms.NumericUpDown tbProb3;
        private System.Windows.Forms.NumericUpDown tbProb4;
        private System.Windows.Forms.NumericUpDown tbNum;
        private System.Windows.Forms.TextBox tbProb5;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Label lbChi;
        private System.Windows.Forms.TextBox tbVar;
        private System.Windows.Forms.TextBox tbAv;
        private System.Windows.Forms.TextBox tbCompare;
        private System.Windows.Forms.TextBox tbChi;
        private System.Windows.Forms.Label lbAvErr;
        private System.Windows.Forms.Label lbVarErr;
        private System.Windows.Forms.TextBox tbVarErr;
        private System.Windows.Forms.TextBox tbAvErr;
    }
}

