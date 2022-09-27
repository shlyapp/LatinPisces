using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinPisces.Model
{
    internal class Card
    {
        private string _name;
        private string _translate;
        private string _transcription;
        private string _path;

        public Card()
        {

        }

        public Card(string name, string path, string transalate, string transcription)
        {
            this._name = name;
            this._path = path;
            this._translate = transalate;
        }

    }
}
