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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void CriarTabelaSeNaoExistir()
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string query = "CREATE TABLE IF NOT EXISTS Estrelas (" +
                               "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                               "Nome TEXT," +
                               "TipoEspectral TEXT," +
                               "ClasseLuminosidade TEXT," +
                               "Magnitude REAL," +
                               "Distancia REAL," +
                               "Temperatura INTEGER," +
                               "Idade REAL," +
                               "EstadoEvolutivo TEXT," +
                               "Metallicidade TEXT);";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cmbTipoEspectral.SelectedIndex = -1; // Limpar o ComboBox
            cmbClasseLuminosidade.SelectedIndex = -1;
            numMagnitude.Value = 0;
            txtDistancia.Clear();
            numTemperatura.Value = 0;
            txtIdade.Value = 0;
            cmbEstadoEvolutivo.SelectedIndex = -1;
            txtMetallicidade.Clear();
        }
        private void InserirEstrela(string nome, string tipoEspectral, string classeLuminosidade, decimal magnitude, float distancia, int temperatura, decimal idade, string estadoEvolutivo, string metallicidade)
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Estrelas (Nome, TipoEspectral, ClasseLuminosidade, Magnitude, Distancia, Temperatura, Idade, EstadoEvolutivo, Metallicidade) " +
                               "VALUES (@Nome, @TipoEspectral, @ClasseLuminosidade, @Magnitude, @Distancia, @Temperatura, @Idade, @EstadoEvolutivo, @Metallicidade)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
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



        private void CadastarBTN_Click(object sender, EventArgs e)
        {
            if (txtNome == null || cmbTipoEspectral == null || cmbClasseLuminosidade == null || numMagnitude == null || txtDistancia == null ||
       numTemperatura == null || txtIdade == null || cmbEstadoEvolutivo == null || txtMetallicidade == null)
            {
                MessageBox.Show("Erro: Um ou mais campos estão nulos.");
                return;
            }

            // Capture os valores dos campos
            string nome = txtNome.Text;
            string tipoEspectral = cmbTipoEspectral.SelectedItem?.ToString() ?? string.Empty;
            string classeLuminosidade = cmbClasseLuminosidade.SelectedItem?.ToString() ?? string.Empty;
            decimal magnitude = numMagnitude.Value;
            float distancia = float.Parse(txtDistancia.Text);
            int temperatura = (int)numTemperatura.Value;
            decimal idade = decimal.Parse(txtIdade.Text);
            string estadoEvolutivo = cmbEstadoEvolutivo.SelectedItem?.ToString() ?? string.Empty;
            string metallicidade = txtMetallicidade.Text;

            // Chamar o método para inserir no banco de dados
            InserirEstrela(nome, tipoEspectral, classeLuminosidade, magnitude, distancia, temperatura, idade, estadoEvolutivo, metallicidade);

            MessageBox.Show("Estrela cadastrada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar os campos após salvar
            LimparCampos();
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
