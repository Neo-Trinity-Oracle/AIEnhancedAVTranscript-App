using System.Text.Json.Serialization;

namespace AIEnhancedAVTranscript.API.Models
{
    public class OpenAiResponse
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
