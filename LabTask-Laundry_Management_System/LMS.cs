using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryManagementSystem
{
    static internal class LMS
    {
        static public List<User> userList;
        static public List<Order> orderList;
        static public Owner owner;
        static LMS() { userList = new List<User>(); orderList = new List<Order>(); owner = new Owner(); }
    }
}
