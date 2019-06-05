using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string AreaCode { get; set; }
        public bool UseChk { get; set; }
        public char StatusType { get; set; }
        public string InUserId { get; set; }
        public DateTime InDateTime { get; set; }
        //public string AreaCode { get; set; }
        //public string AreaName { get; set; }
        public string SaleSmall { get; set; }
        public string SaleBig { get; set; }
        public string AfterSmall { get; set; }
        public string AfterBig { get; set; }
        
    }
}
