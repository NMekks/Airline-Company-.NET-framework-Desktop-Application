namespace Airline_company
{
    partial class Record
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
            this.components = new System.ComponentModel.Container();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.passengerNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerInfo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airLineDataSet = new Airline_company.AirLineDataSet();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.passengerInfo1TableAdapter = new Airline_company.AirLineDataSetTableAdapters.PassengerInfo1TableAdapter();
            this.tableAdapterManager = new Airline_company.AirLineDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerInfo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airLineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.AutoGenerateColumns = false;
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passengerNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.passportNumberDataGridViewTextBoxColumn,
            this.pEDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.primaryContactDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cityFromDataGridViewTextBoxColumn,
            this.cityToDataGridViewTextBoxColumn,
            this.departDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.ticketTypeDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dgvPassenger.DataSource = this.passengerInfo1BindingSource;
            this.dgvPassenger.Location = new System.Drawing.Point(163, 85);
            this.dgvPassenger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.RowHeadersWidth = 51;
            this.dgvPassenger.RowTemplate.Height = 24;
            this.dgvPassenger.Size = new System.Drawing.Size(848, 441);
            this.dgvPassenger.TabIndex = 0;
            this.dgvPassenger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassenger_CellClick);
            this.dgvPassenger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassenger_CellContentClick);
            // 
            // passengerNumberDataGridViewTextBoxColumn
            // 
            this.passengerNumberDataGridViewTextBoxColumn.DataPropertyName = "PassengerNumber";
            this.passengerNumberDataGridViewTextBoxColumn.HeaderText = "PassengerNumber";
            this.passengerNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengerNumberDataGridViewTextBoxColumn.Name = "passengerNumberDataGridViewTextBoxColumn";
            this.passengerNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportNumberDataGridViewTextBoxColumn
            // 
            this.passportNumberDataGridViewTextBoxColumn.DataPropertyName = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.HeaderText = "PassportNumber";
            this.passportNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportNumberDataGridViewTextBoxColumn.Name = "passportNumberDataGridViewTextBoxColumn";
            this.passportNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // pEDDataGridViewTextBoxColumn
            // 
            this.pEDDataGridViewTextBoxColumn.DataPropertyName = "PED";
            this.pEDDataGridViewTextBoxColumn.HeaderText = "PED";
            this.pEDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pEDDataGridViewTextBoxColumn.Name = "pEDDataGridViewTextBoxColumn";
            this.pEDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.Width = 125;
            // 
            // primaryContactDataGridViewTextBoxColumn
            // 
            this.primaryContactDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContact";
            this.primaryContactDataGridViewTextBoxColumn.HeaderText = "PrimaryContact";
            this.primaryContactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primaryContactDataGridViewTextBoxColumn.Name = "primaryContactDataGridViewTextBoxColumn";
            this.primaryContactDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            this.countryCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityFromDataGridViewTextBoxColumn
            // 
            this.cityFromDataGridViewTextBoxColumn.DataPropertyName = "CityFrom";
            this.cityFromDataGridViewTextBoxColumn.HeaderText = "CityFrom";
            this.cityFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityFromDataGridViewTextBoxColumn.Name = "cityFromDataGridViewTextBoxColumn";
            this.cityFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityToDataGridViewTextBoxColumn
            // 
            this.cityToDataGridViewTextBoxColumn.DataPropertyName = "CityTo";
            this.cityToDataGridViewTextBoxColumn.HeaderText = "CityTo";
            this.cityToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityToDataGridViewTextBoxColumn.Name = "cityToDataGridViewTextBoxColumn";
            this.cityToDataGridViewTextBoxColumn.Width = 125;
            // 
            // departDateDataGridViewTextBoxColumn
            // 
            this.departDateDataGridViewTextBoxColumn.DataPropertyName = "DepartDate";
            this.departDateDataGridViewTextBoxColumn.HeaderText = "DepartDate";
            this.departDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departDateDataGridViewTextBoxColumn.Name = "departDateDataGridViewTextBoxColumn";
            this.departDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketTypeDataGridViewTextBoxColumn
            // 
            this.ticketTypeDataGridViewTextBoxColumn.DataPropertyName = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.HeaderText = "TicketType";
            this.ticketTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketTypeDataGridViewTextBoxColumn.Name = "ticketTypeDataGridViewTextBoxColumn";
            this.ticketTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 125;
            // 
            // passengerInfo1BindingSource
            // 
            this.passengerInfo1BindingSource.DataMember = "PassengerInfo1";
            this.passengerInfo1BindingSource.DataSource = this.airLineDataSet;
            // 
            // airLineDataSet
            // 
            this.airLineDataSet.DataSetName = "AirLineDataSet";
            this.airLineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(197, 42);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(285, 41);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(688, 24);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(459, 558);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(233, 41);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // passengerInfo1TableAdapter
            // 
            this.passengerInfo1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PassengerInfo1TableAdapter = this.passengerInfo1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Airline_company.AirLineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 636);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvPassenger);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerInfo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airLineDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnback;
        private AirLineDataSet airLineDataSet;
        private System.Windows.Forms.BindingSource passengerInfo1BindingSource;
        private AirLineDataSetTableAdapters.PassengerInfo1TableAdapter passengerInfo1TableAdapter;
        private AirLineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
    }
}