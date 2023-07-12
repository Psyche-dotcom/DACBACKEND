using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacBackend.Model.Dto
{
    public class BvnResponseDto
    {
        public string Bvn { get; set; }
        public string RequestId { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}
