using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TonyTI_Login.Integracao
{
    public class OpenAiService : IDisposable
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        // Use "gpt-3.5-turbo" ou outro modelo disponível para sua conta
        private const string MODEL = "gpt-3.5-turbo";
        private const string URL = "https://api.openai.com/v1/chat/completions";

        public OpenAiService(string apiKey, HttpClient client = null)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _http = client ?? new HttpClient();
            _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
            _http.Timeout = TimeSpan.FromSeconds(60);
        }

        public async Task<string> GetChatResponseAsync(string userMessage, IEnumerable<(string role, string content)> conversation = null)
        {
            if (string.IsNullOrWhiteSpace(userMessage))
                throw new ArgumentException("userMessage é obrigatório", nameof(userMessage));

            // build messages: system prompt + conversation history + user message
            var messages = new List<object>();

            // system prompt (define comportamento do assistente)
            messages.Add(new { role = "system", content = "Você é um assistente de suporte técnico que responde de forma clara e objetiva. Responda apenas perguntas técnicas." });

            if (conversation != null)
            {
                foreach (var tuple in conversation)
                {
                    // Evita desestruturação para compatibilidade máxima
                    messages.Add(new { role = tuple.role, content = tuple.content });
                }
            }

            messages.Add(new { role = "user", content = userMessage });

            var payload = new
            {
                model = MODEL,
                messages = messages,
                max_tokens = 800,
                temperature = 0.2,
                n = 1
            };

            var json = JsonSerializer.Serialize(payload);
            var contentPayload = new StringContent(json, Encoding.UTF8, "application/json");

            // Compatível com C# 7.3: usar bloco using tradicional
            using (var resp = await _http.PostAsync(URL, contentPayload).ConfigureAwait(false))
            {
                var respStr = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (!resp.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro OpenAI ({(int)resp.StatusCode}): {respStr}");
                }

                using (JsonDocument doc = JsonDocument.Parse(respStr))
                {
                    if (doc.RootElement.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
                    {
                        var messageElement = choices[0].GetProperty("message");
                        if (messageElement.TryGetProperty("content", out var contentElement))
                        {
                            var message = contentElement.GetString();
                            return message?.Trim() ?? string.Empty;
                        }
                    }
                }

                throw new Exception("Resposta inesperada da API OpenAI.");
            }
        }

        public void Dispose()
        {
            _http?.Dispose();
        }
    }
}
