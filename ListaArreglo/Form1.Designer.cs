
namespace ListaArreglo
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonOrdenamientoB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(39, 452);
            this.buttonArreglo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(112, 35);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(675, 26);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(505, 564);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(18, 43);
            this.buttonCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(112, 35);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(238, 46);
            this.textBoxContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(426, 384);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(18, 125);
            this.buttonNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(112, 35);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonOrdenamientoB
            // 
            this.buttonOrdenamientoB.Location = new System.Drawing.Point(18, 194);
            this.buttonOrdenamientoB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOrdenamientoB.Name = "buttonOrdenamientoB";
            this.buttonOrdenamientoB.Size = new System.Drawing.Size(188, 35);
            this.buttonOrdenamientoB.TabIndex = 5;
            this.buttonOrdenamientoB.Text = "Ordenamiento a-z";
            this.buttonOrdenamientoB.UseVisualStyleBackColor = true;
            this.buttonOrdenamientoB.Click += new System.EventHandler(this.buttonOrdenamientoB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrdenamientoB);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonOrdenamientoB;
        private System.Windows.Forms.Label label1;
    }
}

