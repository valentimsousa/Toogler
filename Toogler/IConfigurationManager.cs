using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    public interface IConfigurationManager
    {
       string GetConfigurationValue(string buttonName);
       
    }
}
