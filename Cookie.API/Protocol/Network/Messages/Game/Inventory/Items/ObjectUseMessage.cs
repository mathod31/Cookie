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
    
    
    public class ObjectUseMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 3019;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        public ObjectUseMessage(uint objectUID)
        {
            m_objectUID = objectUID;
        }
        
        public ObjectUseMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectUID = reader.ReadVarUhInt();
        }
    }
}
