using DevExpress.ExpressApp.Spa.AspNetCore;
using DevExpress.ExpressApp.Spa.AspNetCore.Mvc;

namespace SecurTest1.Spa.Api
{
    public class SecurTest1SpaMetaDataController : MetaDataController {
        public SecurTest1SpaMetaDataController(ISpaApplicationConfigProvider applicationProvider) : base(applicationProvider) { }
    }
}