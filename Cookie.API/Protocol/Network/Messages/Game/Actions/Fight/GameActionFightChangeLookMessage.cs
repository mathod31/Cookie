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
    using Cookie.API.Protocol.Network.Types.Game.Look;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameActionFightChangeLookMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 5532;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_entityLook;
        
        public virtual EntityLook EntityLook
        {
            get
            {
                return m_entityLook;
            }
            set
            {
                m_entityLook = value;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        public GameActionFightChangeLookMessage(EntityLook entityLook, double targetId)
        {
            m_entityLook = entityLook;
            m_targetId = targetId;
        }
        
        public GameActionFightChangeLookMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_entityLook.Serialize(writer);
            writer.WriteDouble(m_targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_entityLook = new EntityLook();
            m_entityLook.Deserialize(reader);
            m_targetId = reader.ReadDouble();
        }
    }
}
