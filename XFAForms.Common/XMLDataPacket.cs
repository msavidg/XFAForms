using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace XFAForms.Common
{
    [ProtoContract]
    public class XMLDataPacket
    {
        [ProtoMember(1)]
        public Guid Id { get; set; }
        [ProtoMember(2)]
        public String Filename { get; set; }
    }
}
