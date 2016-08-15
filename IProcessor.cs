using Batchly.SDK.Request;
using Batchly.SDK.Response;

namespace Batchly.SDK
{
    public interface IProcessor<TREQUEST, TRESPONSE>
        where TREQUEST : IRequest
        where TRESPONSE : IResponse
    {
        TRESPONSE Process(TREQUEST request);
    }
}
