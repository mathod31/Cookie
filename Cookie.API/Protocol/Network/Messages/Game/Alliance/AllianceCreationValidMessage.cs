//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Alliance
{
    using Cookie.API.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AllianceCreationValidMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6393;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_allianceEmblem;
        
        public virtual GuildEmblem AllianceEmblem
        {
            get
            {
                return m_allianceEmblem;
            }
            set
            {
                m_allianceEmblem = value;
            }
        }
        
        private string m_allianceName;
        
        public virtual string AllianceName
        {
            get
            {
                return m_allianceName;
            }
            set
            {
                m_allianceName = value;
            }
        }
        
        private string m_allianceTag;
        
        public virtual string AllianceTag
        {
            get
            {
                return m_allianceTag;
            }
            set
            {
                m_allianceTag = value;
            }
        }
        
        public AllianceCreationValidMessage(GuildEmblem allianceEmblem, string allianceName, string allianceTag)
        {
            m_allianceEmblem = allianceEmblem;
            m_allianceName = allianceName;
            m_allianceTag = allianceTag;
        }
        
        public AllianceCreationValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_allianceEmblem.Serialize(writer);
            writer.WriteUTF(m_allianceName);
            writer.WriteUTF(m_allianceTag);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allianceEmblem = new GuildEmblem();
            m_allianceEmblem.Deserialize(reader);
            m_allianceName = reader.ReadUTF();
            m_allianceTag = reader.ReadUTF();
        }
    }
}
