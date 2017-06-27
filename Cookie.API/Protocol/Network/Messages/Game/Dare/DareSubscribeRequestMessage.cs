//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Dare
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class DareSubscribeRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6666;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        private bool m_subscribe;
        
        public virtual bool Subscribe
        {
            get
            {
                return m_subscribe;
            }
            set
            {
                m_subscribe = value;
            }
        }
        
        public DareSubscribeRequestMessage(double dareId, bool subscribe)
        {
            m_dareId = dareId;
            m_subscribe = subscribe;
        }
        
        public DareSubscribeRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_dareId);
            writer.WriteBoolean(m_subscribe);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dareId = reader.ReadDouble();
            m_subscribe = reader.ReadBoolean();
        }
    }
}
