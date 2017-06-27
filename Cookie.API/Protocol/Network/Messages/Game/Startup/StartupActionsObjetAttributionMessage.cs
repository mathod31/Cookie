//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Startup
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class StartupActionsObjetAttributionMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 1303;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_actionId;
        
        public virtual int ActionId
        {
            get
            {
                return m_actionId;
            }
            set
            {
                m_actionId = value;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public StartupActionsObjetAttributionMessage(int actionId, ulong characterId)
        {
            m_actionId = actionId;
            m_characterId = characterId;
        }
        
        public StartupActionsObjetAttributionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_actionId);
            writer.WriteVarUhLong(m_characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_actionId = reader.ReadInt();
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
