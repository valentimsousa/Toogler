using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    public class ButtonFeature: IButtonFeature
    {
        private readonly IConfigurationManager _configuration;
        public ButtonFeature(IConfigurationManager configuration)
        {
            _configuration = configuration;
        }
        public bool IsButtonEnabled(string buttonName)
        {
            var buttonValue = _configuration.GetConfigurationValue(buttonName);
            if (string.IsNullOrWhiteSpace(buttonValue))
            {
                throw new FeatureButtonNotFoundException(buttonName);
            }


            return buttonValue== "1" ? true : false;
        }
    
    }
}
