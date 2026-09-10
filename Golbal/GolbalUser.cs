using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;
using DVLDBusinessLayer;
namespace Golbal
{
    public class GolbalUser
    {
      public static clsUser CurrentUser = clsUser.GetUserInfoByUserNameAndPassword("", "");
    }
}
