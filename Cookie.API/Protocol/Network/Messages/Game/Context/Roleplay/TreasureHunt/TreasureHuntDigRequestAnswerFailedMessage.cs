//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.TreasureHunt
{
    using Cookie.API.IO;


    public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
    {
        
        public new const uint ProtocolId = 6509;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_wrongFlagCount;
        
        public virtual byte WrongFlagCount
        {
            get
            {
                return m_wrongFlagCount;
            }
            set
            {
                m_wrongFlagCount = value;
            }
        }
        
        public TreasureHuntDigRequestAnswerFailedMessage(byte wrongFlagCount)
        {
            m_wrongFlagCount = wrongFlagCount;
        }
        
        public TreasureHuntDigRequestAnswerFailedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_wrongFlagCount);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_wrongFlagCount = reader.ReadByte();
        }
    }
}