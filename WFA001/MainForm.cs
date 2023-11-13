namespace WFA001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblhello.Click += Lblhello_Click;
        }

        private void Lblhello_Click(object? sender, EventArgs e)
        {
            _ = MessageBox.Show("Hello,world!");
        }
    }
}