//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.API.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 5741;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_markId;
        
        public virtual short MarkId
        {
            get
            {
                return m_markId;
            }
            set
            {
                m_markId = value;
            }
        }
        
        private double m_triggeringCharacterId;
        
        public virtual double TriggeringCharacterId
        {
            get
            {
                return m_triggeringCharacterId;
            }
            set
            {
                m_triggeringCharacterId = value;
            }
        }
        
        private ushort m_triggeredSpellId;
        
        public virtual ushort TriggeredSpellId
        {
            get
            {
                return m_triggeredSpellId;
            }
            set
            {
                m_triggeredSpellId = value;
            }
        }
        
        public GameActionFightTriggerGlyphTrapMessage(short markId, double triggeringCharacterId, ushort triggeredSpellId)
        {
            m_markId = markId;
            m_triggeringCharacterId = triggeringCharacterId;
            m_triggeredSpellId = triggeredSpellId;
        }
        
        public GameActionFightTriggerGlyphTrapMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_markId);
            writer.WriteDouble(m_triggeringCharacterId);
            writer.WriteVarUhShort(m_triggeredSpellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_markId = reader.ReadShort();
            m_triggeringCharacterId = reader.ReadDouble();
            m_triggeredSpellId = reader.ReadVarUhShort();
        }
    }
}
