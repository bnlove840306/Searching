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


        //���Ӷ���
        MySqlConnection conn = null;

        //���ִ�ж���
        MySqlCommand comm = null;
        //���ִ�н�����ݶ���
        MySqlDataReader dr = null;

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Database = bn;Server = localhost;Port = 3306;Password = bn.com;UserID = bainan;charset = utf8mb4");


            //�ж�����״̬
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                //tbText.Text = strConn;
                //label4.Text = "";
                label1.Text = "���ӳɹ�";
                button2.Enabled = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            comm = new MySqlCommand("select * from bntest_tbl", conn);
            dr = comm.ExecuteReader(); /*��ѯ*/
            //dr = comm.ExecuteNonQuery();  /*��ɾ��*/

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