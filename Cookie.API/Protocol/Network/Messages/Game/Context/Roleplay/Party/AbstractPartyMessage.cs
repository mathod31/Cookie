//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class AbstractPartyMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6274;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_partyId;
        
        public virtual uint PartyId
        {
            get
            {
                return m_partyId;
            }
            set
            {
                m_partyId = value;
            }
        }
        
        public AbstractPartyMessage(uint partyId)
        {
            m_partyId = partyId;
        }
        
        public AbstractPartyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_partyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_partyId = reader.ReadVarUhInt();
        }
    }
}
