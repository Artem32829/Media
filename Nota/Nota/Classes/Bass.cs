using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass; //подключение библиотеки для работы с аудио

namespace Nota.Classes
{
    public static class BASS
    {
        //путь к исполняемому файлу
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        //частота дискретизации
        public static int HZ = 44100;
        //состояние инициализации
        public static bool InitDefaultDevice;
        //Канал
        public static int Stream;
        //громкость
        public static int Volume = 100;
        //канал остановлен вручную
        private static bool isStoped = true;
        //плейлист доигран полностью
        public static bool EndPlaylist;

        private static readonly List<int> BassPluginsHandles = new List<int>();

        //инициализация bass.dll
        public static bool InitBass(int HZ)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, HZ, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if(InitDefaultDevice)
                {
                    //плагины для воспроизведения различных форматов аудиофайлов
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\basscd.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(AppPath + @"plugins\basswv.dll"));

                    int ErrorCount = 0;
                    for(int i=0; i<BassPluginsHandles.Count; i++)
                    {
                        if(BassPluginsHandles[i]==0)
                        {
                            ErrorCount++;
                        }
                    }
                    if (ErrorCount != 0)
                    {
                        MessageBox.Show(ErrorCount + " плагин(а) не было загружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ErrorCount = 0;
                    }

                }
            }
            return InitDefaultDevice;
        }

        //воспроизведение
        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(HZ))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
            isStoped = false;
        }
        //Стоп
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
        }

        //пауза
        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
        }

        //установка громкости
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        //длительность трека в секундах
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }

        //позиция проигрывания
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        //установка позиции проигрываия
        public static void SetPos(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, ((double)pos));
        }
        //автоматическое переключение на следующий трек
        public static bool ToNextTrack()
        {
            if((Bass.BASS_ChannelIsActive(Stream)==BASSActive.BASS_ACTIVE_STOPPED)&&(!isStoped))
            {
                if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
                {
                    Play(Vars.Files[++Vars.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            }
            return false;
        }
        //переключение на предыдущий трек
        public static bool ToPrewTrackClick()
        {
                if (Vars.CurrentTrackNumber - 1 > -1)
                {
                    Play(Vars.Files[--Vars.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            return false;
        }
        //переключение на следующий трек
        public static bool ToNextTrackClick()
        {
                if (Vars.Files.Count > Vars.CurrentTrackNumber + 1)
                {
                    Play(Vars.Files[++Vars.CurrentTrackNumber], Volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            return false;
        }
    }
}

