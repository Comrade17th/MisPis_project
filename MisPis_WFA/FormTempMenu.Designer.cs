namespace MisPis_WFA
{
    partial class FormTempMenu
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
            this.label_good_text = new System.Windows.Forms.Label();
            this.buttonOpenMainMenu = new System.Windows.Forms.Button();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.buttonQuestEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_good_text
            // 
            this.label_good_text.AutoSize = true;
            this.label_good_text.Location = new System.Drawing.Point(270, 61);
            this.label_good_text.Name = "label_good_text";
            this.label_good_text.Size = new System.Drawing.Size(162, 13);
            this.label_good_text.TabIndex = 0;
            this.label_good_text.Text = "Добро пожаловать и т.д. и т.п.";
            // 
            // buttonOpenMainMenu
            // 
            this.buttonOpenMainMenu.Location = new System.Drawing.Point(297, 136);
            this.buttonOpenMainMenu.Name = "buttonOpenMainMenu";
            this.buttonOpenMainMenu.Size = new System.Drawing.Size(126, 23);
            this.buttonOpenMainMenu.TabIndex = 1;
            this.buttonOpenMainMenu.Text = "Перейти к курсу";
            this.buttonOpenMainMenu.UseVisualStyleBackColor = true;
            this.buttonOpenMainMenu.Click += new System.EventHandler(this.buttonOpenMainMenu_Click);
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Location = new System.Drawing.Point(630, 342);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(158, 23);
            this.buttonUserEdit.TabIndex = 2;
            this.buttonUserEdit.Text = "Редактор Пользователей";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            this.buttonUserEdit.Click += new System.EventHandler(this.buttonUserEdit_Click);
            // 
            // buttonQuestEdit
            // 
            this.buttonQuestEdit.Location = new System.Drawing.Point(630, 371);
            this.buttonQuestEdit.Name = "buttonQuestEdit";
            this.buttonQuestEdit.Size = new System.Drawing.Size(158, 23);
            this.buttonQuestEdit.TabIndex = 3;
            this.buttonQuestEdit.Text = "Редактор Вопросов";
            this.buttonQuestEdit.UseVisualStyleBackColor = true;
            this.buttonQuestEdit.Click += new System.EventHandler(this.buttonQuestEdit_Click);
            // 
            // FormTempMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuestEdit);
            this.Controls.Add(this.buttonUserEdit);
            this.Controls.Add(this.buttonOpenMainMenu);
            this.Controls.Add(this.label_good_text);
            this.Name = "FormTempMenu";
            this.Text = "FormTempMenu";
            this.Load += new System.EventHandler(this.FormTempMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_good_text;
        private System.Windows.Forms.Button buttonOpenMainMenu;
        private System.Windows.Forms.Button buttonUserEdit;
        private System.Windows.Forms.Button buttonQuestEdit;
    }
}