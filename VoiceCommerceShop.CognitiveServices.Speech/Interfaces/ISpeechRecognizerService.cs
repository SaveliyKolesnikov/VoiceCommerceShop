namespace VoiceCommerceShop.CognitiveServices.Speech;

public interface ISpeechRecognizerService
{
    Task<string> RecognizeFromBinaryStream(BinaryReader reader);
}