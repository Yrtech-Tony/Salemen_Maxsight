using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopLossRateDtlDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
        public string PositionCountThis { get; set; }
        public string PositionCountLast { get; set; }
        public string PositionLossRate { get; set; }
        public string AuthCountThis { get; set; }
        public string AuthCountLast { get; set; }
        public string AuthLossRate { get; set; }
        public char StatusType { get; set; }
    }
}
