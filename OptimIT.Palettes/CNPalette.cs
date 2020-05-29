using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class CNPalette
    {
        static CNPalette _INST;
        public static CNPalette INST => _INST ?? new CNPalette();
        public SolidColorBrush GoldenSand => "#eccc68".ToBrush();
        public SolidColorBrush Coral => "#ff7f50".ToBrush();
        public SolidColorBrush WildWatermelon => "#ff6b81".ToBrush();
        public SolidColorBrush Peace => "#a4b0be".ToBrush();
        public SolidColorBrush Grisaille => "#57606f".ToBrush();


        public SolidColorBrush Orange => "#ffa502".ToBrush();
        public SolidColorBrush BruschettaTomato => "#ff6348".ToBrush();
        public SolidColorBrush Watermelon => "#ff4757".ToBrush();
        public SolidColorBrush BayWharf => "#747d8c".ToBrush();
        public SolidColorBrush PrestigeBlue => "#2f3542".ToBrush();


        public SolidColorBrush LimeSoap => "#7bed9f".ToBrush();
        public SolidColorBrush FrenchSkyBlue => "#70a1ff".ToBrush();
        public SolidColorBrush SaturatedSky => "#5352ed".ToBrush();
        public SolidColorBrush White => "#ffffff".ToBrush();
        public SolidColorBrush CityLights => "#dfe4ea".ToBrush();


        public SolidColorBrush UFOGreen => "#2ed573".ToBrush();
        public SolidColorBrush ClearChill => "#1e90ff".ToBrush();
        public SolidColorBrush BrightGreek => "#3742fa".ToBrush();
        public SolidColorBrush AntiFlashWhite => "#f1f2f6".ToBrush();
        public SolidColorBrush TwinkleBlue => "#ced6e0".ToBrush();



    }
}
