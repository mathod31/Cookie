//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Script
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class URLOpenMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6266;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_urlId;
        
        public virtual byte UrlId
        {
            get
            {
                return m_urlId;
            }
            set
            {
                m_urlId = value;
            }
        }
        
        public URLOpenMessage(byte urlId)
        {
            m_urlId = urlId;
        }
        
        public URLOpenMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_urlId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_urlId = reader.ReadByte();
        }
    }
}
