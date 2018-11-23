using DevExpress.ExpressApp.Spa;
using DevExpress.ExpressApp.Spa.AspNetCore;
using DevExpress.ExpressApp.Spa.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurTest1.Spa.Api {
	[Microsoft.AspNetCore.Authorization.AllowAnonymous]
    public class SecurTest1SpaApplicationController : SpaApplicationController {
        public SecurTest1SpaApplicationController(ISpaApplicationProvider applicationProvider) : base(applicationProvider) { }
    }
}