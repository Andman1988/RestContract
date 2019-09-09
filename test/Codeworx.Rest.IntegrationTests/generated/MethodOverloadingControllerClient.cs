using System;
using System.Threading.Tasks;
using Codeworx.Rest.UnitTests.Model;
using Codeworx.Rest.UnitTests.Api.Contract;
using Codeworx.Rest.Client;

namespace Codeworx.Rest.UnitTests.Generated
{
    public class MethodOverloadingControllerClient : RestClient<IMethodOverloadingController>, IMethodOverloadingController
    {
        public MethodOverloadingControllerClient(RestOptions<IMethodOverloadingController> options): base(options)
        {
        }

        public MethodOverloadingControllerClient(RestOptions options): base(options)
        {
        }

        public Task<Item> MethodWithSameUrl1()
        {
            return CallAsync(c => c.MethodWithSameUrl1());
        }

        public Task<Item> MethodWithSameUrl2()
        {
            return CallAsync(c => c.MethodWithSameUrl2());
        }

        public Task<Item> MethodWithSameName()
        {
            return CallAsync(c => c.MethodWithSameName());
        }

        public Task<Item> MethodWithSameName(string resultItemName)
        {
            return CallAsync(c => c.MethodWithSameName(resultItemName));
        }
    }
}