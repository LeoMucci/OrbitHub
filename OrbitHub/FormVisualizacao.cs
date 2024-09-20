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
    public partial class FormVisualizacao : Form
    {
        public FormVisualizacao()
        {
            InitializeComponent();
            CarregarEstrelas();
        }

        private void FormVisualizacao_Load(object sender, EventArgs e)
        {
            CarregarEstrelas();  // Carrega os dados quando o formulário for carregado
        }

        public void CarregarEstrelas()
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Estrelas";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        con.Open();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Verifica se há dados
                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewEstrelas.DataSource = dt;

                            dataGridViewEstrelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajusta ao conteúdo



                            // Definir como somente leitura
                            dataGridViewEstrelas.ReadOnly = true;

                            // Ocultar a coluna de ID
                            dataGridViewEstrelas.Columns["Id"].Visible = false;

                            // Atualiza a interface
                            dataGridViewEstrelas.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado foi encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }




        private void dataGridViewEstrelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar se a célula clicada é válida (não cabeçalho)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewEstrelas.Rows[e.RowIndex];
                    // Exibir os detalhes da estrela, por exemplo:
                    string nome = row.Cells["Nome"].Value.ToString();
                    MessageBox.Show("Estrela selecionada: " + nome);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao clicar na célula: " + ex.Message);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dataGridViewEstrelas.SelectedRows.Count > 0)
            {
                // Obtém os valores da linha selecionada
                DataGridViewRow row = dataGridViewEstrelas.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["Id"].Value); // Supondo que "Id" é o nome da coluna no DataTable
                string nome = row.Cells["Nome"].Value.ToString();
                string tipoEspectral = row.Cells["TipoEspectral"].Value.ToString();
                string classeLuminosidade = row.Cells["ClasseLuminosidade"].Value.ToString();
                decimal magnitude = Convert.ToDecimal(row.Cells["Magnitude"].Value);
                float distancia = Convert.ToSingle(row.Cells["Distancia"].Value);
                int temperatura = Convert.ToInt32(row.Cells["Temperatura"].Value);
                decimal idade = Convert.ToDecimal(row.Cells["Idade"].Value);
                string estadoEvolutivo = row.Cells["EstadoEvolutivo"].Value.ToString();
                string metallicidade = row.Cells["Metallicidade"].Value.ToString();

                // Abre o formulário de edição passando os valores
                FormEdicao formEdicao = new FormEdicao(id, nome, tipoEspectral, classeLuminosidade, magnitude, distancia, temperatura, idade, estadoEvolutivo, metallicidade);
                formEdicao.ShowDialog();

                // Recarrega os dados após a edição
                CarregarEstrelas();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para editar.");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dataGridViewEstrelas.SelectedRows.Count > 0)
            {
                // Pergunta ao usuário se ele tem certeza que deseja deletar
                var confirmResult = MessageBox.Show("Você tem certeza que deseja deletar esta estrela?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Obtém o ID da estrela
                    DataGridViewRow row = dataGridViewEstrelas.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["Id"].Value);

                    // Chama o método para deletar a estrela
                    DeletarEstrela(id);

                    // Recarrega os dados após a exclusão
                    CarregarEstrelas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para deletar.");
            }
        }

        private void DeletarEstrela(int id)
        {
            string connectionString = "Data Source=estrelas.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string query = "DELETE FROM Estrelas WHERE Id = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
