//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectFoundWhileRecoltingMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6017;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_genericId;
        
        public virtual ushort GenericId
        {
            get
            {
                return m_genericId;
            }
            set
            {
                m_genericId = value;
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
        
        private uint m_resourceGenericId;
        
        public virtual uint ResourceGenericId
        {
            get
            {
                return m_resourceGenericId;
            }
            set
            {
                m_resourceGenericId = value;
            }
        }
        
        public ObjectFoundWhileRecoltingMessage(ushort genericId, uint quantity, uint resourceGenericId)
        {
            m_genericId = genericId;
            m_quantity = quantity;
            m_resourceGenericId = resourceGenericId;
        }
        
        public ObjectFoundWhileRecoltingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhShort(m_genericId);
            writer.WriteVarUhInt(m_quantity);
            writer.WriteVarUhInt(m_resourceGenericId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_genericId = reader.ReadVarUhShort();
            m_quantity = reader.ReadVarUhInt();
            m_resourceGenericId = reader.ReadVarUhInt();
        }
    }
}
