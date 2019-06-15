namespace NetCoreGlow
{
    public class GL46 : GL45
    {

        public readonly uint PARAMETER_BUFFER = 0x80EE;

        public readonly uint PARAMETER_BUFFER_BINDING = 0x80EF;

        public readonly uint
            VERTICES_SUBMITTED = 0x82EE,
            PRIMITIVES_SUBMITTED = 0x82EF,
            VERTEX_SHADER_INVOCATIONS = 0x82F0,
            TESS_CONTROL_SHADER_PATCHES = 0x82F1,
            TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2,
            GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3,
            FRAGMENT_SHADER_INVOCATIONS = 0x82F4,
            COMPUTE_SHADER_INVOCATIONS = 0x82F5,
            CLIPPING_INPUT_PRIMITIVES = 0x82F6,
            CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;

        public readonly uint POLYGON_OFFSET_CLAMP = 0x8E1B;

        public readonly uint CONTEXT_FLAG_NO_ERROR_BIT = 0x8;

        public readonly uint SHADER_BINARY_FORMAT_SPIR_V = 0x9551;

        public readonly uint SPIR_V_BINARY = 0x9552;

        public readonly uint SPIR_V_EXTENSIONS = 0x9553;

        public readonly uint NUM_SPIR_V_EXTENSIONS = 0x9554;

        public readonly uint TEXTURE_MAX_ANISOTROPY = 0x84FE;

        public readonly uint MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;

        public readonly uint
            TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC,
            TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;


    }

}
