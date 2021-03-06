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
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
    {
        public new const uint ProtocolId = 5999;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItemNotInContainer m_objectInfo;
        
        public virtual ObjectItemNotInContainer ObjectInfo
        {
            get
            {
                return m_objectInfo;
            }
            set
            {
                m_objectInfo = value;
            }
        }
        
        public ExchangeCraftResultWithObjectDescMessage(ObjectItemNotInContainer objectInfo)
        {
            m_objectInfo = objectInfo;
        }
        
        public ExchangeCraftResultWithObjectDescMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_objectInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_objectInfo = new ObjectItemNotInContainer();
            m_objectInfo.Deserialize(reader);
        }
    }
}
