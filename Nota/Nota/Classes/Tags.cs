using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;//подключение библиотеки для работы с тегами аудио

namespace Nota.Classes
{
    //теги аудиофайла
    class Tags
    {
        public int Bitrate;
        public int Freq;
        public string Channels;
        public string Album;
        public string Artists;
        public string Title;
        public string Year;

        //словарь каналов воспроизведения
        Dictionary<int, string> ChannelsDict = new Dictionary<int, string>()
        {
            {0,"Null" },
            {1,"Mono" },
            {2,"Stereo" }
        };

        //чтение тегов
        public Tags(string file)
        {
            TAG_INFO taginfo = new TAG_INFO();
            taginfo = BassTags.BASS_TAG_GetFromFile(file);
            Bitrate = taginfo.bitrate;
            Freq = taginfo.channelinfo.freq;
            Channels = ChannelsDict[taginfo.channelinfo.chans];
            Artists = taginfo.artist;
            Album = taginfo.album;
            if (taginfo.title == "")
                Title = Vars.GetFileName(file);
            else
                Title = taginfo.title;
            Year = taginfo.year;
        }
    }
}
