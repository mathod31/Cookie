//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Shortcut
{
    using Cookie.API.Utils.IO;


    public class ShortcutObjectPreset : ShortcutObject
    {
        
        public new const short ProtocolId = 370;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        public ShortcutObjectPreset(byte presetId)
        {
            m_presetId = presetId;
        }
        
        public ShortcutObjectPreset()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_presetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_presetId = reader.ReadByte();
        }
    }
}
