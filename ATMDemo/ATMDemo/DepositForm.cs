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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
                string sql = "insert into Card(Transaction_Date,CardNo,AccNo,Transaction_Mode,Account_Type,Ammount,Pin) Values(@tDate,@cardno,@accno,@tMode,@aType,@ammount,@pin)";
                string sql1 = "select Balance ,AccNo from user where Pin = @pin";
                string sql2 = " update User set Balance = @balance WHERE CardNo = @cardno";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlCommand command2 = new MySqlCommand(sql2, connection);
                User user = new User();
                Card card = new Card();
                DateTime tDate = DateTime.Now;
                double cardno = Convert.ToDouble(ATMApp.SetValueForText2);

                string tmode = "withdraw";
                string atype = cmbAtype.Text.ToString();

                decimal ammount = Convert.ToDecimal(txtAmount.Text);

                int pin = Convert.ToInt32(ATMApp.SetValueForText1);


                command.Parameters.AddWithValue("tDate", tDate);
                command.Parameters.AddWithValue("cardno", cardno);

                command.Parameters.AddWithValue("tmode", tmode);
                command.Parameters.AddWithValue("atype", atype);
                command.Parameters.AddWithValue("ammount", ammount);

                command2.Parameters.AddWithValue("cardno", cardno);
                command.Parameters.AddWithValue("pin", pin);
                command1.Parameters.AddWithValue("pin", pin);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlDataReader reader = command1.ExecuteReader();
                reader.Read();
                string data = reader["Balance"].ToString();
                string data2 = reader["AccNo"].ToString();
                long accno = long.Parse(reader["AccNo"].ToString());
                double? AccNo = accno;
                decimal data1 = decimal.Parse(data) + ammount;



                command2.Parameters.AddWithValue("balance", data1);
                command.Parameters.AddWithValue("accno", accno);

                reader.Close();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                MessageBox.Show("Money Deposit successfully");
                MessageBox.Show("Ammount"+ ammount + " "+"has been Credited successfully");

                txtAmount.Clear();
            }
            catch (Exception)
            {

                throw;
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
