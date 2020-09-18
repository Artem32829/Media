using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota.Classes
{
    public static class Vars
    {
        //список полных имён файлов
        public static List<string> Files = new List<string>();
        //текущая позиция в плейлисте
        public static int CurrentTrackNumber;
        //только имя файла
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
    }
}
