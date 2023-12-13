namespace StockApp.WindowsForms.Cadastros
{
    partial class frmCategoria
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
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            chkStatus = new CheckBox();
            txtCategoria = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(chkStatus);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Location = new Point(84, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 138);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Categoria";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(210, 20);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(150, 24);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(54, 19);
            chkStatus.TabIndex = 1;
            chkStatus.Text = "Ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 22);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(121, 23);
            txtCategoria.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(345, 136);
            dataGridView1.TabIndex = 2;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private CheckBox chkStatus;
        private TextBox txtCategoria;
        private DataGridView dataGridView1;
    }
}