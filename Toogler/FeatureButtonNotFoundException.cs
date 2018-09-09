using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{
    class FeatureButtonNotFoundException : Exception
    {
            private readonly string _buttonFeatureName;
            public FeatureButtonNotFoundException(string buttonName)
            {
                _buttonFeatureName = buttonName;
            }
        
    }
}
