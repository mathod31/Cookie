//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeBuyMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5774;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectToBuyId;
        
        public virtual uint ObjectToBuyId
        {
            get
            {
                return m_objectToBuyId;
            }
            set
            {
                m_objectToBuyId = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            m_objectToBuyId = objectToBuyId;
            m_quantity = quantity;
        }
        
        public ExchangeBuyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_objectToBuyId);
            writer.WriteVarUhInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectToBuyId = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
