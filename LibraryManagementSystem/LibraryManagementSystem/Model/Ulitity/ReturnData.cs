using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReturnData
    {
        public bool IsSuccess { get; set; }
        public int Code { get; set; }
        public string Info { get; set; }
        public string Redirect { get; set; }
        public object Data { get; set; }
    }
}
