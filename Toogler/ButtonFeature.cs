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
        public bool SetButtonFeature(string featureName, bool featureEnabled)
        {
            return _configuration.setConfigurationValue(featureName, featureEnabled);
        }

        public bool IsButtonEnabled(string featureName)
        {
            var buttonValue = _configuration.GetConfigurationValue(featureName);
            if (string.IsNullOrWhiteSpace(buttonValue))
            {
                throw new ButtonFeatureNotFoundException(featureName);
            }


            return buttonValue== "1" ? true : false;
        }
    
    }
}
