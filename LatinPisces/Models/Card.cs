using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace LatinPisces.Models
{
    internal class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Translation { get; set; }
        public string Path { get; set; }
        public string Transcription { get; set; }

        private List<String> _wrongOptions;

        public Card(string name, string translation, string path, string transcription)
        {
            this.Name = name;
            this.Translation = translation;
            this.Path = path;
            this.Transcription = transcription;
        }

        public void AddDictionary(string path)
        {
            _wrongOptions = new List<String>();

            string wrongOption;
            StreamReader streamReader = new StreamReader(path);
            while ((wrongOption = streamReader.ReadLine()) != null)
            {
                
                _wrongOptions.Add(wrongOption);
            }
            streamReader.Close();
            
        }

        public List<String> getWrongOption()
        {
            return _wrongOptions;
        }

    }
}
