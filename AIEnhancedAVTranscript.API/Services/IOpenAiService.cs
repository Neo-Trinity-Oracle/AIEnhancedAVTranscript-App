﻿namespace AIEnhancedAVTranscript.API.Services
{
    public interface IOpenAiService
    {
        Task<string> GenerateFormattedContentAsync(string input, string outputType);
    }
}
