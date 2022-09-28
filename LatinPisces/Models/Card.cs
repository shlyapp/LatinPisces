using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Models
{
    internal class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Translation { get; set; }
        public string Path { get; set; }
        public string Transcription { get; set; }
        
        public Card(string name, string translation, string path, string transcription)
        {
            this.Name = name;
            this.Translation = translation;
            this.Path = path;
            this.Transcription = transcription;
        }

    }
}
