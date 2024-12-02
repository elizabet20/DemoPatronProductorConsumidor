namespace DemoPatronProductorConsumidor.Sistema_de_Riego_Automatizado
{
    partial class Riego
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
            panel1 = new Panel();
            btnAgregarSensor = new Button();
            btnEliminarSensor = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminarSensor);
            panel1.Controls.Add(btnAgregarSensor);
            panel1.Location = new Point(16, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 126);
            panel1.TabIndex = 0;
            // 
            // btnAgregarSensor
            // 
            btnAgregarSensor.Location = new Point(44, 20);
            btnAgregarSensor.Name = "btnAgregarSensor";
            btnAgregarSensor.Size = new Size(104, 23);
            btnAgregarSensor.TabIndex = 0;
            btnAgregarSensor.Text = "Agregar Sensor";
            btnAgregarSensor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSensor
            // 
            btnEliminarSensor.Location = new Point(44, 62);
            btnEliminarSensor.Name = "btnEliminarSensor";
            btnEliminarSensor.Size = new Size(104, 23);
            btnEliminarSensor.TabIndex = 1;
            btnEliminarSensor.Text = "Eliminar Sensor";
            btnEliminarSensor.UseVisualStyleBackColor = true;
            // 
            // Riego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Riego";
            Text = "Riego Automatizado";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminarSensor;
        private Button btnAgregarSensor;
    }
}