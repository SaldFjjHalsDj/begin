namespace ProjectBegin
{
    partial class FormDolgnost
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.коддолжнDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минОкладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.максОкладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дОЛЖНОСТИBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONNELSADDataSet = new ProjectBegin.PERSONNELSADDataSet();
            this.дОЛЖНОСТИTableAdapter = new ProjectBegin.PERSONNELSADDataSetTableAdapters.ДОЛЖНОСТИTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дОЛЖНОСТИBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNELSADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддолжнDataGridViewTextBoxColumn,
            this.наименованияDataGridViewTextBoxColumn,
            this.минОкладDataGridViewTextBoxColumn,
            this.максОкладDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дОЛЖНОСТИBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // коддолжнDataGridViewTextBoxColumn
            // 
            this.коддолжнDataGridViewTextBoxColumn.DataPropertyName = "Код_должн";
            this.коддолжнDataGridViewTextBoxColumn.HeaderText = "Код должности";
            this.коддолжнDataGridViewTextBoxColumn.Name = "коддолжнDataGridViewTextBoxColumn";
            // 
            // наименованияDataGridViewTextBoxColumn
            // 
            this.наименованияDataGridViewTextBoxColumn.DataPropertyName = "Наименования";
            this.наименованияDataGridViewTextBoxColumn.HeaderText = "Наименования";
            this.наименованияDataGridViewTextBoxColumn.Name = "наименованияDataGridViewTextBoxColumn";
            // 
            // минОкладDataGridViewTextBoxColumn
            // 
            this.минОкладDataGridViewTextBoxColumn.DataPropertyName = "МинОклад";
            this.минОкладDataGridViewTextBoxColumn.HeaderText = "Минимальный оклад";
            this.минОкладDataGridViewTextBoxColumn.Name = "минОкладDataGridViewTextBoxColumn";
            // 
            // максОкладDataGridViewTextBoxColumn
            // 
            this.максОкладDataGridViewTextBoxColumn.DataPropertyName = "МаксОклад";
            this.максОкладDataGridViewTextBoxColumn.HeaderText = "Максимальный оклад";
            this.максОкладDataGridViewTextBoxColumn.Name = "максОкладDataGridViewTextBoxColumn";
            // 
            // дОЛЖНОСТИBindingSource
            // 
            this.дОЛЖНОСТИBindingSource.DataMember = "ДОЛЖНОСТИ";
            this.дОЛЖНОСТИBindingSource.DataSource = this.pERSONNELSADDataSet;
            // 
            // pERSONNELSADDataSet
            // 
            this.pERSONNELSADDataSet.DataSetName = "PERSONNELSADDataSet";
            this.pERSONNELSADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дОЛЖНОСТИTableAdapter
            // 
            this.дОЛЖНОСТИTableAdapter.ClearBeforeFill = true;
            // 
            // FormDolgnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDolgnost";
            this.Text = "СПРАВОЧНИК ДОЛЖНОСТЕЙ";
            this.Load += new System.EventHandler(this.FormDolgnost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дОЛЖНОСТИBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNELSADDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PERSONNELSADDataSet pERSONNELSADDataSet;
        private System.Windows.Forms.BindingSource дОЛЖНОСТИBindingSource;
        private PERSONNELSADDataSetTableAdapters.ДОЛЖНОСТИTableAdapter дОЛЖНОСТИTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддолжнDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минОкладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn максОкладDataGridViewTextBoxColumn;
    }
}