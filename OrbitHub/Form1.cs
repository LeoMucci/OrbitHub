using System.Data.SQLite;

namespace OrbitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            VerificarDadosTabelaEstrelas();
            InitializeComponent();
            CriarBancoEDBSeNaoExistir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void VerificarDadosTabelaEstrelas()
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Estrelas";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        MessageBox.Show("Número de registros na tabela Estrelas: " + count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao contar registros: " + ex.Message);
                }
            }
        }

        private void CriarBancoEDBSeNaoExistir()
        {
            // Defina a string de conexão, pode usar caminho absoluto para garantir a criação
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                // Query para criar a tabela se não existir
                string query = @"CREATE TABLE IF NOT EXISTS Estrelas (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome TEXT,
                            TipoEspectral TEXT,
                            ClasseLuminosidade TEXT,
                            Magnitude REAL,
                            Distancia REAL,
                            Temperatura INTEGER,
                            Idade REAL,
                            EstadoEvolutivo TEXT,
                            Metallicidade TEXT);";

                try
                {
                    con.Open(); // Abrir a conexão (isso criará o arquivo se ele não existir)
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.ExecuteNonQuery(); // Executa a query para criar a tabela
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar o banco de dados: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Fechar a conexão
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void VerEstrelas_Click(object sender, EventArgs e)
        {
            FormVisualizacao formVisualizacao = new FormVisualizacao();
            formVisualizacao.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
