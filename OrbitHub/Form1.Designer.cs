namespace OrbitHub
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
            CadastroEstrela = new Button();
            label = new Label();
            VerEstrelas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // CadastroEstrela
            // 
            CadastroEstrela.BackColor = Color.White;
            CadastroEstrela.FlatAppearance.BorderSize = 0;
            CadastroEstrela.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CadastroEstrela.ForeColor = SystemColors.ActiveCaptionText;
            CadastroEstrela.Location = new Point(231, 226);
            CadastroEstrela.Margin = new Padding(0);
            CadastroEstrela.Name = "CadastroEstrela";
            CadastroEstrela.Size = new Size(410, 69);
            CadastroEstrela.TabIndex = 0;
            CadastroEstrela.Text = "[ Cadastrar Estrela ]";
            CadastroEstrela.TextImageRelation = TextImageRelation.TextBeforeImage;
            CadastroEstrela.UseVisualStyleBackColor = false;
            CadastroEstrela.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(171, 101);
            label.Name = "label";
            label.Size = new Size(517, 78);
            label.TabIndex = 1;
            label.Text = "- OrbitHub -\nCategorização de Estrelas";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VerEstrelas
            // 
            VerEstrelas.BackColor = Color.White;
            VerEstrelas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VerEstrelas.ForeColor = SystemColors.ActiveCaptionText;
            VerEstrelas.Location = new Point(231, 352);
            VerEstrelas.Name = "VerEstrelas";
            VerEstrelas.Size = new Size(410, 68);
            VerEstrelas.TabIndex = 2;
            VerEstrelas.Text = "[ Ver Estrelas Catalogadas ] ";
            VerEstrelas.UseVisualStyleBackColor = false;
            VerEstrelas.Click += VerEstrelas_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 474);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 3;
            button1.Text = "[ Fechar ]";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(851, 531);
            Controls.Add(button1);
            Controls.Add(VerEstrelas);
            Controls.Add(label);
            Controls.Add(CadastroEstrela);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CadastroEstrela;
        private Label label;
        private Button VerEstrelas;
        private Button button1;
    }
}
