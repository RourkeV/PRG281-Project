using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Linq;

namespace PRG281_Project
{
    public partial class API : Form
    {
        public static readonly HttpClient client = new HttpClient();

        public API()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            await SubmitUserInputAsync();
        }

        private async void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await SubmitUserInputAsync();
            }
        }

        private async Task SubmitUserInputAsync()
        {
            string userInput = textBox.Text.Trim();

            if (lengthValidation(userInput))
            {
                // Simulate right alignment for user input
                richTextBox.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox.AppendText("User: " + userInput + Environment.NewLine);
                textBox.Clear();
                richTextBox.ScrollToCaret();

                // Get the AI response and append it to the RichTextBox
                string aiResponse = await GetAIResponseAsync(userInput);

                // Simulate left alignment for AI response
                richTextBox.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox.AppendText("AI: " + aiResponse + Environment.NewLine);
                richTextBox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Input is invalid. Please try again.");
            }
        }

        private async Task<string> GetAIResponseAsync(string userInput)
        {
            try
            {
                string apiKey = "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";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var payload = new
                {
                    model = "gpt-3.5-turbo-0125",
                    messages = new[]
                    {
                        new { role = "system", content = "You are a dating app assistant." },
                        new { role = "user", content = userInput }
                    },
                    max_tokens = 250,
                    temperature = 0.7,
                    top_p = 0.85
                };

                var content = new StringContent(
                    JsonConvert.SerializeObject(payload),
                    System.Text.Encoding.UTF8,
                    "application/json"
                );

                HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Raw API response: " + result);

                var jsonResponse = JObject.Parse(result);

                if (jsonResponse["choices"] != null &&
                    jsonResponse["choices"].Any() &&
                    jsonResponse["choices"][0]["message"] != null &&
                    jsonResponse["choices"][0]["message"]["content"] != null)
                {
                    var aiResponse = jsonResponse["choices"][0]["message"]["content"].ToString();
                    return aiResponse;
                }
                else
                {
                    return "AI response not available.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return "Error occurred.";
            }
        }

        private bool lengthValidation(string input)
        {
            return input.Length > 0;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
