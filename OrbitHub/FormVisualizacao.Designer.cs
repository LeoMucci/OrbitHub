namespace OrbitHub
{
    partial class FormVisualizacao
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
            components = new System.ComponentModel.Container();
            dataGridViewEstrelas = new DataGridView();
            formCadastroBindingSource = new BindingSource(components);
            btnEditar = new Button();
            btnDeletar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstrelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formCadastroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEstrelas
            // 
            dataGridViewEstrelas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstrelas.Location = new Point(12, 12);
            dataGridViewEstrelas.Name = "dataGridViewEstrelas";
            dataGridViewEstrelas.ReadOnly = true;
            dataGridViewEstrelas.Size = new Size(900, 567);
            dataGridViewEstrelas.TabIndex = 0;
            dataGridViewEstrelas.CellContentClick += dataGridViewEstrelas_CellContentClick;
            // 
            // formCadastroBindingSource
            // 
            formCadastroBindingSource.DataSource = typeof(FormCadastro);
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(12, 614);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(313, 49);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "[ Editar Estrela ]";
            btnEditar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.White;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.ForeColor = SystemColors.ActiveCaptionText;
            btnDeletar.Location = new Point(399, 614);
            btnDeletar.Margin = new Padding(0);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(313, 49);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "[ Deletar Estrela ]";
            btnDeletar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(787, 614);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(125, 49);
            button1.TabIndex = 4;
            button1.Text = "[ Voltar ]";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormVisualizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(922, 672);
            Controls.Add(button1);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridViewEstrelas);
            Name = "FormVisualizacao";
            Text = "FormVisualizacao";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstrelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)formCadastroBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEstrelas;
        private BindingSource formCadastroBindingSource;
        private Button btnEditar;
        private Button btnDeletar;
        private Button button1;
    }
}