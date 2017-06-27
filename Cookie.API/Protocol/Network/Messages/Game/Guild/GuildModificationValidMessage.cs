//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Guild
{
    using Cookie.API.Protocol.Network.Types.Game.Guild;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildModificationValidMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6323;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_guildEmblem;
        
        public virtual GuildEmblem GuildEmblem
        {
            get
            {
                return m_guildEmblem;
            }
            set
            {
                m_guildEmblem = value;
            }
        }
        
        private string m_guildName;
        
        public virtual string GuildName
        {
            get
            {
                return m_guildName;
            }
            set
            {
                m_guildName = value;
            }
        }
        
        public GuildModificationValidMessage(GuildEmblem guildEmblem, string guildName)
        {
            m_guildEmblem = guildEmblem;
            m_guildName = guildName;
        }
        
        public GuildModificationValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_guildEmblem.Serialize(writer);
            writer.WriteUTF(m_guildName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildEmblem = new GuildEmblem();
            m_guildEmblem.Deserialize(reader);
            m_guildName = reader.ReadUTF();
        }
    }
}
