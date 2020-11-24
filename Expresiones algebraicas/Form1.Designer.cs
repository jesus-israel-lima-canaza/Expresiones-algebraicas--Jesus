namespace Expresiones_algebraicas
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
            this.txtBoxExpresion = new System.Windows.Forms.TextBox();
            this.btnEvaluarExpresion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxExpresion
            // 
            this.txtBoxExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxExpresion.Location = new System.Drawing.Point(88, 137);
            this.txtBoxExpresion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxExpresion.Name = "txtBoxExpresion";
            this.txtBoxExpresion.Size = new System.Drawing.Size(136, 28);
            this.txtBoxExpresion.TabIndex = 0;
            // 
            // btnEvaluarExpresion
            // 
            this.btnEvaluarExpresion.Location = new System.Drawing.Point(281, 128);
            this.btnEvaluarExpresion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEvaluarExpresion.Name = "btnEvaluarExpresion";
            this.btnEvaluarExpresion.Size = new System.Drawing.Size(330, 51);
            this.btnEvaluarExpresion.TabIndex = 1;
            this.btnEvaluarExpresion.Text = "Evaluar Expresion";
            this.btnEvaluarExpresion.UseVisualStyleBackColor = true;
            this.btnEvaluarExpresion.Click += new System.EventHandler(this.btnEvaluarExpresion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosemary", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "EVALUAR EXPRESIONES ARITMETICAS O ALGEBRAICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lab N°1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvaluarExpresion);
            this.Controls.Add(this.txtBoxExpresion);
            this.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Universitario: Lima Canaza Jesus Israel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxExpresion;
        private System.Windows.Forms.Button btnEvaluarExpresion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

