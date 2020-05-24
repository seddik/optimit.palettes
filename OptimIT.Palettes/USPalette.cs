using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class USPalette
    {
        static USPalette _INST;
        public static USPalette INST => _INST ?? new USPalette();
        public SolidColorBrush LightGreenBlue => "#55efc4".ToBrush();
        public SolidColorBrush FadedPoster => "#81ecec".ToBrush();
        public SolidColorBrush GreenDarnerTail => "#74b9ff".ToBrush();
        public SolidColorBrush ShyMoment => "#a29bfe".ToBrush();
        public SolidColorBrush CityLights => "#dfe6e9".ToBrush();


        public SolidColorBrush MintLeaf => "#00b894".ToBrush();
        public SolidColorBrush RobinsEggBlue => "#00cec9".ToBrush();
        public SolidColorBrush ElectronBlue => "#0984e3".ToBrush();
        public SolidColorBrush ExodusFruit => "#6c5ce7".ToBrush();
        public SolidColorBrush SoothingBreeze => "#b2bec3".ToBrush();


        public SolidColorBrush SourLemon => "#ffeaa7".ToBrush();
        public SolidColorBrush FirstDate => "#fab1a0".ToBrush();
        public SolidColorBrush PinkGlamour => "#ff7675".ToBrush();
        public SolidColorBrush Pico8Pink => "#fd79a8".ToBrush();
        public SolidColorBrush AmericanRiver => "#636e72".ToBrush();


        public SolidColorBrush BrightYarrow => "#fdcb6e".ToBrush();
        public SolidColorBrush OrangeVille => "#e17055".ToBrush();
        public SolidColorBrush ChiGong => "#d63031".ToBrush();
        public SolidColorBrush PrunusAvium => "#e84393".ToBrush();
        public SolidColorBrush DraculaOrchid => "#2d3436".ToBrush();



    }
}
