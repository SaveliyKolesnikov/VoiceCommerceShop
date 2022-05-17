using Microsoft.CognitiveServices.Speech;
using VoiceCommerceShop.Shared;

namespace VoiceCommerceShop.CognitiveServices.Speech;

public class SpeechRecognizerService : ISpeechRecognizerService
{
    private readonly SpeechServiceSettings settings;

    public SpeechRecognizerService(SpeechServiceSettings settings)
    {
        this.settings = settings;
    }

    public async Task<string> RecognizeFromBinaryStream(BinaryReader reader)
    {
        var config = SpeechConfig.FromSubscription(settings.SubscriptionKey, settings.ServiceRegion);

        // Create an audio stream from a wav file.
        // Replace with your own audio file name.
        using var audioInput = Helper.OpenWavFile(reader);

        // Creates a speech recognizer using audio stream input.
        using var recognizer = new SpeechRecognizer(config, audioInput);
        
        var res = await recognizer.RecognizeOnceAsync();
        return res.Text;
    }
}