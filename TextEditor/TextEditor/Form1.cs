namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(dialog.FileName);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, textBox1.Text);
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("メモ帳を終了します", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) // テキストが空でない場合
            {
                DialogResult result = MessageBox.Show(
                    "現在の内容を保存しますか？",
                    "確認",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // 上書き保存または保存ダイアログを表示
                    保存ToolStripMenuItem_Click(sender, e);
                    textBox1.Clear();
                }
                else if (result == DialogResult.No)
                {
                    textBox1.Clear();
                }
                // Cancelの場合は何もしない
            }
            else
            {
                textBox1.Clear();
            }
        }
    }
}
/*
 *【すぐ出来るかも】

新規作成ボタン
上書き保存機能・ボタン
Ctrl+Sで上書き保存などショートカットキーの設定
すべて選択
 

【ちょっと難しい】

コピー
貼り付け
切り取り
指定の行へジャンプする
 

【難しめ】

元に戻す
やり直し
検索機能
置換機能
*/