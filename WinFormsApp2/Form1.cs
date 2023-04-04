namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 0 
        // 1 = 进入
        // 2 = 离开
        //private static int mousestate = 0;

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //三个条件判断
            // 1. 窗体Top坐标小于2时候（隐藏触发的条件）
            // 2. Top的坐标>-Height+3(隐藏停止的条件，+3是为了露出3像素的据类，方便用户找到隐藏的窗体）
            // 3. IsMouseOver 鼠标不在窗体上的时候
            while (Top <= 2 && Top > -Height + 20 && !isMouseIn())
            {
                //窗体Top不断-1
                Top -= 1;
            }

            while (Left <= 2 && Left > -Width + 20 && isMouseIn())
            {
                //窗体Top不断-1
                Left -= 1;
            }

        }

        private bool isMouseIn()
        {
            Point Mp = Control.MousePosition;
            Point Fp = this.PointToClient(Mp);
            Point Fp2 = this.PointToScreen(Mp);

            if (Mp.X>this.ClientSize.Width || Mp.X<0 || Mp.Y>this.ClientSize.Height || Mp.Y<0  ) {
                return false;
            }
            return true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            //如果窗体的上坐标小于-1
            // 解释：当窗体的Top坐标 =-1 的时候，窗体就不向下移动了
            //      这样就解决了，窗体上下跳的问题
            while (this.Top < -1)
                //窗体的上坐标不断 +1
                this.Top += this.Height - 20;
            //if (this.Top==0) {
            //    this.Top += 1;
            //}
        }
    }
}