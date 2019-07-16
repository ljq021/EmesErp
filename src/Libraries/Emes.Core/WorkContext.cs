using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Surging.Core.CPlatform.Transport.Implementation;

namespace Emes.Core
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string SystemName { get; set; }
        public bool IsLock { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public bool IsLimitDuplicateLogin { get; set; }
        public string Notes { get; set; }
    }
    public class WorkContext
    {
        public static dynamic GetCurrentUser()
        {
            var payload = RpcContext.GetContext().GetAttachment("payload");
            if (payload == null)
            {
                return new
                {
                    TenantId = 0,
                    Id = 0
                };
            }
            else
            {
                return JsonConvert.DeserializeObject<UserModel>(JsonConvert.DeserializeObject(payload.ToString()).ToString());
            }
        }
    }
}
