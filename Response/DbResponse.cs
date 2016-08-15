
using Batchly.SDK.Enumerations;
using Batchly.SDK.Request;
using System;
using System.Collections.Generic;

namespace Batchly.SDK.Response
{
    public class DbResponse : IResponse
    {

        public DbResponse()
        {
            this.Status = ResponseStatus.Success;
        }

        public DbResponse(IRequest request)
            : this()
        {
            this.ID = request.ID;
            this.Status = ResponseStatus.Success;
        }

        /// <summary>
        ///     Request ID for the Unit of Work
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        ///     Status of Processing
        /// </summary>  
        /// <summary>
        ///     Parameter Name and Data pair for each parameter of the SQL Query that is run on successful processing.
        ///     The query is configured as part of Batchly Portal and is run in sequence to ensure successful writes to the database.
        /// </summary>
        public Dictionary<String, String> ParameterValues { get; set; }

        /// <summary>
        ///     Duplicate message that can be deleted without any post processing
        /// </summary>

        public ResponseStatus Status { get; set; }

    }


}
