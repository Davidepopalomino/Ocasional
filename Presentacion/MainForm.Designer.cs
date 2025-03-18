namespace Presentacion
{
    partial class MainForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSMMLV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbDedicacion = new System.Windows.Forms.ComboBox();
            this.cmbPosgrado = new System.Windows.Forms.ComboBox();
            this.cmbGrupoInvestigacion = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonificaciónPosgrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonificaciónInvestigación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioTotalMensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProyecciónAnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeCálculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularNomina = new System.Windows.Forms.Button();
            this.lblNominaTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 30);
            this.label11.TabIndex = 97;
            this.label11.Text = "Nomina Profesores Ocasionales";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(619, 69);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalcular.Size = new System.Drawing.Size(93, 32);
            this.btnCalcular.TabIndex = 96;
            this.btnCalcular.Text = "Calcular Salario";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.SalarioBase,
            this.BonificaciónPosgrado,
            this.BonificaciónInvestigación,
            this.SalarioTotalMensual,
            this.ProyecciónAnual,
            this.FechadeCálculo});
            this.dgvResultados.Location = new System.Drawing.Point(0, 320);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(812, 204);
            this.dgvResultados.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 81;
            this.label1.Text = "SMMLV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 82;
            this.label2.Text = "Posgrado:";
            // 
            // txtSMMLV
            // 
            this.txtSMMLV.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMMLV.Location = new System.Drawing.Point(118, 126);
            this.txtSMMLV.Name = "txtSMMLV";
            this.txtSMMLV.Size = new System.Drawing.Size(134, 21);
            this.txtSMMLV.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 86;
            this.label4.Text = "Dedicacion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 21);
            this.txtNombre.TabIndex = 87;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoSize = true;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.Location = new System.Drawing.Point(23, 233);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(57, 14);
            this.cmbCategoria.TabIndex = 90;
            this.cmbCategoria.Text = "Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 14);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 14);
            this.label9.TabIndex = 93;
            this.label9.Text = "Grupo de Investigación:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Ocasional"});
            this.cmbTipo.Location = new System.Drawing.Point(118, 179);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(134, 21);
            this.cmbTipo.TabIndex = 112;
            // 
            // cmbDedicacion
            // 
            this.cmbDedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDedicacion.FormattingEnabled = true;
            this.cmbDedicacion.Items.AddRange(new object[] {
            "Tiempo Completo",
            "Medio Tiempo"});
            this.cmbDedicacion.Location = new System.Drawing.Point(425, 78);
            this.cmbDedicacion.Name = "cmbDedicacion";
            this.cmbDedicacion.Size = new System.Drawing.Size(134, 21);
            this.cmbDedicacion.TabIndex = 113;
            // 
            // cmbPosgrado
            // 
            this.cmbPosgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosgrado.FormattingEnabled = true;
            this.cmbPosgrado.Items.AddRange(new object[] {
            "Ninguno",
            "Especialización",
            "Maestría ",
            "Doctorado"});
            this.cmbPosgrado.Location = new System.Drawing.Point(425, 120);
            this.cmbPosgrado.Name = "cmbPosgrado";
            this.cmbPosgrado.Size = new System.Drawing.Size(134, 21);
            this.cmbPosgrado.TabIndex = 114;
            // 
            // cmbGrupoInvestigacion
            // 
            this.cmbGrupoInvestigacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupoInvestigacion.FormattingEnabled = true;
            this.cmbGrupoInvestigacion.Items.AddRange(new object[] {
            "Ninguno",
            "A1",
            "A ",
            "B",
            "C"});
            this.cmbGrupoInvestigacion.Location = new System.Drawing.Point(425, 173);
            this.cmbGrupoInvestigacion.Name = "cmbGrupoInvestigacion";
            this.cmbGrupoInvestigacion.Size = new System.Drawing.Size(134, 21);
            this.cmbGrupoInvestigacion.TabIndex = 115;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Green;
            this.lblResultado.Location = new System.Drawing.Point(327, 228);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(2, 22);
            this.lblResultado.TabIndex = 116;
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Items.AddRange(new object[] {
            "Auxiliar",
            "Asistente",
            "Asociado",
            "Titular"});
            this.cmb_Categoria.Location = new System.Drawing.Point(118, 230);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(134, 21);
            this.cmb_Categoria.TabIndex = 117;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "Salario Base";
            this.SalarioBase.Name = "SalarioBase";
            // 
            // BonificaciónPosgrado
            // 
            this.BonificaciónPosgrado.HeaderText = "BonificaciónPosgrado";
            this.BonificaciónPosgrado.Name = "BonificaciónPosgrado";
            this.BonificaciónPosgrado.Width = 120;
            // 
            // BonificaciónInvestigación
            // 
            this.BonificaciónInvestigación.HeaderText = "BonificaciónInvestigación";
            this.BonificaciónInvestigación.Name = "BonificaciónInvestigación";
            this.BonificaciónInvestigación.Width = 132;
            // 
            // SalarioTotalMensual
            // 
            this.SalarioTotalMensual.HeaderText = "SalarioTotalMensual";
            this.SalarioTotalMensual.Name = "SalarioTotalMensual";
            this.SalarioTotalMensual.Width = 120;
            // 
            // ProyecciónAnual
            // 
            this.ProyecciónAnual.HeaderText = "ProyecciónAnual";
            this.ProyecciónAnual.Name = "ProyecciónAnual";
            // 
            // FechadeCálculo
            // 
            this.FechadeCálculo.HeaderText = "FechadeCálculo";
            this.FechadeCálculo.Name = "FechadeCálculo";
            this.FechadeCálculo.Width = 110;
            // 
            // btnCalcularNomina
            // 
            this.btnCalcularNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcularNomina.FlatAppearance.BorderSize = 0;
            this.btnCalcularNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularNomina.Location = new System.Drawing.Point(619, 126);
            this.btnCalcularNomina.Name = "btnCalcularNomina";
            this.btnCalcularNomina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalcularNomina.Size = new System.Drawing.Size(93, 32);
            this.btnCalcularNomina.TabIndex = 118;
            this.btnCalcularNomina.Text = "Calcular Nomina Total";
            this.btnCalcularNomina.UseVisualStyleBackColor = false;
            this.btnCalcularNomina.Click += new System.EventHandler(this.btnCalcularNomina_Click);
            // 
            // lblNominaTotal
            // 
            this.lblNominaTotal.AutoSize = true;
            this.lblNominaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNominaTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblNominaTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNominaTotal.Location = new System.Drawing.Point(327, 270);
            this.lblNominaTotal.Name = "lblNominaTotal";
            this.lblNominaTotal.Size = new System.Drawing.Size(2, 22);
            this.lblNominaTotal.TabIndex = 119;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 542);
            this.Controls.Add(this.lblNominaTotal);
            this.Controls.Add(this.btnCalcularNomina);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbGrupoInvestigacion);
            this.Controls.Add(this.cmbPosgrado);
            this.Controls.Add(this.cmbDedicacion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSMMLV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSMMLV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label cmbCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbDedicacion;
        private System.Windows.Forms.ComboBox cmbPosgrado;
        private System.Windows.Forms.ComboBox cmbGrupoInvestigacion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonificaciónPosgrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonificaciónInvestigación;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioTotalMensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProyecciónAnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeCálculo;
        private System.Windows.Forms.Button btnCalcularNomina;
        private System.Windows.Forms.Label lblNominaTotal;
    }
}

