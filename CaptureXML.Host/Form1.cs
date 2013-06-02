using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using CaptureXML.Service;
using CaptureBehavior;
using System.ServiceModel.Dispatcher;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace CaptureXML.Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ServiceHost host = new ServiceHost(typeof(HelloService));

        CustomBehavior behavior = new CustomBehavior();


        private void buttonStartService_Click(object sender, EventArgs e)
        {
            // Add our Custom Behaviour to the list of behaviours
            host.Description.Behaviors.Add(behavior);
            // start the service
            host.Open();

            // add event handlers
            foreach (ChannelDispatcher dispatcher in host.ChannelDispatchers)
            {
                foreach (var endPoint in dispatcher.Endpoints)
                {
                    // get a list of MessageInspectors that are of type Inspector
                    var query = (from ex in endPoint.DispatchRuntime.MessageInspectors
                                 where ex.GetType() == typeof(Inspector)
                                 select ex).Cast<Inspector>();

                    // hook up the events
                    foreach (var item in query)
                    {
                        item.RaiseRequestReceived += 
                            new EventHandler<InspectorEventArgs>(Form1_RaiseRequestReceived);
                        item.RaiseSendingReply += 
                            new EventHandler<InspectorEventArgs>(Form1_RaiseSendingReply);

                    }
                }
            }
        }

        /// <summary>
        /// Writes xml to browser.
        /// WebBrowser control does render xml properly and to get around
        /// I am using this handy tip from this link.
        /// http://www.c-sharpcorner.com/Forums/ShowMessages.aspx?ThreadID=51473
        /// </summary>
        /// <param name="browser">The browser.</param>
        /// <param name="message">The message.</param>
        private void WriteToBrowser(WebBrowser browser, string message)
        {
            XslCompiledTransform xTrans = new XslCompiledTransform();
            xTrans.Load("default.xslt");
            StringReader sr = new StringReader(message);
            XmlReader xReader = XmlReader.Create(sr);
            System.IO.MemoryStream ms = new MemoryStream();
            xTrans.Transform(xReader, null, ms);
            ms.Position = 0;
            browser.DocumentStream = ms;
        }

        void Form1_RaiseSendingReply(object sender, InspectorEventArgs e)
        {
            WriteToBrowser(webBrowserResponse, e.Message);
        }

        void Form1_RaiseRequestReceived(object sender, InspectorEventArgs e)
        {
            WriteToBrowser(webBrowserRequest, e.Message);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            host.Close();
            host = null;
            base.OnClosing(e);

        }
    }
}
