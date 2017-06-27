//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Paddock
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay;
    using Cookie.API.Utils.IO;


    public class PaddockPrivateInformations : PaddockAbandonnedInformations
    {
        
        public new const short ProtocolId = 131;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildInformations m_guildInfo;
        
        public virtual GuildInformations GuildInfo
        {
            get
            {
                return m_guildInfo;
            }
            set
            {
                m_guildInfo = value;
            }
        }
        
        public PaddockPrivateInformations(GuildInformations guildInfo)
        {
            m_guildInfo = guildInfo;
        }
        
        public PaddockPrivateInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildInfo = new GuildInformations();
            m_guildInfo.Deserialize(reader);
        }
    }
}
