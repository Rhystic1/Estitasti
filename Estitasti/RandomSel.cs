using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estitasti
{
    public class RandomSel
    {
        public static string RandomNumber()
        {
            Random rnd = new Random();  /// Creates the random number generator 
            string[] estiFiles = { "ESTI_001.wav", "ESTI_002.wav", "ESTI_003.wav", "ESTI_004.wav", "ESTI_005.wav", "ESTI_006.wav", "ESTI_007.wav", "ESTI_008.wav" }; /// Array that includes the audio files we want
            string estiIndex = estiFiles[rnd.Next(estiFiles.Length)]; /// We take one random number equalling one random file and return it as a string in the next line
            return estiIndex;
        }
    }
}
