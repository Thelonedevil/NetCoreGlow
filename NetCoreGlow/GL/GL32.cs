namespace NetCoreGlow
{
    public class GL32 : GL31
    {

        public readonly uint CONTEXT_PROFILE_MASK = 0x9126;

        public readonly uint
            CONTEXT_CORE_PROFILE_BIT = 0x1,
            CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x2;

        public readonly uint
            MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122,
            MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123,
            MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124,
            MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;

        public readonly uint
            FIRST_VERTEX_CONVENTION = 0x8E4D,
            LAST_VERTEX_CONVENTION = 0x8E4E;

        public readonly uint
            PROVOKING_VERTEX = 0x8E4F,
            QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;

        public readonly uint TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;

        public readonly uint SAMPLE_POSITION = 0x8E50;

        public readonly uint SAMPLE_MASK = 0x8E51;

        public readonly uint SAMPLE_MASK_VALUE = 0x8E52;

        public readonly uint TEXTURE_2D_MULTISAMPLE = 0x9100;

        public readonly uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;

        public readonly uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;

        public readonly uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;

        public readonly uint
            MAX_SAMPLE_MASK_WORDS = 0x8E59,
            MAX_COLOR_TEXTURE_SAMPLES = 0x910E,
            MAX_DEPTH_TEXTURE_SAMPLES = 0x910F,
            MAX_INTEGER_SAMPLES = 0x9110,
            TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104,
            TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;

        public readonly uint
            TEXTURE_SAMPLES = 0x9106,
            TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;

        public readonly uint
            SAMPLER_2D_MULTISAMPLE = 0x9108,
            INT_SAMPLER_2D_MULTISAMPLE = 0x9109,
            UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,
            SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,
            INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,
            UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;

        public readonly uint DEPTH_CLAMP = 0x864F;

        public readonly uint GEOMETRY_SHADER = 0x8DD9;

        public readonly uint
            GEOMETRY_VERTICES_OUT = 0x8DDA,
            GEOMETRY_INPUT_TYPE = 0x8DDB,
            GEOMETRY_OUTPUT_TYPE = 0x8DDC;

        public readonly uint
            MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29,
            MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF,
            MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0,
            MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;

        public readonly uint
            LINES_ADJACENCY = 0xA,
            LINE_STRIP_ADJACENCY = 0xB,
            TRIANGLES_ADJACENCY = 0xC,
            TRIANGLE_STRIP_ADJACENCY = 0xD;

        public readonly uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;

        public readonly uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;

        public readonly uint PROGRAM_POINT_SIZE = 0x8642;

        public readonly uint MAX_SERVER_WAIT_TIMEOUT = 0x9111;

        public readonly uint
            OBJECT_TYPE = 0x9112,
            SYNC_CONDITION = 0x9113,
            SYNC_STATUS = 0x9114,
            SYNC_FLAGS = 0x9115;

        public readonly uint SYNC_FENCE = 0x9116;

        public readonly uint SYNC_GPU_COMMANDS_COMPLETE = 0x9117;

        public readonly uint
            UNSIGNALED = 0x9118,
            SIGNALED = 0x9119;

        public readonly uint SYNC_FLUSH_COMMANDS_BIT = 0x1;

        public readonly ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFFL;

        public readonly uint
            ALREADY_SIGNALED = 0x911A,
            TIMEOUT_EXPIRED = 0x911B,
            CONDITION_SATISFIED = 0x911C,
            WAIT_FAILED = 0x911D;


    }

}
