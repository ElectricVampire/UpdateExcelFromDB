using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web;

using System.Web.Security;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Web.UI.WebControls.WebParts;

using System.Web.UI.HtmlControls;

using System.Text;

using System.IO;

namespace Update_Excel_DBData
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private DataTable invoice;
        private DataTable purchase;
        private string invoiceQuery;
        private string purchaseQuery;
        public Form1()
        {
            InitializeComponent();
            SetDateTimeFormat();

            string[] InvoiceColNames = { "Invoice_ID", "Payment_Name", "Total", "Date_Issued" };
            invoice = CreateTable(4, InvoiceColNames);

            string[] PurchaseColNames = { "Purchase_ID", "Bill_ID", "Vendor", "Status_Id", "Payment_Description", "Total", "Date_Issued" };
            purchase = CreateTable(7, PurchaseColNames);



            connection = new MySqlConnection(GetConnectionString("localhost", "finaldata", "root", ""));
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            invoiceQuery = string.Format("SELECT invoice_id,payment_name,total,date_issued FROM izhjm_invoice WHERE date_issued >= '{0} 00:00:00' AND date_issued <= '{1} 23:59:59'", dtpfrom.Text, dtpto.Text);
            purchaseQuery = string.Format("purchase_id,bill_id,vendor,payment_description,status_id,total,date_issued FROM izhjm_purchase WHERE date_issued>='{0} 00:00:00' AND date_issue <= '{1} 00:00:00'", dtpfrom.Text, dtpto.Text);
            UpdateTable(invoice, invoiceQuery);
            UpdateTable(purchase, purchaseQuery);
           
        }


        var connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\SomePath\ExcelWorkBook.xls;Extended Properties=Excel 8.0";
using (var excelConnection = new OleDbConnection(connectionString))
{
    // The excel file does not need to exist, opening the connection will create the
    // excel file for you
    if (excelConnection.State != ConnectionState.Open) { excelConnection.Open(); }

// data is an object so it works with DBNull.Value
object propertyOneValue = "cool!";
object propertyTwoValue = "testing";

var sqlText = "CREATE TABLE YourTableNameHere ([PropertyOne] VARCHAR(100), [PropertyTwo] INT)";

    // Executing this command will create the worksheet inside of the workbook
    // the table name will be the new worksheet name
    using (var command = new OleDbCommand(sqlText, excelConnection)) { command.ExecuteNonQuery(); }

    // Add (insert) data to the worksheet
    var commandText = $"Insert Into YourTableNameHere ([PropertyOne], [PropertyTwo]) Values (@PropertyOne, @PropertyTwo)";

    using (var command = new OleDbCommand(commandText, excelConnection))
    {
        // We need to allow for nulls just like we would with
        // sql, if your data is null a DBNull.Value should be used
        // instead of null 
        command.Parameters.AddWithValue("@PropertyOne", propertyOneValue ?? DBNull.Value);
        command.Parameters.AddWithValue("@PropertyTwo", propertyTwoValue ?? DBNull.Value);

        command.ExecuteNonQuery();
    }
}

        private DataTable CreateTable(int numberOfCol, string[] coloumnNames)
        {
            DataTable table = new DataTable();
            for (int i = 0; i < numberOfCol; i++)
            {
                table.Columns.Add(coloumnNames[i]);
            }
            return table;
        }

        private void UpdateTable(DataTable dt, string query)
        {
            MySqlDataAdapter myDA = new MySqlDataAdapter();
            MySqlCommand Command = new MySqlCommand(invoiceQuery, connection);
            myDA.SelectCommand = Command;
            DataTable MyDT = new DataTable();
            myDA.Fill(dt);
            myDA.Update(dt);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void SetDateTimeFormat()
        {
            dtpfrom.Format = DateTimePickerFormat.Custom;
            dtpto.Format = DateTimePickerFormat.Custom;
        }

        private string GetConnectionString(string server, string database , string uid, string password)
        {          
            return "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }
    }
}
