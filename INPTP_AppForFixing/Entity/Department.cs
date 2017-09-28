using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                string dptCode = "DPT-";
                dptCode += Name.Replace(" ", "-").Replace(":","-").Replace(",","-").Replace(".","-").Replace("--","-").ToUpper();

                return dptCode;
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}
