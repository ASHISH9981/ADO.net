using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Regisparam
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public string PassWordFist { get; set; }
        public string PassWordConfirm { get; set; }
    }

    public class LoginParams
    {
        public string Name { get; set; }
        public string PassWordFist { get; set; }

    }
}