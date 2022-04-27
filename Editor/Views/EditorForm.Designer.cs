namespace Editor.Views
{
    partial class EditorForm
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
            this._richTextBoxTextContent = new System.Windows.Forms.RichTextBox();
            this._menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._dateTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._toolStripStatusLabelFontSize = new System.Windows.Forms.ToolStripStatusLabel();
            this._toolStripStatusLabelLineColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this._menuStripMainMenu.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _richTextBoxTextContent
            // 
            this._richTextBoxTextContent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._richTextBoxTextContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._richTextBoxTextContent.BackColor = System.Drawing.Color.White;
            this._richTextBoxTextContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._richTextBoxTextContent.Location = new System.Drawing.Point(0, 30);
            this._richTextBoxTextContent.Name = "_richTextBoxTextContent";
            this._richTextBoxTextContent.Size = new System.Drawing.Size(702, 374);
            this._richTextBoxTextContent.TabIndex = 0;
            this._richTextBoxTextContent.Text = "";
            this._richTextBoxTextContent.WordWrap = false;
            this._richTextBoxTextContent.SelectionChanged += new System.EventHandler(this.RichTextBoxTextContent_SelectionChanged);
            // 
            // _menuStripMainMenu
            // 
            this._menuStripMainMenu.BackColor = System.Drawing.Color.White;
            this._menuStripMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this._editToolStripMenuItem,
            this._formatToolStripMenuItem,
            this._viewToolStripMenuItem,
            this._helpToolStripMenuItem});
            this._menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this._menuStripMainMenu.Name = "_menuStripMainMenu";
            this._menuStripMainMenu.Size = new System.Drawing.Size(702, 28);
            this._menuStripMainMenu.TabIndex = 1;
            this._menuStripMainMenu.Text = "Главное меню";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newFileToolStripMenuItem,
            this._openFileToolStripMenuItem,
            this._saveAsToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.ShowShortcutKeys = false;
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this._fileToolStripMenuItem.Text = "Файл";
            this._fileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _newFileToolStripMenuItem
            // 
            this._newFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._newFileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._newFileToolStripMenuItem.Name = "_newFileToolStripMenuItem";
            this._newFileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this._newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._newFileToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this._newFileToolStripMenuItem.Text = "Новый файл...";
            this._newFileToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // _openFileToolStripMenuItem
            // 
            this._openFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._openFileToolStripMenuItem.Name = "_openFileToolStripMenuItem";
            this._openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._openFileToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this._openFileToolStripMenuItem.Text = "Открыть файл...";
            this._openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // _saveAsToolStripMenuItem
            // 
            this._saveAsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._saveAsToolStripMenuItem.Name = "_saveAsToolStripMenuItem";
            this._saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._saveAsToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this._saveAsToolStripMenuItem.Text = "Сохранить как...";
            this._saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this._exitToolStripMenuItem.Text = "Выйти";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // _editToolStripMenuItem
            // 
            this._editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._findToolStripMenuItem,
            this._replaceToolStripMenuItem,
            this._dateTimeToolStripMenuItem});
            this._editToolStripMenuItem.Name = "_editToolStripMenuItem";
            this._editToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this._editToolStripMenuItem.Text = "Правка";
            this._editToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _findToolStripMenuItem
            // 
            this._findToolStripMenuItem.Name = "_findToolStripMenuItem";
            this._findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this._findToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this._findToolStripMenuItem.Text = "Найти";
            this._findToolStripMenuItem.Click += new System.EventHandler(this.FindToolStripMenuItem_Click);
            // 
            // _replaceToolStripMenuItem
            // 
            this._replaceToolStripMenuItem.Name = "_replaceToolStripMenuItem";
            this._replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this._replaceToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this._replaceToolStripMenuItem.Text = "Заменить";
            this._replaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // _dateTimeToolStripMenuItem
            // 
            this._dateTimeToolStripMenuItem.Name = "_dateTimeToolStripMenuItem";
            this._dateTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._dateTimeToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this._dateTimeToolStripMenuItem.Text = "Дата/Время";
            this._dateTimeToolStripMenuItem.Click += new System.EventHandler(this.DateTimeToolStripMenuItem_Click);
            // 
            // _formatToolStripMenuItem
            // 
            this._formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fontToolStripMenuItem,
            this._wordWrapToolStripMenuItem});
            this._formatToolStripMenuItem.Name = "_formatToolStripMenuItem";
            this._formatToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this._formatToolStripMenuItem.Text = "Формат";
            this._formatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _fontToolStripMenuItem
            // 
            this._fontToolStripMenuItem.Name = "_fontToolStripMenuItem";
            this._fontToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this._fontToolStripMenuItem.Text = "Шрифт";
            this._fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // _wordWrapToolStripMenuItem
            // 
            this._wordWrapToolStripMenuItem.CheckOnClick = true;
            this._wordWrapToolStripMenuItem.Name = "_wordWrapToolStripMenuItem";
            this._wordWrapToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this._wordWrapToolStripMenuItem.Text = "Перенос слов";
            this._wordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.WordWrapToolStripMenuItem_CheckedChanged);
            // 
            // _viewToolStripMenuItem
            // 
            this._viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._zoomInToolStripMenuItem,
            this._zoomOutToolStripMenuItem,
            this._statusBarToolStripMenuItem});
            this._viewToolStripMenuItem.Name = "_viewToolStripMenuItem";
            this._viewToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this._viewToolStripMenuItem.Text = "Вид";
            this._viewToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _zoomInToolStripMenuItem
            // 
            this._zoomInToolStripMenuItem.Name = "_zoomInToolStripMenuItem";
            this._zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this._zoomInToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this._zoomInToolStripMenuItem.Text = "Увеличить";
            this._zoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInToolStripMenuItem_Click);
            // 
            // _zoomOutToolStripMenuItem
            // 
            this._zoomOutToolStripMenuItem.Name = "_zoomOutToolStripMenuItem";
            this._zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this._zoomOutToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this._zoomOutToolStripMenuItem.Text = "Уменьшить";
            this._zoomOutToolStripMenuItem.Click += new System.EventHandler(this.ZoomOutToolStripMenuItem_Click);
            // 
            // _statusBarToolStripMenuItem
            // 
            this._statusBarToolStripMenuItem.Checked = true;
            this._statusBarToolStripMenuItem.CheckOnClick = true;
            this._statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._statusBarToolStripMenuItem.Name = "_statusBarToolStripMenuItem";
            this._statusBarToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this._statusBarToolStripMenuItem.Text = "Панель состояния";
            this._statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.StatusBarToolStripMenuItem_CheckedChanged);
            // 
            // _helpToolStripMenuItem
            // 
            this._helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutToolStripMenuItem});
            this._helpToolStripMenuItem.Name = "_helpToolStripMenuItem";
            this._helpToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this._helpToolStripMenuItem.Text = "Помощь";
            this._helpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _aboutToolStripMenuItem
            // 
            this._aboutToolStripMenuItem.Name = "_aboutToolStripMenuItem";
            this._aboutToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this._aboutToolStripMenuItem.Text = "О программе";
            this._aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // _statusStrip
            // 
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripStatusLabelFontSize,
            this._toolStripStatusLabelLineColumn});
            this._statusStrip.Location = new System.Drawing.Point(0, 407);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(702, 26);
            this._statusStrip.TabIndex = 2;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _toolStripStatusLabelFontSize
            // 
            this._toolStripStatusLabelFontSize.AccessibleName = "";
            this._toolStripStatusLabelFontSize.Name = "_toolStripStatusLabelFontSize";
            this._toolStripStatusLabelFontSize.Size = new System.Drawing.Size(0, 20);
            // 
            // _toolStripStatusLabelLineColumn
            // 
            this._toolStripStatusLabelLineColumn.Name = "_toolStripStatusLabelLineColumn";
            this._toolStripStatusLabelLineColumn.Size = new System.Drawing.Size(147, 20);
            this._toolStripStatusLabelLineColumn.Text = "Строка 1, Колонка 1";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._richTextBoxTextContent);
            this.Controls.Add(this._menuStripMainMenu);
            this.MainMenuStrip = this._menuStripMainMenu;
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "EditorForm";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorForm_KeyDown);
            this._menuStripMainMenu.ResumeLayout(false);
            this._menuStripMainMenu.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox _richTextBoxTextContent;
        private MenuStrip _menuStripMainMenu;
        private ToolStripMenuItem _fileToolStripMenuItem;
        private ToolStripMenuItem _newFileToolStripMenuItem;
        private ToolStripMenuItem _openFileToolStripMenuItem;
        private ToolStripMenuItem _saveAsToolStripMenuItem;
        private ToolStripMenuItem _exitToolStripMenuItem;
        private ToolStripMenuItem _editToolStripMenuItem;
        private ToolStripMenuItem _findToolStripMenuItem;
        private ToolStripMenuItem _replaceToolStripMenuItem;
        private ToolStripMenuItem _dateTimeToolStripMenuItem;
        private ToolStripMenuItem _viewToolStripMenuItem;
        private ToolStripMenuItem _zoomInToolStripMenuItem;
        private ToolStripMenuItem _zoomOutToolStripMenuItem;
        private ToolStripMenuItem _statusBarToolStripMenuItem;
        private ToolStripMenuItem _helpToolStripMenuItem;
        private ToolStripMenuItem _aboutToolStripMenuItem;
        private ToolStripMenuItem _formatToolStripMenuItem;
        private ToolStripMenuItem _fontToolStripMenuItem;
        private ToolStripMenuItem _wordWrapToolStripMenuItem;
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _toolStripStatusLabelFontSize;
        private ToolStripStatusLabel _toolStripStatusLabelLineColumn;
    }
}