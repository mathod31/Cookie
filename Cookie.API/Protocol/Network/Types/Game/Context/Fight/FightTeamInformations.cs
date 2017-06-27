//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Fight
{
    
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class FightTeamInformations : AbstractFightTeamInformations
    {
        
        public new const short ProtocolId = 33;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<FightTeamMemberInformations> m_teamMembers;
        
        public virtual List<FightTeamMemberInformations> TeamMembers
        {
            get
            {
                return m_teamMembers;
            }
            set
            {
                m_teamMembers = value;
            }
        }
        
        public FightTeamInformations(List<FightTeamMemberInformations> teamMembers)
        {
            m_teamMembers = teamMembers;
        }
        
        public FightTeamInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_teamMembers.Count)));
            int teamMembersIndex;
            for (teamMembersIndex = 0; (teamMembersIndex < m_teamMembers.Count); teamMembersIndex = (teamMembersIndex + 1))
            {
                FightTeamMemberInformations objectToSend = m_teamMembers[teamMembersIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int teamMembersCount = reader.ReadUShort();
            int teamMembersIndex;
            m_teamMembers = new System.Collections.Generic.List<FightTeamMemberInformations>();
            for (teamMembersIndex = 0; (teamMembersIndex < teamMembersCount); teamMembersIndex = (teamMembersIndex + 1))
            {
                FightTeamMemberInformations objectToAdd = ProtocolTypeManager.GetInstance<FightTeamMemberInformations>((short)reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_teamMembers.Add(objectToAdd);
            }
        }
    }
}
