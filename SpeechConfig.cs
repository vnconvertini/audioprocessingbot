using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

class Program 
{
    async static Task Main(string[] args)
    {
        var speechConfig = SpeechConfig.FromSubscription("<paste-your-speech-key-here>", "<paste-your-speech-location/region-here>");
    }
}
