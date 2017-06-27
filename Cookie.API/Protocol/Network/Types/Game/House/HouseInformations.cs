//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.House
{
    using Cookie.API.Utils.IO;


    public class HouseInformations : NetworkType
    {
        
        public const short ProtocolId = 111;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private ushort m_modelId;
        
        public virtual ushort ModelId
        {
            get
            {
                return m_modelId;
            }
            set
            {
                m_modelId = value;
            }
        }
        
        public HouseInformations(uint houseId, ushort modelId)
        {
            m_houseId = houseId;
            m_modelId = modelId;
        }
        
        public HouseInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_houseId);
            writer.WriteVarUhShort(m_modelId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_houseId = reader.ReadVarUhInt();
            m_modelId = reader.ReadVarUhShort();
        }
    }
}
