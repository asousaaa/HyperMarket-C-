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
    public partial class Form4 : Form
    {
        
        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        //---------------------------------------------------------------//


        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            manger_update_salary_text.Visible = false;
            manger_update_name_text.Visible = true;
            manger_update_content_text.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (manger_update_prev_name_text.Text != "")
            {
                if (Mager_update_name.Checked == true)
                {


                   
                    
                    if (manger_update_name_text.Text != "")
                    {
                        
                        
                con.Open();
                SqlCommand myCommand = new SqlCommand("  declare @varl INT " +

              "  SELECT @varl = ID   from MANAGER where Ename = '"+ manger_update_prev_name_text.Text +"'"
              + "update MANAGER set ENAME = '"+ manger_update_name_text.Text +"' where ID = @varl ", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
                     }
                    }

                if (manger_update_content.Checked == true)
                {


                   
                    

                    if (manger_update_content_text.Text != "")
                    {
                        
                        
                con.Open();
                SqlCommand myCommand = new SqlCommand("  declare @varl INT " +

              "  SELECT @varl = ID   from MANAGER where Ename = '"+ manger_update_prev_name_text.Text +"'"
              + "update MANAGER set CONTACT = " + manger_update_content_text.Text + " where ID = @varl ", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
                       }
                    }


                if (manger_updatesalary.Checked == true)
                {
                   
                           
                    if (manger_update_salary_text.Text != "")
                    {
                        
                        
                con.Open();
                SqlCommand myCommand = new SqlCommand("  declare @varl INT " +

              "  SELECT @varl = ID   from MANAGER where Ename = '"+ manger_update_prev_name_text.Text +"'"
              + "update MANAGER set SALARY = " + manger_update_salary_text.Text + " where ID = @varl ", con);
                int success = myCommand.ExecuteNonQuery();
                if (success == 1)
                    MessageBox.Show(success + " row has been inserted ");
                con.Close();
                             }
                    


                manger_update_salary_text.ResetText();
                manger_update_name_text.ResetText();
                manger_update_content_text.ResetText();
                manger_update_prev_name_text.ResetText();
                   

                }
            }
        }

        private void manger_updatesalary_CheckedChanged(object sender, EventArgs e)
        {
            manger_update_salary_text.Visible = true;
            manger_update_name_text.Visible = false;
            manger_update_content_text.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
        }

        private void manger_update_content_CheckedChanged(object sender, EventArgs e)
        {
            manger_update_salary_text.Visible = false;
            manger_update_name_text.Visible = false;
            manger_update_content_text.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;
        }
            
    }
}
