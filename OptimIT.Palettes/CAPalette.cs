using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class CAPalette
    {
        static CAPalette _INST;
        public static CAPalette INST => _INST ?? new CAPalette();
        public SolidColorBrush JigglyPuff => "#ff9ff3".ToBrush();
        public SolidColorBrush CasandoraYellow => "#feca57".ToBrush();
        public SolidColorBrush PastelRed => "#ff6b6b".ToBrush();
        public SolidColorBrush MegaMan => "#48dbfb".ToBrush();
        public SolidColorBrush WildCaribbeanGreen => "#1dd1a1".ToBrush();


        public SolidColorBrush LianHongLotusPink => "#f368e0".ToBrush();
        public SolidColorBrush DoubleDragonSkin => "#ff9f43".ToBrush();
        public SolidColorBrush Amour => "#ee5253".ToBrush();
        public SolidColorBrush Cyanite => "#0abde3".ToBrush();
        public SolidColorBrush DarkMountainMeadow => "#10ac84".ToBrush();


        public SolidColorBrush JadeDust => "#00d2d3".ToBrush();
        public SolidColorBrush JoustBlue => "#54a0ff".ToBrush();
        public SolidColorBrush NasuPurple => "#5f27cd".ToBrush();
        public SolidColorBrush LightBlueBallerina => "#c8d6e5".ToBrush();
        public SolidColorBrush FuelTown => "#576574".ToBrush();


        public SolidColorBrush AquaValvet => "#01a3a4".ToBrush();
        public SolidColorBrush BlueDeFrance => "#2e86de".ToBrush();
        public SolidColorBrush BlueBell => "#341f97".ToBrush();
        public SolidColorBrush StormPetrel => "#8395a7".ToBrush();
        public SolidColorBrush ImperialPrimer => "#222f3e".ToBrush();



    }
}
