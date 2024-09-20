namespace OrbitHub
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbTipoEspectral = new ComboBox();
            cmbClasseLuminosidade = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            numMagnitude = new NumericUpDown();
            label6 = new Label();
            txtDistancia = new TextBox();
            label7 = new Label();
            numTemperatura = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtIdade = new NumericUpDown();
            label11 = new Label();
            cmbEstadoEvolutivo = new ComboBox();
            label12 = new Label();
            txtMetallicidade = new TextBox();
            CadastarBTN = new Button();
            CancelarBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIdade).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(180, 47);
            label1.Name = "label1";
            label1.Size = new Size(477, 39);
            label1.TabIndex = 1;
            label1.Text = "- Cadastro de Estrela -";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(257, 144);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(293, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 5;
            label3.Text = "Tipo Espectral:";
            // 
            // cmbTipoEspectral
            // 
            cmbTipoEspectral.ForeColor = SystemColors.InactiveCaptionText;
            cmbTipoEspectral.FormattingEnabled = true;
            cmbTipoEspectral.Items.AddRange(new object[] { "O - Azul ", "B - Azul Branca", "A - Branca", "F - Amarelo Branca", "G - Amarela", "K - Laranja", "M - Vermelha" });
            cmbTipoEspectral.Location = new Point(257, 188);
            cmbTipoEspectral.Name = "cmbTipoEspectral";
            cmbTipoEspectral.Size = new Size(293, 23);
            cmbTipoEspectral.TabIndex = 6;
            // 
            // cmbClasseLuminosidade
            // 
            cmbClasseLuminosidade.ForeColor = SystemColors.InactiveCaptionText;
            cmbClasseLuminosidade.FormattingEnabled = true;
            cmbClasseLuminosidade.Items.AddRange(new object[] { "I - Supergigante", "II - Gigante Brilhante", "III - Gigante", "IV - Subgigante", "V - Sequência Principal", "VI - Subanã", "VII - Anã Branca" });
            cmbClasseLuminosidade.Location = new Point(257, 234);
            cmbClasseLuminosidade.Name = "cmbClasseLuminosidade";
            cmbClasseLuminosidade.Size = new Size(293, 23);
            cmbClasseLuminosidade.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(239, 19);
            label4.TabIndex = 7;
            label4.Text = "Classe de Luminosidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSlateGray;
            label5.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 283);
            label5.Name = "label5";
            label5.Size = new Size(199, 19);
            label5.TabIndex = 10;
            label5.Text = "Magnitude Absoluta:";
            // 
            // numMagnitude
            // 
            numMagnitude.Location = new Point(257, 279);
            numMagnitude.Name = "numMagnitude";
            numMagnitude.Size = new Size(293, 23);
            numMagnitude.TabIndex = 11;
            numMagnitude.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateGray;
            label6.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 323);
            label6.Name = "label6";
            label6.Size = new Size(199, 19);
            label6.TabIndex = 13;
            label6.Text = "Distância da Terra:";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(257, 323);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(293, 23);
            txtDistancia.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateGray;
            label7.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(12, 372);
            label7.Name = "label7";
            label7.Size = new Size(242, 18);
            label7.TabIndex = 15;
            label7.Text = "Temperatura da Superfície:";
            // 
            // numTemperatura
            // 
            numTemperatura.Location = new Point(260, 368);
            numTemperatura.Name = "numTemperatura";
            numTemperatura.Size = new Size(132, 23);
            numTemperatura.TabIndex = 14;
            numTemperatura.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSlateGray;
            label8.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(398, 377);
            label8.Name = "label8";
            label8.Size = new Size(84, 14);
            label8.TabIndex = 16;
            label8.Text = "(Em kelvin)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkSlateGray;
            label9.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(739, 394);
            label9.Name = "label9";
            label9.Size = new Size(91, 14);
            label9.TabIndex = 19;
            label9.Text = "(Em Bilhões)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkSlateGray;
            label10.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(507, 371);
            label10.Name = "label10";
            label10.Size = new Size(179, 19);
            label10.TabIndex = 18;
            label10.Text = "Idade da Estrela:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(692, 368);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(112, 23);
            txtIdade.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkSlateGray;
            label11.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(12, 419);
            label11.Name = "label11";
            label11.Size = new Size(179, 19);
            label11.TabIndex = 20;
            label11.Text = "Estado Evolutivo:";
            // 
            // cmbEstadoEvolutivo
            // 
            cmbEstadoEvolutivo.ForeColor = SystemColors.InactiveCaptionText;
            cmbEstadoEvolutivo.FormattingEnabled = true;
            cmbEstadoEvolutivo.Items.AddRange(new object[] { "Nebulosa Protostelar", "Sequência Principal", "Gigante Vermelha", "Anã Branca", "Estrela de Nêutrons", "Buraco Negro" });
            cmbEstadoEvolutivo.Location = new Point(260, 415);
            cmbEstadoEvolutivo.Name = "cmbEstadoEvolutivo";
            cmbEstadoEvolutivo.Size = new Size(195, 23);
            cmbEstadoEvolutivo.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkSlateGray;
            label12.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(508, 423);
            label12.Name = "label12";
            label12.Size = new Size(149, 19);
            label12.TabIndex = 22;
            label12.Text = "Metallicidade:";
            // 
            // txtMetallicidade
            // 
            txtMetallicidade.Location = new Point(692, 419);
            txtMetallicidade.Name = "txtMetallicidade";
            txtMetallicidade.Size = new Size(112, 23);
            txtMetallicidade.TabIndex = 23;
            // 
            // CadastarBTN
            // 
            CadastarBTN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CadastarBTN.ForeColor = SystemColors.ActiveCaptionText;
            CadastarBTN.Location = new Point(124, 481);
            CadastarBTN.Name = "CadastarBTN";
            CadastarBTN.Size = new Size(230, 53);
            CadastarBTN.TabIndex = 24;
            CadastarBTN.Text = "[ Cadastrar Estrela ]";
            CadastarBTN.UseVisualStyleBackColor = true;
            CadastarBTN.Click += CadastarBTN_Click;
            // 
            // CancelarBTN
            // 
            CancelarBTN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarBTN.ForeColor = SystemColors.ActiveCaptionText;
            CancelarBTN.Location = new Point(508, 481);
            CancelarBTN.Name = "CancelarBTN";
            CancelarBTN.Size = new Size(230, 53);
            CancelarBTN.TabIndex = 25;
            CancelarBTN.Text = "[ Cancelar ]";
            CancelarBTN.UseVisualStyleBackColor = true;
            CancelarBTN.Click += CancelarBTN_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(849, 561);
            Controls.Add(CancelarBTN);
            Controls.Add(CadastarBTN);
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
            Name = "FormCadastro";
            Text = "FormCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMagnitude).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoEspectral;
        private ComboBox cmbClasseLuminosidade;
        private Label label4;
        private Label label5;
        private NumericUpDown numMagnitude;
        private Label label6;
        private TextBox txtDistancia;
        private Label label7;
        private NumericUpDown numTemperatura;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown txtIdade;
        private Label label11;
        private ComboBox cmbEstadoEvolutivo;
        private Label label12;
        private TextBox txtMetallicidade;
        private Button CadastarBTN;
        private Button CancelarBTN;
    }
}