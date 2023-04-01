namespace CRUD.View
{
    partial class ViewInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInformacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFechaIngreso = new System.Windows.Forms.Button();
            this.btnFechaContratacionT = new System.Windows.Forms.Button();
            this.DGVInformacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MediumPurple;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(352, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 35);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFechaIngreso
            // 
            this.btnFechaIngreso.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechaIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFechaIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnFechaIngreso.Image")));
            this.btnFechaIngreso.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechaIngreso.Location = new System.Drawing.Point(44, 12);
            this.btnFechaIngreso.Name = "btnFechaIngreso";
            this.btnFechaIngreso.Size = new System.Drawing.Size(118, 72);
            this.btnFechaIngreso.TabIndex = 1;
            this.btnFechaIngreso.Text = "Fecha Nacimiento";
            this.btnFechaIngreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechaIngreso.UseVisualStyleBackColor = false;
            this.btnFechaIngreso.Click += new System.EventHandler(this.btnFechaIngreso_Click);
            // 
            // btnFechaContratacionT
            // 
            this.btnFechaContratacionT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFechaContratacionT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFechaContratacionT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFechaContratacionT.Image = ((System.Drawing.Image)(resources.GetObject("btnFechaContratacionT.Image")));
            this.btnFechaContratacionT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechaContratacionT.Location = new System.Drawing.Point(204, 14);
            this.btnFechaContratacionT.Name = "btnFechaContratacionT";
            this.btnFechaContratacionT.Size = new System.Drawing.Size(118, 72);
            this.btnFechaContratacionT.TabIndex = 2;
            this.btnFechaContratacionT.Text = "Fecha Contratacion";
            this.btnFechaContratacionT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechaContratacionT.UseVisualStyleBackColor = false;
            this.btnFechaContratacionT.Click += new System.EventHandler(this.btnFechaContratacionT_Click);
            // 
            // DGVInformacion
            // 
            this.DGVInformacion.AllowUserToAddRows = false;
            this.DGVInformacion.AllowUserToDeleteRows = false;
            this.DGVInformacion.AllowUserToResizeColumns = false;
            this.DGVInformacion.AllowUserToResizeRows = false;
            this.DGVInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVInformacion.BackgroundColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInformacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVInformacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVInformacion.EnableHeadersVisualStyles = false;
            this.DGVInformacion.GridColor = System.Drawing.SystemColors.HotTrack;
            this.DGVInformacion.Location = new System.Drawing.Point(-4, 90);
            this.DGVInformacion.Name = "DGVInformacion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVInformacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVInformacion.RowTemplate.Height = 25;
            this.DGVInformacion.Size = new System.Drawing.Size(404, 248);
            this.DGVInformacion.TabIndex = 3;
            // 
            // ViewInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(399, 329);
            this.Controls.Add(this.DGVInformacion);
            this.Controls.Add(this.btnFechaContratacionT);
            this.Controls.Add(this.btnFechaIngreso);
            this.Controls.Add(this.btnHome);
            this.Name = "ViewInformacion";
            this.Text = "ViewInformacion";
            ((System.ComponentModel.ISupportInitialize)(this.DGVInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHome;
        private Button btnFechaIngreso;
        private Button btnFechaContratacionT;
        private DataGridView DGVInformacion;
    }
}