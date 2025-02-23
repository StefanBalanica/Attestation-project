using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Settings
    {
        public static int width { get; set; }
        public static int height { get; set; }
        public static string directie;

        public Settings()
        {
            width = 30;
            height = 30;
            directie ="st";
        }
    }
}
