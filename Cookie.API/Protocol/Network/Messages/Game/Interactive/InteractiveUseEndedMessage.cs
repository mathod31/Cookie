//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Interactive
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class InteractiveUseEndedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6112;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_elemId;
        
        public virtual uint ElemId
        {
            get
            {
                return m_elemId;
            }
            set
            {
                m_elemId = value;
            }
        }
        
        private ushort m_skillId;
        
        public virtual ushort SkillId
        {
            get
            {
                return m_skillId;
            }
            set
            {
                m_skillId = value;
            }
        }
        
        public InteractiveUseEndedMessage(uint elemId, ushort skillId)
        {
            m_elemId = elemId;
            m_skillId = skillId;
        }
        
        public InteractiveUseEndedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_elemId);
            writer.WriteVarUhShort(m_skillId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_elemId = reader.ReadVarUhInt();
            m_skillId = reader.ReadVarUhShort();
        }
    }
}
