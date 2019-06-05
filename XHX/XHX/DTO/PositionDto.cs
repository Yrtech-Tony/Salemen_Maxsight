using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class PositionDto
    {
        public string PositionCode { get; set; }
        public string PositionName { get; set; }
        public string InUserId { get; set; }
        public DateTime InDateTime { get; set; }
        public string Remark { get; set; }
        public char StatusType { get; set; }

    }
}
