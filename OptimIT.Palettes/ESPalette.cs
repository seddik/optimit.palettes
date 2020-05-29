using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class ESPalette
    {
        static ESPalette _INST;
        public static ESPalette INST => _INST ?? new ESPalette();
        public SolidColorBrush JacksonsPurple => "#40407a".ToBrush();
        public SolidColorBrush C64Purple => "#706fd3".ToBrush();
        public SolidColorBrush SwanWhite => "#f7f1e3".ToBrush();
        public SolidColorBrush SummerSky=> "#34ace0".ToBrush();
        public SolidColorBrush CelestialGreen=> "#33d9b2".ToBrush();


        public SolidColorBrush LuckyPoint=> "#2c2c54".ToBrush();
        public SolidColorBrush Liberty=> "#474787".ToBrush();
        public SolidColorBrush HotStone=> "#aaa69d".ToBrush();
        public SolidColorBrush DevilBLue=> "#227093".ToBrush();
        public SolidColorBrush PalmSpringSplash=> "#218c74".ToBrush();


        public SolidColorBrush FluorescentRed=> "#ff5252".ToBrush();
        public SolidColorBrush SyntheticPumpkin=> "#ff793f".ToBrush();
        public SolidColorBrush CrocodileTooth=> "#d1ccc0".ToBrush();
        public SolidColorBrush MadnarinSorbet=> "#ffb142".ToBrush();
        public SolidColorBrush SpicedButternut=> "#ffda79".ToBrush();


        public SolidColorBrush EyeOfNewt => "#b33939".ToBrush();
        public SolidColorBrush ChileanFire=> "#cd6133".ToBrush();
        public SolidColorBrush GreyPorcelain=> "#84817a".ToBrush();
        public SolidColorBrush AlamedaOchre => "#cc8e35".ToBrush();
        public SolidColorBrush Desert => "#ccae62".ToBrush();



    }
}
