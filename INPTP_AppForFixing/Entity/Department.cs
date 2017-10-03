using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Department
    {
        public string Name { get; set; }

        public string Code
        {
            get
            {
                return "DPT-" + Regex.Replace(Name, " :,.--", "-");
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}
