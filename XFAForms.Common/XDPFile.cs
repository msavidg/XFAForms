using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace XFAForms.Common
{
    [ProtoContract]
    public class XDPFile
    {
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [ProtoMember(2)]
        public String Filename { get; set; }

        [ProtoMember(3)]
        public Byte[] Document { get; set; }

        [ProtoMember(4)]
        public Boolean HasError { get; set; }

        [ProtoMember(5)]
        public String ErrorMessage { get; set; }

        [ProtoMember(6)]
        public Int32 ProcessingOrder { get; set; }
    }
}
