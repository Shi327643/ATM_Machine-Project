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
using System.Configuration;
namespace ATMDemo
{
    public partial class ATMApp : Form
    {
        TransactionDataStore dataStore;
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public ATMApp()
        {
            InitializeComponent();
            dataStore = new TransactionDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCardNo.Text == String.Empty && txtPin.Text == String.Empty)
                {
                    MessageBox.Show("Please enter the card number and Pin");
                    return;
                }
                User user = new User()
                {
                    CardNo = long.Parse(txtCardNo.Text),
                    Pin = Convert.ToInt32(txtPin.Text)
                };

                //int count = dataStore.ValidateUser(cardno, pin);
                if (txtCardNo.Text == String.Empty && txtPin.Text == String.Empty)
                {
                    MessageBox.Show("Enter card number and password");
                }
                else
                {
                    MessageBox.Show("login Successfull");
                    dataStore.ValidateUser(user);
                    //lblMessage.Text = "Loggin Successfull";
                    TransactionModeForm transactionModeForm = new TransactionModeForm();
                    transactionModeForm.Show();
                    SetValueForText1 = txtPin.Text;
                    SetValueForText2 = txtCardNo.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
