namespace OrbitHub
{
    partial class FormEdicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdicao));
            txtMetallicidade = new TextBox();
            label12 = new Label();
            cmbEstadoEvolutivo = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtIdade = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            numTemperatura = new NumericUpDown();
            label6 = new Label();
            txtDistancia = new TextBox();
            numMagnitude = new NumericUpDown();
            label5 = new Label();
            cmbClasseLuminosidade = new ComboBox();
            label4 = new Label();
            cmbTipoEspectral = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtIdade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMetallicidade
            // 
            txtMetallicidade.Location = new Point(723, 425);
            txtMetallicidade.Name = "txtMetallicidade";
            txtMetallicidade.Size = new Size(112, 23);
            txtMetallicidade.TabIndex = 47;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkSlateGray;
            label12.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(539, 429);
            label12.Name = "label12";
            label12.Size = new Size(149, 19);
            label12.TabIndex = 46;
            label12.Text = "Metallicidade:";
            // 
            // cmbEstadoEvolutivo
            // 
            cmbEstadoEvolutivo.ForeColor = SystemColors.InactiveCaptionText;
            cmbEstadoEvolutivo.FormattingEnabled = true;
            cmbEstadoEvolutivo.Items.AddRange(new object[] { "Nebulosa Protostelar", "Sequência Principal", "Gigante Vermelha", "Anã Branca", "Estrela de Nêutrons", "Buraco Negro" });
            cmbEstadoEvolutivo.Location = new Point(291, 421);
            cmbEstadoEvolutivo.Name = "cmbEstadoEvolutivo";
            cmbEstadoEvolutivo.Size = new Size(195, 23);
            cmbEstadoEvolutivo.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkSlateGray;
            label11.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(43, 425);
            label11.Name = "label11";
            label11.Size = new Size(179, 19);
            label11.TabIndex = 44;
            label11.Text = "Estado Evolutivo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkSlateGray;
            label9.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(770, 400);
            label9.Name = "label9";
            label9.Size = new Size(91, 14);
            label9.TabIndex = 43;
            label9.Text = "(Em Bilhões)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkSlateGray;
            label10.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(538, 377);
            label10.Name = "label10";
            label10.Size = new Size(179, 19);
            label10.TabIndex = 42;
            label10.Text = "Idade da Estrela:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(723, 374);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(112, 23);
            txtIdade.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSlateGray;
            label8.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(429, 383);
            label8.Name = "label8";
            label8.Size = new Size(84, 14);
            label8.TabIndex = 40;
            label8.Text = "(Em kelvin)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateGray;
            label7.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(43, 378);
            label7.Name = "label7";
            label7.Size = new Size(242, 18);
            label7.TabIndex = 39;
            label7.Text = "Temperatura da Superfície:";
            // 
            // numTemperatura
            // 
            numTemperatura.Location = new Point(291, 374);
            numTemperatura.Name = "numTemperatura";
            numTemperatura.Size = new Size(132, 23);
            numTemperatura.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateGray;
            label6.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(43, 329);
            label6.Name = "label6";
            label6.Size = new Size(199, 19);
            label6.TabIndex = 37;
            label6.Text = "Distância da Terra:";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(288, 329);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(293, 23);
            txtDistancia.TabIndex = 36;
            // 
            // numMagnitude
            // 
            numMagnitude.Location = new Point(288, 285);
            numMagnitude.Name = "numMagnitude";
            numMagnitude.Size = new Size(293, 23);
            numMagnitude.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(43, 289);
            label5.Name = "label5";
            label5.Size = new Size(199, 19);
            label5.TabIndex = 34;
            label5.Text = "Magnitude Absoluta:";
            // 
            // cmbClasseLuminosidade
            // 
            cmbClasseLuminosidade.ForeColor = SystemColors.InactiveCaptionText;
            cmbClasseLuminosidade.FormattingEnabled = true;
            cmbClasseLuminosidade.Items.AddRange(new object[] { "I - Supergigante", "II - Gigante Brilhante", "III - Gigante", "IV - Subgigante", "V - Sequência Principal", "VI - Subanã", "VII - Anã Branca" });
            cmbClasseLuminosidade.Location = new Point(288, 240);
            cmbClasseLuminosidade.Name = "cmbClasseLuminosidade";
            cmbClasseLuminosidade.Size = new Size(293, 23);
            cmbClasseLuminosidade.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(43, 240);
            label4.Name = "label4";
            label4.Size = new Size(239, 19);
            label4.TabIndex = 32;
            label4.Text = "Classe de Luminosidade:";
            // 
            // cmbTipoEspectral
            // 
            cmbTipoEspectral.ForeColor = SystemColors.InactiveCaptionText;
            cmbTipoEspectral.FormattingEnabled = true;
            cmbTipoEspectral.Items.AddRange(new object[] { "O - Azul ", "B - Azul Branca", "A - Branca", "F - Amarelo Branca", "G - Amarela", "K - Laranja", "M - Vermelha" });
            cmbTipoEspectral.Location = new Point(288, 194);
            cmbTipoEspectral.Name = "cmbTipoEspectral";
            cmbTipoEspectral.Size = new Size(293, 23);
            cmbTipoEspectral.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(43, 198);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 30;
            label3.Text = "Tipo Espectral:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(43, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 29;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(288, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(293, 23);
            txtNome.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(270, 45);
            label1.Name = "label1";
            label1.Size = new Size(377, 39);
            label1.TabIndex = 27;
            label1.Text = "- Editar Estrela -";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(604, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(102, 479);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(214, 62);
            btnSalvar.TabIndex = 50;
            btnSalvar.Text = "[ Salvar Edição ]";
            btnSalvar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(571, 479);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(214, 62);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "[ Cancelar ]";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEdicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(905, 570);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtMetallicidade);
            Controls.Add(label12);
            Controls.Add(cmbEstadoEvolutivo);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtIdade);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numTemperatura);
            Controls.Add(label6);
            Controls.Add(txtDistancia);
            Controls.Add(numMagnitude);
            Controls.Add(label5);
            Controls.Add(cmbClasseLuminosidade);
            Controls.Add(label4);
            Controls.Add(cmbTipoEspectral);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormEdicao";
            Text = "FormEdicao";
            ((System.ComponentModel.ISupportInitialize)txtIdade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMetallicidade;
        private Label label12;
        private ComboBox cmbEstadoEvolutivo;
        private Label label11;
        private Label label9;
        private Label label10;
        private NumericUpDown txtIdade;
        private Label label8;
        private Label label7;
        private NumericUpDown numTemperatura;
        private Label label6;
        private TextBox txtDistancia;
        private NumericUpDown numMagnitude;
        private Label label5;
        private ComboBox cmbClasseLuminosidade;
        private Label label4;
        private ComboBox cmbTipoEspectral;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}