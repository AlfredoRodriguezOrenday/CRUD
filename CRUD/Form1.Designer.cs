namespace CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTrabajador = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTrabajador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrabajador.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrabajador.Image = ((System.Drawing.Image)(resources.GetObject("btnTrabajador.Image")));
            this.btnTrabajador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrabajador.Location = new System.Drawing.Point(41, 69);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(154, 81);
            this.btnTrabajador.TabIndex = 0;
            this.btnTrabajador.Text = "Trabajador";
            this.btnTrabajador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrabajador.UseVisualStyleBackColor = false;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDepartamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepartamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartamento.Image")));
            this.btnDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamento.Location = new System.Drawing.Point(221, 69);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(154, 81);
            this.btnDepartamento.TabIndex = 1;
            this.btnDepartamento.Text = "Departamento";
            this.btnDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamento.UseVisualStyleBackColor = false;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInformacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInformacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInformacion.Image")));
            this.btnInformacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInformacion.Location = new System.Drawing.Point(114, 174);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(181, 81);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Informacion Extra";
            this.btnInformacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(406, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnTrabajador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTrabajador;
        private Button btnDepartamento;
        private Button btnInformacion;
        private Label label1;
    }
}