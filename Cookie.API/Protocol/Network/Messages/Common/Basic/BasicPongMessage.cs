//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Common.Basic
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class BasicPongMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 183;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_quiet;
        
        public virtual bool Quiet
        {
            get
            {
                return m_quiet;
            }
            set
            {
                m_quiet = value;
            }
        }
        
        public BasicPongMessage(bool quiet)
        {
            m_quiet = quiet;
        }
        
        public BasicPongMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_quiet);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_quiet = reader.ReadBoolean();
        }
    }
}
