namespace TextBoxKeyPress
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
            this.lbl_ApenasNumeros = new System.Windows.Forms.Label();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ApenasNumeros
            // 
            this.lbl_ApenasNumeros.AutoSize = true;
            this.lbl_ApenasNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApenasNumeros.Location = new System.Drawing.Point(12, 9);
            this.lbl_ApenasNumeros.Name = "lbl_ApenasNumeros";
            this.lbl_ApenasNumeros.Size = new System.Drawing.Size(123, 18);
            this.lbl_ApenasNumeros.TabIndex = 0;
            this.lbl_ApenasNumeros.Text = "Apenas Numeros";
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(15, 40);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(213, 20);
            this.txt_Texto.TabIndex = 1;
            this.txt_Texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Texto_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 78);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.lbl_ApenasNumeros);
            this.Name = "Form1";
            this.Text = "KeyPress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ApenasNumeros;
        private System.Windows.Forms.TextBox txt_Texto;
    }
}

