namespace NetCoreGlow
{
    public class GL44 : GL43
    {

        public readonly uint MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

        public readonly uint PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

        public readonly uint TEXTURE_BUFFER_BINDING = 0x8C2A;

        public readonly uint
            MAP_PERSISTENT_BIT = 0x40,
            MAP_COHERENT_BIT = 0x80,
            DYNAMIC_STORAGE_BIT = 0x100,
            CLIENT_STORAGE_BIT = 0x200;

        public readonly uint
            BUFFER_IMMUTABLE_STORAGE = 0x821F,
            BUFFER_STORAGE_FLAGS = 0x8220;

        public readonly uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x4000;

        public readonly uint CLEAR_TEXTURE = 0x9365;

        public readonly uint
            LOCATION_COMPONENT = 0x934A,
            TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B,
            TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

        public readonly uint QUERY_RESULT_NO_WAIT = 0x9194;

        public readonly uint QUERY_BUFFER = 0x9192;

        public readonly uint QUERY_BUFFER_BINDING = 0x9193;

        public readonly uint QUERY_BUFFER_BARRIER_BIT = 0x8000;

        public readonly uint MIRROR_CLAMP_TO_EDGE = 0x8743;


    }

}
