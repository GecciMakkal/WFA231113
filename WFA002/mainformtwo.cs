namespace WFA002
{
    public partial class mainformtwo : Form
    {
        public mainformtwo()
        {
            InitializeComponent();
            gomb.Click += Gomb_Click;
            gomb.MouseEnter += Gomb_MouseEnter;
            gomb.MouseMove += Gomb_MouseMove;
            gomb.MouseLeave += Gomb_MouseLeave;
        }

        private void Gomb_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
            gomb.Text=gomb.Text.ToLower();
        }

        private void Gomb_MouseMove(object? sender, MouseEventArgs e)
        {
            int x=Cursor.Position.X;
            int y=Cursor.Position.Y;

            this.Text = $"[x:={x};y:={y}]";
        }

        private void Gomb_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void Gomb_Click(object? sender, EventArgs e)
        {
           gomb.Text=gomb.Text.ToUpper();
        }
    }
}