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

        /// <summary>
        /// TODO : suppression de masse selon la durée
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // ------------ INIT ENGINE ------------
            manageFiles = new ManageFiles();
            manageConfig = new ManageConfig();

            // ------------ INIT COMPOSANT ------------

            // ------------ LOAD DATA ------------

            LoadData();
            
        }

        /// <summary>
        /// Charge les données sauvegardées dans l'interface.
        /// </summary>
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
                listFiles.Items.Clear();
                foreach( string file in manageFiles.getFilesNames() ) {
                    listFiles.Items.Add(file);
                }
            }
        }

        /// <summary>
        /// Choisi un fichier parmi la liste affichée et lance la lecture de la vidéo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFile(object sender, EventArgs e)
        {
            if(listFiles.SelectedIndex != -1)
            {
                manageFiles.file = listFiles.SelectedItem.ToString();
                video_path = manageFiles.getFullPathFile();
                Console.WriteLine(video_path);
                videoPlayer.URL = video_path;
                videoPlayer.Ctlcontrols.play();
                this.Text = manageFiles.file;
            }
        }

        /// <summary>
        /// Lance la sauvegarde de données lors de la fermeture du programme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Suppression de toutes les vidéos trop courtes.
        /// TODO : à revoir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suppressionAutomatiqueDesVidéosDeMoinsDe1SecondesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageFiles.DeleteFiles(1, videoPlayer);
        }

        /// <summary>
        /// Suppression après confirmation du fichier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Supprimer ce fichier ?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                videoPlayer.Ctlcontrols.stop();
                listFiles.SelectedIndex = -1;
                listFiles.Items.Remove(manageFiles.file);
                manageFiles.DeleteFile();
            }
        }

        /// <summary>
        /// Renommage du fichier en cours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonValidRename_Click(object sender, EventArgs e)
        {
            listFiles.Items[listFiles.SelectedIndex] = manageFiles.Rename(labelNomTemp.Text);
        }

        /// <summary>
        /// Suppression d'un tag après validation d'un utilisateur.
        /// </summary>
        /// <param name="liste">ListBox contenant un tag.</param>
        private void DeleteTag(ListBox liste)
        {
            if (liste.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show($"Voulez-vous Supprimer ce tag : {liste.SelectedItem.ToString()} ?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int index = liste.SelectedIndex;
                    liste.SelectedIndex = -1;
                    liste.Items.RemoveAt(index);
                }
            }
        }

        // ===========================================================================================================================
        // **************************************************** I N T E R F A C E ****************************************************
        // ===========================================================================================================================

        /// <summary>
        /// Ajoute un Sujet Principal à la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSP(object sender, EventArgs e)
        {
            if (addSujetPBox.Text != "")
            {
                listSujetP.Items.Add(addSujetPBox.Text);
                addSujetPBox.Text = "";
            }
        }

        /// <summary>
        /// Ajoute un Sujet Secondaire à la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSS(object sender, EventArgs e)
        {
            if (addSujetSBox.Text != "")
            {
                listSujetS.Items.Add(addSujetSBox.Text);
                addSujetSBox.Text = "";
            }
        }

        /// <summary>
        /// Ajoute un Context à la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContext(object sender, EventArgs e)
        {
            if (addContextBox.Text != "")
            {
                listContext.Items.Add(addContextBox.Text);
                addContextBox.Text = "";
            }
        }

        /// <summary>
        /// Sélectionne un sujet principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSujetP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSujetP.SelectedIndex != -1)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}";
            }
        }

        /// <summary>
        /// Sélectionne un nombre associé au sujet principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nbSujetP_ValueChanged(object sender, EventArgs e)
        {
            if (listSujetP.SelectedIndex != -1)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}";
            }
        }

        /// <summary>
        /// Sélectionne un sujet secondaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSujetS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSujetS.SelectedIndex != -1 && listSujetP.SelectedIndex != -1)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}_{listSujetS.SelectedItem.ToString()}_{nbSujetS.Value}";
            }
        }

        /// <summary>
        /// Sélectionne un nombre associé au sujet secondaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nbSujetS_ValueChanged(object sender, EventArgs e)
        {
            if (listSujetP.SelectedItem != null && listSujetS.SelectedItem != null)
            {
                labelNomTemp.Text = $"{listSujetP.SelectedItem.ToString()}_{nbSujetP.Value}_{listSujetS.SelectedItem.ToString()}_{nbSujetS.Value}";
            }
        }

        /// <summary>
        /// Sélectionne un context.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listContext_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(listContext.SelectedIndex != -1)
                {
                    labelNomTemp.Text += $"_{listContext.SelectedItem.ToString()}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Suppression d'un tag de Sujet Principal via double clique.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSujetP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteTag(listSujetP);
        }

        /// <summary>
        /// Suppression d'un tag de Sujet Secondaire via double clique.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSujetS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteTag(listSujetS);
        }

        /// <summary>
        /// Suppression d'un tag de Context via double clique.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listContext_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteTag(listContext);
        }

        /// <summary>
        /// Chargement d'une configuration existante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chargerConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers JSON (*.json)|*.json";
            openFileDialog.Title = "Sélectionner un fichier de configuration JSON";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                manageConfig = new ManageConfig(openFileDialog.FileName);
                LoadData();
            }
        }
    }
}
