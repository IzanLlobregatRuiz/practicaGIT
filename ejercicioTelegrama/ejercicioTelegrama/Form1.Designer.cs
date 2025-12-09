namespace ejercicioTelegrama
{
    partial class Form1
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
            this.lblTit = new System.Windows.Forms.Label();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtnUrgente = new System.Windows.Forms.RadioButton();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Location = new System.Drawing.Point(101, 77);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(34, 13);
            this.lblTit.TabIndex = 0;
            this.lblTit.Text = "Texto";
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(101, 191);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(40, 13);
            this.lblCoste.TabIndex = 1;
            this.lblCoste.Text = "Coste: ";
            this.lblCoste.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(104, 94);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(266, 70);
            this.txtTelegrama.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(147, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(110, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(263, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(107, 37);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnUrgente
            // 
            this.rbtnUrgente.AutoSize = true;
            this.rbtnUrgente.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnUrgente.Location = new System.Drawing.Point(177, 170);
            this.rbtnUrgente.Name = "rbtnUrgente";
            this.rbtnUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbtnUrgente.TabIndex = 6;
            this.rbtnUrgente.Text = "Urgente";
            this.rbtnUrgente.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.AutoSize = true;
            this.rbtnOrdinario.Location = new System.Drawing.Point(104, 170);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rbtnOrdinario.TabIndex = 7;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 264);
            this.Controls.Add(this.rbtnOrdinario);
            this.Controls.Add(this.rbtnUrgente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblTit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtnUrgente;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
    }
}

