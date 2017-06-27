//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Character.Stats
{
    using Cookie.API.Protocol.Network.Types.Game.Character.Characteristic;
    using Cookie.API.Utils.IO;


    public class CharacterStatsListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 500;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterCharacteristicsInformations m_stats;
        
        public virtual CharacterCharacteristicsInformations Stats
        {
            get
            {
                return m_stats;
            }
            set
            {
                m_stats = value;
            }
        }
        
        public CharacterStatsListMessage(CharacterCharacteristicsInformations stats)
        {
            m_stats = stats;
        }
        
        public CharacterStatsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_stats.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_stats = new CharacterCharacteristicsInformations();
            m_stats.Deserialize(reader);
        }
    }
}
