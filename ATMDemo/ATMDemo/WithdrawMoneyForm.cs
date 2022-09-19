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
    public partial class WithdrawMoneyForm : Form
    {
        public WithdrawMoneyForm()
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
                string sql3 = "select  Ammount from Card where Pin = @pin";
                string sql4 = "select count(Transaction_Date) as count_Date from Card where Pin = @pin";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlCommand command1 = new MySqlCommand(sql1, connection);
                MySqlCommand command2 = new MySqlCommand(sql2, connection);
                MySqlCommand command3 = new MySqlCommand(sql3, connection);
                MySqlCommand command4 = new MySqlCommand(sql4, connection);
                
                User user = new User();
                Card card = new Card();
                DateTime tDate = DateTime.Now;
                double cardno = Convert.ToDouble(ATMApp.SetValueForText2);
                
                string tmode = "withdraw";
                string atype = cmbAtype.Text.ToString();

                decimal ammount = Convert.ToDecimal(txtAmount.Text);

                
                if (ammount <500 )
                {
                    MessageBox.Show("Please enter ammount above 500");
                    return;
                }
                else if(ammount > 20000)
                {
                    MessageBox.Show("Please enter amount less than 20000");
                    return;
                }

                int pin = Convert.ToInt32(ATMApp.SetValueForText1);


                command.Parameters.AddWithValue("tDate",tDate );
                command.Parameters.AddWithValue("cardno", cardno);
               
                command.Parameters.AddWithValue("tmode", tmode);
                command.Parameters.AddWithValue("atype", atype);
                command.Parameters.AddWithValue("ammount", ammount);
                command.Parameters.AddWithValue("pin", pin);

                command1.Parameters.AddWithValue("pin", pin);

                command2.Parameters.AddWithValue("cardno", cardno);
                command3.Parameters.AddWithValue("pin", pin);

                
                command4.Parameters.AddWithValue("pin", pin);

                

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
                decimal data1 = decimal.Parse(data) - ammount;

                

                command2.Parameters.AddWithValue("balance", data1);
                command.Parameters.AddWithValue("accno", accno);
                
                reader.Close();

                
                MySqlDataReader reader1 = command4.ExecuteReader();
                reader1.Read();

                string date = reader1["count_Date"].ToString();

                

                int count = int.Parse(reader1["count_Date"].ToString());
                
                reader1.Close();

                if ( count>2)
                {
                    MessageBox.Show("Transaction limit for the day has been exceeded", "Sorry, no more Transaction");
                }
                else
                {
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();

                    MessageBox.Show("Money withdrwal successfully");
                    MessageBox.Show("Ammount" + ammount + "has been debited from your account");
                }
                

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
