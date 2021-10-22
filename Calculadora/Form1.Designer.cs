
namespace Calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Uno = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            this.RaizCuadrada = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Restar = new System.Windows.Forms.Button();
            this.Sumar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Signo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResultado.Location = new System.Drawing.Point(13, 13);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(303, 45);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Uno
            // 
            this.Uno.BackColor = System.Drawing.SystemColors.Desktop;
            this.Uno.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Uno.ForeColor = System.Drawing.SystemColors.Control;
            this.Uno.Location = new System.Drawing.Point(13, 249);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(45, 45);
            this.Uno.TabIndex = 1;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = false;
            this.Uno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Dos
            // 
            this.Dos.BackColor = System.Drawing.SystemColors.Desktop;
            this.Dos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dos.ForeColor = System.Drawing.SystemColors.Control;
            this.Dos.Location = new System.Drawing.Point(70, 249);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(45, 45);
            this.Dos.TabIndex = 2;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = false;
            this.Dos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Tres
            // 
            this.Tres.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tres.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tres.ForeColor = System.Drawing.SystemColors.Control;
            this.Tres.Location = new System.Drawing.Point(127, 249);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(45, 45);
            this.Tres.TabIndex = 3;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = false;
            this.Tres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Seis
            // 
            this.Seis.BackColor = System.Drawing.SystemColors.Desktop;
            this.Seis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Seis.ForeColor = System.Drawing.SystemColors.Control;
            this.Seis.Location = new System.Drawing.Point(127, 190);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(45, 45);
            this.Seis.TabIndex = 6;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = false;
            this.Seis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cinco
            // 
            this.Cinco.BackColor = System.Drawing.SystemColors.Desktop;
            this.Cinco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cinco.ForeColor = System.Drawing.SystemColors.Control;
            this.Cinco.Location = new System.Drawing.Point(70, 190);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(45, 45);
            this.Cinco.TabIndex = 5;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = false;
            this.Cinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cuatro
            // 
            this.Cuatro.BackColor = System.Drawing.SystemColors.Desktop;
            this.Cuatro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cuatro.ForeColor = System.Drawing.SystemColors.Control;
            this.Cuatro.Location = new System.Drawing.Point(13, 190);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(45, 45);
            this.Cuatro.TabIndex = 4;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = false;
            this.Cuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Quitar
            // 
            this.Quitar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Quitar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quitar.ForeColor = System.Drawing.SystemColors.Control;
            this.Quitar.Location = new System.Drawing.Point(127, 71);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(45, 45);
            this.Quitar.TabIndex = 12;
            this.Quitar.Text = "<-";
            this.Quitar.UseVisualStyleBackColor = false;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.BackColor = System.Drawing.SystemColors.Desktop;
            this.BorrarTodo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BorrarTodo.ForeColor = System.Drawing.SystemColors.Control;
            this.BorrarTodo.Location = new System.Drawing.Point(70, 71);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(45, 45);
            this.BorrarTodo.TabIndex = 11;
            this.BorrarTodo.Text = "C";
            this.BorrarTodo.UseVisualStyleBackColor = false;
            this.BorrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Borrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Borrar.ForeColor = System.Drawing.SystemColors.Control;
            this.Borrar.Location = new System.Drawing.Point(13, 71);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(45, 45);
            this.Borrar.TabIndex = 10;
            this.Borrar.Text = "CE";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Nueve
            // 
            this.Nueve.BackColor = System.Drawing.SystemColors.Desktop;
            this.Nueve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nueve.ForeColor = System.Drawing.SystemColors.Control;
            this.Nueve.Location = new System.Drawing.Point(127, 131);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(45, 45);
            this.Nueve.TabIndex = 9;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = false;
            this.Nueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Ocho
            // 
            this.Ocho.BackColor = System.Drawing.SystemColors.Desktop;
            this.Ocho.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ocho.ForeColor = System.Drawing.SystemColors.Control;
            this.Ocho.Location = new System.Drawing.Point(70, 131);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(45, 45);
            this.Ocho.TabIndex = 8;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = false;
            this.Ocho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Siete
            // 
            this.Siete.BackColor = System.Drawing.SystemColors.Desktop;
            this.Siete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Siete.ForeColor = System.Drawing.SystemColors.Control;
            this.Siete.Location = new System.Drawing.Point(13, 131);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(45, 45);
            this.Siete.TabIndex = 7;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = false;
            this.Siete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Cuadrado
            // 
            this.Cuadrado.BackColor = System.Drawing.SystemColors.Desktop;
            this.Cuadrado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cuadrado.ForeColor = System.Drawing.SystemColors.Control;
            this.Cuadrado.Location = new System.Drawing.Point(271, 71);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(45, 45);
            this.Cuadrado.TabIndex = 14;
            this.Cuadrado.Tag = "²";
            this.Cuadrado.Text = "x²";
            this.Cuadrado.UseVisualStyleBackColor = false;
            this.Cuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // RaizCuadrada
            // 
            this.RaizCuadrada.BackColor = System.Drawing.SystemColors.Desktop;
            this.RaizCuadrada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RaizCuadrada.ForeColor = System.Drawing.SystemColors.Control;
            this.RaizCuadrada.Location = new System.Drawing.Point(214, 71);
            this.RaizCuadrada.Name = "RaizCuadrada";
            this.RaizCuadrada.Size = new System.Drawing.Size(45, 45);
            this.RaizCuadrada.TabIndex = 13;
            this.RaizCuadrada.Tag = "√";
            this.RaizCuadrada.Text = "√";
            this.RaizCuadrada.UseVisualStyleBackColor = false;
            this.RaizCuadrada.Click += new System.EventHandler(this.clickOperador);
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Multiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Multiplicar.ForeColor = System.Drawing.SystemColors.Control;
            this.Multiplicar.Location = new System.Drawing.Point(271, 131);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(45, 45);
            this.Multiplicar.TabIndex = 16;
            this.Multiplicar.Tag = "X";
            this.Multiplicar.Text = "X";
            this.Multiplicar.UseVisualStyleBackColor = false;
            this.Multiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.SystemColors.Desktop;
            this.Dividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dividir.ForeColor = System.Drawing.SystemColors.Control;
            this.Dividir.Location = new System.Drawing.Point(214, 131);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(45, 45);
            this.Dividir.TabIndex = 15;
            this.Dividir.Tag = "∕";
            this.Dividir.Text = "∕";
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // Restar
            // 
            this.Restar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Restar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Restar.ForeColor = System.Drawing.SystemColors.Control;
            this.Restar.Location = new System.Drawing.Point(271, 190);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(45, 45);
            this.Restar.TabIndex = 18;
            this.Restar.Tag = "−";
            this.Restar.Text = "−";
            this.Restar.UseVisualStyleBackColor = false;
            this.Restar.Click += new System.EventHandler(this.clickOperador);
            // 
            // Sumar
            // 
            this.Sumar.BackColor = System.Drawing.SystemColors.Desktop;
            this.Sumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sumar.ForeColor = System.Drawing.SystemColors.Control;
            this.Sumar.Location = new System.Drawing.Point(214, 190);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(45, 45);
            this.Sumar.TabIndex = 17;
            this.Sumar.Tag = "+";
            this.Sumar.Text = "+";
            this.Sumar.UseVisualStyleBackColor = false;
            this.Sumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.Desktop;
            this.Resultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resultado.ForeColor = System.Drawing.SystemColors.Control;
            this.Resultado.Location = new System.Drawing.Point(214, 249);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(102, 45);
            this.Resultado.TabIndex = 19;
            this.Resultado.Text = "=";
            this.Resultado.UseVisualStyleBackColor = false;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Punto
            // 
            this.Punto.BackColor = System.Drawing.SystemColors.Desktop;
            this.Punto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Punto.ForeColor = System.Drawing.SystemColors.Control;
            this.Punto.Location = new System.Drawing.Point(127, 310);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(45, 45);
            this.Punto.TabIndex = 22;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = false;
            this.Punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // Cero
            // 
            this.Cero.BackColor = System.Drawing.SystemColors.Desktop;
            this.Cero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cero.ForeColor = System.Drawing.SystemColors.Control;
            this.Cero.Location = new System.Drawing.Point(70, 310);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(45, 45);
            this.Cero.TabIndex = 21;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = false;
            this.Cero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // Signo
            // 
            this.Signo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Signo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Signo.ForeColor = System.Drawing.SystemColors.Control;
            this.Signo.Location = new System.Drawing.Point(13, 310);
            this.Signo.Name = "Signo";
            this.Signo.Size = new System.Drawing.Size(45, 45);
            this.Signo.TabIndex = 20;
            this.Signo.Text = "+/-";
            this.Signo.UseVisualStyleBackColor = false;
            this.Signo.Click += new System.EventHandler(this.Signo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(331, 365);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Signo);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Sumar);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.RaizCuadrada);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.BorrarTodo);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.Ocho);
            this.Controls.Add(this.Siete);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Cuatro);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dos);
            this.Controls.Add(this.Uno);
            this.Controls.Add(this.txtResultado);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Cuadrado;
        private System.Windows.Forms.Button RaizCuadrada;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Restar;
        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Signo;
    }
}

