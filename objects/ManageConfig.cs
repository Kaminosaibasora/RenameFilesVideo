using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RenameFilesVideo.objects
{
    internal class ManageConfig
    {
        public string pathConfig;
        public dynamic data;

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
                        Folder = root.GetProperty("Folder").GetString(),
                        File = root.GetProperty("File").GetString(),
                    },
                    DataRename = new {
                        SujetPrincipal = root.GetProperty("SujetPrinciapl").GetString(), // TODO : chercher type liste
                        SujetSecondaire = root.GetProperty("SujetSecondaire").GetString(),
                        Context = root.GetProperty("Context").GetString(),
                    },
                };
            }
        }

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
