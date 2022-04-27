using Editor.Utils;
using System.Globalization;

namespace Editor.Views
{
    public partial class FindForm : Form
    {
        public List<SelectedText> SelectedTexts { get; set; }
        public EditorForm EditorForm { get; }
        public RichTextBox RichTextBoxTextContent { get; }
        private int _indexQty = 0;

        public FindForm(WindowType type, EditorForm editorForm, RichTextBox _richTextBoxTextContent)
        {
            InitializeComponent();
            switch (type)
            {
                case WindowType.Find:
                    _buttonReplace.Visible = false;
                    _buttonReplace.Enabled = false;
                    _textBoxReplace.Visible = false;
                    _labelReplace.Visible = false;
                    break;
                case WindowType.Replace:
                    Text = "Заменить";
                    _buttonReplace.Visible = true;
                    _buttonReplace.Enabled = true;
                    _textBoxReplace.Visible = true;
                    _labelReplace.Visible = true;
                    break;
            }
            EditorForm = editorForm;
            RichTextBoxTextContent = _richTextBoxTextContent;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Search(_textBoxFind.Text);
            _indexQty++;
        }

        private void Search(string word)
        {
            var indecies = new List<int>(RichTextBoxTextContent.Text.AllIndeciesOf(word, _checkBoxMatchCase.Checked));
            var maxLength = RichTextBoxTextContent.Text.Length;
            if (indecies.Count <= _indexQty)
            {
                _indexQty = 0; 
            }
            var searchLength = word.Length + indecies[_indexQty];
            if (maxLength >= searchLength)
            {
                RichTextBoxTextContent.Select(indecies[_indexQty], word.Length);
                EditorForm.Focus();
            }
        }

        private void Replace(string findWord, string replaceWord)
        {
            /*
             1. Найти слово
             2. Узнать его положение
             3. Разделить текст на до и после
             4. Вставить новое слово вместо предыдыщего
             5. Поместить текст в контрол
             */

            RichTextBoxTextContent.Text = RichTextBoxTextContent.Text.Replace(findWord, replaceWord);
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            Replace(_textBoxFind.Text, _textBoxReplace.Text);
            _indexQty++;
            EditorForm.Focus();
        }
    }
}
