namespace NetCoreGlow
{
    public class GL12 : GL11
    {

        public readonly uint
            ALIASED_LINE_WIDTH_RANGE = 0x846E,
            SMOOTH_POINT_SIZE_RANGE = 0xB12,
            SMOOTH_POINT_SIZE_GRANULARITY = 0xB13,
            SMOOTH_LINE_WIDTH_RANGE = 0xB22,
            SMOOTH_LINE_WIDTH_GRANULARITY = 0xB23;

        public readonly uint TEXTURE_BINDING_3D = 0x806A;

        public readonly uint
            PACK_SKIP_IMAGES = 0x806B,
            PACK_IMAGE_HEIGHT = 0x806C,
            UNPACK_SKIP_IMAGES = 0x806D,
            UNPACK_IMAGE_HEIGHT = 0x806E;

        public readonly uint TEXTURE_3D = 0x806F;

        public readonly uint PROXY_TEXTURE_3D = 0x8070;

        public readonly uint TEXTURE_DEPTH = 0x8071;

        public readonly uint TEXTURE_WRAP_R = 0x8072;

        public readonly uint MAX_3D_TEXTURE_SIZE = 0x8073;

        public readonly uint
            BGR = 0x80E0,
            BGRA = 0x80E1;

        public readonly uint
            UNSIGNED_BYTE_3_3_2 = 0x8032,
            UNSIGNED_BYTE_2_3_3_REV = 0x8362,
            UNSIGNED_SHORT_5_6_5 = 0x8363,
            UNSIGNED_SHORT_5_6_5_REV = 0x8364,
            UNSIGNED_SHORT_4_4_4_4 = 0x8033,
            UNSIGNED_SHORT_4_4_4_4_REV = 0x8365,
            UNSIGNED_SHORT_5_5_5_1 = 0x8034,
            UNSIGNED_SHORT_1_5_5_5_REV = 0x8366,
            UNSIGNED_INT_8_8_8_8 = 0x8035,
            UNSIGNED_INT_8_8_8_8_REV = 0x8367,
            UNSIGNED_INT_10_10_10_2 = 0x8036,
            UNSIGNED_INT_2_10_10_10_REV = 0x8368;

        public readonly uint CLAMP_TO_EDGE = 0x812F;

        public readonly uint
            TEXTURE_MIN_LOD = 0x813A,
            TEXTURE_MAX_LOD = 0x813B,
            TEXTURE_BASE_LEVEL = 0x813C,
            TEXTURE_MAX_LEVEL = 0x813D;

        public readonly uint
            MAX_ELEMENTS_VERTICES = 0x80E8,
            MAX_ELEMENTS_INDICES = 0x80E9;
        public override void LoadFunctionPointers()
        {
            base.LoadFunctionPointers();

        }

    }
}
