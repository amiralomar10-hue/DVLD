using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;
using System.Diagnostics;
namespace Golbal
{
    public class GolbalUser
    {
      public static clsUser CurrentUser = clsUser.GetUserInfoByUserNameAndPassword("", "");
    }
  

}
