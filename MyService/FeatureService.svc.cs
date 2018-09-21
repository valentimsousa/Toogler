using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Toogler;

namespace MyService
{

    public class Service1 : IFeatureService
    {
        internal bool AddNewFeature(string featureName, bool featureEnabled, [CallerMemberName] string memberName = "")
        {

            IConfigurationManager configuration = new ConfigurationFile();
            ButtonFeature feature = new ButtonFeature(configuration);
            if (feature.IsButtonEnabled("isButtonBlue"))
            {
                return feature.SetButtonFeature(featureName, featureEnabled);

            }
            else if (!feature.IsButtonEnabled("isButtonBlue") && memberName == "ABC")
            {
                feature.SetButtonFeature("isButtonBlue", true);
                return feature.SetButtonFeature(featureName, featureEnabled);
            }
            else if (feature.IsButtonEnabled("isButtonGreen"))
            {
                return feature.SetButtonFeature(featureName, featureEnabled);
            }
            else if (feature.IsButtonEnabled("isButtonRed") && memberName != "ABC")
            {
                return feature.SetButtonFeature(featureName, featureEnabled);
            }
            else
                return false;

        }

        public string ABC(int t)
        {

            //do something 
            //....
            AddNewFeature("isButtonYellow", false);

            return string.Empty;
        }

        public Feature ServiceA(Feature composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            //do something 
            //....
            AddNewFeature("isButtonYellow", true);

            return composite;
        }
    }
}
