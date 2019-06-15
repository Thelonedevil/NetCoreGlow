namespace NetCoreGlow
{
    public class GL14 : GL13
    {

        public readonly uint
            CONSTANT_COLOR = 0x8001,
            ONE_MINUS_CONSTANT_COLOR = 0x8002,
            CONSTANT_ALPHA = 0x8003,
            ONE_MINUS_CONSTANT_ALPHA = 0x8004;

        public readonly uint
            FUNC_ADD = 0x8006,
            MIN = 0x8007,
            MAX = 0x8008;

        public readonly uint
            FUNC_SUBTRACT = 0x800A,
            FUNC_REVERSE_SUBTRACT = 0x800B;

        public readonly uint
            DEPTH_COMPONENT16 = 0x81A5,
            DEPTH_COMPONENT24 = 0x81A6,
            DEPTH_COMPONENT32 = 0x81A7;

        public readonly uint TEXTURE_DEPTH_SIZE = 0x884A;

        public readonly uint
            TEXTURE_COMPARE_MODE = 0x884C,
            TEXTURE_COMPARE_FUNC = 0x884D;

        public readonly uint POINT_FADE_THRESHOLD_SIZE = 0x8128;

        public readonly uint
            BLEND_DST_RGB = 0x80C8,
            BLEND_SRC_RGB = 0x80C9,
            BLEND_DST_ALPHA = 0x80CA,
            BLEND_SRC_ALPHA = 0x80CB;

        public readonly uint
            INCR_WRAP = 0x8507,
            DECR_WRAP = 0x8508;

        public readonly uint TEXTURE_LOD_BIAS = 0x8501;

        public readonly uint MAX_TEXTURE_LOD_BIAS = 0x84FD;

        public readonly uint MIRRORED_REPEAT = 0x8370;


    }

}
