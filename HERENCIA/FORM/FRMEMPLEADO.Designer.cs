﻿
namespace FORM
{
    partial class FRMEMPLEADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMEMPLEADO));
            this.gvoempleados = new System.Windows.Forms.GroupBox();
            this.TXTCEDULA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.CBOTIPCONTRATO = new System.Windows.Forms.ComboBox();
            this.CBOTIPEMPLEADO = new System.Windows.Forms.ComboBox();
            this.TXTAPMATERNO = new System.Windows.Forms.TextBox();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.TXTNUMSEGSOCIAL = new System.Windows.Forms.TextBox();
            this.TXTAPPATERNO = new System.Windows.Forms.TextBox();
            this.CBOSEXO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVEMPLEADO = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPEMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvoempleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // gvoempleados
            // 
            this.gvoempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvoempleados.BackgroundImage = global::FORM.Properties.Resources._43cb7c2be497681b341d09eef1324244;
            this.gvoempleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gvoempleados.Controls.Add(this.TXTCEDULA);
            this.gvoempleados.Controls.Add(this.label8);
            this.gvoempleados.Controls.Add(this.button1);
            this.gvoempleados.Controls.Add(this.BTNSAVE);
            this.gvoempleados.Controls.Add(this.CBOTIPCONTRATO);
            this.gvoempleados.Controls.Add(this.CBOTIPEMPLEADO);
            this.gvoempleados.Controls.Add(this.TXTAPMATERNO);
            this.gvoempleados.Controls.Add(this.TXTNOMBRES);
            this.gvoempleados.Controls.Add(this.TXTNUMSEGSOCIAL);
            this.gvoempleados.Controls.Add(this.TXTAPPATERNO);
            this.gvoempleados.Controls.Add(this.CBOSEXO);
            this.gvoempleados.Controls.Add(this.label7);
            this.gvoempleados.Controls.Add(this.label6);
            this.gvoempleados.Controls.Add(this.label5);
            this.gvoempleados.Controls.Add(this.label4);
            this.gvoempleados.Controls.Add(this.label3);
            this.gvoempleados.Controls.Add(this.label2);
            this.gvoempleados.Controls.Add(this.label1);
            this.gvoempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvoempleados.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvoempleados.Location = new System.Drawing.Point(0, 0);
            this.gvoempleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvoempleados.Name = "gvoempleados";
            this.gvoempleados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvoempleados.Size = new System.Drawing.Size(1284, 557);
            this.gvoempleados.TabIndex = 0;
            this.gvoempleados.TabStop = false;
            this.gvoempleados.Text = "EMPLEADOS";
            this.gvoempleados.Enter += new System.EventHandler(this.gvoempleados_Enter);
            // 
            // TXTCEDULA
            // 
            this.TXTCEDULA.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCEDULA.Location = new System.Drawing.Point(1015, 357);
            this.TXTCEDULA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTCEDULA.Name = "TXTCEDULA";
            this.TXTCEDULA.Size = new System.Drawing.Size(183, 28);
            this.TXTCEDULA.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1048, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "CEDULA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1073, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSAVE.FlatAppearance.BorderSize = 2;
            this.BTNSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSAVE.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAVE.Location = new System.Drawing.Point(1333, 440);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(152, 51);
            this.BTNSAVE.TabIndex = 15;
            this.BTNSAVE.Text = "GUARDAR";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // CBOTIPCONTRATO
            // 
            this.CBOTIPCONTRATO.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOTIPCONTRATO.FormattingEnabled = true;
            this.CBOTIPCONTRATO.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CBOTIPCONTRATO.Location = new System.Drawing.Point(715, 357);
            this.CBOTIPCONTRATO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBOTIPCONTRATO.Name = "CBOTIPCONTRATO";
            this.CBOTIPCONTRATO.Size = new System.Drawing.Size(251, 30);
            this.CBOTIPCONTRATO.TabIndex = 14;
            // 
            // CBOTIPEMPLEADO
            // 
            this.CBOTIPEMPLEADO.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOTIPEMPLEADO.FormattingEnabled = true;
            this.CBOTIPEMPLEADO.Items.AddRange(new object[] {
            "VENDEDOR",
            "GERENTE"});
            this.CBOTIPEMPLEADO.Location = new System.Drawing.Point(412, 357);
            this.CBOTIPEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBOTIPEMPLEADO.Name = "CBOTIPEMPLEADO";
            this.CBOTIPEMPLEADO.Size = new System.Drawing.Size(251, 30);
            this.CBOTIPEMPLEADO.TabIndex = 13;
            // 
            // TXTAPMATERNO
            // 
            this.TXTAPMATERNO.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPMATERNO.Location = new System.Drawing.Point(264, 148);
            this.TXTAPMATERNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTAPMATERNO.Name = "TXTAPMATERNO";
            this.TXTAPMATERNO.Size = new System.Drawing.Size(226, 28);
            this.TXTAPMATERNO.TabIndex = 11;
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRES.Location = new System.Drawing.Point(556, 148);
            this.TXTNOMBRES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.Size = new System.Drawing.Size(285, 28);
            this.TXTNOMBRES.TabIndex = 10;
            // 
            // TXTNUMSEGSOCIAL
            // 
            this.TXTNUMSEGSOCIAL.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUMSEGSOCIAL.Location = new System.Drawing.Point(6, 357);
            this.TXTNUMSEGSOCIAL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTNUMSEGSOCIAL.Name = "TXTNUMSEGSOCIAL";
            this.TXTNUMSEGSOCIAL.Size = new System.Drawing.Size(293, 28);
            this.TXTNUMSEGSOCIAL.TabIndex = 9;
            // 
            // TXTAPPATERNO
            // 
            this.TXTAPPATERNO.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPPATERNO.Location = new System.Drawing.Point(6, 148);
            this.TXTAPPATERNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTAPPATERNO.Name = "TXTAPPATERNO";
            this.TXTAPPATERNO.Size = new System.Drawing.Size(205, 28);
            this.TXTAPPATERNO.TabIndex = 8;
            // 
            // CBOSEXO
            // 
            this.CBOSEXO.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOSEXO.FormattingEnabled = true;
            this.CBOSEXO.Items.AddRange(new object[] {
            "MASCULINO ",
            "FEMENINO"});
            this.CBOSEXO.Location = new System.Drawing.Point(935, 148);
            this.CBOSEXO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBOSEXO.Name = "CBOSEXO";
            this.CBOSEXO.Size = new System.Drawing.Size(219, 30);
            this.CBOSEXO.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "TIPO DE CONTRATO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "TIPO DE EMPLEADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "NUMERO DE EGURIDAD SOCIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(970, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEXO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO MARTERNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELLIDO PARTERNO";
            // 
            // DGVEMPLEADO
            // 
            this.DGVEMPLEADO.AllowUserToAddRows = false;
            this.DGVEMPLEADO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DGVEMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEMPLEADO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.CEDULA,
            this.SEXO,
            this.NUMSEGSOCIAL,
            this.TIPEMPLEADO,
            this.TIPCONTRATO,
            this.SUELDO});
            this.DGVEMPLEADO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEMPLEADO.Location = new System.Drawing.Point(0, 557);
            this.DGVEMPLEADO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVEMPLEADO.Name = "DGVEMPLEADO";
            this.DGVEMPLEADO.RowHeadersWidth = 51;
            this.DGVEMPLEADO.RowTemplate.Height = 24;
            this.DGVEMPLEADO.Size = new System.Drawing.Size(1284, 358);
            this.DGVEMPLEADO.TabIndex = 2;
            this.DGVEMPLEADO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCLIENTES_CellContentClick);
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 170;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 170;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 200;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 120;
            // 
            // NUMSEGSOCIAL
            // 
            this.NUMSEGSOCIAL.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOCIAL.MinimumWidth = 6;
            this.NUMSEGSOCIAL.Name = "NUMSEGSOCIAL";
            this.NUMSEGSOCIAL.Width = 190;
            // 
            // TIPEMPLEADO
            // 
            this.TIPEMPLEADO.HeaderText = "TIPO DE EMPLEADO";
            this.TIPEMPLEADO.MinimumWidth = 6;
            this.TIPEMPLEADO.Name = "TIPEMPLEADO";
            this.TIPEMPLEADO.Width = 170;
            // 
            // TIPCONTRATO
            // 
            this.TIPCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPCONTRATO.MinimumWidth = 6;
            this.TIPCONTRATO.Name = "TIPCONTRATO";
            this.TIPCONTRATO.Width = 170;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.MinimumWidth = 6;
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 125;
            // 
            // FRMEMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 915);
            this.Controls.Add(this.DGVEMPLEADO);
            this.Controls.Add(this.gvoempleados);
            this.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRMEMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMEMPLEADO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMEMPLEADO_Load);
            this.gvoempleados.ResumeLayout(false);
            this.gvoempleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEMPLEADO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gvoempleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.ComboBox CBOTIPCONTRATO;
        private System.Windows.Forms.ComboBox CBOTIPEMPLEADO;
        private System.Windows.Forms.TextBox TXTAPMATERNO;
        private System.Windows.Forms.TextBox TXTNOMBRES;
        private System.Windows.Forms.TextBox TXTNUMSEGSOCIAL;
        private System.Windows.Forms.TextBox TXTAPPATERNO;
        private System.Windows.Forms.ComboBox CBOSEXO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVEMPLEADO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTCEDULA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPEMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
    }
}