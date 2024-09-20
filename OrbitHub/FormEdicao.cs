using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbitHub
{
    public partial class FormEdicao : Form
    {
        private int estrelaId; // Armazena o ID da estrela sendo editada

        // Construtor que recebe os parâmetros da estrela para edição
        public FormEdicao(int id, string nome, string tipoEspectral, string classeLuminosidade, decimal magnitude, float distancia, int temperatura, decimal idade, string estadoEvolutivo, string metallicidade)
        {
            InitializeComponent();

            // Armazena o ID da estrela para atualização
            estrelaId = id;

            // Preenche os campos do formulário com os dados da estrela
            txtNome.Text = nome;
            cmbTipoEspectral.SelectedItem = tipoEspectral;
            cmbClasseLuminosidade.SelectedItem = classeLuminosidade;
            numMagnitude.Value = magnitude;
            txtDistancia.Text = distancia.ToString();
            numTemperatura.Value = temperatura;
            txtIdade.Text = idade.ToString();
            cmbEstadoEvolutivo.SelectedItem = estadoEvolutivo;
            txtMetallicidade.Text = metallicidade;
        }

        // Evento do botão Salvar, onde atualizamos a estrela no banco de dados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Captura os novos valores dos campos
            string nome = txtNome.Text;
            string tipoEspectral = cmbTipoEspectral.SelectedItem.ToString();
            string classeLuminosidade = cmbClasseLuminosidade.SelectedItem.ToString();
            decimal magnitude = numMagnitude.Value;
            float distancia = float.Parse(txtDistancia.Text);
            int temperatura = (int)numTemperatura.Value;
            decimal idade = decimal.Parse(txtIdade.Text);
            string estadoEvolutivo = cmbEstadoEvolutivo.SelectedItem.ToString();
            string metallicidade = txtMetallicidade.Text;

            // Chama o método para atualizar a estrela no banco de dados
            AtualizarEstrela(estrelaId, nome, tipoEspectral, classeLuminosidade, magnitude, distancia, temperatura, idade, estadoEvolutivo, metallicidade);

            MessageBox.Show("Estrela Editada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Fecha o formulário após salvar
        }

        // Método para atualizar a estrela no banco de dados
        private void AtualizarEstrela(int id, string nome, string tipoEspectral, string classeLuminosidade, decimal magnitude, float distancia, int temperatura, decimal idade, string estadoEvolutivo, string metallicidade)
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Estrelas SET Nome = @Nome, TipoEspectral = @TipoEspectral, ClasseLuminosidade = @ClasseLuminosidade, " +
                               "Magnitude = @Magnitude, Distancia = @Distancia, Temperatura = @Temperatura, Idade = @Idade, " +
                               "EstadoEvolutivo = @EstadoEvolutivo, Metallicidade = @Metallicidade WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@TipoEspectral", tipoEspectral);
                    cmd.Parameters.AddWithValue("@ClasseLuminosidade", classeLuminosidade);
                    cmd.Parameters.AddWithValue("@Magnitude", magnitude);
                    cmd.Parameters.AddWithValue("@Distancia", distancia);
                    cmd.Parameters.AddWithValue("@Temperatura", temperatura);
                    cmd.Parameters.AddWithValue("@Idade", idade);
                    cmd.Parameters.AddWithValue("@EstadoEvolutivo", estadoEvolutivo);
                    cmd.Parameters.AddWithValue("@Metallicidade", metallicidade);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
