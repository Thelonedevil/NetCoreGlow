namespace NetCoreGlow
{
    public class GL40 : GL33
    {

        public readonly uint DRAW_INDIRECT_BUFFER = 0x8F3F;

        public readonly uint DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;

        public readonly uint GEOMETRY_SHADER_INVOCATIONS = 0x887F;

        public readonly uint
            MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A,
            MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B,
            MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C,
            FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;

        public readonly uint
            DOUBLE_VEC2 = 0x8FFC,
            DOUBLE_VEC3 = 0x8FFD,
            DOUBLE_VEC4 = 0x8FFE,
            DOUBLE_MAT2 = 0x8F46,
            DOUBLE_MAT3 = 0x8F47,
            DOUBLE_MAT4 = 0x8F48,
            DOUBLE_MAT2x3 = 0x8F49,
            DOUBLE_MAT2x4 = 0x8F4A,
            DOUBLE_MAT3x2 = 0x8F4B,
            DOUBLE_MAT3x4 = 0x8F4C,
            DOUBLE_MAT4x2 = 0x8F4D,
            DOUBLE_MAT4x3 = 0x8F4E;

        public readonly uint SAMPLE_SHADING = 0x8C36;

        public readonly uint MIN_SAMPLE_SHADING_VALUE = 0x8C37;

        public readonly uint
            ACTIVE_SUBROUTINES = 0x8DE5,
            ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6,
            ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47,
            ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48,
            ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;

        public readonly uint
            MAX_SUBROUTINES = 0x8DE7,
            MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;

        public readonly uint
            NUM_COMPATIBLE_SUBROUTINES = 0x8E4A,
            COMPATIBLE_SUBROUTINES = 0x8E4B;

        public readonly uint PATCHES = 0xE;

        public readonly uint PATCH_VERTICES = 0x8E72;

        public readonly uint
            PATCH_DEFAULT_INNER_LEVEL = 0x8E73,
            PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;

        public readonly uint
            TESS_CONTROL_OUTPUT_VERTICES = 0x8E75,
            TESS_GEN_MODE = 0x8E76,
            TESS_GEN_SPACING = 0x8E77,
            TESS_GEN_VERTEX_ORDER = 0x8E78,
            TESS_GEN_POINT_MODE = 0x8E79;

        public readonly uint ISOLINES = 0x8E7A;

        public readonly uint
            FRACTIONAL_ODD = 0x8E7B,
            FRACTIONAL_EVEN = 0x8E7C;

        public readonly uint
            MAX_PATCH_VERTICES = 0x8E7D,
            MAX_TESS_GEN_LEVEL = 0x8E7E,
            MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F,
            MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80,
            MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81,
            MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82,
            MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83,
            MAX_TESS_PATCH_COMPONENTS = 0x8E84,
            MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85,
            MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86,
            MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89,
            MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A,
            MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C,
            MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D,
            MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E,
            MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;

        public readonly uint
            UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0,
            UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;

        public readonly uint
            TESS_EVALUATION_SHADER = 0x8E87,
            TESS_CONTROL_SHADER = 0x8E88;

        public readonly uint TEXTURE_CUBE_MAP_ARRAY = 0x9009;

        public readonly uint TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;

        public readonly uint PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;

        public readonly uint
            SAMPLER_CUBE_MAP_ARRAY = 0x900C,
            SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,
            INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,
            UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;

        public readonly uint
            MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E,
            MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;

        public readonly uint TRANSFORM_FEEDBACK = 0x8E22;

        public readonly uint
            TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23,
            TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24,
            TRANSFORM_FEEDBACK_BINDING = 0x8E25;

        public readonly uint
            MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70,
            MAX_VERTEX_STREAMS = 0x8E71;


    }

}
