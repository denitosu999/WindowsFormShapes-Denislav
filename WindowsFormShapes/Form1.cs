namespace WindowsFormShapes
{
    public partial class Form1 : Form
    {
        private Random randomGenerator;

        private Thread rectangleThread;
        private Thread triangleThread;
        private Thread circleThread;

        public Form1()
        {
            randomGenerator = new Random();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangleThread = new Thread(rectangleThreadMethod);
            rectangleThread.Start();
        }

        private void rectangleThreadMethod()
        {
            while(true)
            { 
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), randomGenerator.Next(55, 100), randomGenerator.Next(10, 50)));
                Thread.Sleep(3000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangleThread = new Thread(triangleThreadMethod);
            triangleThread.Start();
        }

        private void triangleThreadMethod()
        {
            while (true)
            {
                this.CreateGraphics().DrawPolygon(new Pen(Brushes.Red, 5), new Point[] {
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height))
                });
                Thread.Sleep(2000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            circleThread = new Thread(cricleThreadMethod);
            circleThread.Start();
        }

        private void cricleThreadMethod()
        {
            while(true)
            {
                int circleSize = randomGenerator.Next(50, 250);
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 3), new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), circleSize, circleSize));
                Thread.Sleep(4000);
            }
        }
    }
}