namespace listasRutas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.buttonRecorrido = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMinutos = new System.Windows.Forms.TextBox();
            this.textBoxMuestra = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregarInicio = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonoInsertarDespuesD = new System.Windows.Forms.Button();
            this.textBoxInsertar = new System.Windows.Forms.TextBox();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.textBoxRecorrido = new System.Windows.Forms.TextBox();
            this.textBoxHoraF = new System.Windows.Forms.TextBox();
            this.textBoxHoraI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(201, 58);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(100, 22);
            this.textBoxBase.TabIndex = 1;
            // 
            // buttonRecorrido
            // 
            this.buttonRecorrido.Location = new System.Drawing.Point(339, 335);
            this.buttonRecorrido.Name = "buttonRecorrido";
            this.buttonRecorrido.Size = new System.Drawing.Size(83, 31);
            this.buttonRecorrido.TabIndex = 2;
            this.buttonRecorrido.Text = "Recorrido";
            this.buttonRecorrido.UseVisualStyleBackColor = true;
            this.buttonRecorrido.Click += new System.EventHandler(this.buttonRecorrido_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(201, 156);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(83, 31);
            this.buttonAgregar.TabIndex = 3;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo para llegar a la base";
            // 
            // textBoxMinutos
            // 
            this.textBoxMinutos.Location = new System.Drawing.Point(201, 101);
            this.textBoxMinutos.Name = "textBoxMinutos";
            this.textBoxMinutos.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinutos.TabIndex = 5;
            // 
            // textBoxMuestra
            // 
            this.textBoxMuestra.Location = new System.Drawing.Point(339, 12);
            this.textBoxMuestra.Multiline = true;
            this.textBoxMuestra.Name = "textBoxMuestra";
            this.textBoxMuestra.Size = new System.Drawing.Size(515, 282);
            this.textBoxMuestra.TabIndex = 6;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(67, 330);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(83, 31);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(67, 292);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(83, 31);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregarInicio
            // 
            this.buttonAgregarInicio.Location = new System.Drawing.Point(67, 156);
            this.buttonAgregarInicio.Name = "buttonAgregarInicio";
            this.buttonAgregarInicio.Size = new System.Drawing.Size(106, 31);
            this.buttonAgregarInicio.TabIndex = 9;
            this.buttonAgregarInicio.Text = "Agregar inicio";
            this.buttonAgregarInicio.UseVisualStyleBackColor = true;
            this.buttonAgregarInicio.Click += new System.EventHandler(this.buttonAgregarInicio_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.BackColor = System.Drawing.Color.White;
            this.buttonReporte.Location = new System.Drawing.Point(592, 339);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(83, 31);
            this.buttonReporte.TabIndex = 10;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = false;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonoInsertarDespuesD
            // 
            this.buttonoInsertarDespuesD.Location = new System.Drawing.Point(67, 367);
            this.buttonoInsertarDespuesD.Name = "buttonoInsertarDespuesD";
            this.buttonoInsertarDespuesD.Size = new System.Drawing.Size(83, 31);
            this.buttonoInsertarDespuesD.TabIndex = 11;
            this.buttonoInsertarDespuesD.Text = "Insertar ";
            this.buttonoInsertarDespuesD.UseVisualStyleBackColor = true;
            this.buttonoInsertarDespuesD.Click += new System.EventHandler(this.buttonoInsertarDespuesD_Click);
            // 
            // textBoxInsertar
            // 
            this.textBoxInsertar.Location = new System.Drawing.Point(156, 376);
            this.textBoxInsertar.Name = "textBoxInsertar";
            this.textBoxInsertar.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertar.TabIndex = 12;
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(156, 339);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(100, 22);
            this.textBoxEliminar.TabIndex = 13;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(156, 296);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 22);
            this.textBoxBuscar.TabIndex = 14;
            // 
            // textBoxRecorrido
            // 
            this.textBoxRecorrido.Location = new System.Drawing.Point(331, 372);
            this.textBoxRecorrido.Name = "textBoxRecorrido";
            this.textBoxRecorrido.Size = new System.Drawing.Size(100, 22);
            this.textBoxRecorrido.TabIndex = 15;
            // 
            // textBoxHoraF
            // 
            this.textBoxHoraF.Location = new System.Drawing.Point(532, 377);
            this.textBoxHoraF.Name = "textBoxHoraF";
            this.textBoxHoraF.Size = new System.Drawing.Size(35, 22);
            this.textBoxHoraF.TabIndex = 16;
            // 
            // textBoxHoraI
            // 
            this.textBoxHoraI.Location = new System.Drawing.Point(532, 339);
            this.textBoxHoraI.Name = "textBoxHoraI";
            this.textBoxHoraI.Size = new System.Drawing.Size(36, 22);
            this.textBoxHoraI.TabIndex = 17;
            this.textBoxHoraI.TextChanged += new System.EventHandler(this.textBoxHoraI_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hora Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hora Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hora Fin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHoraI);
            this.Controls.Add(this.textBoxHoraF);
            this.Controls.Add(this.textBoxRecorrido);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.textBoxEliminar);
            this.Controls.Add(this.textBoxInsertar);
            this.Controls.Add(this.buttonoInsertarDespuesD);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonAgregarInicio);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBoxMuestra);
            this.Controls.Add(this.textBoxMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonRecorrido);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Button buttonRecorrido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMinutos;
        private System.Windows.Forms.TextBox textBoxMuestra;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregarInicio;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonoInsertarDespuesD;
        private System.Windows.Forms.TextBox textBoxInsertar;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.TextBox textBoxRecorrido;
        private System.Windows.Forms.TextBox textBoxHoraF;
        private System.Windows.Forms.TextBox textBoxHoraI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

