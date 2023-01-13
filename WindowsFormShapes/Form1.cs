namespace WindowsFormShapes
{
    public partial class Form1 : Form
    {
        private Random randomGenerator;

        public Form1()
        {
            randomGenerator = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), 60, 30));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPolygon(new Pen(Brushes.Red, 5), new Point[] { 
                new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)) 
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 3), new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), 100, 100));
        }
    }
}