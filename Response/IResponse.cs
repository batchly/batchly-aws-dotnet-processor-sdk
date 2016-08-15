using Batchly.SDK.Enumerations;
using System;


namespace Batchly.SDK.Response
{
    public interface IResponse
    {
        String ID { get; set; }

        ResponseStatus Status { get; set; }
    }
}
