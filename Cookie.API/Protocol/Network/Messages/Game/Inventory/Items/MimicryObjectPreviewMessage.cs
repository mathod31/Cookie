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
    using Cookie.API.Protocol.Network.Types.Game.Data.Items;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class MimicryObjectPreviewMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6458;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ObjectItem m_result;
        
        public virtual ObjectItem Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public MimicryObjectPreviewMessage(ObjectItem result)
        {
            m_result = result;
        }
        
        public MimicryObjectPreviewMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_result.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_result = new ObjectItem();
            m_result.Deserialize(reader);
        }
    }
}
