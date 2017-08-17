using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Auth;


namespace TableStorageAzure1
{
    public partial class AzureForm : Form
    {
        /*string storageAccountName = "augappdiag253";
        string accountAccountKey = "6w6ranWlhfOyWrorrZIUGLQ6KmECvJZNIEkVSpVS9A0jIW9FOw7EPvNq8pSk1n3gMrFaz3O2KeJJs4lbSmyahQ==";*/
        CloudStorageAccount account = new CloudStorageAccount(
            new StorageCredentials("augappdiag253", "6w6ranWlhfOyWrorrZIUGLQ6KmECvJZNIEkVSpVS9A0jIW9FOw7EPvNq8pSk1n3gMrFaz3O2KeJJs4lbSmyahQ=="), true);
        
        public class Product : TableEntity
        {
            public int ProdID { get; set; }
            public string ProdName { get; set; }
            public int Price { get; set; }
            
        }

        public AzureForm()
        {
            InitializeComponent();
            
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            /*StorageCredentials storageCredentials = new StorageCredentials(storageAccountName, accountAccountKey);
            CloudStorageAccount account = new CloudStorageAccount(storageCredentials, useHttps: true);*/
            CloudTableClient cloudTableClient = account.CreateCloudTableClient();
            string tableName = tableNameTxt.Text;
            CloudTable azureTable = cloudTableClient.GetTableReference(tableName);
            azureTable.CreateIfNotExists();
            MessageBox.Show("Azure table is created");

        }
        private void AddDatabtn_Click(object sender, EventArgs e)
        {
            var prodEntity = new Product
            {
                ProdID = int.Parse(pruductIdTxt.Text),
                ProdName = productNameTxt.Text,
                Price = int.Parse(productPriceTxt.Text)
            };
            CloudTableClient cloudTableClient = account.CreateCloudTableClient();
            CloudTable azureTable = cloudTableClient.GetTableReference("TestTable");
            prodEntity.RowKey = prodEntity.ProdID + "" + ProductName;
            prodEntity.PartitionKey =prodEntity.Price.ToString();
            TableOperation tableOperation = TableOperation.Insert(prodEntity);
            azureTable.Execute(tableOperation);
            MessageBox.Show("Data added to Azure table");

        }

        private void blobsBtn_Click(object sender, EventArgs e)
        {
            CloudTableClient cloudTableClient = account.CreateCloudTableClient();
            CloudTable azureTable = cloudTableClient.GetTableReference("TestTable");
            TableQuery<Product> query = new TableQuery<Product>();
            var prodEntites = azureTable.ExecuteQuery(query);
            foreach (var entity in prodEntites)
            {
                listBox1.Items.Add(entity.ProdID + "  " + entity.ProdName + "  " + entity.Price);
            }

        }
    }
}
