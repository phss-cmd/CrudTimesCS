
namespace CrudTimesCS.view
{
    partial class TelaCadastrarJogadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarJogadores));
            this.lblTituloJogadores = new System.Windows.Forms.Label();
            this.lblNomeJogadores = new System.Windows.Forms.Label();
            this.lblEmailJogadores = new System.Windows.Forms.Label();
            this.lblFoneJogadores = new System.Windows.Forms.Label();
            this.tbxNomeJogadores = new System.Windows.Forms.TextBox();
            this.tbxEmailJogadores = new System.Windows.Forms.TextBox();
            this.tbxFoneJogadores = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloJogadores
            // 
            this.lblTituloJogadores.AutoSize = true;
            this.lblTituloJogadores.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloJogadores.Location = new System.Drawing.Point(41, 9);
            this.lblTituloJogadores.Name = "lblTituloJogadores";
            this.lblTituloJogadores.Size = new System.Drawing.Size(216, 30);
            this.lblTituloJogadores.TabIndex = 0;
            this.lblTituloJogadores.Text = "Cadastro Jogadores";
            // 
            // lblNomeJogadores
            // 
            this.lblNomeJogadores.AutoSize = true;
            this.lblNomeJogadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeJogadores.Location = new System.Drawing.Point(41, 64);
            this.lblNomeJogadores.Name = "lblNomeJogadores";
            this.lblNomeJogadores.Size = new System.Drawing.Size(56, 21);
            this.lblNomeJogadores.TabIndex = 1;
            this.lblNomeJogadores.Text = "Nome:";
            // 
            // lblEmailJogadores
            // 
            this.lblEmailJogadores.AutoSize = true;
            this.lblEmailJogadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailJogadores.Location = new System.Drawing.Point(41, 122);
            this.lblEmailJogadores.Name = "lblEmailJogadores";
            this.lblEmailJogadores.Size = new System.Drawing.Size(57, 21);
            this.lblEmailJogadores.TabIndex = 2;
            this.lblEmailJogadores.Text = "E-mail:";
            // 
            // lblFoneJogadores
            // 
            this.lblFoneJogadores.AutoSize = true;
            this.lblFoneJogadores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFoneJogadores.Location = new System.Drawing.Point(41, 180);
            this.lblFoneJogadores.Name = "lblFoneJogadores";
            this.lblFoneJogadores.Size = new System.Drawing.Size(47, 21);
            this.lblFoneJogadores.TabIndex = 3;
            this.lblFoneJogadores.Text = "Fone:";
            // 
            // tbxNomeJogadores
            // 
            this.tbxNomeJogadores.Location = new System.Drawing.Point(41, 92);
            this.tbxNomeJogadores.Name = "tbxNomeJogadores";
            this.tbxNomeJogadores.Size = new System.Drawing.Size(216, 23);
            this.tbxNomeJogadores.TabIndex = 4;
            // 
            // tbxEmailJogadores
            // 
            this.tbxEmailJogadores.Location = new System.Drawing.Point(41, 150);
            this.tbxEmailJogadores.Name = "tbxEmailJogadores";
            this.tbxEmailJogadores.Size = new System.Drawing.Size(216, 23);
            this.tbxEmailJogadores.TabIndex = 5;
            // 
            // tbxFoneJogadores
            // 
            this.tbxFoneJogadores.Location = new System.Drawing.Point(41, 208);
            this.tbxFoneJogadores.Name = "tbxFoneJogadores";
            this.tbxFoneJogadores.Size = new System.Drawing.Size(216, 23);
            this.tbxFoneJogadores.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(108, 238);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 363);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxFoneJogadores);
            this.Controls.Add(this.tbxEmailJogadores);
            this.Controls.Add(this.tbxNomeJogadores);
            this.Controls.Add(this.lblFoneJogadores);
            this.Controls.Add(this.lblEmailJogadores);
            this.Controls.Add(this.lblNomeJogadores);
            this.Controls.Add(this.lblTituloJogadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastrarJogadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloJogadores;
        private System.Windows.Forms.Label lblNomeJogadores;
        private System.Windows.Forms.Label lblEmailJogadores;
        private System.Windows.Forms.Label lblFoneJogadores;
        private System.Windows.Forms.TextBox tbxNomeJogadores;
        private System.Windows.Forms.TextBox tbxEmailJogadores;
        private System.Windows.Forms.TextBox tbxFoneJogadores;
        private System.Windows.Forms.Button btnCadastrar;
    }
}