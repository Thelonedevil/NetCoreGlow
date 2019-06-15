namespace NetCoreGlow
{
    public class GL41 : GL40
    {

        public readonly uint
            SHADER_COMPILER = 0x8DFA,
            SHADER_BINARY_FORMATS = 0x8DF8,
            NUM_SHADER_BINARY_FORMATS = 0x8DF9,
            MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB,
            MAX_VARYING_VECTORS = 0x8DFC,
            MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD,
            IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,
            IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

        public readonly uint FIXED = 0x140C;

        public readonly uint
            LOW_FLOAT = 0x8DF0,
            MEDIUM_FLOAT = 0x8DF1,
            HIGH_FLOAT = 0x8DF2,
            LOW_INT = 0x8DF3,
            MEDIUM_INT = 0x8DF4,
            HIGH_INT = 0x8DF5;

        public readonly uint RGB565 = 0x8D62;

        public readonly uint PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

        public readonly uint PROGRAM_BINARY_LENGTH = 0x8741;

        public readonly uint
            NUM_PROGRAM_BINARY_FORMATS = 0x87FE,
            PROGRAM_BINARY_FORMATS = 0x87FF;

        public readonly uint
            VERTEX_SHADER_BIT = 0x1,
            FRAGMENT_SHADER_BIT = 0x2,
            GEOMETRY_SHADER_BIT = 0x4,
            TESS_CONTROL_SHADER_BIT = 0x8,
            TESS_EVALUATION_SHADER_BIT = 0x10,
            ALL_SHADER_BITS = 0xFFFFFFFF;

        public readonly uint PROGRAM_SEPARABLE = 0x8258;

        public readonly uint ACTIVE_PROGRAM = 0x8259;

        public readonly uint PROGRAM_PIPELINE_BINDING = 0x825A;

        public readonly uint
            MAX_VIEWPORTS = 0x825B,
            VIEWPORT_SUBPIXEL_BITS = 0x825C,
            VIEWPORT_BOUNDS_RANGE = 0x825D,
            LAYER_PROVOKING_VERTEX = 0x825E,
            VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

        public readonly uint UNDEFINED_VERTEX = 0x8260;


    }

}
