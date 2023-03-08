namespace MisPis_WFA
{
    partial class FormTest
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
            this.richTextBoxQuest1 = new System.Windows.Forms.RichTextBox();
            this.textBoxAns1 = new System.Windows.Forms.TextBox();
            this.textBoxAns2 = new System.Windows.Forms.TextBox();
            this.richTextBoxQuest2 = new System.Windows.Forms.RichTextBox();
            this.textBoxAns3 = new System.Windows.Forms.TextBox();
            this.richTextBoxQuest3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonEndTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxQuest1
            // 
            this.richTextBoxQuest1.Location = new System.Drawing.Point(24, 12);
            this.richTextBoxQuest1.Name = "richTextBoxQuest1";
            this.richTextBoxQuest1.ReadOnly = true;
            this.richTextBoxQuest1.Size = new System.Drawing.Size(429, 91);
            this.richTextBoxQuest1.TabIndex = 0;
            this.richTextBoxQuest1.Text = "";
            // 
            // textBoxAns1
            // 
            this.textBoxAns1.Location = new System.Drawing.Point(24, 109);
            this.textBoxAns1.Name = "textBoxAns1";
            this.textBoxAns1.Size = new System.Drawing.Size(429, 20);
            this.textBoxAns1.TabIndex = 3;
            // 
            // textBoxAns2
            // 
            this.textBoxAns2.Location = new System.Drawing.Point(24, 232);
            this.textBoxAns2.Name = "textBoxAns2";
            this.textBoxAns2.Size = new System.Drawing.Size(429, 20);
            this.textBoxAns2.TabIndex = 5;
            // 
            // richTextBoxQuest2
            // 
            this.richTextBoxQuest2.Location = new System.Drawing.Point(24, 135);
            this.richTextBoxQuest2.Name = "richTextBoxQuest2";
            this.richTextBoxQuest2.ReadOnly = true;
            this.richTextBoxQuest2.Size = new System.Drawing.Size(429, 91);
            this.richTextBoxQuest2.TabIndex = 4;
            this.richTextBoxQuest2.Text = "";
            // 
            // textBoxAns3
            // 
            this.textBoxAns3.Location = new System.Drawing.Point(24, 365);
            this.textBoxAns3.Name = "textBoxAns3";
            this.textBoxAns3.Size = new System.Drawing.Size(429, 20);
            this.textBoxAns3.TabIndex = 7;
            // 
            // richTextBoxQuest3
            // 
            this.richTextBoxQuest3.Location = new System.Drawing.Point(24, 268);
            this.richTextBoxQuest3.Name = "richTextBoxQuest3";
            this.richTextBoxQuest3.ReadOnly = true;
            this.richTextBoxQuest3.Size = new System.Drawing.Size(429, 91);
            this.richTextBoxQuest3.TabIndex = 6;
            this.richTextBoxQuest3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Таймер 20:00";
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(672, 60);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(105, 23);
            this.buttonStartTest.TabIndex = 9;
            this.buttonStartTest.Text = "Начать тест";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            this.buttonStartTest.Click += new System.EventHandler(this.buttonStartTest_Click);
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.Location = new System.Drawing.Point(674, 362);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(103, 23);
            this.buttonEndTest.TabIndex = 10;
            this.buttonEndTest.Text = "Закончить Тест";
            this.buttonEndTest.UseVisualStyleBackColor = true;
            this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEndTest);
            this.Controls.Add(this.buttonStartTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAns3);
            this.Controls.Add(this.richTextBoxQuest3);
            this.Controls.Add(this.textBoxAns2);
            this.Controls.Add(this.richTextBoxQuest2);
            this.Controls.Add(this.textBoxAns1);
            this.Controls.Add(this.richTextBoxQuest1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuest1;
        private System.Windows.Forms.TextBox textBoxAns1;
        private System.Windows.Forms.TextBox textBoxAns2;
        private System.Windows.Forms.RichTextBox richTextBoxQuest2;
        private System.Windows.Forms.TextBox textBoxAns3;
        private System.Windows.Forms.RichTextBox richTextBoxQuest3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.Button buttonEndTest;
    }
}