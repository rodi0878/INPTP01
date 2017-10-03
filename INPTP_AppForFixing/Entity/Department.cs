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
        /// <summary>
        /// Property for get and set name of departement
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property Code with private setter and getter which return code composed of 
        /// prefix "DPT-" and Name which has modified some chars using regular expressions
        /// </summary>
        public string Code
        {
            get
            {
                return "DPT-" + Regex.Replace(Name, "[ :,.]|[-]{2}", "-").ToUpper();
            }
        }

        /// <summary>
        /// Method ToString converts an object to its string representation.
        /// </summary>
        /// <returns>Code of department</returns>
        public override string ToString()
        {
            return Code;
        }
    }
}
