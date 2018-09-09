using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    class ConfigurationFile : IConfigurationManager
    {
        public string GetConfigurationValue(string buttonName)
        {
            //obter o valor do ficheiro
            /*
             * ButtonBlue: 1
             * ButtonGreen: 0
             * ButtonRed: 0
             * ....
             */
            return "1";
        }
    }
}
