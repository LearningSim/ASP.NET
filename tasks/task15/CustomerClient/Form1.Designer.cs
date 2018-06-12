namespace CustomerClient {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.countryList = new System.Windows.Forms.ComboBox();
			this.customerGrid = new System.Windows.Forms.DataGridView();
			this.customerManagementDataSet = new CustomerClient.CustomerManagementDataSet();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new CustomerClient.CustomerManagementDataSetTableAdapters.CustomersTableAdapter();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerManagementDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// countryList
			// 
			this.countryList.FormattingEnabled = true;
			this.countryList.Location = new System.Drawing.Point(13, 13);
			this.countryList.Name = "countryList";
			this.countryList.Size = new System.Drawing.Size(145, 21);
			this.countryList.TabIndex = 0;
			this.countryList.SelectedIndexChanged += new System.EventHandler(this.countryList_SelectedIndexChanged);
			// 
			// customerGrid
			// 
			this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Address,
            this.City,
            this.Country});
			this.customerGrid.Location = new System.Drawing.Point(13, 53);
			this.customerGrid.Name = "customerGrid";
			this.customerGrid.Size = new System.Drawing.Size(696, 150);
			this.customerGrid.TabIndex = 1;
			// 
			// customerManagementDataSet
			// 
			this.customerManagementDataSet.DataSetName = "CustomerManagementDataSet";
			this.customerManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.customerManagementDataSet;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "FirstName";
			this.FirstName.Name = "FirstName";
			// 
			// LastName
			// 
			this.LastName.HeaderText = "LastName";
			this.LastName.Name = "LastName";
			// 
			// Address
			// 
			this.Address.HeaderText = "Address";
			this.Address.Name = "Address";
			// 
			// City
			// 
			this.City.HeaderText = "City";
			this.City.Name = "City";
			// 
			// Country
			// 
			this.Country.HeaderText = "Country";
			this.Country.Name = "Country";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 262);
			this.Controls.Add(this.customerGrid);
			this.Controls.Add(this.countryList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerManagementDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox countryList;
		private System.Windows.Forms.DataGridView customerGrid;
		private CustomerManagementDataSet customerManagementDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private CustomerManagementDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
	}
}

