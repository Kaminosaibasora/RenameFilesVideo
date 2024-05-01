using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenameFilesVideo.objects{
    internal class ManageFiles
    {
        public string folder;
        public string file;

        public ManageFiles() {
            folder = "";
            file = "";
        }

        /// <summary>
        /// Obtient le nom de tous les fichiers contenu dans le dossier sélectionné (folder).
        /// </summary>
        /// <returns>liste de noms de fichiers.</returns>
        public List<string> getFilesNames() { 
            List<string> listeFiles = new List<string>();
            string[] files = Directory.GetFiles(folder, "*.mp4");
            foreach (string file in files)
            {
                listeFiles.Add(Path.GetFileName(file));
            }
            return listeFiles;
        }

        /// <summary>
        /// Retourne le chemin complet du fichier sélectionné (file).
        /// </summary>
        /// <returns>Chemin Complet vers file.</returns>
        public string getFullPathFile() { 
            return folder + @"\" + file; 
        }

        /// <summary>
        /// Renome un fichier selon le nom saisi.
        /// </summary>
        /// <param name="name">nouveau nom du fichier.</param>
        public String Rename(string name) {
            try
            {
                int id_alea = new Random().Next(999999);
                File.Move(getFullPathFile(), $@"{folder}\{name}_{id_alea}.mp4" );
                this.file = "";
                return $@"{name}_{id_alea}.mp4";
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur s'est produite lors du renommage du fichier : " + e.Message);
            }
            return "";
        }

        /// <summary>
        /// Parcourt la liste des fichiers et supprime tous ceux qui ne correspondent pas au critère.
        /// TODO : trouver un moyen efficace de trouver la durée d'une vidéo.
        /// </summary>
        /// <param name="timeMinimum">nombre de seconde minimum pour échapper à la suppression.</param>
        public void DeleteFiles(int timeMinimum, AxWMPLib.AxWindowsMediaPlayer player) {
            List<string> files = getFilesNames();
            foreach (string file in files)
            {
                string path = this.folder + @"\" + file;
                player.URL = path;
                // player.Ctlcontrols.play();
                player.Ctlcontrols.pause();
                double duration = player.currentMedia.duration;
                Console.WriteLine(duration.ToString());
                break;
            }
        }

        public void DeleteFile()
        {
            File.Delete(this.folder + @"\" + file);
            this.file = "";
        }
    }
}
