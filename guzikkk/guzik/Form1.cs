namespace guzik
{
    public partial class Form1 : Form
    {
        readonly Random r;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e) {
            int maxX = this.Size.Width - button1.Size.Width - 12;
            int maxY = this.Size.Height - button1.Size.Height - 12;
            Point p = new Point();
            p.X = r.Next(12, 1700);
            p.Y = r.Next(12, 1000);
            button1.Location = p;
        

        }
    }
}
