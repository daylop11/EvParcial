namespace EvParcial.Vistas
{
    partial class Frm_Carreras
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlEstudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEstudiantes
            // 
            this.pnlEstudiantes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEstudiantes.Controls.Add(this.comboBox1);
            this.pnlEstudiantes.Controls.Add(this.btnCerrar);
            this.pnlEstudiantes.Controls.Add(this.lblBienvenidos);
            this.pnlEstudiantes.Controls.Add(this.lblemail);
            this.pnlEstudiantes.Controls.Add(this.lblid);
            this.pnlEstudiantes.Controls.Add(this.lblname);
            this.pnlEstudiantes.Controls.Add(this.button2);
            this.pnlEstudiantes.Controls.Add(this.button1);
            this.pnlEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.pnlEstudiantes.Name = "pnlEstudiantes";
            this.pnlEstudiantes.Size = new System.Drawing.Size(534, 461);
            this.pnlEstudiantes.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(221, 361);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(85, 57);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.lblemail.Location = new System.Drawing.Point(52, 266);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(101, 13);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "ELEGIR CARRERA";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(55, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.pnlEstudiantes);
            this.Name = "Frm_Carreras";
            this.Text = "Carreras";
            this.pnlEstudiantes.ResumeLayout(false);
            this.pnlEstudiantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEstudiantes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}