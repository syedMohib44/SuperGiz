using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupergizWinApp.Models
{
    class Response_Model
    {
        public string type { get; set; }
        public string status { get; set; }
        public Data_Model data { get; set; }
    }
}
