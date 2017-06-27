//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Authorized
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ConsoleCommandsListMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6127;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.String> m_aliases;
        
        public virtual List<System.String> Aliases
        {
            get
            {
                return m_aliases;
            }
            set
            {
                m_aliases = value;
            }
        }
        
        private List<System.String> m_args;
        
        public virtual List<System.String> Args
        {
            get
            {
                return m_args;
            }
            set
            {
                m_args = value;
            }
        }
        
        private List<System.String> m_descriptions;
        
        public virtual List<System.String> Descriptions
        {
            get
            {
                return m_descriptions;
            }
            set
            {
                m_descriptions = value;
            }
        }
        
        public ConsoleCommandsListMessage(List<System.String> aliases, List<System.String> args, List<System.String> descriptions)
        {
            m_aliases = aliases;
            m_args = args;
            m_descriptions = descriptions;
        }
        
        public ConsoleCommandsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_aliases.Count)));
            int aliasesIndex;
            for (aliasesIndex = 0; (aliasesIndex < m_aliases.Count); aliasesIndex = (aliasesIndex + 1))
            {
                writer.WriteUTF(m_aliases[aliasesIndex]);
            }
            writer.WriteShort(((short)(m_args.Count)));
            int argsIndex;
            for (argsIndex = 0; (argsIndex < m_args.Count); argsIndex = (argsIndex + 1))
            {
                writer.WriteUTF(m_args[argsIndex]);
            }
            writer.WriteShort(((short)(m_descriptions.Count)));
            int descriptionsIndex;
            for (descriptionsIndex = 0; (descriptionsIndex < m_descriptions.Count); descriptionsIndex = (descriptionsIndex + 1))
            {
                writer.WriteUTF(m_descriptions[descriptionsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int aliasesCount = reader.ReadUShort();
            int aliasesIndex;
            m_aliases = new System.Collections.Generic.List<string>();
            for (aliasesIndex = 0; (aliasesIndex < aliasesCount); aliasesIndex = (aliasesIndex + 1))
            {
                m_aliases.Add(reader.ReadUTF());
            }
            int argsCount = reader.ReadUShort();
            int argsIndex;
            m_args = new System.Collections.Generic.List<string>();
            for (argsIndex = 0; (argsIndex < argsCount); argsIndex = (argsIndex + 1))
            {
                m_args.Add(reader.ReadUTF());
            }
            int descriptionsCount = reader.ReadUShort();
            int descriptionsIndex;
            m_descriptions = new System.Collections.Generic.List<string>();
            for (descriptionsIndex = 0; (descriptionsIndex < descriptionsCount); descriptionsIndex = (descriptionsIndex + 1))
            {
                m_descriptions.Add(reader.ReadUTF());
            }
        }
    }
}
