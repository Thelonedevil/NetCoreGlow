namespace NetCoreGlow
{
    public class GL30 : GL21
    {

        public readonly uint
            MAJOR_VERSION = 0x821B,
            MINOR_VERSION = 0x821C,
            NUM_EXTENSIONS = 0x821D,
            CONTEXT_FLAGS = 0x821E,
            CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x1;

        public readonly uint
            COMPARE_REF_TO_TEXTURE = 0x884E,
            CLIP_DISTANCE0 = 0x3000,
            CLIP_DISTANCE1 = 0x3001,
            CLIP_DISTANCE2 = 0x3002,
            CLIP_DISTANCE3 = 0x3003,
            CLIP_DISTANCE4 = 0x3004,
            CLIP_DISTANCE5 = 0x3005,
            CLIP_DISTANCE6 = 0x3006,
            CLIP_DISTANCE7 = 0x3007,
            MAX_CLIP_DISTANCES = 0xD32,
            MAX_VARYING_COMPONENTS = 0x8B4B;

        public readonly uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

        public readonly uint
            SAMPLER_1D_ARRAY = 0x8DC0,
            SAMPLER_2D_ARRAY = 0x8DC1,
            SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,
            SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,
            SAMPLER_CUBE_SHADOW = 0x8DC5,
            UNSIGNED_INT_VEC2 = 0x8DC6,
            UNSIGNED_INT_VEC3 = 0x8DC7,
            UNSIGNED_INT_VEC4 = 0x8DC8,
            INT_SAMPLER_1D = 0x8DC9,
            INT_SAMPLER_2D = 0x8DCA,
            INT_SAMPLER_3D = 0x8DCB,
            INT_SAMPLER_CUBE = 0x8DCC,
            INT_SAMPLER_1D_ARRAY = 0x8DCE,
            INT_SAMPLER_2D_ARRAY = 0x8DCF,
            UNSIGNED_INT_SAMPLER_1D = 0x8DD1,
            UNSIGNED_INT_SAMPLER_2D = 0x8DD2,
            UNSIGNED_INT_SAMPLER_3D = 0x8DD3,
            UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,
            UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,
            UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

        public readonly uint
            MIN_PROGRAM_TEXEL_OFFSET = 0x8904,
            MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

        public readonly uint
            QUERY_WAIT = 0x8E13,
            QUERY_NO_WAIT = 0x8E14,
            QUERY_BY_REGION_WAIT = 0x8E15,
            QUERY_BY_REGION_NO_WAIT = 0x8E16;

        public readonly uint
            MAP_READ_BIT = 0x1,
            MAP_WRITE_BIT = 0x2,
            MAP_INVALIDATE_RANGE_BIT = 0x4,
            MAP_INVALIDATE_BUFFER_BIT = 0x8,
            MAP_FLUSH_EXPLICIT_BIT = 0x10,
            MAP_UNSYNCHRONIZED_BIT = 0x20;

        public readonly uint
            BUFFER_ACCESS_FLAGS = 0x911F,
            BUFFER_MAP_LENGTH = 0x9120,
            BUFFER_MAP_OFFSET = 0x9121;

        public readonly uint CLAMP_READ_COLOR = 0x891C;

        public readonly uint FIXED_ONLY = 0x891D;

        public readonly uint
            DEPTH_COMPONENT32F = 0x8CAC,
            DEPTH32F_STENCIL8 = 0x8CAD;

        public readonly uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

        public readonly uint
            TEXTURE_RED_TYPE = 0x8C10,
            TEXTURE_GREEN_TYPE = 0x8C11,
            TEXTURE_BLUE_TYPE = 0x8C12,
            TEXTURE_ALPHA_TYPE = 0x8C13,
            TEXTURE_DEPTH_TYPE = 0x8C16;

        public readonly uint UNSIGNED_NORMALIZED = 0x8C17;

        public readonly uint
            RGBA32F = 0x8814,
            RGB32F = 0x8815,
            RGBA16F = 0x881A,
            RGB16F = 0x881B;

        public readonly uint R11F_G11F_B10F = 0x8C3A;

        public readonly uint UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

        public readonly uint RGB9_E5 = 0x8C3D;

        public readonly uint UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

        public readonly uint TEXTURE_SHARED_SIZE = 0x8C3F;

        public readonly uint
            FRAMEBUFFER = 0x8D40,
            READ_FRAMEBUFFER = 0x8CA8,
            DRAW_FRAMEBUFFER = 0x8CA9;

        public readonly uint RENDERBUFFER = 0x8D41;

        public readonly uint
            STENCIL_INDEX1 = 0x8D46,
            STENCIL_INDEX4 = 0x8D47,
            STENCIL_INDEX8 = 0x8D48,
            STENCIL_INDEX16 = 0x8D49;

        public readonly uint
            RENDERBUFFER_WIDTH = 0x8D42,
            RENDERBUFFER_HEIGHT = 0x8D43,
            RENDERBUFFER_INTERNAL_FORMAT = 0x8D44,
            RENDERBUFFER_RED_SIZE = 0x8D50,
            RENDERBUFFER_GREEN_SIZE = 0x8D51,
            RENDERBUFFER_BLUE_SIZE = 0x8D52,
            RENDERBUFFER_ALPHA_SIZE = 0x8D53,
            RENDERBUFFER_DEPTH_SIZE = 0x8D54,
            RENDERBUFFER_STENCIL_SIZE = 0x8D55,
            RENDERBUFFER_SAMPLES = 0x8CAB;

        public readonly uint
            FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0,
            FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3,
            FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4,
            FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210,
            FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211,
            FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212,
            FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213,
            FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214,
            FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215,
            FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216,
            FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

        public readonly uint FRAMEBUFFER_DEFAULT = 0x8218;

        public readonly uint
            COLOR_ATTACHMENT0 = 0x8CE0,
            COLOR_ATTACHMENT1 = 0x8CE1,
            COLOR_ATTACHMENT2 = 0x8CE2,
            COLOR_ATTACHMENT3 = 0x8CE3,
            COLOR_ATTACHMENT4 = 0x8CE4,
            COLOR_ATTACHMENT5 = 0x8CE5,
            COLOR_ATTACHMENT6 = 0x8CE6,
            COLOR_ATTACHMENT7 = 0x8CE7,
            COLOR_ATTACHMENT8 = 0x8CE8,
            COLOR_ATTACHMENT9 = 0x8CE9,
            COLOR_ATTACHMENT10 = 0x8CEA,
            COLOR_ATTACHMENT11 = 0x8CEB,
            COLOR_ATTACHMENT12 = 0x8CEC,
            COLOR_ATTACHMENT13 = 0x8CED,
            COLOR_ATTACHMENT14 = 0x8CEE,
            COLOR_ATTACHMENT15 = 0x8CEF,
            COLOR_ATTACHMENT16 = 0x8CF0,
            COLOR_ATTACHMENT17 = 0x8CF1,
            COLOR_ATTACHMENT18 = 0x8CF2,
            COLOR_ATTACHMENT19 = 0x8CF3,
            COLOR_ATTACHMENT20 = 0x8CF4,
            COLOR_ATTACHMENT21 = 0x8CF5,
            COLOR_ATTACHMENT22 = 0x8CF6,
            COLOR_ATTACHMENT23 = 0x8CF7,
            COLOR_ATTACHMENT24 = 0x8CF8,
            COLOR_ATTACHMENT25 = 0x8CF9,
            COLOR_ATTACHMENT26 = 0x8CFA,
            COLOR_ATTACHMENT27 = 0x8CFB,
            COLOR_ATTACHMENT28 = 0x8CFC,
            COLOR_ATTACHMENT29 = 0x8CFD,
            COLOR_ATTACHMENT30 = 0x8CFE,
            COLOR_ATTACHMENT31 = 0x8CFF,
            DEPTH_ATTACHMENT = 0x8D00,
            STENCIL_ATTACHMENT = 0x8D20,
            DEPTH_STENCIL_ATTACHMENT = 0x821A;

        public readonly uint MAX_SAMPLES = 0x8D57;

        public readonly uint
            FRAMEBUFFER_COMPLETE = 0x8CD5,
            FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6,
            FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7,
            FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB,
            FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC,
            FRAMEBUFFER_UNSUPPORTED = 0x8CDD,
            FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56,
            FRAMEBUFFER_UNDEFINED = 0x8219;

        public readonly uint
            FRAMEBUFFER_BINDING = 0x8CA6,
            DRAW_FRAMEBUFFER_BINDING = 0x8CA6,
            READ_FRAMEBUFFER_BINDING = 0x8CAA,
            RENDERBUFFER_BINDING = 0x8CA7,
            MAX_COLOR_ATTACHMENTS = 0x8CDF,
            MAX_RENDERBUFFER_SIZE = 0x84E8;

        public readonly uint INVALID_FRAMEBUFFER_OPERATION = 0x506;

        public readonly uint DEPTH_STENCIL = 0x84F9;

        public readonly uint UNSIGNED_INT_24_8 = 0x84FA;

        public readonly uint DEPTH24_STENCIL8 = 0x88F0;

        public readonly uint TEXTURE_STENCIL_SIZE = 0x88F1;

        public readonly uint HALF_FLOAT = 0x140B;

        public readonly uint
            RGBA32UI = 0x8D70,
            RGB32UI = 0x8D71,
            RGBA16UI = 0x8D76,
            RGB16UI = 0x8D77,
            RGBA8UI = 0x8D7C,
            RGB8UI = 0x8D7D,
            RGBA32I = 0x8D82,
            RGB32I = 0x8D83,
            RGBA16I = 0x8D88,
            RGB16I = 0x8D89,
            RGBA8I = 0x8D8E,
            RGB8I = 0x8D8F;

        public readonly uint
            RED_INTEGER = 0x8D94,
            GREEN_INTEGER = 0x8D95,
            BLUE_INTEGER = 0x8D96,
            RGB_INTEGER = 0x8D98,
            RGBA_INTEGER = 0x8D99,
            BGR_INTEGER = 0x8D9A,
            BGRA_INTEGER = 0x8D9B;

        public readonly uint
            TEXTURE_1D_ARRAY = 0x8C18,
            TEXTURE_2D_ARRAY = 0x8C1A;

        public readonly uint PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

        public readonly uint PROXY_TEXTURE_1D_ARRAY = 0x8C19;

        public readonly uint
            TEXTURE_BINDING_1D_ARRAY = 0x8C1C,
            TEXTURE_BINDING_2D_ARRAY = 0x8C1D,
            MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

        public readonly uint
            COMPRESSED_RED_RGTC1 = 0x8DBB,
            COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC,
            COMPRESSED_RG_RGTC2 = 0x8DBD,
            COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

        public readonly uint
            R8 = 0x8229,
            R16 = 0x822A,
            RG8 = 0x822B,
            RG16 = 0x822C,
            R16F = 0x822D,
            R32F = 0x822E,
            RG16F = 0x822F,
            RG32F = 0x8230,
            R8I = 0x8231,
            R8UI = 0x8232,
            R16I = 0x8233,
            R16UI = 0x8234,
            R32I = 0x8235,
            R32UI = 0x8236,
            RG8I = 0x8237,
            RG8UI = 0x8238,
            RG16I = 0x8239,
            RG16UI = 0x823A,
            RG32I = 0x823B,
            RG32UI = 0x823C,
            RG = 0x8227,
            COMPRESSED_RED = 0x8225,
            COMPRESSED_RG = 0x8226;

        public readonly uint RG_INTEGER = 0x8228;

        public readonly uint TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

        public readonly uint
            TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84,
            TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

        public readonly uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

        public readonly uint
            INTERLEAVED_ATTRIBS = 0x8C8C,
            SEPARATE_ATTRIBS = 0x8C8D;

        public readonly uint
            PRIMITIVES_GENERATED = 0x8C87,
            TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

        public readonly uint RASTERIZER_DISCARD = 0x8C89;

        public readonly uint
            MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A,
            MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B,
            MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

        public readonly uint
            TRANSFORM_FEEDBACK_VARYINGS = 0x8C83,
            TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F,
            TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

        public readonly uint VERTEX_ARRAY_BINDING = 0x85B5;

        public readonly uint FRAMEBUFFER_SRGB = 0x8DB9;

        public delegate void glGenVertexArrays(int n, uint[] arrays);
        public delegate void glBindVertexArray(uint array);

        public glGenVertexArrays GenVertexArrays { get; private set; }
        public glBindVertexArray BindVertexArray { get; private set; }

        public override void LoadFunctionPointers()
        {
            base.LoadFunctionPointers();
            GenVertexArrays = GL.GetMethod<glGenVertexArrays>();
            BindVertexArray = GL.GetMethod<glBindVertexArray>();
        }
    }

}
