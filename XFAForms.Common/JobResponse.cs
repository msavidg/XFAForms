using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace XFAForms.Common
{
    [ProtoContract]
    public class JobResponse
    {

        [ProtoMember(1)]
        public String Data { get; set; }

        [ProtoMember(2)]
        public List<String> Forms { get; set; }

        public JobResponse()
        {
            this.Data = null;
            this.Forms = new List<string>();
        }
    }
}
