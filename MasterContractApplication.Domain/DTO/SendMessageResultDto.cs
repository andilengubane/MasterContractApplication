using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Domain.DTO
{
    public class SendMessageResultDto
    {
        public bool Ok { get; }
        public int Status { get; }
        public string Message { get; } = string.Empty;
        public  SendMessageDataDto Data { get; } = new SendMessageDataDto();
    }
}
