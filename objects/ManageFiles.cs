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

        public List<string> getFilesNames() { 
            List<string> listeFiles = new List<string>();
            string[] files = Directory.GetFiles(folder);

            // Affichez chaque fichier
            foreach (string file in files)
            {
                listeFiles.Add(Path.GetFileName(file));
            }
            return listeFiles;
        }

        public string getFullPathFile() { 
            return folder + @"\" + file; 
        }

        public void Rename(string name) {
            try
            {
                File.Move(getFullPathFile(), folder + @"\" + name );
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur s'est produite lors du renommage du fichier : " + e.Message);
            }
        }

        public void DeleteFiles() { } 
    }
}
