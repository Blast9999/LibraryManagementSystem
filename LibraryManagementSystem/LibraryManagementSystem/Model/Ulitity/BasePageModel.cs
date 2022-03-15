using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BasePageModel
    {
        /// <summary>
        /// 总记录数
        /// </summary>
        public int? Total { get; set; }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int? PageNum { get; set; }
        /// <summary>
        /// 每页的数量
        /// </summary>
        public int? PageSize { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int? Pages { get; set; }
    }
}
