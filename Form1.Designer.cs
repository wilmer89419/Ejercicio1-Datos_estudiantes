namespace Datos_estudiantes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            txtEdad = new TextBox();
            txtMatricula = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            lblMatricula = new Label();
            lblDatos = new Label();
            lblDatos_Nombre = new Label();
            lblDatos_Apellido = new Label();
            lblDatos_Edad = new Label();
            lblDatos_Carrera = new Label();
            lblDatos_Matricula = new Label();
            btnImprimir = new Button();
            btnClear = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(178, 237);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(404, 40);
            txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 150);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(404, 40);
            txtNombre.TabIndex = 1;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(178, 434);
            txtCarrera.Margin = new Padding(4, 3, 4, 3);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(404, 40);
            txtCarrera.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(178, 339);
            txtEdad.Margin = new Padding(4, 3, 4, 3);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(404, 40);
            txtEdad.TabIndex = 3;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(178, 521);
            txtMatricula.Margin = new Padding(4, 3, 4, 3);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(404, 40);
            txtMatricula.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(32, 150);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(118, 36);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(32, 237);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(126, 36);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            lblApellido.Click += lblApellido_Click;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(32, 339);
            lblEdad.Margin = new Padding(4, 0, 4, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(81, 36);
            lblEdad.TabIndex = 7;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrera.Location = new Point(32, 434);
            lblCarrera.Margin = new Padding(4, 0, 4, 0);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(111, 36);
            lblCarrera.TabIndex = 8;
            lblCarrera.Text = "Carrera";
            lblCarrera.Click += lblCarrera_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatricula.Location = new Point(32, 522);
            lblMatricula.Margin = new Padding(4, 0, 4, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(138, 36);
            lblMatricula.TabIndex = 9;
            lblMatricula.Text = "Matricula";
            lblMatricula.Click += lblMatricula_Click;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.Location = new Point(295, 38);
            lblDatos.Margin = new Padding(4, 0, 4, 0);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(447, 55);
            lblDatos.TabIndex = 10;
            lblDatos.Text = "Datos del Estudiante";
            // 
            // lblDatos_Nombre
            // 
            lblDatos_Nombre.AutoSize = true;
            lblDatos_Nombre.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos_Nombre.Location = new Point(695, 165);
            lblDatos_Nombre.Margin = new Padding(4, 0, 4, 0);
            lblDatos_Nombre.Name = "lblDatos_Nombre";
            lblDatos_Nombre.Size = new Size(0, 36);
            lblDatos_Nombre.TabIndex = 11;
            // 
            // lblDatos_Apellido
            // 
            lblDatos_Apellido.AutoSize = true;
            lblDatos_Apellido.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos_Apellido.Location = new Point(695, 253);
            lblDatos_Apellido.Margin = new Padding(4, 0, 4, 0);
            lblDatos_Apellido.Name = "lblDatos_Apellido";
            lblDatos_Apellido.Size = new Size(0, 36);
            lblDatos_Apellido.TabIndex = 12;
            // 
            // lblDatos_Edad
            // 
            lblDatos_Edad.AutoSize = true;
            lblDatos_Edad.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos_Edad.Location = new Point(695, 351);
            lblDatos_Edad.Margin = new Padding(4, 0, 4, 0);
            lblDatos_Edad.Name = "lblDatos_Edad";
            lblDatos_Edad.Size = new Size(0, 36);
            lblDatos_Edad.TabIndex = 13;
            // 
            // lblDatos_Carrera
            // 
            lblDatos_Carrera.AutoSize = true;
            lblDatos_Carrera.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos_Carrera.Location = new Point(695, 450);
            lblDatos_Carrera.Margin = new Padding(4, 0, 4, 0);
            lblDatos_Carrera.Name = "lblDatos_Carrera";
            lblDatos_Carrera.Size = new Size(0, 36);
            lblDatos_Carrera.TabIndex = 14;
            // 
            // lblDatos_Matricula
            // 
            lblDatos_Matricula.AutoSize = true;
            lblDatos_Matricula.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatos_Matricula.Location = new Point(695, 539);
            lblDatos_Matricula.Margin = new Padding(4, 0, 4, 0);
            lblDatos_Matricula.Name = "lblDatos_Matricula";
            lblDatos_Matricula.Size = new Size(0, 36);
            lblDatos_Matricula.TabIndex = 15;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(6, 682);
            btnImprimir.Margin = new Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(139, 45);
            btnImprimir.TabIndex = 16;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(153, 685);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 45);
            btnClear.TabIndex = 17;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(921, 687);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(117, 40);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 739);
            Controls.Add(btnCerrar);
            Controls.Add(btnClear);
            Controls.Add(btnImprimir);
            Controls.Add(lblDatos_Matricula);
            Controls.Add(lblDatos_Carrera);
            Controls.Add(lblDatos_Edad);
            Controls.Add(lblDatos_Apellido);
            Controls.Add(lblDatos_Nombre);
            Controls.Add(lblDatos);
            Controls.Add(lblMatricula);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtMatricula);
            Controls.Add(txtEdad);
            Controls.Add(txtCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Captura de Datos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private TextBox txtEdad;
        private TextBox txtMatricula;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblCarrera;
        private Label lblMatricula;
        private Label lblDatos;
        private Label lblDatos_Nombre;
        private Label lblDatos_Apellido;
        private Label lblDatos_Edad;
        private Label lblDatos_Carrera;
        private Label lblDatos_Matricula;
        private Button btnImprimir;
        private Button btnClear;
        private Button btnCerrar;
    }
}