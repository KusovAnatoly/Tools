using Editor.Utils;
using System.Globalization;

namespace Editor.Views
{
    public partial class EditorForm : Form
    {
        /// <summary>
        /// Имя файла (file-name.txt)
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Полный путь к файлу (C:/file-name.txt)
        /// </summary>
        public string FilePath { get; set; }

        public EditorForm()
        {
            InitializeComponent();
            _toolStripStatusLabelFontSize.Text = $"Размер шрифта: {_richTextBoxTextContent.Font.Size}";
        }

        // Сохранение данных в текстовый файл с помощью диалогового окна
        private string SaveData()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить как...";
            saveFileDialog.FileName = "Документ";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Текстовые документы|*.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = Path.GetFullPath(saveFileDialog.FileName);
                File.WriteAllText(filePath, _richTextBoxTextContent.Text);
                return Path.GetFileName(saveFileDialog.FileName);
            }
            return null;
        }

        private void ReadData()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Открыть";
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.Filter = "Текстовые документы|*.txt";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        _richTextBoxTextContent.Text = fileContent;
                        Text = $"{openFileDialog.SafeFileName} - Редактор текста";
                    }
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richTextBoxTextContent.WordWrap = _wordWrapToolStripMenuItem.Checked;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowEffects = false;
            fontDialog.FontMustExist = true;

            fontDialog.Font = _richTextBoxTextContent.Font;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                _richTextBoxTextContent.Font = fontDialog.Font;
            }
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Индекс положения курсора в тексте
            int index = _richTextBoxTextContent.SelectionStart;
            // Разделение текста по индексу на 2 части
            string firstPart = _richTextBoxTextContent.Text.Substring(0, index);
            string secondPart = _richTextBoxTextContent.Text.Substring(index, _richTextBoxTextContent.TextLength - firstPart.Length);
            // Вставка текста в контрол
            _richTextBoxTextContent.Text = firstPart + DateTime.Now.ToString(new CultureInfo("ru-RU")) + secondPart;

        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richTextBoxTextContent.Clear();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = SaveData();
            if (!string.IsNullOrEmpty(fileName))
            {
                Text = $"{fileName} - Редактор текста";
            }
            else
            {
                Text = $"Редактор текста";
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(WindowType.Find, this, _richTextBoxTextContent);
            findForm.Show();
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(WindowType.Replace, this, _richTextBoxTextContent);
            findForm.Show();
        }

        private void WordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _richTextBoxTextContent.WordWrap = _wordWrapToolStripMenuItem.Checked;
        }

        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var font = _richTextBoxTextContent.Font;
            var newFontStyle = (FontStyle)font.Style;
            _richTextBoxTextContent.Font = new Font(font.FontFamily, font.Size + 1, newFontStyle);
            _toolStripStatusLabelFontSize.Text = $"Размер шрифта: {_richTextBoxTextContent.Font.Size}";
        }

        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var font = _richTextBoxTextContent.Font;
            var newFontStyle = (FontStyle)font.Style;
            _richTextBoxTextContent.Font = new Font(font.FontFamily, font.Size - 1, newFontStyle);
            _toolStripStatusLabelFontSize.Text = $"Размер шрифта: {_richTextBoxTextContent.Font.Size}";
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void StatusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _statusStrip.Visible = _statusBarToolStripMenuItem.Checked;
            _richTextBoxTextContent.Height = _statusBarToolStripMenuItem.Checked ? Height - 26 - 28 - 10 : Height - 28 - 10;
        }

        private void RichTextBoxTextContent_SelectionChanged(object sender, EventArgs e)
        {
            var index = _richTextBoxTextContent.SelectionStart;
            var row = _richTextBoxTextContent.GetLineFromCharIndex(index);
            var column = _richTextBoxTextContent.SelectionStart - _richTextBoxTextContent.GetFirstCharIndexFromLine(row);
            _toolStripStatusLabelLineColumn.Text = $"Строка: {row + 1}; Колонка: {column}";
        }

        private void EditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
            {
                _richTextBoxTextContent = new RichTextBox();
            }
            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                ReadData();
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                var fileName = SaveData();
                if (!string.IsNullOrEmpty(fileName))
                {
                    Text = $"{fileName} - Редактор текста";
                }
                else
                {
                    Text = $"Редактор текста";
                }
            }
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                FindForm findForm = new FindForm(WindowType.Find, this, _richTextBoxTextContent);
                findForm.Show();
            }
            if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control)
            {
                FindForm findForm = new FindForm(WindowType.Replace, this, _richTextBoxTextContent);
                findForm.Show();
            }
            if (e.KeyCode == Keys.Y&& e.Modifiers == Keys.Control)
            {
                var font = _richTextBoxTextContent.Font;
                var newFontStyle = (FontStyle)font.Style;
                _richTextBoxTextContent.Font = new Font(font.FontFamily, font.Size + 1, newFontStyle);
                _toolStripStatusLabelFontSize.Text = $"Размер шрифта: {_richTextBoxTextContent.Font.Size}";
            }
            if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                var font = _richTextBoxTextContent.Font;
                var newFontStyle = (FontStyle)font.Style;
                _richTextBoxTextContent.Font = new Font(font.FontFamily, font.Size - 1, newFontStyle);
                _toolStripStatusLabelFontSize.Text = $"Размер шрифта: {_richTextBoxTextContent.Font.Size}";
            }
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Хотите сохранить изменения?", "Редактор текста", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    SaveData();
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = false;
                    break;
            }
        }
    }
}
