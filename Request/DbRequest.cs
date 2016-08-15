using System;
using System.Collections.Generic;



namespace Batchly.SDK.Request
{
    public class DbRequest : IRequest
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
        ///     Connection String for connecting to database
        /// </summary>
        public String ConnectionString { get; set; }

        /// <summary>
        ///     Dictionary of data containing a single row from configured query
        ///     Key of the dictionary is the column name while value is an object of data
        /// </summary>
        public Dictionary<String, Object> Data { get; set; }

        /// <summary>
        ///     Path for loading additional content - Path to container from where code is executed
        /// </summary>
        public String ContentPath { get; set; }
    }
}
