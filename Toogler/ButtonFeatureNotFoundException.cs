using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    class ButtonFeatureNotFoundException : Exception
    {
            private readonly string _buttonFeatureName;
            public ButtonFeatureNotFoundException(string featureName)
            {
                _buttonFeatureName = featureName;
            }

        
    }
}
