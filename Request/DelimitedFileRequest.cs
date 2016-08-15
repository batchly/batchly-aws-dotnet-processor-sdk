using System;
using System.Collections.Generic;

namespace Batchly.SDK.Request
{
    public class DelimitedFileRequest: IRequest
    {

        /// <summary>
        ///     Unique ID of the Unit of Work
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        ///     Parameters that has been configured in portal.  
        /// </summary>
        public Dictionary<String, String> Parameters { get; set; }

        /// <summary>
        ///     Fields contain the individual columns of a delimited row
        /// </summary>
        public String[] Fields { get; set; }

        /// <summary>
        ///     Path for loading additional content - Path to container from where code is executed
        /// </summary>
        public String ContentPath { get; set; }

    }
}
