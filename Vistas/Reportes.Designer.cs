namespace EvParcial.Vistas
{
    partial class Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaDeControlDePagosDeUniversidadDataSet = new EvParcial.SistemaDeControlDePagosDeUniversidadDataSet();
            this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDeControlTableAdapter1 = new EvParcial.SistemaDeControlDePagosDeUniversidadDataSetTableAdapters.SistemaDeControlTableAdapter();
            this.sistemaDeControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlDePagosDeUniversidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 54);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 407);
            this.panel3.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sistemaDeControlBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EvParcial.Vistas.Reportes.ReporteEstudiantes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaDeControlDePagosDeUniversidadDataSet
            // 
            this.sistemaDeControlDePagosDeUniversidadDataSet.DataSetName = "SistemaDeControlDePagosDeUniversidadDataSet";
            this.sistemaDeControlDePagosDeUniversidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaDeControlDePagosDeUniversidadDataSetBindingSource
            // 
            this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource.DataSource = this.sistemaDeControlDePagosDeUniversidadDataSet;
            this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource.Position = 0;
            // 
            // sistemaDeControlTableAdapter1
            // 
            this.sistemaDeControlTableAdapter1.ClearBeforeFill = true;
            // 
            // sistemaDeControlBindingSource
            // 
            this.sistemaDeControlBindingSource.DataMember = "SistemaDeControl";
            this.sistemaDeControlBindingSource.DataSource = this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlDePagosDeUniversidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlDePagosDeUniversidadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDeControlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource sistemaDeControlDePagosDeUniversidadDataSetBindingSource;
        private SistemaDeControlDePagosDeUniversidadDataSet sistemaDeControlDePagosDeUniversidadDataSet;
        private SistemaDeControlDePagosDeUniversidadDataSetTableAdapters.SistemaDeControlTableAdapter sistemaDeControlTableAdapter1;
        private System.Windows.Forms.BindingSource sistemaDeControlBindingSource;
    }
}