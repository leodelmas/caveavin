using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveAVin
{
    public class Csv
    {
        private readonly string _filePath;

        public Csv(string filePath)
        {
            _filePath = filePath;
        }

        public List<List<string>> Lire()
        {
            var lines = File.ReadAllLines(_filePath);
            var data = new List<List<string>>();

            foreach (var line in lines)
            {
                data.Add(new List<string>(line.Split(',')));
            }

            return data;
        }

        public void Enregistrer(List<List<string>> data)
        {
            var lines = new List<string>();

            foreach (var row in data)
            {
                lines.Add(string.Join(",", row));
            }

            File.WriteAllLines(_filePath, lines);
        }
    }
}
