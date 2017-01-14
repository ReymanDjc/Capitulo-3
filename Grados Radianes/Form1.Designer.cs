namespace Grados_Radianes
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
            this.BorrarGradoRadianesBotton = new System.Windows.Forms.Button();
            this.ResultadoRadianesTextBox = new System.Windows.Forms.TextBox();
            this.CantidadGradoTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoRadianesLabel = new System.Windows.Forms.Label();
            this.CantidadGradosLabel = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorrarGradoRadianesBotton
            // 
            this.BorrarGradoRadianesBotton.Location = new System.Drawing.Point(188, 60);
            this.BorrarGradoRadianesBotton.Name = "BorrarGradoRadianesBotton";
            this.BorrarGradoRadianesBotton.Size = new System.Drawing.Size(75, 27);
            this.BorrarGradoRadianesBotton.TabIndex = 11;
            this.BorrarGradoRadianesBotton.Text = "Borrar";
            this.BorrarGradoRadianesBotton.UseVisualStyleBackColor = true;
            this.BorrarGradoRadianesBotton.Click += new System.EventHandler(this.BorrarGradoRadianesBotton_Click);
            // 
            // ResultadoRadianesTextBox
            // 
            this.ResultadoRadianesTextBox.Location = new System.Drawing.Point(73, 64);
            this.ResultadoRadianesTextBox.Name = "ResultadoRadianesTextBox";
            this.ResultadoRadianesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadoRadianesTextBox.TabIndex = 10;
            // 
            // CantidadGradoTextBox
            // 
            this.CantidadGradoTextBox.Location = new System.Drawing.Point(106, 12);
            this.CantidadGradoTextBox.Name = "CantidadGradoTextBox";
            this.CantidadGradoTextBox.Size = new System.Drawing.Size(69, 20);
            this.CantidadGradoTextBox.TabIndex = 9;
            // 
            // ResultadoRadianesLabel
            // 
            this.ResultadoRadianesLabel.AutoSize = true;
            this.ResultadoRadianesLabel.Location = new System.Drawing.Point(14, 67);
            this.ResultadoRadianesLabel.Name = "ResultadoRadianesLabel";
            this.ResultadoRadianesLabel.Size = new System.Drawing.Size(53, 13);
            this.ResultadoRadianesLabel.TabIndex = 8;
            this.ResultadoRadianesLabel.Text = "Resutado";
            // 
            // CantidadGradosLabel
            // 
            this.CantidadGradosLabel.AutoSize = true;
            this.CantidadGradosLabel.Location = new System.Drawing.Point(14, 15);
            this.CantidadGradosLabel.Name = "CantidadGradosLabel";
            this.CantidadGradosLabel.Size = new System.Drawing.Size(86, 13);
            this.CantidadGradosLabel.TabIndex = 7;
            this.CantidadGradosLabel.Text = "Cantidad Grados";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(188, 10);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 34);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 122);
            this.Controls.Add(this.BorrarGradoRadianesBotton);
            this.Controls.Add(this.ResultadoRadianesTextBox);
            this.Controls.Add(this.CantidadGradoTextBox);
            this.Controls.Add(this.ResultadoRadianesLabel);
            this.Controls.Add(this.CantidadGradosLabel);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BorrarGradoRadianesBotton;
        private System.Windows.Forms.TextBox ResultadoRadianesTextBox;
        private System.Windows.Forms.TextBox CantidadGradoTextBox;
        private System.Windows.Forms.Label ResultadoRadianesLabel;
        private System.Windows.Forms.Label CantidadGradosLabel;
        private System.Windows.Forms.Button CalcularButton;
    }
}

