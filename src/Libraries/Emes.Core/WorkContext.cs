using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Surging.Core.CPlatform.Transport.Implementation;

namespace Emes.Core
{
    public class WorkContext
    {
        public static dynamic GetCurrentUser()
        {
            var payload = RpcContext.GetContext().GetAttachment("payload");
            if (payload == null)
            {
                return new
                {
                    OrgId = 0,
                    Id = 0
                };
            }
            else
            {
                return JsonConvert.DeserializeObject(payload as string);
            }
        }
    }
}
