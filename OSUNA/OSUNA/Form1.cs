namespace OSUNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                Form f = new Form();
                f.Size = new Size(200, 200);
                f.StartPosition = FormStartPosition.Manual;

                int x = i * 150; 
                int y = i * 100;

                f.Location = new Point(x, y);
                f.Text = $"Window {i + 1}";

                Label label = new Label();
                label.Text = "押すなっつただろ～";
                label.AutoSize = true;
                label.Location = new Point(20, 20);

                f.Controls.Add(label);

                f.Show();
            }
        }
    }
}
