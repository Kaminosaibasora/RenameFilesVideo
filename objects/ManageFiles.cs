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
            string[] files = Directory.GetFiles(folder);
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
        public void Rename(string name) {
            try
            {
                File.Move(getFullPathFile(), folder + @"\" + name );
                this.file = "";
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur s'est produite lors du renommage du fichier : " + e.Message);
            }
        }

        /// <summary>
        /// Parcourt la liste des fichiers et supprime tous ceux qui ne correspondent pas au critère.
        /// </summary>
        /// <param name="timeMinimum">nombre de seconde minimum pour échapper à la suppression.</param>
        public void DeleteFiles(int timeMinimum) { } 
    }
}
