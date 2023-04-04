namespace WinFormsApp1
{
    using MySql.Data.MySqlClient;
    using MySql.Data;
    using System.Data;

    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            button2.Enabled=false;
        }


        //连接对象
        MySqlConnection conn = null;

        //语句执行对象
        MySqlCommand comm = null;
        //语句执行结果数据对象
        MySqlDataReader dr = null;

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Database = bn;Server = localhost;Port = 3306;Password = bn.com;UserID = bainan;charset = utf8mb4");


            //判断连接状态
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                //tbText.Text = strConn;
                //label4.Text = "";
                label1.Text = "连接成功";
                button2.Enabled = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            comm = new MySqlCommand("select * from bntest_tbl", conn);
            dr = comm.ExecuteReader(); /*查询*/
            //dr = comm.ExecuteNonQuery();  /*增删改*/

            label1.Text = String.Empty;
            while (dr.Read())
            {
                label1.Text += dr.GetString("user_name") + "|" + dr.GetString("user_address");
                label1.Text += "\r";
            }
            dr.Close();
            conn.Close();
        }
    }
}