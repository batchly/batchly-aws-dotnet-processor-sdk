using System;
using System.Collections.Generic;



namespace Batchly.SDK.Request
{
    public interface IRequest
    {

        /// <summary>
        ///     ID for the Unit of Work
        /// </summary>
        String ID { get; set; }

        /// <summary>
        ///     Values for parameters configured via UI
        /// </summary>
        Dictionary<String, String> Parameters { get; set; }

        /// <summary>
        ///     Path for loading additional content - Path to container from where code is executed
        /// </summary>
        String ContentPath { get; set; }
    }
}
