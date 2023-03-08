namespace MisPis_WFA
{
    partial class FormMainMenu
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
            this.labelSomeText = new System.Windows.Forms.Label();
            this.buttonUnit1 = new System.Windows.Forms.Button();
            this.buttonUnit2 = new System.Windows.Forms.Button();
            this.buttonUnit3 = new System.Windows.Forms.Button();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonMaterials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSomeText
            // 
            this.labelSomeText.AutoSize = true;
            this.labelSomeText.Location = new System.Drawing.Point(276, 77);
            this.labelSomeText.Name = "labelSomeText";
            this.labelSomeText.Size = new System.Drawing.Size(246, 13);
            this.labelSomeText.TabIndex = 0;
            this.labelSomeText.Text = "Какой-то приятный текст и описывающий курс";
            // 
            // buttonUnit1
            // 
            this.buttonUnit1.Location = new System.Drawing.Point(145, 159);
            this.buttonUnit1.Name = "buttonUnit1";
            this.buttonUnit1.Size = new System.Drawing.Size(123, 23);
            this.buttonUnit1.TabIndex = 1;
            this.buttonUnit1.Text = "Раздел 1 (ВычМат)";
            this.buttonUnit1.UseVisualStyleBackColor = true;
            this.buttonUnit1.Click += new System.EventHandler(this.buttonUnit1_Click);
            // 
            // buttonUnit2
            // 
            this.buttonUnit2.Location = new System.Drawing.Point(145, 188);
            this.buttonUnit2.Name = "buttonUnit2";
            this.buttonUnit2.Size = new System.Drawing.Size(123, 23);
            this.buttonUnit2.TabIndex = 2;
            this.buttonUnit2.Text = "Раздел 2 (SciLab)";
            this.buttonUnit2.UseVisualStyleBackColor = true;
            this.buttonUnit2.Click += new System.EventHandler(this.buttonUnit2_Click);
            // 
            // buttonUnit3
            // 
            this.buttonUnit3.Location = new System.Drawing.Point(145, 217);
            this.buttonUnit3.Name = "buttonUnit3";
            this.buttonUnit3.Size = new System.Drawing.Size(123, 23);
            this.buttonUnit3.TabIndex = 3;
            this.buttonUnit3.Text = "Раздел 3 (История)";
            this.buttonUnit3.UseVisualStyleBackColor = true;
            this.buttonUnit3.Click += new System.EventHandler(this.buttonUnit3_Click);
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(458, 159);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(153, 23);
            this.buttonMap.TabIndex = 4;
            this.buttonMap.Text = "Интеллект Карта";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // buttonMaterials
            // 
            this.buttonMaterials.Location = new System.Drawing.Point(458, 217);
            this.buttonMaterials.Name = "buttonMaterials";
            this.buttonMaterials.Size = new System.Drawing.Size(153, 23);
            this.buttonMaterials.TabIndex = 5;
            this.buttonMaterials.Text = "Лекционные Материалы";
            this.buttonMaterials.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMaterials);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.buttonUnit3);
            this.Controls.Add(this.buttonUnit2);
            this.Controls.Add(this.buttonUnit1);
            this.Controls.Add(this.labelSomeText);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSomeText;
        private System.Windows.Forms.Button buttonUnit1;
        private System.Windows.Forms.Button buttonUnit2;
        private System.Windows.Forms.Button buttonUnit3;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonMaterials;
    }
}