using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace VaccineRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "Data Source=TIISETSO;Initial Catalog=VaccineReg;Integrated Security=True";
                String queryTwo = "insert into VaccineApplications(ID, Surname, Firstname, Gender, Province)" +
                "Values('" + Int64.Parse(ID1.Text) + "','" + Surnametxt.Text +
                "','" + nametxt.Text + "','" + gendercb.Text + "','" + provincecb.Text + "')";

                String query = "select * from data";
                SqlConnection con = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(queryTwo, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The information has been stored! Thank you for registering");
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
