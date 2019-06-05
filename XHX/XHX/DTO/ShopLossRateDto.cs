using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopLossRateDto
    {
        public string ProjectCode { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string CountThis { get; set; }
        public string CountLast { get; set; }
        public string LossRate { get; set; }
        public char StatusType { get; set; }
    }
}
