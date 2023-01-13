namespace WindowsFormShapes
{
    public partial class Form1 : Form
    {
        private Random randomGenerator;

        private Thread rectangleThread;
        private Thread triangleThread;
        private Thread circleThread;

        private bool isRectangleClicked;
        private bool isTriangleClicked;
        private bool isCircleClicked;
        private bool isRandomColorClicked;

        public Form1()
        {
            this.isRectangleClicked = false;
            this.isTriangleClicked = false;
            this.isCircleClicked = false;
            this.isRandomColorClicked = false;
            randomGenerator = new Random();
            InitializeComponent();
        }

        private Pen GeneratePen()
        {
            int colourNumber = randomGenerator.Next(0, 14);
            Brush brush;
            switch (colourNumber)
            {
                case 0:
                    brush = Brushes.Green;
                    break;
                case 1:
                    brush = Brushes.Pink;
                    break;
                case 2:
                    brush = Brushes.Red;
                    break;
                case 3:
                    brush = Brushes.Yellow;
                    break;
                case 4:
                    brush = Brushes.Blue;
                    break;
                case 5:
                    brush = Brushes.Black;
                    break;
                case 6:
                    brush = Brushes.Orange;
                    break;
                case 7:
                    brush = Brushes.Purple;
                    break;
                case 8:
                    brush = Brushes.Beige;
                    break;
                case 9:
                    brush = Brushes.DarkOrchid;
                    break;
                case 10:
                    brush = Brushes.DeepSkyBlue;
                    break;
                case 11:
                    brush = Brushes.Ivory;
                    break;
                case 12:
                    brush = Brushes.SandyBrown;
                    break;
                case 13:
                    brush = Brushes.LimeGreen;
                    break;
                case 14:
                    brush = Brushes.Cornsilk;
                    break;
                case 15:
                    brush = Brushes.GreenYellow;
                    break;
                default:
                    brush = Brushes.GreenYellow;
                    break;
            }

            return new Pen(brush, 5);
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.isRectangleClicked = !this.isRectangleClicked;

            rectangleThread = new Thread(rectangleThreadMethod);
            rectangleThread.Start();
        }

        private void rectangleThreadMethod()
        {
            while(this.isRectangleClicked)
            {
                Pen pen = new Pen(Brushes.Brown, 5);
                if (this.isRandomColorClicked)
                {
                    pen = GeneratePen();
                }

                this.CreateGraphics().DrawRectangle(pen, new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), randomGenerator.Next(55, 100), randomGenerator.Next(10, 50)));
                Thread.Sleep(3000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.isTriangleClicked = !this.isTriangleClicked;

            triangleThread = new Thread(triangleThreadMethod);
            triangleThread.Start();
        }

        private void triangleThreadMethod()
        {
            while (this.isTriangleClicked)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                if (this.isRandomColorClicked)
                {
                    pen = GeneratePen();
                }

                this.CreateGraphics().DrawPolygon(pen, new Point[] {
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height)),
                    new Point(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height))
                });
                Thread.Sleep(2000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.isCircleClicked = !this.isCircleClicked;

            circleThread = new Thread(cricleThreadMethod);
            circleThread.Start();
        }

        private void cricleThreadMethod()
        {
            while(this.isCircleClicked)
            {
                Pen pen = new Pen(Brushes.Blue, 5);
                if (this.isRandomColorClicked)
                {
                    pen = GeneratePen();
                }

                int circleSize = randomGenerator.Next(50, 250);
                this.CreateGraphics().DrawEllipse(pen, new Rectangle(randomGenerator.Next(0, this.Width), randomGenerator.Next(0, this.Height), circleSize, circleSize));
                Thread.Sleep(4000);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isRandomColorClicked = !this.isRandomColorClicked;
        }
    }
}