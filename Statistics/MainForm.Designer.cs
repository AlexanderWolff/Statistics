namespace Statistics
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_load = new System.Windows.Forms.Button();
            this.radioButton_file = new System.Windows.Forms.RadioButton();
            this.radioButton_generate = new System.Windows.Forms.RadioButton();
            this.richTextBox_data = new System.Windows.Forms.RichTextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.chart_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_mean = new System.Windows.Forms.Label();
            this.label_standarddeviaiton = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).BeginInit();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(86, 12);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(81, 22);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load Data";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // radioButton_file
            // 
            this.radioButton_file.AutoSize = true;
            this.radioButton_file.Checked = true;
            this.radioButton_file.Location = new System.Drawing.Point(12, 15);
            this.radioButton_file.Name = "radioButton_file";
            this.radioButton_file.Size = new System.Drawing.Size(41, 17);
            this.radioButton_file.TabIndex = 1;
            this.radioButton_file.TabStop = true;
            this.radioButton_file.Text = "File";
            this.radioButton_file.UseVisualStyleBackColor = true;
            // 
            // radioButton_generate
            // 
            this.radioButton_generate.AutoSize = true;
            this.radioButton_generate.Location = new System.Drawing.Point(12, 38);
            this.radioButton_generate.Name = "radioButton_generate";
            this.radioButton_generate.Size = new System.Drawing.Size(69, 17);
            this.radioButton_generate.TabIndex = 2;
            this.radioButton_generate.Text = "Generate";
            this.radioButton_generate.UseVisualStyleBackColor = true;
            // 
            // richTextBox_data
            // 
            this.richTextBox_data.BackColor = System.Drawing.Color.White;
            this.richTextBox_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_data.Location = new System.Drawing.Point(12, 61);
            this.richTextBox_data.Name = "richTextBox_data";
            this.richTextBox_data.ReadOnly = true;
            this.richTextBox_data.Size = new System.Drawing.Size(155, 345);
            this.richTextBox_data.TabIndex = 3;
            this.richTextBox_data.Text = "";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(86, 38);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown.TabIndex = 4;
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart_data
            // 
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX2.Maximum = 100D;
            chartArea5.AxisX2.Minimum = 0D;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.Name = "ChartArea1";
            this.chart_data.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chart_data.Legends.Add(legend5);
            this.chart_data.Location = new System.Drawing.Point(173, 61);
            this.chart_data.Name = "chart_data";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "bins";
            series9.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series10.Legend = "Legend1";
            series10.MarkerSize = 2;
            series10.Name = "datapoints";
            this.chart_data.Series.Add(series9);
            this.chart_data.Series.Add(series10);
            this.chart_data.Size = new System.Drawing.Size(527, 345);
            this.chart_data.TabIndex = 6;
            // 
            // label_mean
            // 
            this.label_mean.AutoSize = true;
            this.label_mean.Location = new System.Drawing.Point(190, 17);
            this.label_mean.Name = "label_mean";
            this.label_mean.Size = new System.Drawing.Size(83, 13);
            this.label_mean.TabIndex = 7;
            this.label_mean.Text = "Arithmetic Mean";
            // 
            // label_standarddeviaiton
            // 
            this.label_standarddeviaiton.AutoSize = true;
            this.label_standarddeviaiton.Location = new System.Drawing.Point(190, 40);
            this.label_standarddeviaiton.Name = "label_standarddeviaiton";
            this.label_standarddeviaiton.Size = new System.Drawing.Size(98, 13);
            this.label_standarddeviaiton.TabIndex = 8;
            this.label_standarddeviaiton.Text = "Standard Deviation";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "CSV Files|*.csv";
            this.openFileDialog.Title = "Open CSV";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 418);
            this.Controls.Add(this.label_standarddeviaiton);
            this.Controls.Add(this.label_mean);
            this.Controls.Add(this.chart_data);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.richTextBox_data);
            this.Controls.Add(this.radioButton_generate);
            this.Controls.Add(this.radioButton_file);
            this.Controls.Add(this.button_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.RadioButton radioButton_file;
        private System.Windows.Forms.RadioButton radioButton_generate;
        private System.Windows.Forms.RichTextBox richTextBox_data;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_data;
        private System.Windows.Forms.Label label_mean;
        private System.Windows.Forms.Label label_standarddeviaiton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

