using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Build_Music_Player_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusicSongs.URL = paths[lbSong.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Create GLobal Variables of string type array to save the title
        String[] paths, files;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            
            // Code to seclect songs
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Save tthe names of the track in files 
                paths = ofd.FileNames; // Save the paths of the tracks in path array
                
                //Display the music titles in listbox

                for (int i = 0; i <  files.Length; i++)
                {
                    lbSong.Items.Add(files[i]); // Display songs in listbox
                }

            }
        }

        private void lbSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
