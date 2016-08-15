using Batchly.SDK.Enumerations;
using Batchly.SDK.Request;
using System;

namespace Batchly.SDK.Response
{
    public class StatusResponse : IResponse
    {

        public StatusResponse()
        {
            this.Status = ResponseStatus.Success;
        }

        public StatusResponse(IRequest request): this()
        {
            this.ID = request.ID;
            this.Status = ResponseStatus.Success;
        }

        /// <summary>
        ///     Unique Identifier for Unit of Work
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        ///     Status of the processing
        /// </summary>

        /// <summary>
        ///     Duplicate message that can be deleted without any post processing
        /// </summary>
  
        public ResponseStatus Status { get; set; }


    }
}
