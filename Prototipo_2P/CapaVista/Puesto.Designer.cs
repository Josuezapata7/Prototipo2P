
namespace CapaVista
{
    partial class Puesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puesto));
            this.lblTituloP = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtEP = new System.Windows.Forms.TextBox();
            this.lblEstatusP = new System.Windows.Forms.Label();
            this.dvgPuesto = new System.Windows.Forms.DataGridView();
            this.lblIngresarP = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.pnlIngresar = new System.Windows.Forms.Panel();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.pnlDB = new System.Windows.Forms.Panel();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.pnlBodeM = new System.Windows.Forms.Panel();
            this.pnlBordeE = new System.Windows.Forms.Panel();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloP
            // 
            this.lblTituloP.AutoSize = true;
            this.lblTituloP.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.lblTituloP.Location = new System.Drawing.Point(362, 42);
            this.lblTituloP.Name = "lblTituloP";
            this.lblTituloP.Size = new System.Drawing.Size(76, 23);
            this.lblTituloP.TabIndex = 0;
            this.lblTituloP.Text = "Puestos";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(80, 178);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(54, 13);
            this.lblCP.TabIndex = 1;
            this.lblCP.Text = "ID Puesto";
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(83, 194);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(100, 20);
            this.txtIDP.TabIndex = 2;
            // 
            // txtNP
            // 
            this.txtNP.Location = new System.Drawing.Point(83, 255);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(100, 20);
            this.txtNP.TabIndex = 4;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(80, 239);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(80, 13);
            this.lblNombreP.TabIndex = 3;
            this.lblNombreP.Text = "Nombre Puesto";
            // 
            // txtEP
            // 
            this.txtEP.Location = new System.Drawing.Point(225, 232);
            this.txtEP.Name = "txtEP";
            this.txtEP.Size = new System.Drawing.Size(100, 20);
            this.txtEP.TabIndex = 6;
            // 
            // lblEstatusP
            // 
            this.lblEstatusP.AutoSize = true;
            this.lblEstatusP.Location = new System.Drawing.Point(222, 216);
            this.lblEstatusP.Name = "lblEstatusP";
            this.lblEstatusP.Size = new System.Drawing.Size(78, 13);
            this.lblEstatusP.TabIndex = 5;
            this.lblEstatusP.Text = "Estatus Puesto";
            // 
            // dvgPuesto
            // 
            this.dvgPuesto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.dvgPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPuesto.Location = new System.Drawing.Point(390, 162);
            this.dvgPuesto.Name = "dvgPuesto";
            this.dvgPuesto.Size = new System.Drawing.Size(300, 180);
            this.dvgPuesto.TabIndex = 7;
            // 
            // lblIngresarP
            // 
            this.lblIngresarP.AutoSize = true;
            this.lblIngresarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIngresarP.Location = new System.Drawing.Point(97, 96);
            this.lblIngresarP.Name = "lblIngresarP";
            this.lblIngresarP.Size = new System.Drawing.Size(45, 13);
            this.lblIngresarP.TabIndex = 8;
            this.lblIngresarP.Text = "Ingresar";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblModificar.Location = new System.Drawing.Point(382, 95);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(50, 13);
            this.lblModificar.TabIndex = 9;
            this.lblModificar.Text = "Modificar";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDB.Location = new System.Drawing.Point(625, 96);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(63, 13);
            this.lblDB.TabIndex = 10;
            this.lblDB.Text = "Dar de Baja";
            // 
            // pnlIngresar
            // 
            this.pnlIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIngresar.BackgroundImage")));
            this.pnlIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlIngresar.Location = new System.Drawing.Point(177, 307);
            this.pnlIngresar.Name = "pnlIngresar";
            this.pnlIngresar.Size = new System.Drawing.Size(42, 43);
            this.pnlIngresar.TabIndex = 11;
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlModificar.BackgroundImage")));
            this.pnlModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlModificar.Location = new System.Drawing.Point(225, 314);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(35, 35);
            this.pnlModificar.TabIndex = 12;
            // 
            // pnlDB
            // 
            this.pnlDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDB.BackgroundImage")));
            this.pnlDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDB.Location = new System.Drawing.Point(269, 307);
            this.pnlDB.Name = "pnlDB";
            this.pnlDB.Size = new System.Drawing.Size(45, 43);
            this.pnlDB.TabIndex = 13;
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.pnlBorde.Location = new System.Drawing.Point(98, 112);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Size = new System.Drawing.Size(42, 3);
            this.pnlBorde.TabIndex = 14;
            // 
            // pnlBodeM
            // 
            this.pnlBodeM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.pnlBodeM.Location = new System.Drawing.Point(385, 112);
            this.pnlBodeM.Name = "pnlBodeM";
            this.pnlBodeM.Size = new System.Drawing.Size(42, 3);
            this.pnlBodeM.TabIndex = 15;
            // 
            // pnlBordeE
            // 
            this.pnlBordeE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.pnlBordeE.Location = new System.Drawing.Point(635, 112);
            this.pnlBordeE.Name = "pnlBordeE";
            this.pnlBordeE.Size = new System.Drawing.Size(42, 3);
            this.pnlBordeE.TabIndex = 16;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCerrar.BackgroundImage")));
            this.pnlCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCerrar.Location = new System.Drawing.Point(750, 12);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(23, 24);
            this.pnlCerrar.TabIndex = 35;
            this.pnlCerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCerrar_MouseClick);
            // 
            // Puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(210)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCerrar);
            this.Controls.Add(this.pnlBordeE);
            this.Controls.Add(this.pnlBodeM);
            this.Controls.Add(this.pnlBorde);
            this.Controls.Add(this.pnlDB);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.pnlIngresar);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblIngresarP);
            this.Controls.Add(this.dvgPuesto);
            this.Controls.Add(this.txtEP);
            this.Controls.Add(this.lblEstatusP);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.txtIDP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblTituloP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Puesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puesto";
            this.Load += new System.EventHandler(this.Puesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtEP;
        private System.Windows.Forms.Label lblEstatusP;
        private System.Windows.Forms.DataGridView dvgPuesto;
        private System.Windows.Forms.Label lblIngresarP;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Panel pnlIngresar;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Panel pnlDB;
        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel pnlBodeM;
        private System.Windows.Forms.Panel pnlBordeE;
        private System.Windows.Forms.Panel pnlCerrar;
    }
}