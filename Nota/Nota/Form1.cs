using Nota.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nota
{
    public partial class Nota : Form
    {
        public Nota()
        {
            InitializeComponent();
            //инициализация библиотеки
            BASS.InitBass(BASS.HZ);
        }

        //действия при нажатии кнопки "добавить"
        private void add_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        //добавление файлов в плейлист
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for(int i=0; i<tmp.Length;i++)
            {
                Vars.Files.Add(tmp[i]);
                Tags TM = new Tags(tmp[i]);
                Songs.Items.Add(TM.Artists + "-" + TM.Title);
            }
           
        }

        //действия при нажатии кнопки проигрывания
        private void play_Click_1(object sender, EventArgs e)
        {
            if ((Songs.Items.Count != 0) && (Songs.SelectedIndex != -1))
            {
                string current = Vars.Files[Songs.SelectedIndex];
                Vars.CurrentTrackNumber = Songs.SelectedIndex;
                BASS.Play(current, BASS.Volume);
                label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BASS.GetTimeOfStream(BASS.Stream)).ToString();
                colorSlider2.Maximum = BASS.GetTimeOfStream(BASS.Stream);
                colorSlider2.Value = BASS.GetPosOfStream(BASS.Stream);
                timer1.Enabled = true;
            }
        }

        //действия при нажатии кнопки остановки проигрывания
        private void stop_Click_1(object sender, EventArgs e)
        {
            BASS.Stop();
            timer1.Enabled = false;
            colorSlider2.Value = 0;
            label1.Text = "00:00:00";
        }

        //действия на каждую секунду таймера
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
            colorSlider2.Value = BASS.GetPosOfStream(BASS.Stream);
            //автоматическое переключение треков при окончании предыдущего
            if(BASS.ToNextTrack())
            {
                Songs.SelectedIndex = Vars.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BASS.GetTimeOfStream(BASS.Stream)).ToString();

            }
            if(BASS.EndPlaylist)
            {
                stop_Click_1(this, new EventArgs());
                Songs.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BASS.EndPlaylist = false;
            }
        }

        //действия при изменении выбранного трека
        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Songs.Items.Count != 0) && (Songs.SelectedIndex != -1))
            {
                string current = Vars.Files[Songs.SelectedIndex];
                Vars.CurrentTrackNumber = Songs.SelectedIndex;
                BASS.Play(current, BASS.Volume);
                label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BASS.GetTimeOfStream(BASS.Stream)).ToString();
                colorSlider2.Maximum = BASS.GetTimeOfStream(BASS.Stream);
                colorSlider2.Value = BASS.GetPosOfStream(BASS.Stream);
                timer1.Enabled = true;
            }
        }

        //действия принажатии кнопки паузы
        private void pause_Click(object sender, EventArgs e)
        {
            BASS.Pause();
        }

        //контроллер звука
        private void colorSlider4_Scroll(object sender, ScrollEventArgs e)
        {
            BASS.SetVolumeToStream(BASS.Stream, (int)colorSlider4.Value);
        }

        //контроллер проигрывания трека
        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            BASS.SetPos(BASS.Stream, (int)colorSlider2.Value);
        }

        //действия при переключении на предыдущий трек
        private void prew_Click(object sender, EventArgs e)
        {
            if (BASS.ToPrewTrackClick())
            {
                Songs.SelectedIndex = Vars.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BASS.GetTimeOfStream(BASS.Stream)).ToString();

            }
            if (BASS.EndPlaylist)
            {
                stop_Click_1(this, new EventArgs());

                Songs.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BASS.EndPlaylist = false;
            }
        }

        //действия при переключении на следующий трек
        private void next_Click(object sender, EventArgs e)
        {
            if (BASS.ToNextTrackClick())
            {
                Songs.SelectedIndex = Vars.CurrentTrackNumber;
                label1.Text = TimeSpan.FromSeconds(BASS.GetPosOfStream(BASS.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BASS.GetTimeOfStream(BASS.Stream)).ToString();

            }
            if (BASS.EndPlaylist)
            {
                stop_Click_1(this, new EventArgs());
                Songs.SelectedIndex = Vars.CurrentTrackNumber = 0;
                BASS.EndPlaylist = false;
            }
        }

        //вызов справки
        private void question_Click(object sender, EventArgs e)
        {
           Help.ShowHelp(this, @"Справка.docx", HelpNavigator.TableOfContents);
        }
    }
}
