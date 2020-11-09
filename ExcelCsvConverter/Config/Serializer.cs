using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace ExcelCsvConverter.Config
{
    static class Serializer
    {
        public static void Serialize(ConfigurationModel model){
            string output = JsonConvert.SerializeObject(model);
            Savefile(output);
        }
        public static ConfigurationModel DeSerializemodel()
        {
            
            return   JsonConvert.DeserializeObject<ConfigurationModel>(Readfile());
        }

        private static void Savefile(string fileContent)
        {
            File.WriteAllText(Application.StartupPath + @"\configuration.json", fileContent);
        }

        private static string Readfile()
        {
            if(!File.Exists(Application.StartupPath + @"\configuration.json"))
                File.WriteAllText(Application.StartupPath + @"\configuration.json", "{}");
            return  File.ReadAllText(Application.StartupPath + @"\configuration.json");
        }

    }
}



