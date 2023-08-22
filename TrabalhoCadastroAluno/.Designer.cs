namespace TrabalhoCadastroAluno
{
    partial class CadastroAluno
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_matricula = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_cadastar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.msk_datanasc = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento";
            // 
            // tx_matricula
            // 
            this.tx_matricula.Location = new System.Drawing.Point(93, 115);
            this.tx_matricula.Name = "tx_matricula";
            this.tx_matricula.Size = new System.Drawing.Size(167, 20);
            this.tx_matricula.TabIndex = 4;
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(72, 141);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(188, 20);
            this.tx_nome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "CADASTRO DE ALUNO";
            // 
            // bt_cadastar
            // 
            this.bt_cadastar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastar.Location = new System.Drawing.Point(264, 360);
            this.bt_cadastar.Name = "bt_cadastar";
            this.bt_cadastar.Size = new System.Drawing.Size(92, 27);
            this.bt_cadastar.TabIndex = 9;
            this.bt_cadastar.Text = "Cadastrar";
            this.bt_cadastar.UseVisualStyleBackColor = true;
            this.bt_cadastar.Click += new System.EventHandler(this.bt_cadastar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(183, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msk_cpf
            // 
            this.msk_cpf.Location = new System.Drawing.Point(72, 167);
            this.msk_cpf.Mask = "000,000,000-00";
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(188, 20);
            this.msk_cpf.TabIndex = 11;
            // 
            // msk_datanasc
            // 
            this.msk_datanasc.Location = new System.Drawing.Point(160, 196);
            this.msk_datanasc.Mask = "00/00/0000";
            this.msk_datanasc.Name = "msk_datanasc";
            this.msk_datanasc.Size = new System.Drawing.Size(100, 20);
            this.msk_datanasc.TabIndex = 12;
            this.msk_datanasc.ValidatingType = typeof(System.DateTime);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(368, 425);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msk_datanasc);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_cadastar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CadastroAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_matricula;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_cadastar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.MaskedTextBox msk_datanasc;
        private System.Windows.Forms.Button button2;
    }
}

