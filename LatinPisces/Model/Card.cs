using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Model
{
    ///[Table("cards")]

    internal class Card
    {
        //[Key]

        private string name;
        private string translate;
        private string transcription;
        private string path;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Translate
        {
            get { return translate; }
            set { translate = value; }
        }

        public string Transcription
        {
            get { return transcription; }
            set { transcription = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public Card()
        {

        }

        public Card(string name, string path, string transalate, string transcription)
        {
            this.name = name;
            this.path = path;
            this.translate = transalate;
            this.transcription = transcription;
        }

    }
}
