using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TonyTI_Login.Integracao; // ajuste namespace

namespace TonyTI_Login.Apresentacao
{
    public partial class Ajuda : UserControl
    {
        private readonly OpenAiService _openAiService;

        public Ajuda()
        {
            InitializeComponent();

            // Carregar chave da variável de ambiente (preferível)
            var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            // Se quiser usar appsettings, leia via configuration
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                // para desenvolvimento, você pode colocar fallback (apenas local)
                // apiKey = "COLOQUE_SUA_API_KEY_AQUI";
                MessageBox.Show("OpenAI API key não encontrada. Defina a variável de ambiente OPENAI_API_KEY.", "Configuração ausente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _openAiService = new OpenAiService(apiKey);
        }

        // Lógica real acionando a OpenAI
        private async void btnEnviarPergunta_Click(object sender, EventArgs e)
        {
            string pergunta = txtPergunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pergunta))
            {
                txtResposta.Text = "Por favor, digite sua pergunta.";
                return;
            }

            try
            {
                btnEnviarPergunta.Enabled = false;
                txtResposta.Text = "Respondendo..."; // feedback imediato

                // (Opcional) montar um pequeno histórico local se quiser contexto entre perguntas
                List<(string role, string content)> history = new List<(string role, string content)>();
                // Exemplo: history.Add(("user", "pergunta anterior"));
                // Para começar, não enviamos histórico

                string resposta = await _openAiService.GetChatResponseAsync(pergunta, history);

                // Verificações simples de segurança (filtragem de conteúdo, comprimento etc.)
                if (string.IsNullOrWhiteSpace(resposta))
                    resposta = "Desculpe, não obtivemos resposta. Tente reformular a pergunta.";

                txtResposta.Text = resposta;
            }
            catch (Exception ex)
            {
                // Exibir erro amigável; logar stack se precisar
                txtResposta.Text = "Erro ao consultar o serviço de IA: " + ex.Message;
            }
            finally
            {
                btnEnviarPergunta.Enabled = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _openAiService?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
