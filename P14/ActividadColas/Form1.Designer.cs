namespace ActividadColas
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
            this.components = new System.ComponentModel.Container();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbAciertos = new System.Windows.Forms.TextBox();
            this.gpbCalificar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtbAlumnoCalificar = new System.Windows.Forms.TextBox();
            this.gpbCalificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(13, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(283, 29);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Calificador de Alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar nombre completo del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aciertos en su examen (1 a 10)";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(21, 84);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(194, 22);
            this.txtbNombre.TabIndex = 4;
            // 
            // txtbAciertos
            // 
            this.txtbAciertos.Location = new System.Drawing.Point(21, 151);
            this.txtbAciertos.Name = "txtbAciertos";
            this.txtbAciertos.Size = new System.Drawing.Size(69, 22);
            this.txtbAciertos.TabIndex = 5;
            // 
            // gpbCalificar
            // 
            this.gpbCalificar.Controls.Add(this.txtbAlumnoCalificar);
            this.gpbCalificar.Controls.Add(this.label3);
            this.gpbCalificar.Controls.Add(this.btnCalificar);
            this.gpbCalificar.Location = new System.Drawing.Point(298, 63);
            this.gpbCalificar.Name = "gpbCalificar";
            this.gpbCalificar.Size = new System.Drawing.Size(259, 198);
            this.gpbCalificar.TabIndex = 6;
            this.gpbCalificar.TabStop = false;
            this.gpbCalificar.Text = "Califica al alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alumno a calificar";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(57, 121);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(138, 37);
            this.btnCalificar.TabIndex = 0;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(75, 205);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(140, 56);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "Añadir a la cola";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtbAlumnoCalificar
            // 
            this.txtbAlumnoCalificar.Enabled = false;
            this.txtbAlumnoCalificar.Location = new System.Drawing.Point(37, 76);
            this.txtbAlumnoCalificar.Name = "txtbAlumnoCalificar";
            this.txtbAlumnoCalificar.Size = new System.Drawing.Size(194, 22);
            this.txtbAlumnoCalificar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 293);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.gpbCalificar);
            this.Controls.Add(this.txtbAciertos);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCalificar.ResumeLayout(false);
            this.gpbCalificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbAciertos;
        private System.Windows.Forms.GroupBox gpbCalificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox txtbAlumnoCalificar;
    }
}

