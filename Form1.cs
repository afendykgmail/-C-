namespace Рисуем_на_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point click; // 11:40 created new object
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Black); // 3:57  https://youtu.be/yrGBmu9Ee7o?si=3NQj2ZL3bPzriQMC           
            g.DrawEllipse(Pens.Blue, 100, 100, 300, 200); // Ошибка компилятора CS1501  https://tinyurl.com/25p5n8he

            //Был произведен вызов метода класса, но ни одно определение метода не принимает указанное количество аргументов.
            g.DrawEllipse(Pens.Red, 100, 100, 200, 200);
            g.FillEllipse(Brushes.Coral, 50, 150, 150, 50); // https://youtu.be/iFV5A7tyoUc?si=0v2n4LZ79Q9s7gYz 4:50
            g.DrawRectangle(Pens.Green, 300, 300, 300, 200);
            g.DrawLine(Pens.White, 600, 150, 150, 300); // 9:32

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;  // 12:03
            //g.DrawRectangle(Pens.Yellow, click.X, click.Y, 100, 50);    // 13:05
            g.DrawEllipse(Pens.Red, click.X, click.Y, 100, 200);
            g.DrawEllipse(Pens.Green, click.X, click.Y, 200, 100);
            g.DrawEllipse(Pens.White, click.X, click.Y, 20, 20);
            g.FillEllipse(Brushes.Yellow, click.X, click.Y, 50, 50);
        }
    }
}