﻿namespace PizzaTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndomicilio = new System.Windows.Forms.Button();
            this.btntiendafisica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese que opcion desea ocupar.";
            // 
            // btndomicilio
            // 
            this.btndomicilio.Location = new System.Drawing.Point(309, 260);
            this.btndomicilio.Name = "btndomicilio";
            this.btndomicilio.Size = new System.Drawing.Size(132, 57);
            this.btndomicilio.TabIndex = 2;
            this.btndomicilio.Text = "A domicilio";
            this.btndomicilio.UseVisualStyleBackColor = true;
            this.btndomicilio.Click += new System.EventHandler(this.btndomicilio_Click);
            // 
            // btntiendafisica
            // 
            this.btntiendafisica.Location = new System.Drawing.Point(309, 153);
            this.btntiendafisica.Name = "btntiendafisica";
            this.btntiendafisica.Size = new System.Drawing.Size(132, 57);
            this.btntiendafisica.TabIndex = 3;
            this.btntiendafisica.Text = "En tienda ";
            this.btntiendafisica.UseVisualStyleBackColor = true;
            this.btntiendafisica.Click += new System.EventHandler(this.btntiendafisica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntiendafisica);
            this.Controls.Add(this.btndomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizzeria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndomicilio;
        private System.Windows.Forms.Button btntiendafisica;
    }
}

