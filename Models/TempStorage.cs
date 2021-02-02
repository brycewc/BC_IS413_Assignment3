using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment3.Models
{
    public class TempStorage
    {
        private static List<Movies> apps = new List<Movies>();

        public static IEnumerable<Movies> App => apps;

        public static void AddApp(Movies app)
        {
            apps.Add(app);
        }
    }
}
