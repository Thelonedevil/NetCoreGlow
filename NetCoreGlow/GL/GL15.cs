namespace NetCoreGlow
{
    public class GL15 : GL14
    {

        public readonly uint SRC1_ALPHA = 0x8589;

        public readonly uint
            ARRAY_BUFFER = 0x8892,
            ELEMENT_ARRAY_BUFFER = 0x8893;

        public readonly uint
            ARRAY_BUFFER_BINDING = 0x8894,
            ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

        public readonly uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

        public readonly uint
            STREAM_DRAW = 0x88E0,
            STREAM_READ = 0x88E1,
            STREAM_COPY = 0x88E2,
            STATIC_DRAW = 0x88E4,
            STATIC_READ = 0x88E5,
            STATIC_COPY = 0x88E6,
            DYNAMIC_DRAW = 0x88E8,
            DYNAMIC_READ = 0x88E9,
            DYNAMIC_COPY = 0x88EA;

        public readonly uint
            READ_ONLY = 0x88B8,
            WRITE_ONLY = 0x88B9,
            READ_WRITE = 0x88BA;

        public readonly uint
            BUFFER_SIZE = 0x8764,
            BUFFER_USAGE = 0x8765,
            BUFFER_ACCESS = 0x88BB,
            BUFFER_MAPPED = 0x88BC;

        public readonly uint BUFFER_MAP_POINTER = 0x88BD;

        public readonly uint SAMPLES_PASSED = 0x8914;

        public readonly uint
            QUERY_COUNTER_BITS = 0x8864,
            CURRENT_QUERY = 0x8865;

        public readonly uint
            QUERY_RESULT = 0x8866,
            QUERY_RESULT_AVAILABLE = 0x8867;


    }

}
