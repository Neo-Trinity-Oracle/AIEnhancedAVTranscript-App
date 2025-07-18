namespace AIEnhancedAVTranscript.API.Services
{
    public interface IWhisperService
    {
        Task<string> TranscribeAudioAsync(string filePath);
    }
}
