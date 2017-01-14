namespace Par_Impar
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
            this.BorrarBotton = new System.Windows.Forms.Button();
            this.CalcularNumeroButton = new System.Windows.Forms.Button();
            this.ResultadoNumeroLabel = new System.Windows.Forms.Label();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.DigiteNumeroTextBox = new System.Windows.Forms.TextBox();
            this.DigiteNumeroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BorrarBotton
            // 
            this.BorrarBotton.Location = new System.Drawing.Point(218, 55);
            this.BorrarBotton.Name = "BorrarBotton";
            this.BorrarBotton.Size = new System.Drawing.Size(75, 31);
            this.BorrarBotton.TabIndex = 11;
            this.BorrarBotton.Text = "Borrar";
            this.BorrarBotton.UseVisualStyleBackColor = true;
            this.BorrarBotton.Click += new System.EventHandler(this.BorrarBotton_Click);
            // 
            // CalcularNumeroButton
            // 
            this.CalcularNumeroButton.Location = new System.Drawing.Point(218, 6);
            this.CalcularNumeroButton.Name = "CalcularNumeroButton";
            this.CalcularNumeroButton.Size = new System.Drawing.Size(92, 36);
            this.CalcularNumeroButton.TabIndex = 10;
            this.CalcularNumeroButton.Text = "CalcularNumero";
            this.CalcularNumeroButton.UseVisualStyleBackColor = true;
            this.CalcularNumeroButton.Click += new System.EventHandler(this.CalcularNumeroButton_Click);
            // 
            // ResultadoNumeroLabel
            // 
            this.ResultadoNumeroLabel.AutoSize = true;
            this.ResultadoNumeroLabel.Location = new System.Drawing.Point(42, 55);
            this.ResultadoNumeroLabel.Name = "ResultadoNumeroLabel";
            this.ResultadoNumeroLabel.Size = new System.Drawing.Size(55, 13);
            this.ResultadoNumeroLabel.TabIndex = 9;
            this.ResultadoNumeroLabel.Text = "Resultado";
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(103, 52);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadoTextBox.TabIndex = 8;
            // 
            // DigiteNumeroTextBox
            // 
            this.DigiteNumeroTextBox.Location = new System.Drawing.Point(103, 15);
            this.DigiteNumeroTextBox.Name = "DigiteNumeroTextBox";
            this.DigiteNumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.DigiteNumeroTextBox.TabIndex = 7;
            // 
            // DigiteNumeroLabel
            // 
            this.DigiteNumeroLabel.AutoSize = true;
            this.DigiteNumeroLabel.Location = new System.Drawing.Point(12, 18);
            this.DigiteNumeroLabel.Name = "DigiteNumeroLabel";
            this.DigiteNumeroLabel.Size = new System.Drawing.Size(85, 13);
            this.DigiteNumeroLabel.TabIndex = 6;
            this.DigiteNumeroLabel.Text = "Digite el Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 113);
            this.Controls.Add(this.BorrarBotton);
            this.Controls.Add(this.CalcularNumeroButton);
            this.Controls.Add(this.ResultadoNumeroLabel);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.DigiteNumeroTextBox);
            this.Controls.Add(this.DigiteNumeroLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BorrarBotton;
        private System.Windows.Forms.Button CalcularNumeroButton;
        private System.Windows.Forms.Label ResultadoNumeroLabel;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.TextBox DigiteNumeroTextBox;
        private System.Windows.Forms.Label DigiteNumeroLabel;
    }
}

