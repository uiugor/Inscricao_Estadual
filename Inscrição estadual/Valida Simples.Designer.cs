﻿namespace Inscrição_estadual
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValida = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnV2 = new System.Windows.Forms.Button();
            this.brnV3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscrição Estadual:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(134, 25);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(148, 20);
            this.txtInscricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UF:";
            // 
            // btnValida
            // 
            this.btnValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValida.Location = new System.Drawing.Point(126, 83);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(75, 23);
            this.btnValida.TabIndex = 4;
            this.btnValida.Text = "Validar";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(207, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbUF
            // 
            this.cbUF.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "SP",
            "PR"});
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(134, 56);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(148, 21);
            this.cbUF.TabIndex = 9;
            this.cbUF.Text = "Selecione";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 103);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnV2
            // 
            this.btnV2.Location = new System.Drawing.Point(248, 121);
            this.btnV2.Name = "btnV2";
            this.btnV2.Size = new System.Drawing.Size(42, 23);
            this.btnV2.TabIndex = 11;
            this.btnV2.Text = "V 2.0";
            this.btnV2.UseVisualStyleBackColor = true;
            this.btnV2.Click += new System.EventHandler(this.btnV2_Click);
            // 
            // brnV3
            // 
            this.brnV3.Location = new System.Drawing.Point(200, 121);
            this.brnV3.Name = "brnV3";
            this.brnV3.Size = new System.Drawing.Size(42, 23);
            this.brnV3.TabIndex = 12;
            this.brnV3.Text = "V 3.0";
            this.brnV3.UseVisualStyleBackColor = true;
            this.brnV3.Click += new System.EventHandler(this.brnV3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 145);
            this.Controls.Add(this.brnV3);
            this.Controls.Add(this.btnV2);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Validação Inscrição Estadual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnV2;
        private System.Windows.Forms.Button brnV3;
    }
}

