using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestService.Dto
{
    public class RequestDto
    {
        public IEnumerable<int> numbers { get; set; }
    }
}
