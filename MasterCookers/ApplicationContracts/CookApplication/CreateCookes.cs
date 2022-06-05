using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.ApplicationContracts.CookApplication
{
    public class CreateCookes
    {
        public string Title { get;  set; }
        public string shortdicriptio { get;  set; }
        public string contant { get;  set; }
        public string image { get;  set; }
        public long categoryId { get;  set; }
    }
}
