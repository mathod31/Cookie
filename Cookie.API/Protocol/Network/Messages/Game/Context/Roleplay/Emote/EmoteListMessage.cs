//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Emote
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class EmoteListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5689;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.SByte> m_emoteIds;
        
        public virtual List<System.SByte> EmoteIds
        {
            get
            {
                return m_emoteIds;
            }
            set
            {
                m_emoteIds = value;
            }
        }
        
        public EmoteListMessage(List<System.SByte> emoteIds)
        {
            m_emoteIds = emoteIds;
        }
        
        public EmoteListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_emoteIds.Count)));
            int emoteIdsIndex;
            for (emoteIdsIndex = 0; (emoteIdsIndex < m_emoteIds.Count); emoteIdsIndex = (emoteIdsIndex + 1))
            {
                writer.WriteSByte(m_emoteIds[emoteIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int emoteIdsCount = reader.ReadUShort();
            int emoteIdsIndex;
            m_emoteIds = new System.Collections.Generic.List<sbyte>();
            for (emoteIdsIndex = 0; (emoteIdsIndex < emoteIdsCount); emoteIdsIndex = (emoteIdsIndex + 1))
            {
                m_emoteIds.Add(reader.ReadSByte());
            }
        }
    }
}
