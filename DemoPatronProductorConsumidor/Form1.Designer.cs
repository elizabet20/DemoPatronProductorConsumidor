namespace DemoPatronProductorConsumidor
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnProcesar = new Button();
            DGVUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 219);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(349, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(29, 107);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(369, 23);
            txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 89);
            label2.Name = "label2";
            label2.Size = new Size(132, 14);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(29, 42);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(369, 23);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(DGVUsuarios);
            panel2.Location = new Point(12, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 231);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(128, 255, 128);
            btnProcesar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcesar.Location = new Point(443, 23);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(75, 26);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.AllowUserToAddRows = false;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            DGVUsuarios.Location = new Point(15, 14);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.Size = new Size(409, 205);
            DGVUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostración patrón Productor -Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtNombres;
        private Label label1;
        private Panel panel2;
        private DataGridView DGVUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnProcesar;
    }
}
