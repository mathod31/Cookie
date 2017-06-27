//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Achievement
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AchievementRewardRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6377;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_achievementId;
        
        public virtual short AchievementId
        {
            get
            {
                return m_achievementId;
            }
            set
            {
                m_achievementId = value;
            }
        }
        
        public AchievementRewardRequestMessage(short achievementId)
        {
            m_achievementId = achievementId;
        }
        
        public AchievementRewardRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_achievementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_achievementId = reader.ReadShort();
        }
    }
}
