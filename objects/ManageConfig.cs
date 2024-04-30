using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text.Json;

namespace RenameFilesVideo.objects
{
    internal class ManageConfig
    {
        public string pathConfig;
        public dynamic data;

        /// <summary>
        /// Initialise le composant et lance le chargement de la configuration si elle existe.
        /// </summary>
        /// <param name="pathConfig">Chemin vers le fichier de configuration au format JSON.</param>
        public ManageConfig(string pathConfig = "./RenameConfig.json")
        {
            this.pathConfig = pathConfig;
            if (File.Exists(pathConfig))
            {
                string fullPath = Path.GetFullPath(pathConfig);
                Console.WriteLine("Chemin complet du fichier : " + fullPath);
                Console.WriteLine("Load Data");
                LoadingConfig();
            }
        }

        /// <summary>
        /// Charge la configuration existante dans la variable data.
        /// </summary>
        public void LoadingConfig()
        {
            string jsonString = File.ReadAllText(this.pathConfig);
            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                JsonElement root = document.RootElement;
                this.data = new
                {
                    Current = new
                    {
                        Folder = root.GetProperty("Current").GetProperty("Folder").GetString(),
                        File = root.GetProperty("Current").GetProperty("File").GetString(),
                    },
                    DataRename = new {
                        SujetPrincipal = new List<String>(),
                        SujetSecondaire = new List<String>(),
                        Context = new List<String>(),
                    },
                };
                foreach (JsonElement item in root.GetProperty("DataRename").GetProperty("SujetPrincipal").EnumerateArray())
                {
                    this.data.DataRename.SujetPrincipal.Add(item.GetString());
                }
                foreach (JsonElement item in root.GetProperty("DataRename").GetProperty("SujetSecondaire").EnumerateArray())
                {
                    this.data.DataRename.SujetSecondaire.Add(item.GetString());
                }
                foreach (JsonElement item in root.GetProperty("DataRename").GetProperty("Context").EnumerateArray())
                {
                    this.data.DataRename.Context.Add(item.GetString());
                }
            }
        }

        /// <summary>
        /// Sauvegarde les données dans le fichier de configuration JSON.
        /// </summary>
        /// <param name="folder">Dossier ouvert dans l'application</param>
        /// <param name="file">fichier en cours de traitement</param>
        /// <param name="listSP">liste des sujets principaux</param>
        /// <param name="listSS">liste des sujets secondaires</param>
        /// <param name="listC">liste des contexts.</param>
        public void SaveConfig(string folder, string file, List<String> listSP, List<String> listSS, List<String> listC)
        {
            var configObject = new
            {
                Current = new
                {
                    Folder = folder,
                    File = file
                },
                DataRename = new
                {
                    SujetPrincipal = listSP,
                    SujetSecondaire = listSS,
                    Context = listC
                }
            };
            this.data = configObject;
            try
            {
                string jsonString = JsonSerializer.Serialize(configObject);
                File.WriteAllText(this.pathConfig, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR : {ex}");
            }
        }
    }
}
