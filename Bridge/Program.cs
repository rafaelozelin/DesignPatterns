using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    internal class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            var live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            var live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Comments();
            live.Subtitle();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLiveAdvanced(new YouTube());
            StartLiveAdvanced(new DLive());
            StartLive(new TwitchTV());
            StartLive(new Facebook());

            Console.ReadLine();
        }
    }
}
