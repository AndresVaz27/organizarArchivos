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
using Vlc.DotNet.Forms;

namespace organizarArchivos
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd;
        FolderBrowserDialog fbd;
        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            fbd = new FolderBrowserDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string path;
            path = ofd.FileName;
            vlcControl1.Play(new Uri(path));
            btnPlayPause.Text = "Pause"; 
            txtLyrics.Visible = false;
            if(path == @"C:\Users\andre\Music\Grupo Frontera x Bad Bunny - un x100to (Video Oficial).mp3" | path == @"E:\Audios\Grupo Frontera x Bad Bunny - un x100to (Video Oficial).mp3" | path == @"E:\Grupo Frontera x Bad Bunny - un x100to (Video Oficial).mp3")
            {
                txtLyrics.Visible = true;
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if(btnPlayPause.Text == "Pause")
            {
                vlcControl1.Pause();
                btnPlayPause.Text = "Play";
            }
            else if(btnPlayPause.Text == "Play")
            {
                vlcControl1.Play();
                btnPlayPause.Text = "Pause";
            }
        }

        

        private void btnOrganize_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(fbd.SelectedPath);
                foreach (string archivo in archivos)
                {
                    string extension = Path.GetExtension(archivo);
                    string nombreArchivo = Path.GetFileName(archivo);
                    string rutaDestino = "";
                    switch (extension)
                    {
                        case ".jpg":
                        case ".png":
                        case ".bmp":
                            rutaDestino = Path.Combine(fbd.SelectedPath, "Imágenes");
                            break;
                        case ".mp4":
                        case ".avi":
                        case ".mov":
                            rutaDestino = Path.Combine(fbd.SelectedPath, "Videos");
                            break;
                        case ".mp3":
                        case ".wav":
                        case ".aac":
                        case ".opus":
                            rutaDestino = Path.Combine(fbd.SelectedPath, "Audios");
                            break;
                        default:
                            rutaDestino = Path.Combine(fbd.SelectedPath, "Otros");
                            break;
                    }
                    if (!Directory.Exists(rutaDestino))
                    {
                        Directory.CreateDirectory(rutaDestino);
                    }
                    string rutaArchivoDestino = Path.Combine(rutaDestino, nombreArchivo);
                    File.Move(archivo, rutaArchivoDestino);
                }
                MessageBox.Show("Archivos organizados correctamente");
                
            }
        }
    }
}
