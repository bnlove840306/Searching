namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 0 
        // 1 = ����
        // 2 = �뿪
        //private static int mousestate = 0;

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //���������ж�
            // 1. ����Top����С��2ʱ�����ش�����������
            // 2. Top������>-Height+3(����ֹͣ��������+3��Ϊ��¶��3���صľ��࣬�����û��ҵ����صĴ��壩
            // 3. IsMouseOver ��겻�ڴ����ϵ�ʱ��
            while (Top <= 2 && Top > -Height + 20 && !isMouseIn())
            {
                //����Top����-1
                Top -= 1;
            }

            while (Left <= 2 && Left > -Width + 20 && isMouseIn())
            {
                //����Top����-1
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
            //��������������С��-1
            // ���ͣ��������Top���� =-1 ��ʱ�򣬴���Ͳ������ƶ���
            //      �����ͽ���ˣ�����������������
            while (this.Top < -1)
                //����������겻�� +1
                this.Top += this.Height - 20;
            //if (this.Top==0) {
            //    this.Top += 1;
            //}
        }
    }
}