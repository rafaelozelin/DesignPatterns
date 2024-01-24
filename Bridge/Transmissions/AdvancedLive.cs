using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform)
        {
        }

        public void Subtitle()
        {
            Console.WriteLine("Legendas ativadas");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados");
        }

        public void Record()
        {
            Console.WriteLine("Gravação iniciada!");
        }
    }
}
