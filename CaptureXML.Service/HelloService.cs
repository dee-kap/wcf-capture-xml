using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CaptureXML.Service
{
    public class HelloService : IHelloService
    {
        #region IHelloService Members

        public string SayHello(string name)
        {
            return string.Concat("Hello ", name);
        }

        #endregion
    }
}
