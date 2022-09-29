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
        public string PathToDictionary { get; set; }

        //private static List<String> _defaultDictionary = new List<string>();
        //private List<String> _specialDictionary;
        private static string _pathToDefaultDictionry;

        public Card(string name, string translation, string path, string transcription)
        {
            this.Name = name;
            this.Translation = translation;
            this.Path = path;
            this.Transcription = transcription;

            PathToDictionary = _pathToDefaultDictionry;
        }

        public static void AddDefaultDictionary(string path)
        {
            _pathToDefaultDictionry = path;
        }

        //public static void AddDefautlDictionary(string path)
        //{
        //    string wrongOption;
        //    StreamReader streamReader = new StreamReader(path);
        //    while ((wrongOption = streamReader.ReadLine()) != null)
        //    {

        //        _defaultDictionary.Add(wrongOption);
        //    }
        //    streamReader.Close();
        //}

        //public void AddDictionary(string path)
        //{
        //    _specialDictionary = new List<String>();

        //    string wrongOption;
        //    StreamReader streamReader = new StreamReader(path);
        //    while ((wrongOption = streamReader.ReadLine()) != null)
        //    {
                
        //        _specialDictionary.Add(wrongOption);
        //    }
        //    streamReader.Close();
            
        //}

        public List<String> GetWrongAnswers()
        {

            List<String> wrongAnswers = new List<String>();
            string wrongAnswer;

            StreamReader streamReader = new StreamReader(PathToDictionary);
            while ((wrongAnswer = streamReader.ReadLine()) != null)
            {
                wrongAnswers.Add(wrongAnswer);
            }
            
            return wrongAnswers;
        }

    }
}
