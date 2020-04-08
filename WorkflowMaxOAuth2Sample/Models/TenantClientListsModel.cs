using System;
using System.Collections.Generic;

namespace WorkflowMaxOAuth2Sample.Models
{
    public class TenantClientListsModel
    {
        public string LoggedInUser { get; set; }
        public List<(Guid tenantId, ClientApi.ClientListResponse clients)> TenantClients { get; set; }
    }
}
