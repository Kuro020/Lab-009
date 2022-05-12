
namespace Lab_009.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.lblRendimentoResultado = new System.Windows.Forms.Label();
            this.lblConsumoresultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(124, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de Combustível";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(50, 169);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(28, 15);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "&KM:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(39, 228);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(39, 15);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "&Litros:";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(381, 139);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(141, 15);
            this.lblRendimento.TabIndex = 3;
            this.lblRendimento.Text = "Rendimento - KM / Litros";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(381, 198);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(128, 15);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo - KM / Litros";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(84, 166);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(100, 23);
            this.tbxKM.TabIndex = 5;
            this.tbxKM.Tag = "1";
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(84, 225);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(100, 23);
            this.tbxLitros.TabIndex = 6;
            this.tbxLitros.Tag = "1";
            // 
            // lblRendimentoResultado
            // 
            this.lblRendimentoResultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRendimentoResultado.Location = new System.Drawing.Point(381, 169);
            this.lblRendimentoResultado.Name = "lblRendimentoResultado";
            this.lblRendimentoResultado.Size = new System.Drawing.Size(128, 23);
            this.lblRendimentoResultado.TabIndex = 7;
            this.lblRendimentoResultado.Tag = "1";
            // 
            // lblConsumoresultado
            // 
            this.lblConsumoresultado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblConsumoresultado.Location = new System.Drawing.Point(381, 226);
            this.lblConsumoresultado.Name = "lblConsumoresultado";
            this.lblConsumoresultado.Size = new System.Drawing.Size(128, 24);
            this.lblConsumoresultado.TabIndex = 8;
            this.lblConsumoresultado.Tag = "1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(170, 307);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(239, 63);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblConsumoresultado);
            this.Controls.Add(this.lblRendimentoResultado);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Consumo de Combustível";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Label lblRendimentoResultado;
        private System.Windows.Forms.Label lblConsumoresultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}