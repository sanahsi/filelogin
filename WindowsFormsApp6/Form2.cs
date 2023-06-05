using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class loginForm2 : Form
    {
        public loginForm2()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Arf\\source\\repos\\WindowsFormsApp6\\WindowsFormsApp6\\Database1.mdf;Integrated Security=True");
         sc.Open();
         String query = "SELECT name,student code FROM students";
         SqlCommand command = new SqlCommand(query, sc);
         SqlDataReader reader = command.ExecuteReader();

         while (reader.Read())
            {
                String name = reader["name"].ToString();
                if (name == textBox1.Text) ;
                String password = reader["password"].ToString();
                if ( password == textBox2.Text) ;
                this.Hide();

          else
          MessageBox.Show("WRONG PASSWORD OR NAME");
                sc.Close();

         }


        


        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
