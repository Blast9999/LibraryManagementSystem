using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookTypeRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 分类代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }
    }
}
