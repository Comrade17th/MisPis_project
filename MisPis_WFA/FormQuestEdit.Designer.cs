﻿namespace MisPis_WFA
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
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.dataGridViewUnits = new System.Windows.Forms.DataGridView();
            this.labelUnit = new System.Windows.Forms.Label();
            this.dataGridViewQuestionTypes = new System.Windows.Forms.DataGridView();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.textBoxDifficulty = new System.Windows.Forms.TextBox();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.labelAns = new System.Windows.Forms.Label();
            this.richTextBoxQuest = new System.Windows.Forms.RichTextBox();
            this.labelQuest = new System.Windows.Forms.Label();
            this.labelEditor = new System.Windows.Forms.Label();
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.buttonChangeUnitName = new System.Windows.Forms.Button();
            this.textBoxQuestionType = new System.Windows.Forms.TextBox();
            this.labelUnitId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionTypes)).BeginInit();
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
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Location = new System.Drawing.Point(12, 265);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.Size = new System.Drawing.Size(776, 173);
            this.dataGridViewQuestions.TabIndex = 3;
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnits.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.Size = new System.Drawing.Size(106, 136);
            this.dataGridViewUnits.TabIndex = 4;
            this.dataGridViewUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnits_CellClick);
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
            // dataGridViewQuestionTypes
            // 
            this.dataGridViewQuestionTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestionTypes.Location = new System.Drawing.Point(143, 57);
            this.dataGridViewQuestionTypes.Name = "dataGridViewQuestionTypes";
            this.dataGridViewQuestionTypes.Size = new System.Drawing.Size(115, 136);
            this.dataGridViewQuestionTypes.TabIndex = 6;
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
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(12, 199);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(106, 20);
            this.textBoxUnitName.TabIndex = 15;
            // 
            // buttonChangeUnitName
            // 
            this.buttonChangeUnitName.Location = new System.Drawing.Point(12, 223);
            this.buttonChangeUnitName.Name = "buttonChangeUnitName";
            this.buttonChangeUnitName.Size = new System.Drawing.Size(106, 36);
            this.buttonChangeUnitName.TabIndex = 16;
            this.buttonChangeUnitName.Text = "Изменить название";
            this.buttonChangeUnitName.UseVisualStyleBackColor = true;
            this.buttonChangeUnitName.Click += new System.EventHandler(this.buttonChangeUnitName_Click);
            // 
            // textBoxQuestionType
            // 
            this.textBoxQuestionType.Location = new System.Drawing.Point(143, 199);
            this.textBoxQuestionType.Name = "textBoxQuestionType";
            this.textBoxQuestionType.ReadOnly = true;
            this.textBoxQuestionType.Size = new System.Drawing.Size(115, 20);
            this.textBoxQuestionType.TabIndex = 17;
            // 
            // labelUnitId
            // 
            this.labelUnitId.AutoSize = true;
            this.labelUnitId.Location = new System.Drawing.Point(12, 180);
            this.labelUnitId.Name = "labelUnitId";
            this.labelUnitId.Size = new System.Drawing.Size(0, 13);
            this.labelUnitId.TabIndex = 18;
            // 
            // FormQuestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUnitId);
            this.Controls.Add(this.textBoxQuestionType);
            this.Controls.Add(this.buttonChangeUnitName);
            this.Controls.Add(this.textBoxUnitName);
            this.Controls.Add(this.labelEditor);
            this.Controls.Add(this.labelQuest);
            this.Controls.Add(this.richTextBoxQuest);
            this.Controls.Add(this.textBoxAns);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.textBoxDifficulty);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.dataGridViewQuestionTypes);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.dataGridViewUnits);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormQuestEdit";
            this.Text = "FormQuestEdit";
            this.Load += new System.EventHandler(this.FormQuestEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.DataGridView dataGridViewUnits;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.DataGridView dataGridViewQuestionTypes;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.TextBox textBoxDifficulty;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.RichTextBox richTextBoxQuest;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.Label labelEditor;
        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.Button buttonChangeUnitName;
        private System.Windows.Forms.TextBox textBoxQuestionType;
        private System.Windows.Forms.Label labelUnitId;
    }
}