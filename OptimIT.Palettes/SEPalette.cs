using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class SEPalette
    {
        static SEPalette _INST;
        public static SEPalette INST => _INST ?? new SEPalette();
        public SolidColorBrush HighlighterPink => "#ef5777".ToBrush();
        public SolidColorBrush DarkPeriwinkle => "#575fcf".ToBrush();
        public SolidColorBrush MegaMan => "#4bcffa".ToBrush();
        public SolidColorBrush FreshTurquoise=> "#34e7e4".ToBrush();
        public SolidColorBrush MintyGreen=> "#0be881".ToBrush();


        public SolidColorBrush SizzlingRed=> "#f53b57".ToBrush();
        public SolidColorBrush FreeSpeechBlue=> "#3c40c6".ToBrush();
        public SolidColorBrush SpiroDiscoBall=> "#0fbcf9".ToBrush();
        public SolidColorBrush JadeDust=> "#00d8d6".ToBrush();
        public SolidColorBrush GreenTeal=> "#05c46b".ToBrush();


        public SolidColorBrush NarenjiOrange=> "#ffc048".ToBrush();
        public SolidColorBrush YrielYellow=> "#ffdd59".ToBrush();
        public SolidColorBrush SunsetOrange=> "#ff5e57".ToBrush();
        public SolidColorBrush HintOfElusiveBlue=> "#d2dae2".ToBrush();
        public SolidColorBrush GoodNight=> "#485460".ToBrush();


        public SolidColorBrush ChromeYellow => "#ffa801".ToBrush();
        public SolidColorBrush VibrantYellow=> "#ffd32a".ToBrush();
        public SolidColorBrush RedOrange=> "#ff3f34".ToBrush();
        public SolidColorBrush LondonSquare=> "#808e9b".ToBrush();
        public SolidColorBrush BlackPearl => "#1e272e".ToBrush();



    }
}
