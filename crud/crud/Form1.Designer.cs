namespace crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(27, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(47, 16);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(23, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(44, 16);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // txtCpf
            // 
            this.txtCpf.AutoSize = true;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(23, 127);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(35, 16);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.Text = "CPF";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(23, 169);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(61, 16);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(23, 210);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(51, 16);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.Text = "Senha";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNome.Location = new System.Drawing.Point(169, 30);
            this.textNome.MaxLength = 100;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(320, 26);
            this.textNome.TabIndex = 1;
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textSenha.Location = new System.Drawing.Point(169, 210);
            this.textSenha.MaxLength = 15;
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(320, 26);
            this.textSenha.TabIndex = 5;
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textUsuario.Location = new System.Drawing.Point(169, 169);
            this.textUsuario.MaxLength = 12;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(320, 26);
            this.textUsuario.TabIndex = 4;
            // 
            // textCpf
            // 
            this.textCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textCpf.Location = new System.Drawing.Point(169, 127);
            this.textCpf.MaxLength = 11;
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(320, 26);
            this.textCpf.TabIndex = 3;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(169, 81);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(320, 26);
            this.textEmail.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(23, 279);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(128, 36);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.Location = new System.Drawing.Point(157, 279);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 36);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "usuario id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(84, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 367);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtNome;
        private Label txtEmail;
        private Label txtCpf;
        private Label txtUsuario;
        private Label txtSenha;
        private Label txtData;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textSenha;
        private TextBox textUsuario;
        private TextBox textCpf;
        private TextBox textEmail;
        private Button btnCadastrar;
        private Button btnPesquisar;
        private Label label1;
        private Label lblId;
        private TextBox textNome;
    }
}