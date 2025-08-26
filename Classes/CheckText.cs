using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerificationTask.Classes
{
    internal class CheckText
    {
        public static bool checkingTextForConverToDouble(string textBoxCounterHBC) {
            Regex regex = new Regex(@"^?\d+(\.\d+)?$");
            MatchCollection matches = regex.Matches(textBoxCounterHBC);
            return matches.Count > 0;
        }
        
    }
}
