using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    public class ConfigurationFile : IConfigurationManager
    {
        public string GetConfigurationValue(string buttonName)
        {
            //read file
            /*
             * ButtonBlue: 1
             * ButtonGreen: 0
             * ButtonRed: 0
             * ....
             */
            return "1";
        }

        public bool setConfigurationValue(string buttonName, bool buttonEnabled)
        {
            //throw new NotImplementedException();
            //add to file
            return true;
        }


    }
}
