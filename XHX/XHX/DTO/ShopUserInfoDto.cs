using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopUserInfoDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string UserName { get; set; }
        public string PinYinName { get; set; }
        public string PostionCode { get; set; }
        public string AuthCode { get; set; }
        public string InUserId { get; set; }
        public DateTime InDateTime { get; set; }
        public string PicNameList { get; set; }
        public char StatusType { get; set; }
        public string AreaName { get; set; }
    }
}
