using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersHandling
{
    internal class SecurityServices
    {

        public bool isAvailable(Users currentUser)
        {
            if (currentUser.RoleID ==1 )
            {
                return true;
            } else
            {
                return false;
            }
            
        }


    }
}
