﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toogler
{

    public interface IButtonFeature
    {
        bool IsButtonEnabled(string featureName);
        bool SetButtonFeature(string featureName, bool featureEnabled);

    }
}

