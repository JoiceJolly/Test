namespace TableStorageAzure1
{
    partial class AzureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableNameTxt = new System.Windows.Forms.TextBox();
            this.pruductIdTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.blobsBtn = new System.Windows.Forms.Button();
            this.AddDatabtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azure Table App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Azure Table Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Product Price";
            // 
            // tableNameTxt
            // 
            this.tableNameTxt.Location = new System.Drawing.Point(167, 80);
            this.tableNameTxt.Name = "tableNameTxt";
            this.tableNameTxt.Size = new System.Drawing.Size(100, 20);
            this.tableNameTxt.TabIndex = 5;
            // 
            // pruductIdTxt
            // 
            this.pruductIdTxt.Location = new System.Drawing.Point(167, 119);
            this.pruductIdTxt.Name = "pruductIdTxt";
            this.pruductIdTxt.Size = new System.Drawing.Size(100, 20);
            this.pruductIdTxt.TabIndex = 6;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(167, 160);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(100, 20);
            this.productNameTxt.TabIndex = 7;
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(167, 195);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.productPriceTxt.TabIndex = 8;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(409, 77);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(95, 36);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Click to Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // blobsBtn
            // 
            this.blobsBtn.Location = new System.Drawing.Point(544, 80);
            this.blobsBtn.Name = "blobsBtn";
            this.blobsBtn.Size = new System.Drawing.Size(90, 33);
            this.blobsBtn.TabIndex = 10;
            this.blobsBtn.Text = "List Blobs!!";
            this.blobsBtn.UseVisualStyleBackColor = true;
            this.blobsBtn.Click += new System.EventHandler(this.blobsBtn_Click);
            // 
            // AddDatabtn
            // 
            this.AddDatabtn.Location = new System.Drawing.Point(167, 251);
            this.AddDatabtn.Name = "AddDatabtn";
            this.AddDatabtn.Size = new System.Drawing.Size(100, 26);
            this.AddDatabtn.TabIndex = 11;
            this.AddDatabtn.Text = "AddData";
            this.AddDatabtn.UseVisualStyleBackColor = true;
            this.AddDatabtn.Click += new System.EventHandler(this.AddDatabtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(409, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 121);
            this.listBox1.TabIndex = 13;
            // 
            // AzureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 311);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddDatabtn);
            this.Controls.Add(this.blobsBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.productPriceTxt);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.pruductIdTxt);
            this.Controls.Add(this.tableNameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzureForm";
            this.Text = "AzureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tableNameTxt;
        private System.Windows.Forms.TextBox pruductIdTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button blobsBtn;
        private System.Windows.Forms.Button AddDatabtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}