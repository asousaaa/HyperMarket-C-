using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HyberMarket
{
    public partial class Form5 : Form
    {


        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        //---------------------------------------------------------------//


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (manger_name.Text != "")
            {


                con.Open();
                errorProvider1.Clear();
                cmd.Connection = con;
                SqlCommand myCommand = new SqlCommand("delete from MANAGER where ENAME= '" + manger_name.Text + "'", con);
                int success = myCommand.ExecuteNonQuery();
                MessageBox.Show(success + " row has been Deleted");
                con.Close();

            }
        }


      

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
