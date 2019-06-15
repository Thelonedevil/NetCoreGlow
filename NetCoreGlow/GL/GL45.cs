namespace NetCoreGlow
{
    public class GL45 : GL44
    {

        public readonly uint
            NEGATIVE_ONE_TO_ONE = 0x935E,
            ZERO_TO_ONE = 0x935F;

        public readonly uint
            CLIP_ORIGIN = 0x935C,
            CLIP_DEPTH_MODE = 0x935D;

        public readonly uint
            QUERY_WAIT_INVERTED = 0x8E17,
            QUERY_NO_WAIT_INVERTED = 0x8E18,
            QUERY_BY_REGION_WAIT_INVERTED = 0x8E19,
            QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

        public readonly uint
            MAX_CULL_DISTANCES = 0x82F9,
            MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;

        public readonly uint TEXTURE_TARGET = 0x1006;

        public readonly uint QUERY_TARGET = 0x82EA;

        public readonly uint CONTEXT_RELEASE_BEHAVIOR = 0x82FB;

        public readonly uint CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

        public readonly uint
            GUILTY_CONTEXT_RESET = 0x8253,
            INNOCENT_CONTEXT_RESET = 0x8254,
            UNKNOWN_CONTEXT_RESET = 0x8255;

        public readonly uint RESET_NOTIFICATION_STRATEGY = 0x8256;

        public readonly uint
            LOSE_CONTEXT_ON_RESET = 0x8252,
            NO_RESET_NOTIFICATION = 0x8261;

        public readonly uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x4;

        public readonly uint CONTEXT_LOST = 0x507;


    }

}
