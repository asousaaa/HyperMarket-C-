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
    public partial class Form3 : Form
    {
        string output;
        int findsimple = 0;
        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        
        //---------------------------------------------------------------//



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hyper_matketDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.hyper_matketDataSet.EMPLOYEE);
            // TODO: This line of code loads data into the 'hyper_matketDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.hyper_matketDataSet.CUSTOMER);

        }

        private void sim_select_customer_find_Click(object sender, EventArgs e)
        {
            con.Close();
            if (Sim_select_customer_name.Text != "")
            {
                customer_sim_secect_view.Visible = true;
                  try
                {
               
                 con.Open();
                SqlCommand cmd = new SqlCommand("select * from CUSTOMER where NAME ="+"'"+ Sim_select_customer_name.Text +"'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                customer_sim_secect_view.DataSource = ds.Tables["ss"]; ;
                Sim_select_customer_name.ResetText(); 
               
                }
                catch 
                {
               
                Sim_select_customer_name.ResetText(); 
                customer_sim_secect_view.Visible = false;
                con.Close();
                con.Open();
                }
                 

            }
        }

        private void employee_sim_select_find_Click(object sender, EventArgs e)
        {
           con.Close();

            if (employee_sim_select_name.Text != "")
            {
               
                employee_sim_secect_View.Visible = true;
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from EMPLOYEE where ENAME =" + "'" + employee_sim_select_name.Text + "'", con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ss");
                    employee_sim_secect_View.Visible = true;
                    employee_sim_secect_View.DataSource = ds.Tables["ss"]; ;
                    employee_sim_select_name.ResetText();
                

                }
                catch
                {
                    employee_sim_select_name.ResetText();
                    employee_sim_secect_View.Visible = false;
                  
                    con.Close();
                    con.Open();
                  
                }


            }
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }






    }
}
