namespace WF_Funcionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RBtnFree = new System.Windows.Forms.RadioButton();
            this.RBtnPJ = new System.Windows.Forms.RadioButton();
            this.RBtnCLT = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(180, 41);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(158, 20);
            this.txtFuncionario.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(180, 103);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(161, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos de Contrato";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(323, 252);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(49, 214);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(124, 24);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "RESULTADO";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(180, 160);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(158, 20);
            this.txtValor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Projeto:";
            // 
            // RBtnFree
            // 
            this.RBtnFree.AutoSize = true;
            this.RBtnFree.Location = new System.Drawing.Point(572, 237);
            this.RBtnFree.Name = "RBtnFree";
            this.RBtnFree.Size = new System.Drawing.Size(46, 17);
            this.RBtnFree.TabIndex = 14;
            this.RBtnFree.TabStop = true;
            this.RBtnFree.Text = "Free";
            this.RBtnFree.UseVisualStyleBackColor = true;
            this.RBtnFree.CheckedChanged += new System.EventHandler(this.RBtnFree_CheckedChanged_1);
            // 
            // RBtnPJ
            // 
            this.RBtnPJ.AutoSize = true;
            this.RBtnPJ.Location = new System.Drawing.Point(572, 214);
            this.RBtnPJ.Name = "RBtnPJ";
            this.RBtnPJ.Size = new System.Drawing.Size(37, 17);
            this.RBtnPJ.TabIndex = 13;
            this.RBtnPJ.TabStop = true;
            this.RBtnPJ.Text = "PJ";
            this.RBtnPJ.UseVisualStyleBackColor = true;
            // 
            // RBtnCLT
            // 
            this.RBtnCLT.AutoSize = true;
            this.RBtnCLT.Location = new System.Drawing.Point(572, 191);
            this.RBtnCLT.Name = "RBtnCLT";
            this.RBtnCLT.Size = new System.Drawing.Size(45, 17);
            this.RBtnCLT.TabIndex = 12;
            this.RBtnCLT.TabStop = true;
            this.RBtnCLT.Text = "CLT";
            this.RBtnCLT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RBtnFree);
            this.Controls.Add(this.RBtnPJ);
            this.Controls.Add(this.RBtnCLT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RBtnFree;
        private System.Windows.Forms.RadioButton RBtnPJ;
        private System.Windows.Forms.RadioButton RBtnCLT;
    }
}

