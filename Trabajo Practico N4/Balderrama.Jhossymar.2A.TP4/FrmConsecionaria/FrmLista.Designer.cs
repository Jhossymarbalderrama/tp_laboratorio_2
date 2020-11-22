namespace FrmConsecionaria
{
    partial class FrmLista
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnGuardarDataTable = new System.Windows.Forms.Button();
            this.btnCargarDataTable = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtVisorTickets = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAbrirTickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(593, 281);
            this.dgvGrilla.TabIndex = 12;
            // 
            // btnGuardarDataTable
            // 
            this.btnGuardarDataTable.Location = new System.Drawing.Point(21, 48);
            this.btnGuardarDataTable.Name = "btnGuardarDataTable";
            this.btnGuardarDataTable.Size = new System.Drawing.Size(117, 23);
            this.btnGuardarDataTable.TabIndex = 29;
            this.btnGuardarDataTable.Text = "&Guardar XML";
            this.btnGuardarDataTable.UseVisualStyleBackColor = true;
            this.btnGuardarDataTable.Click += new System.EventHandler(this.btnGuardarDataTable_Click_1);
            // 
            // btnCargarDataTable
            // 
            this.btnCargarDataTable.Location = new System.Drawing.Point(21, 19);
            this.btnCargarDataTable.Name = "btnCargarDataTable";
            this.btnCargarDataTable.Size = new System.Drawing.Size(117, 23);
            this.btnCargarDataTable.TabIndex = 28;
            this.btnCargarDataTable.Text = "&Cargar XML";
            this.btnCargarDataTable.UseVisualStyleBackColor = true;
            this.btnCargarDataTable.Click += new System.EventHandler(this.btnCargarDataTable_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(6, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 32);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(122, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 71);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Alta de Vehiculos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 71);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Base de Datos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardarDataTable);
            this.groupBox3.Controls.Add(this.btnCargarDataTable);
            this.groupBox3.Location = new System.Drawing.Point(430, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 80);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "&Archivo XML";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVender);
            this.groupBox4.Location = new System.Drawing.Point(252, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 71);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "&Vender";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(16, 32);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(89, 23);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtVisorTickets
            // 
            this.txtVisorTickets.Location = new System.Drawing.Point(9, 19);
            this.txtVisorTickets.Multiline = true;
            this.txtVisorTickets.Name = "txtVisorTickets";
            this.txtVisorTickets.Size = new System.Drawing.Size(216, 225);
            this.txtVisorTickets.TabIndex = 34;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAbrirTickets);
            this.groupBox5.Controls.Add(this.txtVisorTickets);
            this.groupBox5.Location = new System.Drawing.Point(618, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 291);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TICKET DE VENTAS";
            // 
            // btnAbrirTickets
            // 
            this.btnAbrirTickets.Location = new System.Drawing.Point(6, 258);
            this.btnAbrirTickets.Name = "btnAbrirTickets";
            this.btnAbrirTickets.Size = new System.Drawing.Size(216, 23);
            this.btnAbrirTickets.TabIndex = 36;
            this.btnAbrirTickets.Text = "Abrir Tickets";
            this.btnAbrirTickets.UseVisualStyleBackColor = true;
            this.btnAbrirTickets.Click += new System.EventHandler(this.btnAbrirTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(600, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(620, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Concesionaria Balderrama";
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGrilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLista";
            this.Text = "Lista de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnGuardarDataTable;
        private System.Windows.Forms.Button btnCargarDataTable;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtVisorTickets;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAbrirTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}