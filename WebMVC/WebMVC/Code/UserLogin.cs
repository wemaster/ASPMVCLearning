using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.code
{
    [Serializable]
    public class UserLogin
    {
        public int IDAcc { get; set; }
        public string NameAcc { get; set; }
    }
}