namespace Capturaempleadoforms
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
        private void InitializeComponent(Form1 Form1)
        {
            txbcodigo = new TextBox();
            txbnombres = new TextBox();
            txbapellidos = new TextBox();
            txbcorreo = new TextBox();
            txbtelefono = new TextBox();
            txbdireccion = new TextBox();
            textBox7 = new TextBox();
            txbdepartamento = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txbcodigo
            // 
            txbcodigo.Location = new Point(89, 22);
            txbcodigo.Name = "txbcodigo";
            txbcodigo.Size = new Size(100, 23);
            txbcodigo.TabIndex = 0;
            // 
            // txbnombres
            // 
            txbnombres.Location = new Point(57, 22);
            txbnombres.Name = "txbnombres";
            txbnombres.Size = new Size(100, 23);
            txbnombres.TabIndex = 1;
            // 
            // txbapellidos
            // 
            txbapellidos.Location = new Point(252, 22);
            txbapellidos.Name = "txbapellidos";
            txbapellidos.Size = new Size(100, 23);
            txbapellidos.TabIndex = 2;
            // 
            // txbcorreo
            // 
            txbcorreo.Location = new Point(57, 61);
            txbcorreo.Name = "txbcorreo";
            txbcorreo.Size = new Size(100, 23);
            txbcorreo.TabIndex = 3;
            // 
            // txbtelefono
            // 
            txbtelefono.Location = new Point(252, 61);
            txbtelefono.Name = "txbtelefono";
            txbtelefono.Size = new Size(100, 23);
            txbtelefono.TabIndex = 4;
            // 
            // txbdireccion
            // 
            txbdireccion.Location = new Point(57, 99);
            txbdireccion.Name = "txbdireccion";
            txbdireccion.Size = new Size(100, 23);
            txbdireccion.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(284, 61);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // txbdepartamento
            // 
            txbdepartamento.Location = new Point(89, 61);
            txbdepartamento.Name = "txbdepartamento";
            txbdepartamento.Size = new Size(100, 23);
            txbdepartamento.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 9;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 29);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 69);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 69);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 13;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 107);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 69);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "Posicion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 69);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 16;
            label8.Text = "Departamento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 107);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 17;
            label9.Text = "Fecha de Contratacion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txbnombres);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbapellidos);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txbcorreo);
            groupBox1.Controls.Add(txbdireccion);
            groupBox1.Controls.Add(txbtelefono);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 152);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbcodigo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(txbdepartamento);
            groupBox2.Location = new Point(387, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 152);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Laborales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Form1.Form_Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txbcodigo;
        private TextBox txbnombres;
        private TextBox txbapellidos;
        private TextBox txbcorreo;
        private TextBox txbtelefono;
        private TextBox txbdireccion;
        private TextBox textBox7;
        private TextBox txbdepartamento;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;

        public Action<object, EventArgs> Form_Load { get; private set; }
    }
}