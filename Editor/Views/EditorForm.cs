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
        }

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
            var result = MessageBox.Show("Хотите сохранить изменения?", "Редактор текста", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.Yes:
                    SaveData();
                    Close();
                    break;
                case DialogResult.No:
                    Close();
                    break;
            }
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
            int index = _richTextBoxTextContent.SelectionStart;
            string firstPart = _richTextBoxTextContent.Text.Substring(0, index);
            string secondPart = _richTextBoxTextContent.Text.Substring(index, _richTextBoxTextContent.TextLength - firstPart.Length);
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
    }
}
