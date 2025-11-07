namespace ExamOutlineFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openArticle.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string outline = txtOutline.Text;
            string article = txtArticle.Text;
            RunFilter(outline, article);
        }

        private void RunFilter(string outline, string article)
        {
            //
            listOverRange.Items.Clear();

            //判断
            if (string.IsNullOrEmpty(outline)) return;
            if (string.IsNullOrEmpty(article)) return;

            //分离文章中的单词
            string[] words = article.Split(' ');
            foreach (string word in words)
            {
                if (outline.IndexOf(word.ToLower()) == -1)
                {
                    OverRange(word);
                }
            }
        }

        private void OverRange(string word)
        {
            if (listOverRange.Items.IndexOf(word) == -1)
            {
                listOverRange.Items.Add(word);
            }
        }

        private void loadOutlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openOutline.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listOverRange.Items.Clear();
        }
    }
}
