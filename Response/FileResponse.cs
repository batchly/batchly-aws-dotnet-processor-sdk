using Batchly.SDK.Enumerations;
using Batchly.SDK.Request;
using System;
using System.Collections.Generic;


namespace Batchly.SDK.Response
{
    public class FileResponse : IResponse
    {
        public FileResponse()
        {
            this.Status = ResponseStatus.Success;
        }

        public FileResponse(IRequest request)
            : this()
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
        ///     Locations of the ouptut files on disk.  
        ///     One full path per output file.  Disk File Name is used as file name for response.
        ///     E.g.:- C:\Processed\Output\File1.png - Saved to storage as File.Png
        ///     
        /// </summary>
        public List<String> Locations { get; set; }
        /// <summary>
        ///     Duplicate message that can be deleted without any post processing
        /// </summary>
        ///
        public ResponseStatus Status { get; set; }
    }
}
