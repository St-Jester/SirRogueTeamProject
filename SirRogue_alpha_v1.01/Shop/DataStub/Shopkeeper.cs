using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirRogue_alpha_v1._01.Shop.DataStub
{
    public class Shopkeeper
    {
        List<string> RandomPhrases { get; set; }

        public Shopkeeper()
        {
            RandomPhrases = new List<string>();
            RandomPhrases.Add("Phrase 1");
            RandomPhrases.Add("Phrase 2");
            RandomPhrases.Add("Phrase 3");
        }

        public string GetRandomPhrase()
        {
            int maxIndex = RandomPhrases.Count;
            int randomIndex = (new Random()).Next(maxIndex);
            return RandomPhrases[randomIndex];
        }
    }
}
