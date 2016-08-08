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
    public partial class Form2 : Form
    {




        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        //---------------------------------------------------------------//


        public Form2()
        {
            InitializeComponent();
        }

        private void Insert_back_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;

        }

        private void manger_insert_button_Click(object sender, EventArgs e)
        {
            if (manger_content.Text != "" && manger_name.Text != "" && manger_salary.Text != "")
            {
               
  
 
                con.Open();
                SqlCommand myCommand = new SqlCommand("  declare @varl INT " +

              "  SELECT @varl = MAX (ID)   from MANAGER " + "set @varl = @varl+1 insert into MANAGER values ( @varl " + ",'" +
                    manger_name.Text + "', " + 
                   manger_content.Text + ","+ manger_salary.Text +")", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
            }
        }

       
    }
}
