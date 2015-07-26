using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.Serialization;
using ProtoBuf;

namespace XFAForms.Common
{
    [ProtoContract]
    public class JobRequest
    {

        [ProtoMember(1)]
        public String Data { get; set; }

        [ProtoMember(2)]
        public List<XMLDataPacket> Forms { get; set; }

        public JobRequest()
        {
            this.Data = null;
            this.Forms = new List<XMLDataPacket>();
        }
    }
}
