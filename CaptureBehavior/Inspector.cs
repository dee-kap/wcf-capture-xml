using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;

namespace CaptureBehavior
{
    public class Inspector : IDispatchMessageInspector 
    {

        /// <summary>
        /// Stores contents of Request message
        /// passed to the service.
        /// </summary>
        /// <value>The request XML.</value>
        public string Request { get; set; }

        /// <summary>
        /// Stores contents of Response messge
        /// which is sent back to the client.
        /// </summary>
        /// <value>The response XML.</value>
        public string Response { get; set; }


        /// <summary>
        /// Triggered from AfterReceiveRequest method.
        /// </summary>
        public event EventHandler<InspectorEventArgs> RaiseRequestReceived;

        /// <summary>
        /// Triggered from BeforeSendReply method.
        /// </summary>
        public event EventHandler<InspectorEventArgs> RaiseSendingReply;

        protected void OnRaiseRequestReceived(string message)
        {
            EventHandler<InspectorEventArgs> handler = RaiseRequestReceived;
            
            if (handler != null)
            {
                handler(this, new InspectorEventArgs(message));
            }
        }

        protected void OnRaiseSendingReply(string message)
        {
            EventHandler<InspectorEventArgs> handler = RaiseSendingReply;

            if (handler != null)
            {
                handler(this, new InspectorEventArgs(message));
            }
        }

        #region IDispatchMessageInspector Members

        /// <summary>
        /// Called after an inbound message has been received but 
        /// before the message is dispatched to the intended operation.
        /// 
        /// This method will also raise RaiseRequestReceived event.
        /// </summary>
        /// <param name="request">The request message.</param>
        /// <param name="channel">The incoming channel.</param>
        /// <param name="instanceContext">The current service instance.</param>
        /// <returns>
        /// The object used to correlate state. 
        /// </returns>
        public object AfterReceiveRequest(
            ref System.ServiceModel.Channels.Message request, 
            System.ServiceModel.IClientChannel channel, 
            System.ServiceModel.InstanceContext instanceContext)
        {
            Request = request.ToString();
            OnRaiseRequestReceived(Request);
            return null;
        }

        /// <summary>
        /// Called after the operation has returned but before the reply message is sent.
        /// 
        /// This method will also raise RaiseSendReply event.
        /// </summary>
        /// <param name="reply">The reply message. 
        /// This value is null if the operation is one way.</param>
        /// <param name="correlationState">The correlation object returned from the
        /// AfterReceiveRequest method.</param>
        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, 
            object correlationState)
        {
            Response = reply.ToString();
            OnRaiseSendingReply(Response);
        }

        #endregion
    }
}
