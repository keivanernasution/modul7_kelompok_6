using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;
namespace modul7_kelompok_6
{
    internal class DataMahasiswa1302210099
    {
        public static void readJSON()
        {
            string json = File.ReadAllText("\"C:\\Users\\Keivan\\source\\repos\\modul7_kelompok_6\\jurnal7_1_1302210099.json\"");
            var data = JsonSerializer.Deserialize<Object>(json);
        }
    }
}
