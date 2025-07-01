using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKH
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string FullName { get; set; }
        public static string UserType { get; set; }
    }
}
