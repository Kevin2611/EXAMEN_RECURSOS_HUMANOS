﻿
namespace FORM
{
    partial class FRMCLIENTS
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
            this.GPBCLIENTE = new System.Windows.Forms.GroupBox();
            this.TXTCEDULA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.CMBSEXO = new System.Windows.Forms.ComboBox();
            this.CMBCATEGORIA = new System.Windows.Forms.ComboBox();
            this.TXTCODPERSONA = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTNUMSEGSOCIAL = new System.Windows.Forms.TextBox();
            this.TXTAPMATERNO = new System.Windows.Forms.TextBox();
            this.TXTAPPATERNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DGVCLIENTES = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCLIENTE
            // 
            this.GPBCLIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GPBCLIENTE.BackgroundImage = global::FORM.Properties.Resources._43cb7c2be497681b341d09eef1324244;
            this.GPBCLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GPBCLIENTE.Controls.Add(this.TXTCEDULA);
            this.GPBCLIENTE.Controls.Add(this.label8);
            this.GPBCLIENTE.Controls.Add(this.BTNSAVE);
            this.GPBCLIENTE.Controls.Add(this.CMBSEXO);
            this.GPBCLIENTE.Controls.Add(this.CMBCATEGORIA);
            this.GPBCLIENTE.Controls.Add(this.TXTCODPERSONA);
            this.GPBCLIENTE.Controls.Add(this.TXTNOMBRE);
            this.GPBCLIENTE.Controls.Add(this.TXTNUMSEGSOCIAL);
            this.GPBCLIENTE.Controls.Add(this.TXTAPMATERNO);
            this.GPBCLIENTE.Controls.Add(this.TXTAPPATERNO);
            this.GPBCLIENTE.Controls.Add(this.label7);
            this.GPBCLIENTE.Controls.Add(this.label6);
            this.GPBCLIENTE.Controls.Add(this.label5);
            this.GPBCLIENTE.Controls.Add(this.label4);
            this.GPBCLIENTE.Controls.Add(this.label3);
            this.GPBCLIENTE.Controls.Add(this.label2);
            this.GPBCLIENTE.Controls.Add(this.label1);
            this.GPBCLIENTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPBCLIENTE.Location = new System.Drawing.Point(0, 0);
            this.GPBCLIENTE.Margin = new System.Windows.Forms.Padding(5);
            this.GPBCLIENTE.Name = "GPBCLIENTE";
            this.GPBCLIENTE.Padding = new System.Windows.Forms.Padding(5);
            this.GPBCLIENTE.Size = new System.Drawing.Size(1284, 407);
            this.GPBCLIENTE.TabIndex = 0;
            this.GPBCLIENTE.TabStop = false;
            this.GPBCLIENTE.Text = "CLIENTE";
            // 
            // TXTCEDULA
            // 
            this.TXTCEDULA.Location = new System.Drawing.Point(876, 292);
            this.TXTCEDULA.Name = "TXTCEDULA";
            this.TXTCEDULA.Size = new System.Drawing.Size(228, 28);
            this.TXTCEDULA.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(909, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEDULA";
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNSAVE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSAVE.FlatAppearance.BorderSize = 2;
            this.BTNSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNSAVE.Location = new System.Drawing.Point(994, 350);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(147, 49);
            this.BTNSAVE.TabIndex = 15;
            this.BTNSAVE.Text = "GUARDAR";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // CMBSEXO
            // 
            this.CMBSEXO.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMBSEXO.FormattingEnabled = true;
            this.CMBSEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CMBSEXO.Location = new System.Drawing.Point(872, 141);
            this.CMBSEXO.Name = "CMBSEXO";
            this.CMBSEXO.Size = new System.Drawing.Size(232, 30);
            this.CMBSEXO.TabIndex = 14;
            this.CMBSEXO.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CMBCATEGORIA
            // 
            this.CMBCATEGORIA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMBCATEGORIA.FormattingEnabled = true;
            this.CMBCATEGORIA.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CMBCATEGORIA.Location = new System.Drawing.Point(316, 290);
            this.CMBCATEGORIA.Name = "CMBCATEGORIA";
            this.CMBCATEGORIA.Size = new System.Drawing.Size(197, 30);
            this.CMBCATEGORIA.TabIndex = 13;
            this.CMBCATEGORIA.Text = "CATEGORIA";
            // 
            // TXTCODPERSONA
            // 
            this.TXTCODPERSONA.Location = new System.Drawing.Point(539, 292);
            this.TXTCODPERSONA.Name = "TXTCODPERSONA";
            this.TXTCODPERSONA.Size = new System.Drawing.Size(263, 28);
            this.TXTCODPERSONA.TabIndex = 12;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(539, 143);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(263, 28);
            this.TXTNOMBRE.TabIndex = 11;
            // 
            // TXTNUMSEGSOCIAL
            // 
            this.TXTNUMSEGSOCIAL.Location = new System.Drawing.Point(16, 290);
            this.TXTNUMSEGSOCIAL.Name = "TXTNUMSEGSOCIAL";
            this.TXTNUMSEGSOCIAL.Size = new System.Drawing.Size(228, 28);
            this.TXTNUMSEGSOCIAL.TabIndex = 10;
            // 
            // TXTAPMATERNO
            // 
            this.TXTAPMATERNO.Location = new System.Drawing.Point(250, 143);
            this.TXTAPMATERNO.Name = "TXTAPMATERNO";
            this.TXTAPMATERNO.Size = new System.Drawing.Size(216, 28);
            this.TXTAPMATERNO.TabIndex = 8;
            // 
            // TXTAPPATERNO
            // 
            this.TXTAPPATERNO.Location = new System.Drawing.Point(16, 143);
            this.TXTAPPATERNO.Name = "TXTAPPATERNO";
            this.TXTAPPATERNO.Size = new System.Drawing.Size(189, 28);
            this.TXTAPPATERNO.TabIndex = 7;
            this.TXTAPPATERNO.TextChanged += new System.EventHandler(this.TXTAPPATERNO_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(585, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "CODIGO PEDIDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(312, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "NUMERO SEGURO SOCIAL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(922, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEXO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(585, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(273, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO MATERNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DGVCLIENTES
            // 
            this.DGVCLIENTES.AllowUserToAddRows = false;
            this.DGVCLIENTES.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGVCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCLIENTES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.CEDULA,
            this.SEXO,
            this.NUMSEGSOCIAL,
            this.CATEGORIA,
            this.CODIGOPEDIDO});
            this.DGVCLIENTES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCLIENTES.Location = new System.Drawing.Point(0, 407);
            this.DGVCLIENTES.Name = "DGVCLIENTES";
            this.DGVCLIENTES.RowHeadersWidth = 51;
            this.DGVCLIENTES.RowTemplate.Height = 24;
            this.DGVCLIENTES.Size = new System.Drawing.Size(1284, 343);
            this.DGVCLIENTES.TabIndex = 1;
            this.DGVCLIENTES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCLIENTES_CellContentClick);
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 190;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 180;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 225;
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
            this.SEXO.Width = 170;
            // 
            // NUMSEGSOCIAL
            // 
            this.NUMSEGSOCIAL.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOCIAL.MinimumWidth = 6;
            this.NUMSEGSOCIAL.Name = "NUMSEGSOCIAL";
            this.NUMSEGSOCIAL.Width = 191;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 180;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO PEDIDO";
            this.CODIGOPEDIDO.MinimumWidth = 6;
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 180;
            // 
            // FRMCLIENTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1284, 750);
            this.Controls.Add(this.DGVCLIENTES);
            this.Controls.Add(this.GPBCLIENTE);
            this.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMCLIENTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMCLIENTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMCLIENTS_Load);
            this.GPBCLIENTE.ResumeLayout(false);
            this.GPBCLIENTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCLIENTE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox CMBSEXO;
        private System.Windows.Forms.ComboBox CMBCATEGORIA;
        private System.Windows.Forms.TextBox TXTCODPERSONA;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTNUMSEGSOCIAL;
        private System.Windows.Forms.TextBox TXTAPMATERNO;
        private System.Windows.Forms.TextBox TXTAPPATERNO;
        private System.Windows.Forms.DataGridView DGVCLIENTES;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.TextBox TXTCEDULA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
    }
}