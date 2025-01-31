namespace EvParcial
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMenuPrincipal.Controls.Add(this.label1);
            this.pnlMenuPrincipal.Controls.Add(this.btnReportes);
            this.pnlMenuPrincipal.Controls.Add(this.btnCarreras);
            this.pnlMenuPrincipal.Controls.Add(this.btnPagos);
            this.pnlMenuPrincipal.Controls.Add(this.btnEstudiantes);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(534, 461);
            this.pnlMenuPrincipal.TabIndex = 0;
            this.pnlMenuPrincipal.Click += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEstudiantes.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.Location = new System.Drawing.Point(105, 157);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(114, 76);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Location = new System.Drawing.Point(105, 267);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(114, 74);
            this.btnPagos.TabIndex = 1;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.Location = new System.Drawing.Point(317, 157);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(114, 76);
            this.btnCarreras.TabIndex = 2;
            this.btnCarreras.Text = "Carreras";
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(317, 267);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(114, 74);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sistema de Control de Pagos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnEstudiantes;
    }
}

