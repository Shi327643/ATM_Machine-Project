using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using BankDataAccessLibrary;

namespace ATMDemo
{
    public partial class PreviousHistoryForm : Form
    {
        TransactionDataStore dataStore;
        public PreviousHistoryForm()
        {
            InitializeComponent();
            dataStore = new TransactionDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int pin = Convert.ToInt32(ATMApp.SetValueForText1);
                historyDataGrid.DataSource = dataStore.CheckPreviousTransaction(pin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
