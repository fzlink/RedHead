namespace RedHead
{
    partial class DiagnosticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.costChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.maxLenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.deqChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deqChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.timeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.timeChart.Legends.Add(legend1);
            this.timeChart.Location = new System.Drawing.Point(29, 543);
            this.timeChart.Name = "timeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Time";
            this.timeChart.Series.Add(series1);
            this.timeChart.Size = new System.Drawing.Size(307, 290);
            this.timeChart.TabIndex = 0;
            this.timeChart.Text = "chart1";
            // 
            // costChart
            // 
            chartArea2.Name = "ChartArea1";
            this.costChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.costChart.Legends.Add(legend2);
            this.costChart.Location = new System.Drawing.Point(342, 543);
            this.costChart.Name = "costChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Cost";
            this.costChart.Series.Add(series2);
            this.costChart.Size = new System.Drawing.Size(290, 290);
            this.costChart.TabIndex = 1;
            this.costChart.Text = "chart2";
            // 
            // maxLenChart
            // 
            chartArea3.Name = "ChartArea1";
            this.maxLenChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.maxLenChart.Legends.Add(legend3);
            this.maxLenChart.Location = new System.Drawing.Point(638, 543);
            this.maxLenChart.Name = "maxLenChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Max Queue Len";
            this.maxLenChart.Series.Add(series3);
            this.maxLenChart.Size = new System.Drawing.Size(365, 290);
            this.maxLenChart.TabIndex = 2;
            this.maxLenChart.Text = "chart3";
            // 
            // deqChart
            // 
            chartArea4.Name = "ChartArea1";
            this.deqChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.deqChart.Legends.Add(legend4);
            this.deqChart.Location = new System.Drawing.Point(1009, 543);
            this.deqChart.Name = "deqChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Dequeue Count";
            this.deqChart.Series.Add(series4);
            this.deqChart.Size = new System.Drawing.Size(299, 290);
            this.deqChart.TabIndex = 3;
            this.deqChart.Text = "chart4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(685, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(554, 437);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Best First Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(950, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "A*";
            // 
            // DiagnosticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 845);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deqChart);
            this.Controls.Add(this.maxLenChart);
            this.Controls.Add(this.costChart);
            this.Controls.Add(this.timeChart);
            this.Name = "DiagnosticsForm";
            this.Text = "DiagnosticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLenChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deqChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart costChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart maxLenChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart deqChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}