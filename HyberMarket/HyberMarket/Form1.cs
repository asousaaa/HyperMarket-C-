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
    public partial class Form1 : Form
    {


        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        //---------------------------------------------------------------//


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Insert_funcation_Click(object sender, EventArgs e)
        {
            
           this.Hide();
           Form form2 = new Form2();
           form2.Visible = true;          
            /*
            con.Open();
            SqlCommand myCommand = new SqlCommand("insert into CUSTOMER values ('"+"HOSAM"+"', "+"2016" + ")", con);
            int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                MessageBox.Show(success + " row has been inserted ");   
            con.Close(); */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form3();
            form2.Visible = true; 
        }

        private void Update_function_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form4();
            form2.Visible = true; 
        }

        private void Delete_function_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form5();
            form2.Visible = true; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form6();
            form2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form7();
            form2.Visible = true;
        }
    }
}
