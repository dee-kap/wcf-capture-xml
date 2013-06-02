using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaptureBehavior
{
    public class InspectorEventArgs : EventArgs
    {
        public InspectorEventArgs(string message)
        {
            this.Message = message;
        }

        public string Message { get; set; }
    }
}
