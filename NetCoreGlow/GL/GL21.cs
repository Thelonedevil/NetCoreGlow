namespace NetCoreGlow
{
    public class GL21 : GL20
    {

        public readonly uint
            FLOAT_MAT2x3 = 0x8B65,
            FLOAT_MAT2x4 = 0x8B66,
            FLOAT_MAT3x2 = 0x8B67,
            FLOAT_MAT3x4 = 0x8B68,
            FLOAT_MAT4x2 = 0x8B69,
            FLOAT_MAT4x3 = 0x8B6A;

        public readonly uint
            PIXEL_PACK_BUFFER = 0x88EB,
            PIXEL_UNPACK_BUFFER = 0x88EC;

        public readonly uint
            PIXEL_PACK_BUFFER_BINDING = 0x88ED,
            PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;

        public readonly uint
            SRGB = 0x8C40,
            SRGB8 = 0x8C41,
            SRGB_ALPHA = 0x8C42,
            SRGB8_ALPHA8 = 0x8C43,
            COMPRESSED_SRGB = 0x8C48,
            COMPRESSED_SRGB_ALPHA = 0x8C49;


    }

}
