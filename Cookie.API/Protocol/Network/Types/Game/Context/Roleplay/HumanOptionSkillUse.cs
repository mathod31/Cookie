//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HumanOptionSkillUse : HumanOption
    {
        
        public new const short ProtocolId = 495;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_elementId;
        
        public virtual uint ElementId
        {
            get
            {
                return m_elementId;
            }
            set
            {
                m_elementId = value;
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
        
        private double m_skillEndTime;
        
        public virtual double SkillEndTime
        {
            get
            {
                return m_skillEndTime;
            }
            set
            {
                m_skillEndTime = value;
            }
        }
        
        public HumanOptionSkillUse(uint elementId, ushort skillId, double skillEndTime)
        {
            m_elementId = elementId;
            m_skillId = skillId;
            m_skillEndTime = skillEndTime;
        }
        
        public HumanOptionSkillUse()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_elementId);
            writer.WriteVarUhShort(m_skillId);
            writer.WriteDouble(m_skillEndTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_elementId = reader.ReadVarUhInt();
            m_skillId = reader.ReadVarUhShort();
            m_skillEndTime = reader.ReadDouble();
        }
    }
}
