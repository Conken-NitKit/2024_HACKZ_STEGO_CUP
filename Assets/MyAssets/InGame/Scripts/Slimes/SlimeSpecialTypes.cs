using System;

namespace Assets.MyAssets.InGame.Slimes
{
    public enum SpecialTypes
    {
        Water,
        Fire,
        Thunder,
        Wind
    }
    
    static class PlayerIdExtensions
    {
        public static float ToWaitSeconds(this SpecialTypes type)
        {
            switch (type)
            {
                case SpecialTypes.Water:
                    return 0.5f;
                case SpecialTypes.Fire:
                    return 3f;
                case SpecialTypes.Thunder:
                    return 10f;
                case SpecialTypes.Wind:
                    return 2f;
                default:
                    throw new ArgumentOutOfRangeException("Type", type, null);
            }
        }

        public static int ToPower(this SpecialTypes type)
        {
            switch (type)
            {
                case SpecialTypes.Water:
                    return 0;
                case SpecialTypes.Fire:
                    return 3;
                case SpecialTypes.Thunder:
                    return 1;
                case SpecialTypes.Wind:
                    return 2;
                default:
                    throw new ArgumentOutOfRangeException("Type", type, null);
            }
        }
    }

}