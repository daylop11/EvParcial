namespace EvParcial.Vistas
{
    partial class Frm_Estudiantes
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
            this.pnlEstudiantes = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtiD = new System.Windows.Forms.TextBox();
            this.txtNameApellido = new System.Windows.Forms.TextBox();
            this.btnAggStudent = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pnlEstudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEstudiantes
            // 
            this.pnlEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlEstudiantes.Controls.Add(this.txtemail);
            this.pnlEstudiantes.Controls.Add(this.txtiD);
            this.pnlEstudiantes.Controls.Add(this.txtNameApellido);
            this.pnlEstudiantes.Controls.Add(this.btnAggStudent);
            this.pnlEstudiantes.Controls.Add(this.btnCancelar);
            this.pnlEstudiantes.Controls.Add(this.btnGuardar);
            this.pnlEstudiantes.Controls.Add(this.lblBienvenidos);
            this.pnlEstudiantes.Controls.Add(this.lblemail);
            this.pnlEstudiantes.Controls.Add(this.lblid);
            this.pnlEstudiantes.Controls.Add(this.lblname);
            this.pnlEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.pnlEstudiantes.Name = "pnlEstudiantes";
            this.pnlEstudiantes.Size = new System.Drawing.Size(534, 461);
            this.pnlEstudiantes.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(49, 284);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(411, 20);
            this.txtemail.TabIndex = 12;
            // 
            // txtiD
            // 
            this.txtiD.Location = new System.Drawing.Point(49, 194);
            this.txtiD.Name = "txtiD";
            this.txtiD.Size = new System.Drawing.Size(411, 20);
            this.txtiD.TabIndex = 11;
            // 
            // txtNameApellido
            // 
            this.txtNameApellido.Location = new System.Drawing.Point(49, 111);
            this.txtNameApellido.Name = "txtNameApellido";
            this.txtNameApellido.Size = new System.Drawing.Size(411, 20);
            this.txtNameApellido.TabIndex = 10;
            // 
            // btnAggStudent
            // 
            this.btnAggStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggStudent.Location = new System.Drawing.Point(211, 365);
            this.btnAggStudent.Name = "btnAggStudent";
            this.btnAggStudent.Size = new System.Drawing.Size(106, 75);
            this.btnAggStudent.TabIndex = 9;
            this.btnAggStudent.Text = "AGREGAR ESTUDIANTE";
            this.btnAggStudent.UseVisualStyleBackColor = true;
            this.btnAggStudent.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(375, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 57);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(77, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 57);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(132, 30);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(282, 28);
            this.lblBienvenidos.TabIndex = 6;
            this.lblBienvenidos.Text = "BIENVENIDOS ESTUDIANTES";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(52, 268);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(132, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "CORREO ELECTRONICO";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(52, 178);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(161, 13);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "NUMERO DE IDENTIFICACION";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(52, 95);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "NOMBRE Y APELLIDO";
            // 
            // Frm_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.pnlEstudiantes);
            this.Name = "Frm_Estudiantes";
            this.Text = "Estudiantes";
            this.pnlEstudiantes.ResumeLayout(false);
            this.pnlEstudiantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEstudiantes;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAggStudent;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtiD;
        private System.Windows.Forms.TextBox txtNameApellido;
    }
}