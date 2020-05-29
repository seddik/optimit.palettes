using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class TRPalette
    {
        static TRPalette _INST;
        public static TRPalette INST => _INST ?? new TRPalette();
        public SolidColorBrush BrightLilac => "#cd84f1".ToBrush();
        public SolidColorBrush PrettyPlease => "#ffcccc".ToBrush();
        public SolidColorBrush LightRed => "#ff4d4d".ToBrush();
        public SolidColorBrush MandarinSorbet=> "#ffaf40".ToBrush();
        public SolidColorBrush UnmellowYellow=> "#fffa65".ToBrush();


        public SolidColorBrush LightPurple=> "#c56cf0".ToBrush();
        public SolidColorBrush YoungSalmon=> "#ffb8b8".ToBrush();
        public SolidColorBrush RedOrange=> "#ff3838".ToBrush();
        public SolidColorBrush RadiantYellow=> "#ff9f1a".ToBrush();
        public SolidColorBrush DorkYellow=> "#fff200".ToBrush();


        public SolidColorBrush WinterGreen=> "#32ff7e".ToBrush();
        public SolidColorBrush ElectricBlue=> "#7efff5".ToBrush();
        public SolidColorBrush NeonBlue=> "#18dcff".ToBrush();
        public SolidColorBrush LightSlateBlue=> "#7d5fff".ToBrush();
        public SolidColorBrush ShadowedSteel=> "#4b4b4b".ToBrush();


        public SolidColorBrush WeirdGreen => "#3ae374".ToBrush();
        public SolidColorBrush HammanBlue=> "#67e6dc".ToBrush();
        public SolidColorBrush SpiroDiscoBall=> "#17c0eb".ToBrush();
        public SolidColorBrush LightIndigo=> "#7158e2".ToBrush();
        public SolidColorBrush BalticSea => "#3d3d3d".ToBrush();



    }
}
