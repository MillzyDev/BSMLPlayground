using System;
using System.IO;

namespace BSMLPlayground
{
    public static class Playground
    {
        private static string s_playgroundBSML;

        public static string PlaygroundBSML
        {
            get
            {
                if (string.IsNullOrEmpty(s_playgroundBSML))
                    s_playgroundBSML = Path.Combine(Environment.CurrentDirectory, "Playground.bsml");
                return s_playgroundBSML;
            }
        }
    }
}
