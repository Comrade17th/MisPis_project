namespace MisPis_WFA
{
    partial class FormUnit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelUnitText = new System.Windows.Forms.Label();
            this.buttonTestType1 = new System.Windows.Forms.Button();
            this.buttonTestType2 = new System.Windows.Forms.Button();
            this.buttonTestType3 = new System.Windows.Forms.Button();
            this.chartUnit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUnitText
            // 
            this.labelUnitText.AutoSize = true;
            this.labelUnitText.Location = new System.Drawing.Point(317, 46);
            this.labelUnitText.Name = "labelUnitText";
            this.labelUnitText.Size = new System.Drawing.Size(157, 13);
            this.labelUnitText.TabIndex = 0;
            this.labelUnitText.Text = "Это какой-то хороший раздел";
            // 
            // buttonTestType1
            // 
            this.buttonTestType1.Location = new System.Drawing.Point(54, 145);
            this.buttonTestType1.Name = "buttonTestType1";
            this.buttonTestType1.Size = new System.Drawing.Size(139, 23);
            this.buttonTestType1.TabIndex = 1;
            this.buttonTestType1.Text = "Тест на полноту";
            this.buttonTestType1.UseVisualStyleBackColor = true;
            this.buttonTestType1.Click += new System.EventHandler(this.buttonTestType1_Click);
            // 
            // buttonTestType2
            // 
            this.buttonTestType2.Location = new System.Drawing.Point(54, 174);
            this.buttonTestType2.Name = "buttonTestType2";
            this.buttonTestType2.Size = new System.Drawing.Size(139, 23);
            this.buttonTestType2.TabIndex = 3;
            this.buttonTestType2.Text = "Тест на целостность";
            this.buttonTestType2.UseVisualStyleBackColor = true;
            this.buttonTestType2.Click += new System.EventHandler(this.buttonTestType2_Click);
            // 
            // buttonTestType3
            // 
            this.buttonTestType3.Location = new System.Drawing.Point(54, 203);
            this.buttonTestType3.Name = "buttonTestType3";
            this.buttonTestType3.Size = new System.Drawing.Size(139, 23);
            this.buttonTestType3.TabIndex = 4;
            this.buttonTestType3.Text = "Тест на умение";
            this.buttonTestType3.UseVisualStyleBackColor = true;
            this.buttonTestType3.Click += new System.EventHandler(this.buttonTestType3_Click);
            // 
            // chartUnit
            // 
            chartArea4.Name = "ChartArea1";
            this.chartUnit.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartUnit.Legends.Add(legend4);
            this.chartUnit.Location = new System.Drawing.Point(383, 100);
            this.chartUnit.Name = "chartUnit";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartUnit.Series.Add(series4);
            this.chartUnit.Size = new System.Drawing.Size(300, 300);
            this.chartUnit.TabIndex = 5;
            this.chartUnit.Text = "chart1";
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartUnit);
            this.Controls.Add(this.buttonTestType3);
            this.Controls.Add(this.buttonTestType2);
            this.Controls.Add(this.buttonTestType1);
            this.Controls.Add(this.labelUnitText);
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            this.Load += new System.EventHandler(this.FormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnitText;
        private System.Windows.Forms.Button buttonTestType1;
        private System.Windows.Forms.Button buttonTestType2;
        private System.Windows.Forms.Button buttonTestType3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUnit;
    }
}