using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Toogler;

namespace MyService
{

    [ServiceContract]
    public interface IFeatureService
    {

        [OperationContract]
        string ABC(int value);

        [OperationContract]
        Feature ServiceA(Feature input);       


    }


    [DataContract]
    public class Feature
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
