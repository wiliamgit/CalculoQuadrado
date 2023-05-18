namespace CalculoQuadrado
{
    partial class FormQuadrado
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_calcular = new System.Windows.Forms.Label();
            this.lbl_Resul = new System.Windows.Forms.Label();
            this.txBox_Calcular = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(12, 5);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(245, 28);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Calculando o Valor Quadrado";
            // 
            // lbl_calcular
            // 
            this.lbl_calcular.AutoSize = true;
            this.lbl_calcular.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_calcular.Location = new System.Drawing.Point(12, 56);
            this.lbl_calcular.Name = "lbl_calcular";
            this.lbl_calcular.Size = new System.Drawing.Size(160, 28);
            this.lbl_calcular.TabIndex = 1;
            this.lbl_calcular.Text = "Digite um número";
            // 
            // lbl_Resul
            // 
            this.lbl_Resul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Resul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Resul.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resul.Location = new System.Drawing.Point(12, 141);
            this.lbl_Resul.Name = "lbl_Resul";
            this.lbl_Resul.Size = new System.Drawing.Size(333, 225);
            this.lbl_Resul.TabIndex = 2;
            this.lbl_Resul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txBox_Calcular
            // 
            this.txBox_Calcular.Location = new System.Drawing.Point(12, 97);
            this.txBox_Calcular.Name = "txBox_Calcular";
            this.txBox_Calcular.Size = new System.Drawing.Size(160, 23);
            this.txBox_Calcular.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(178, 89);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(83, 33);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // FormQuadrado
            // 
            this.AcceptButton = this.btn_calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(366, 423);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txBox_Calcular);
            this.Controls.Add(this.lbl_Resul);
            this.Controls.Add(this.lbl_calcular);
            this.Controls.Add(this.lbl_titulo);
            this.KeyPreview = true;
            this.Name = "FormQuadrado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Quadrado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_Calcular);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_calcular;
        private Label lbl_Resul;
        private TextBox txBox_Calcular;
        private Button btn_calcular;
    }
}