//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Context.Roleplay
{
    using Cookie.API.Protocol.Network.Types.Game.Look;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class HumanOptionFollowers : HumanOption
    {
        
        public new const short ProtocolId = 410;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<IndexedEntityLook> m_followingCharactersLook;
        
        public virtual List<IndexedEntityLook> FollowingCharactersLook
        {
            get
            {
                return m_followingCharactersLook;
            }
            set
            {
                m_followingCharactersLook = value;
            }
        }
        
        public HumanOptionFollowers(List<IndexedEntityLook> followingCharactersLook)
        {
            m_followingCharactersLook = followingCharactersLook;
        }
        
        public HumanOptionFollowers()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_followingCharactersLook.Count)));
            int followingCharactersLookIndex;
            for (followingCharactersLookIndex = 0; (followingCharactersLookIndex < m_followingCharactersLook.Count); followingCharactersLookIndex = (followingCharactersLookIndex + 1))
            {
                IndexedEntityLook objectToSend = m_followingCharactersLook[followingCharactersLookIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int followingCharactersLookCount = reader.ReadUShort();
            int followingCharactersLookIndex;
            m_followingCharactersLook = new System.Collections.Generic.List<IndexedEntityLook>();
            for (followingCharactersLookIndex = 0; (followingCharactersLookIndex < followingCharactersLookCount); followingCharactersLookIndex = (followingCharactersLookIndex + 1))
            {
                IndexedEntityLook objectToAdd = new IndexedEntityLook();
                objectToAdd.Deserialize(reader);
                m_followingCharactersLook.Add(objectToAdd);
            }
        }
    }
}
