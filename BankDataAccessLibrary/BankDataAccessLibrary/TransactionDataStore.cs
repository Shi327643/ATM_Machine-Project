using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BankDataAccessLibrary
{
    public class TransactionDataStore
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        public TransactionDataStore(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        User user = new User();
        Card card = new Card();

        public List<User> GetAllUsers()
        {
            try
            {
                string sql = "select CardNo,FirstName,LastName,Pin,AccNo,ContactNo,Balance from User";
                command = new MySqlCommand(sql, connection);
                
               

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();
                List<User> userList = new List<User>();

                while (reader.Read())
                {
                    User user = new User();
                    user.CardNo = (long)reader["CardNo"];
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.Pin = (int)reader["Pin"];
                    user.AccNo = (long)reader["AccNo"];
                    user.ContactNo = (long)reader["ContactNo"];
                    user.Balance = reader["Balance"] as decimal?;

                    userList.Add(user);

                }
                return userList;
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


        public bool ValidateUser(User user)
        {
            try
            {
                string sql = "select * from User where CardNo = @cardno  and Pin = @pin";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("cardno", user.CardNo);
                command.Parameters.AddWithValue("pin", user.Pin);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }

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

        


        public List<Card> CheckPreviousTransaction(int pin)
        {
            try
            {
                string sql = "select Transaction_Date,AccNo,Transaction_Mode,Account_Type ,Ammount from Card where Pin = @pin limit 3";
                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("pin", pin);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                List<Card> cardList = new List<Card>();

                while (reader.Read())
                {
                    Card card = new Card();
                    card.TransactionDate =  (DateTime) reader["Transaction_Date"];
                    card.AccNo = reader["AccNo"] as long?;
                    card.TransactionMode = reader["Transaction_Mode"].ToString();
                    card.AccountType = reader["Account_Type"].ToString();
                    card.Ammount = reader["Ammount"] as decimal?;


                    cardList.Add(card);

                    //add this object on empListcollection
                }
                return cardList;
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


    }
}
