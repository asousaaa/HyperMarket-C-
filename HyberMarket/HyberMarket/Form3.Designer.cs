namespace HyberMarket
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sim_select_customer_find = new System.Windows.Forms.Button();
            this.Sim_select_customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_sim_secect_view = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hyper_matketDataSet = new HyberMarket.Hyper_matketDataSet();
            this.employee = new System.Windows.Forms.TabPage();
            this.employee_sim_select_find = new System.Windows.Forms.Button();
            this.employee_sim_select_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_sim_secect_View = new System.Windows.Forms.DataGridView();
            this.eNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSALARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new HyberMarket.Hyper_matketDataSetTableAdapters.CUSTOMERTableAdapter();
            this.eMPLOYEETableAdapter = new HyberMarket.Hyper_matketDataSetTableAdapters.EMPLOYEETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_sim_secect_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyper_matketDataSet)).BeginInit();
            this.employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_sim_secect_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.employee);
            this.tabControl1.Location = new System.Drawing.Point(23, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.sim_select_customer_find);
            this.tabPage1.Controls.Add(this.Sim_select_customer_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.customer_sim_secect_view);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sim_select_customer_find
            // 
            this.sim_select_customer_find.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_select_customer_find.Location = new System.Drawing.Point(327, 90);
            this.sim_select_customer_find.Name = "sim_select_customer_find";
            this.sim_select_customer_find.Size = new System.Drawing.Size(115, 74);
            this.sim_select_customer_find.TabIndex = 3;
            this.sim_select_customer_find.Text = "Find";
            this.sim_select_customer_find.UseVisualStyleBackColor = true;
            this.sim_select_customer_find.Click += new System.EventHandler(this.sim_select_customer_find_Click);
            // 
            // Sim_select_customer_name
            // 
            this.Sim_select_customer_name.Location = new System.Drawing.Point(305, 28);
            this.Sim_select_customer_name.Name = "Sim_select_customer_name";
            this.Sim_select_customer_name.Size = new System.Drawing.Size(153, 20);
            this.Sim_select_customer_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please write customer name :\r\n";
            // 
            // customer_sim_secect_view
            // 
            this.customer_sim_secect_view.AutoGenerateColumns = false;
            this.customer_sim_secect_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customer_sim_secect_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customer_sim_secect_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_sim_secect_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn});
            this.customer_sim_secect_view.DataSource = this.cUSTOMERBindingSource;
            this.customer_sim_secect_view.Location = new System.Drawing.Point(38, 59);
            this.customer_sim_secect_view.Name = "customer_sim_secect_view";
            this.customer_sim_secect_view.ReadOnly = true;
            this.customer_sim_secect_view.Size = new System.Drawing.Size(243, 182);
            this.customer_sim_secect_view.TabIndex = 0;
            this.customer_sim_secect_view.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.hyper_matketDataSet;
            // 
            // hyper_matketDataSet
            // 
            this.hyper_matketDataSet.DataSetName = "Hyper_matketDataSet";
            this.hyper_matketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee
            // 
            this.employee.Controls.Add(this.button2);
            this.employee.Controls.Add(this.employee_sim_select_find);
            this.employee.Controls.Add(this.employee_sim_select_name);
            this.employee.Controls.Add(this.label2);
            this.employee.Controls.Add(this.employee_sim_secect_View);
            this.employee.Location = new System.Drawing.Point(4, 22);
            this.employee.Name = "employee";
            this.employee.Padding = new System.Windows.Forms.Padding(3);
            this.employee.Size = new System.Drawing.Size(489, 269);
            this.employee.TabIndex = 1;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            // 
            // employee_sim_select_find
            // 
            this.employee_sim_select_find.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_sim_select_find.Location = new System.Drawing.Point(339, 93);
            this.employee_sim_select_find.Name = "employee_sim_select_find";
            this.employee_sim_select_find.Size = new System.Drawing.Size(115, 74);
            this.employee_sim_select_find.TabIndex = 7;
            this.employee_sim_select_find.Text = "FinD";
            this.employee_sim_select_find.UseVisualStyleBackColor = true;
            this.employee_sim_select_find.Click += new System.EventHandler(this.employee_sim_select_find_Click);
            // 
            // employee_sim_select_name
            // 
            this.employee_sim_select_name.Location = new System.Drawing.Point(301, 29);
            this.employee_sim_select_name.Name = "employee_sim_select_name";
            this.employee_sim_select_name.Size = new System.Drawing.Size(153, 20);
            this.employee_sim_select_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please write employee name :\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // employee_sim_secect_View
            // 
            this.employee_sim_secect_View.AutoGenerateColumns = false;
            this.employee_sim_secect_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_sim_secect_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNAMEDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.eSALARYDataGridViewTextBoxColumn});
            this.employee_sim_secect_View.DataSource = this.eMPLOYEEBindingSource;
            this.employee_sim_secect_View.Location = new System.Drawing.Point(6, 66);
            this.employee_sim_secect_View.Name = "employee_sim_secect_View";
            this.employee_sim_secect_View.ReadOnly = true;
            this.employee_sim_secect_View.Size = new System.Drawing.Size(317, 182);
            this.employee_sim_secect_View.TabIndex = 4;
            this.employee_sim_secect_View.Visible = false;
            // 
            // eNAMEDataGridViewTextBoxColumn
            // 
            this.eNAMEDataGridViewTextBoxColumn.DataPropertyName = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.HeaderText = "ENAME";
            this.eNAMEDataGridViewTextBoxColumn.Name = "eNAMEDataGridViewTextBoxColumn";
            this.eNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNAMEDataGridViewTextBoxColumn.Width = 69;
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "EID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "EID";
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            this.eIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 69;
            // 
            // eSALARYDataGridViewTextBoxColumn
            // 
            this.eSALARYDataGridViewTextBoxColumn.DataPropertyName = "ESALARY";
            this.eSALARYDataGridViewTextBoxColumn.HeaderText = "ESALARY";
            this.eSALARYDataGridViewTextBoxColumn.Name = "eSALARYDataGridViewTextBoxColumn";
            this.eSALARYDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSALARYDataGridViewTextBoxColumn.Width = 68;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.hyper_matketDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(347, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 69);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 326);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_sim_secect_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyper_matketDataSet)).EndInit();
            this.employee.ResumeLayout(false);
            this.employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_sim_secect_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView customer_sim_secect_view;
        private System.Windows.Forms.TabPage employee;
        private Hyper_matketDataSet hyper_matketDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private Hyper_matketDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Button sim_select_customer_find;
        private System.Windows.Forms.TextBox Sim_select_customer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button employee_sim_select_find;
        private System.Windows.Forms.TextBox employee_sim_select_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView employee_sim_secect_View;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private Hyper_matketDataSetTableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSALARYDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}