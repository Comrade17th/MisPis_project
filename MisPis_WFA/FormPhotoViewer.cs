using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MisPis_WFA
{
    public partial class FormPhotoViewer : Form
    {
        
        string photoDir = @"..\..\materials\";
        string[] files;
        int curr = 0;
        public FormPhotoViewer(string photoDir)
        {
            InitializeComponent();
            this.photoDir += photoDir;
        }

        private void FormPhotoViewer_Load(object sender, EventArgs e)
        {
            LoadFiles();
            if(files != null)
                pictureBox1.Image = Image.FromFile(files[0]);
        }



        private string GetInfo()
        {
            string result = "";
            foreach (var s in files)
                result += $"{s}\n";
            return result;
        }

        private void LoadFiles()
        {
            this.files = getFiles();
        }

        private string[] getFiles()
        {
            string[] files = null;
            if (Directory.Exists(photoDir))
            {
                //MessageBox.Show("Exist");
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(photoDir);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                files = Directory.GetFiles(photoDir);
            }
            return files;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (curr - 1 < 0)
                curr = files.Length - 1;
            else
                curr--;
            pictureBox1.Image = Image.FromFile(files[curr]);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (curr + 1 >= files.Length)
                curr = 0;
            else
                curr++;
            pictureBox1.Image = Image.FromFile(files[curr]);
        }
    }
}
