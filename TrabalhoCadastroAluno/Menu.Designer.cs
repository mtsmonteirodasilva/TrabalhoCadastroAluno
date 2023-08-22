namespace TrabalhoCadastroAluno
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_aluno = new System.Windows.Forms.Button();
            this.bt_responsavel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // bt_aluno
            // 
            this.bt_aluno.Location = new System.Drawing.Point(176, 173);
            this.bt_aluno.Name = "bt_aluno";
            this.bt_aluno.Size = new System.Drawing.Size(75, 23);
            this.bt_aluno.TabIndex = 1;
            this.bt_aluno.Text = "Aluno ";
            this.bt_aluno.UseVisualStyleBackColor = true;
            this.bt_aluno.Click += new System.EventHandler(this.bt_aluno_Click);
            // 
            // bt_responsavel
            // 
            this.bt_responsavel.Location = new System.Drawing.Point(166, 236);
            this.bt_responsavel.Name = "bt_responsavel";
            this.bt_responsavel.Size = new System.Drawing.Size(97, 23);
            this.bt_responsavel.TabIndex = 2;
            this.bt_responsavel.Text = "Responsavel";
            this.bt_responsavel.UseVisualStyleBackColor = true;
            this.bt_responsavel.Click += new System.EventHandler(this.bt_responsavel_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.bt_responsavel);
            this.Controls.Add(this.bt_aluno);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_aluno;
        private System.Windows.Forms.Button bt_responsavel;
    }
}