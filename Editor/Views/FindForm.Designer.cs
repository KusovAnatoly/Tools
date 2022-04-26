namespace Editor.Views
{
    partial class FindForm
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
            this._labelText = new System.Windows.Forms.Label();
            this._textBoxFind = new System.Windows.Forms.TextBox();
            this._buttonNext = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._checkBoxMatchCase = new System.Windows.Forms.CheckBox();
            this._textBoxReplace = new System.Windows.Forms.TextBox();
            this._labelReplace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelText
            // 
            this._labelText.AutoSize = true;
            this._labelText.Location = new System.Drawing.Point(12, 15);
            this._labelText.Name = "_labelText";
            this._labelText.Size = new System.Drawing.Size(55, 20);
            this._labelText.TabIndex = 0;
            this._labelText.Text = "Найти:";
            // 
            // _textBoxFind
            // 
            this._textBoxFind.Location = new System.Drawing.Point(73, 12);
            this._textBoxFind.Name = "_textBoxFind";
            this._textBoxFind.Size = new System.Drawing.Size(290, 27);
            this._textBoxFind.TabIndex = 1;
            // 
            // _buttonNext
            // 
            this._buttonNext.Location = new System.Drawing.Point(369, 10);
            this._buttonNext.Name = "_buttonNext";
            this._buttonNext.Size = new System.Drawing.Size(108, 29);
            this._buttonNext.TabIndex = 2;
            this._buttonNext.Text = "Следующее";
            this._buttonNext.UseVisualStyleBackColor = true;
            this._buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(369, 45);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(108, 29);
            this._buttonCancel.TabIndex = 3;
            this._buttonCancel.Text = "Отмена";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // _checkBoxMatchCase
            // 
            this._checkBoxMatchCase.AutoSize = true;
            this._checkBoxMatchCase.Location = new System.Drawing.Point(12, 167);
            this._checkBoxMatchCase.Name = "_checkBoxMatchCase";
            this._checkBoxMatchCase.Size = new System.Drawing.Size(162, 24);
            this._checkBoxMatchCase.TabIndex = 4;
            this._checkBoxMatchCase.Text = "Учитывать регистр";
            this._checkBoxMatchCase.UseVisualStyleBackColor = true;
            // 
            // _textBoxReplace
            // 
            this._textBoxReplace.Location = new System.Drawing.Point(97, 47);
            this._textBoxReplace.Name = "_textBoxReplace";
            this._textBoxReplace.Size = new System.Drawing.Size(266, 27);
            this._textBoxReplace.TabIndex = 6;
            // 
            // _labelReplace
            // 
            this._labelReplace.AutoSize = true;
            this._labelReplace.Location = new System.Drawing.Point(12, 50);
            this._labelReplace.Name = "_labelReplace";
            this._labelReplace.Size = new System.Drawing.Size(79, 20);
            this._labelReplace.TabIndex = 5;
            this._labelReplace.Text = "Заменить:";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this._textBoxReplace);
            this.Controls.Add(this._labelReplace);
            this.Controls.Add(this._checkBoxMatchCase);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonNext);
            this.Controls.Add(this._textBoxFind);
            this.Controls.Add(this._labelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Найти";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelText;
        private TextBox _textBoxFind;
        private Button _buttonNext;
        private Button _buttonCancel;
        private CheckBox _checkBoxMatchCase;
        private TextBox _textBoxReplace;
        private Label _labelReplace;
    }
}