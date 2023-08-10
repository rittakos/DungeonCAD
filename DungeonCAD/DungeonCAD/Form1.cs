namespace DungeonCAD
{
    public partial class Form1 : Form
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(100, 100);
        bool draw = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(!draw)
                return;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, p1, p2);
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            draw = true;
            panel.Refresh();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            //e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            int a = 0;
        }
    }
}