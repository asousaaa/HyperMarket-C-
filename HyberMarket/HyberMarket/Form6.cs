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
    public partial class Form6 : Form
    {

        //-----------------connection with Database----------------------------//
        public ErrorProvider errorProvider1 = new ErrorProvider();
        SqlConnection con = new SqlConnection(@"Data Source=ESOOOO\SQLEXPRESS;Initial Catalog=Hyper_matket;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader reader;
        //---------------------------------------------------------------//


        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Open();
            DataTable t = new DataTable();
            SqlDataAdapter cmd = new SqlDataAdapter("select  MANAGER.ID as 'Manger id' , MANAGER.ENAME as 'Manager name' , " +
             " count( EMPLOYEE.ID) as 'Num Of Employees' , " +
  " SUM(EMPLOYEE.ESALARY) as 'Total Employee Salary' " +
  " from MANAGER inner join  EMPLOYEE " +
  " on  MANAGER.ID =  EMPLOYEE.ID " +
  " group by  MANAGER.ID  , MANAGER.ENAME ", con);

            cmd.Fill(t);
            complex_select1.Visible = true;
            complex_select1.DataSource = t;

            con.Close();






           

             con.Open();
             DataTable t2 = new DataTable();
             SqlDataAdapter cmd2 = new SqlDataAdapter(" select  MANAGER.ENAME as 'manger name ' "+
               " , SUPPLIERS.SNAME as 'supplier name ',PRODUCT.PNAME "+
   "         as 'product name ' ,PRODUCT.PRICE as ' product price ' "+
"  from MANAGER full outer join SUPPLIERS on MANAGER.ID= SUPPLIERS.ID "+
" full outer join PRODUCT on SUPPLIERS.SID=PRODUCT.SID "+
" where PRODUCT.PRICE in (select PRODUCT.PRICE from PRODUCT where PRODUCT.PRICE >5)",con);

            cmd2.Fill(t2);
            complex_select2.Visible = true;
            complex_select2.DataSource = t2;

            con.Close();

       
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hyper_matketDataSet.MANAGER' table. You can move, or remove it, as needed.
            this.mANAGERTableAdapter.Fill(this.hyper_matketDataSet.MANAGER);

        }
    }
}
