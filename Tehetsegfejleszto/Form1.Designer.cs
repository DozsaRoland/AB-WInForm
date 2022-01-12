
namespace Tehetsegfejleszto
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new Tehetsegfejleszto.Database1DataSet();
            this.fejlesztokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fejlesztokTableAdapter = new Tehetsegfejleszto.Database1DataSetTableAdapters.fejlesztokTableAdapter();
            this.foglalkozasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foglalkozasokTableAdapter = new Tehetsegfejleszto.Database1DataSetTableAdapters.foglalkozasokTableAdapter();
            this.gyermekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyermekekTableAdapter = new Tehetsegfejleszto.Database1DataSetTableAdapters.gyermekekTableAdapter();
            this.szakmakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szakmakTableAdapter = new Tehetsegfejleszto.Database1DataSetTableAdapters.szakmakTableAdapter();
            this.foglalkozasIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fejlesztoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyermekIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megnevezesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlesztokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalkozasokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyermekekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foglalkozasIdDataGridViewTextBoxColumn,
            this.fejlesztoIdDataGridViewTextBoxColumn,
            this.gyermekIdDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.idoDataGridViewTextBoxColumn,
            this.leirasDataGridViewTextBoxColumn,
            this.megnevezesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.foglalkozasokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fejlesztokBindingSource
            // 
            this.fejlesztokBindingSource.DataMember = "fejlesztok";
            this.fejlesztokBindingSource.DataSource = this.database1DataSet;
            // 
            // fejlesztokTableAdapter
            // 
            this.fejlesztokTableAdapter.ClearBeforeFill = true;
            // 
            // foglalkozasokBindingSource
            // 
            this.foglalkozasokBindingSource.DataMember = "foglalkozasok";
            this.foglalkozasokBindingSource.DataSource = this.database1DataSet;
            // 
            // foglalkozasokTableAdapter
            // 
            this.foglalkozasokTableAdapter.ClearBeforeFill = true;
            // 
            // gyermekekBindingSource
            // 
            this.gyermekekBindingSource.DataMember = "gyermekek";
            this.gyermekekBindingSource.DataSource = this.database1DataSet;
            // 
            // gyermekekTableAdapter
            // 
            this.gyermekekTableAdapter.ClearBeforeFill = true;
            // 
            // szakmakBindingSource
            // 
            this.szakmakBindingSource.DataMember = "szakmak";
            this.szakmakBindingSource.DataSource = this.database1DataSet;
            // 
            // szakmakTableAdapter
            // 
            this.szakmakTableAdapter.ClearBeforeFill = true;
            // 
            // foglalkozasIdDataGridViewTextBoxColumn
            // 
            this.foglalkozasIdDataGridViewTextBoxColumn.DataPropertyName = "foglalkozasId";
            this.foglalkozasIdDataGridViewTextBoxColumn.HeaderText = "foglalkozasId";
            this.foglalkozasIdDataGridViewTextBoxColumn.Name = "foglalkozasIdDataGridViewTextBoxColumn";
            this.foglalkozasIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fejlesztoIdDataGridViewTextBoxColumn
            // 
            this.fejlesztoIdDataGridViewTextBoxColumn.DataPropertyName = "fejlesztoId";
            this.fejlesztoIdDataGridViewTextBoxColumn.HeaderText = "fejlesztoId";
            this.fejlesztoIdDataGridViewTextBoxColumn.Name = "fejlesztoIdDataGridViewTextBoxColumn";
            // 
            // gyermekIdDataGridViewTextBoxColumn
            // 
            this.gyermekIdDataGridViewTextBoxColumn.DataPropertyName = "gyermekId";
            this.gyermekIdDataGridViewTextBoxColumn.HeaderText = "gyermekId";
            this.gyermekIdDataGridViewTextBoxColumn.Name = "gyermekIdDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // idoDataGridViewTextBoxColumn
            // 
            this.idoDataGridViewTextBoxColumn.DataPropertyName = "ido";
            this.idoDataGridViewTextBoxColumn.HeaderText = "ido";
            this.idoDataGridViewTextBoxColumn.Name = "idoDataGridViewTextBoxColumn";
            // 
            // leirasDataGridViewTextBoxColumn
            // 
            this.leirasDataGridViewTextBoxColumn.DataPropertyName = "leiras";
            this.leirasDataGridViewTextBoxColumn.HeaderText = "leiras";
            this.leirasDataGridViewTextBoxColumn.Name = "leirasDataGridViewTextBoxColumn";
            // 
            // megnevezesDataGridViewTextBoxColumn
            // 
            this.megnevezesDataGridViewTextBoxColumn.DataPropertyName = "megnevezes";
            this.megnevezesDataGridViewTextBoxColumn.HeaderText = "megnevezes";
            this.megnevezesDataGridViewTextBoxColumn.Name = "megnevezesDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Szűrés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fejlesztokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foglalkozasokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyermekekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szakmakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource fejlesztokBindingSource;
        private Database1DataSetTableAdapters.fejlesztokTableAdapter fejlesztokTableAdapter;
        private System.Windows.Forms.BindingSource foglalkozasokBindingSource;
        private Database1DataSetTableAdapters.foglalkozasokTableAdapter foglalkozasokTableAdapter;
        private System.Windows.Forms.BindingSource gyermekekBindingSource;
        private Database1DataSetTableAdapters.gyermekekTableAdapter gyermekekTableAdapter;
        private System.Windows.Forms.BindingSource szakmakBindingSource;
        private Database1DataSetTableAdapters.szakmakTableAdapter szakmakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn foglalkozasIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fejlesztoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyermekIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leirasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megnevezesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
    }
}

