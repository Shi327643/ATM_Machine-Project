using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankDataAccessLibrary;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace ATMDemo
{
    public partial class BalanceEnquiryForm : Form
    {
        

        public BalanceEnquiryForm()
        {
            InitializeComponent();
            

        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {

                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

                string sql = "select Balance from User where Pin = @pin";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command = new MySqlCommand(sql, connection);

                int pin = Convert.ToInt32(ATMApp.SetValueForText1);
                command.Parameters.AddWithValue("pin", pin);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lblMessage.Text = reader["Balance"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Pin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: \n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
