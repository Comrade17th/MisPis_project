namespace MisPis_WFA
{
    partial class FormQuestEdit
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelUnit = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.textBoxDifficulty = new System.Windows.Forms.TextBox();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.labelAns = new System.Windows.Forms.Label();
            this.richTextBoxQuest = new System.Windows.Forms.RichTextBox();
            this.labelQuest = new System.Windows.Forms.Label();
            this.labelEditor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(703, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(703, 67);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(703, 96);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 173);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(106, 136);
            this.dataGridView2.TabIndex = 4;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(12, 38);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(52, 13);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Разделы";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(143, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(115, 136);
            this.dataGridView3.TabIndex = 6;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(154, 38);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 13);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Типы Вопросов";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(278, 223);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(63, 13);
            this.labelDifficulty.TabIndex = 8;
            this.labelDifficulty.Text = "Сложность";
            // 
            // textBoxDifficulty
            // 
            this.textBoxDifficulty.Location = new System.Drawing.Point(280, 239);
            this.textBoxDifficulty.Name = "textBoxDifficulty";
            this.textBoxDifficulty.Size = new System.Drawing.Size(100, 20);
            this.textBoxDifficulty.TabIndex = 9;
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(280, 200);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(393, 20);
            this.textBoxAns.TabIndex = 11;
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Location = new System.Drawing.Point(278, 184);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(102, 13);
            this.labelAns.TabIndex = 10;
            this.labelAns.Text = "Правильный ответ";
            // 
            // richTextBoxQuest
            // 
            this.richTextBoxQuest.Location = new System.Drawing.Point(280, 85);
            this.richTextBoxQuest.Name = "richTextBoxQuest";
            this.richTextBoxQuest.Size = new System.Drawing.Size(393, 96);
            this.richTextBoxQuest.TabIndex = 12;
            this.richTextBoxQuest.Text = "";
            // 
            // labelQuest
            // 
            this.labelQuest.AutoSize = true;
            this.labelQuest.Location = new System.Drawing.Point(281, 66);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(83, 13);
            this.labelQuest.TabIndex = 13;
            this.labelQuest.Text = "Текст Вопроса";
            // 
            // labelEditor
            // 
            this.labelEditor.AutoSize = true;
            this.labelEditor.Location = new System.Drawing.Point(309, 9);
            this.labelEditor.Name = "labelEditor";
            this.labelEditor.Size = new System.Drawing.Size(122, 13);
            this.labelEditor.TabIndex = 14;
            this.labelEditor.Text = "Конструктор вопросов";
            // 
            // FormQuestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.labelQuest);
            this.Controls.Add(this.richTextBoxQuest);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.textBoxDifficulty);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormQuestEdit";
            this.Text = "FormQuestEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.TextBox textBoxDifficulty;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.RichTextBox richTextBoxQuest;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.Label labelEditor;
    }
}