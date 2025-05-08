namespace MobileShopManagementSystem
{
    partial class SearchPhoneRecord
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phoneDataSet = new MobileShopManagementSystem.phoneDataSet();
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesTableAdapter = new MobileShopManagementSystem.phoneDataSetTableAdapters.PhonesTableAdapter();
            this.phoneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istorageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estorageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rearcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frontcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(342, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(355, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(236, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Phone Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(251, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Search Phone Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneidDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.ramDataGridViewTextBoxColumn,
            this.istorageDataGridViewTextBoxColumn,
            this.estorageDataGridViewTextBoxColumn,
            this.displayDataGridViewTextBoxColumn,
            this.rearcDataGridViewTextBoxColumn,
            this.frontcDataGridViewTextBoxColumn,
            this.fingerDataGridViewTextBoxColumn,
            this.simDataGridViewTextBoxColumn,
            this.networkDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.phonesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 237);
            this.dataGridView1.TabIndex = 49;
            // 
            // phoneDataSet
            // 
            this.phoneDataSet.DataSetName = "phoneDataSet";
            this.phoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            this.phonesBindingSource.DataSource = this.phoneDataSet;
            // 
            // phonesTableAdapter
            // 
            this.phonesTableAdapter.ClearBeforeFill = true;
            // 
            // phoneidDataGridViewTextBoxColumn
            // 
            this.phoneidDataGridViewTextBoxColumn.DataPropertyName = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.HeaderText = "phone_id";
            this.phoneidDataGridViewTextBoxColumn.Name = "phoneidDataGridViewTextBoxColumn";
            this.phoneidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // ramDataGridViewTextBoxColumn
            // 
            this.ramDataGridViewTextBoxColumn.DataPropertyName = "ram";
            this.ramDataGridViewTextBoxColumn.HeaderText = "ram";
            this.ramDataGridViewTextBoxColumn.Name = "ramDataGridViewTextBoxColumn";
            // 
            // istorageDataGridViewTextBoxColumn
            // 
            this.istorageDataGridViewTextBoxColumn.DataPropertyName = "istorage";
            this.istorageDataGridViewTextBoxColumn.HeaderText = "istorage";
            this.istorageDataGridViewTextBoxColumn.Name = "istorageDataGridViewTextBoxColumn";
            // 
            // estorageDataGridViewTextBoxColumn
            // 
            this.estorageDataGridViewTextBoxColumn.DataPropertyName = "estorage";
            this.estorageDataGridViewTextBoxColumn.HeaderText = "estorage";
            this.estorageDataGridViewTextBoxColumn.Name = "estorageDataGridViewTextBoxColumn";
            // 
            // displayDataGridViewTextBoxColumn
            // 
            this.displayDataGridViewTextBoxColumn.DataPropertyName = "display";
            this.displayDataGridViewTextBoxColumn.HeaderText = "display";
            this.displayDataGridViewTextBoxColumn.Name = "displayDataGridViewTextBoxColumn";
            // 
            // rearcDataGridViewTextBoxColumn
            // 
            this.rearcDataGridViewTextBoxColumn.DataPropertyName = "rearc";
            this.rearcDataGridViewTextBoxColumn.HeaderText = "rearc";
            this.rearcDataGridViewTextBoxColumn.Name = "rearcDataGridViewTextBoxColumn";
            // 
            // frontcDataGridViewTextBoxColumn
            // 
            this.frontcDataGridViewTextBoxColumn.DataPropertyName = "frontc";
            this.frontcDataGridViewTextBoxColumn.HeaderText = "frontc";
            this.frontcDataGridViewTextBoxColumn.Name = "frontcDataGridViewTextBoxColumn";
            // 
            // fingerDataGridViewTextBoxColumn
            // 
            this.fingerDataGridViewTextBoxColumn.DataPropertyName = "finger";
            this.fingerDataGridViewTextBoxColumn.HeaderText = "finger";
            this.fingerDataGridViewTextBoxColumn.Name = "fingerDataGridViewTextBoxColumn";
            // 
            // simDataGridViewTextBoxColumn
            // 
            this.simDataGridViewTextBoxColumn.DataPropertyName = "sim";
            this.simDataGridViewTextBoxColumn.HeaderText = "sim";
            this.simDataGridViewTextBoxColumn.Name = "simDataGridViewTextBoxColumn";
            // 
            // networkDataGridViewTextBoxColumn
            // 
            this.networkDataGridViewTextBoxColumn.DataPropertyName = "network";
            this.networkDataGridViewTextBoxColumn.HeaderText = "network";
            this.networkDataGridViewTextBoxColumn.Name = "networkDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // SearchPhoneRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MobileShopManagementSystem.Properties.Resources._5S_6S_pink_color_phone_case_For_iphone_5_6_6_plus_6s_plus_mobile_phone_jpg_350x350;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchPhoneRecord";
            this.Text = "SearchPhoneRecord";
            this.Load += new System.EventHandler(this.SearchPhoneRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private phoneDataSet phoneDataSet;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private phoneDataSetTableAdapters.PhonesTableAdapter phonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istorageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estorageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rearcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frontcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}