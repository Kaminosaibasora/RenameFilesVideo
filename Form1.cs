using RenameFilesVideo.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFilesVideo
{
    public partial class Form1 : Form
    {

        private ManageFiles manageFiles;
        private ManageConfig manageConfig;
        public string video_path = "";

        public Form1()
        {
            InitializeComponent();
            // ------------ INIT ENGINE ------------
            manageFiles = new ManageFiles();
            manageConfig = new ManageConfig();

            // ------------ INIT COMPOSANT ------------
            videoReader.DocumentText = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Video Player</title>
                    <style> html {{ background-color : black; color : white; }} </style>
                </head>
                <body style='margin: 0; padding: 0;'>
                    <p>Sélectionnez une vidéo</p>
                </body>
                </html>
            ";
            // https://github.com/adamfisher/Xamarin.Forms.VideoPlayer

            // ------------ LOAD DATA ------------

            LoadData();
            
        }

        private void LoadData()
        {
            if (manageConfig.data != null)
            {
                manageFiles.folder = manageConfig.data.Current.Folder;
                foreach (string file in manageFiles.getFilesNames())
                {
                    listFiles.Items.Add(file);
                }
                manageFiles.file = manageConfig.data.Current.File;
                foreach (String sp in manageConfig.data.DataRename.SujetPrincipal)
                {
                    listSujetP.Items.Add(sp);
                }
                foreach (String ss in manageConfig.data.DataRename.SujetSecondaire)
                {
                    listSujetS.Items.Add(ss);
                }
                foreach (String c in manageConfig.data.DataRename.Context)
                {
                    listContext.Items.Add(c);
                }
            }
        }

        /// <summary>
        /// Choisi le nouveau dossier courant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseNewFolder(object sender, EventArgs e)
        {
            Console.WriteLine("CHOOSE NEW FOLDER");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                manageFiles.folder = folderBrowserDialog.SelectedPath;
                foreach( string file in manageFiles.getFilesNames() ) {
                    listFiles.Items.Add(file);
                }
            }
        }

        private void ChooseFile(object sender, EventArgs e)
        {
            manageFiles.file = listFiles.SelectedItem.ToString();
            video_path = manageFiles.getFullPathFile();
            Console.WriteLine(video_path);
            videoReader.DocumentText = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Video Player</title>
                    <style> html {{ background-color : black; color : white; }} </style>
                </head>
                <body style='margin: 0; padding: 0;'>
                    <p>video : {video_path}</p>
                    <video width='800' height='450' controls>
                        <source src='{video_path}' type='video/mp4'>
                        Your browser does not support the video tag.
                    </video>
                </body>
                </html>
            ";
        }

        private void AddSP(object sender, EventArgs e)
        {
            if (addSujetPBox.Text != "")
            {
                listSujetP.Items.Add(addSujetPBox.Text);
                addSujetPBox.Text = "";
            }
        }

        private void AddSS(object sender, EventArgs e)
        {
            if (addSujetSBox.Text != "")
            {
                listSujetS.Items.Add(addSujetSBox.Text);
                addSujetSBox.Text = "";
            }
        }

        private void AddContext(object sender, EventArgs e)
        {
            if (addContextBox.Text != "")
            {
                listContext.Items.Add(addContextBox.Text);
                addContextBox.Text = "";
            }
        }

        private void listSujetP_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}";
        }

        private void nbSujetP_ValueChanged(object sender, EventArgs e)
        {
            if (listSujetP.SelectedItem != null)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}";
            }
        }

        private void listSujetS_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}_{listSujetS.SelectedItem.ToString()}_{nbSujetS.Value}";
        }

        private void nbSujetS_ValueChanged(object sender, EventArgs e)
        {
            if (listSujetP.SelectedItem != null && listSujetS.SelectedItem != null)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}_{listSujetS.SelectedItem.ToString()}_{nbSujetS.Value}";
            }
        }

        private void listContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNomTemp.Text += $"_{listContext.SelectedItem.ToString()}";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<String> listSP = new List<String>();
            List<String> listSS = new List<String>();
            List<String> listC = new List<String>();
            foreach (String s in listSujetP.Items) { 
                listSP.Add(s);
            }
            foreach (String s in listSujetS.Items)
            {
                listSS.Add(s);
            }
            foreach (String s in listContext.Items)
            {
                listC.Add(s);
            }
            manageConfig.SaveConfig(manageFiles.folder, manageFiles.file, listSP, listSS, listC);
        }
    }
}
