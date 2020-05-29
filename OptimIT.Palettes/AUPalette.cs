using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class AUPalette
    {
        static AUPalette _INST;
        public static AUPalette INST => _INST ?? new AUPalette();
        public SolidColorBrush BeeKeeper => "#f6e58d".ToBrush();
        public SolidColorBrush SpicedNectarine => "#ffbe76".ToBrush();
        public SolidColorBrush PinkGlamour => "#ffbe76".ToBrush();
        public SolidColorBrush JuneBud => "#badc58".ToBrush();
        public SolidColorBrush CoastalBreeze => "#dff9fb".ToBrush();


        public SolidColorBrush Turbo => "#f9ca24".ToBrush();
        public SolidColorBrush QuinceJelly => "#f0932b".ToBrush();
        public SolidColorBrush CarminePink => "#eb4d4b".ToBrush();
        public SolidColorBrush PureApple => "#6ab04c".ToBrush();
        public SolidColorBrush HintOfIcePack => "#c7ecee".ToBrush();


        public SolidColorBrush MiddleBlue => "#7ed6df".ToBrush();
        public SolidColorBrush HelioTrope => "#e056fd".ToBrush();
        public SolidColorBrush ExodusFruit => "#686de0".ToBrush();
        public SolidColorBrush DeepKoamaru => "#30336b".ToBrush();
        public SolidColorBrush SoaringEagle => "#95afc0".ToBrush();


        public SolidColorBrush GreenlandGreen => "#22a6b3".ToBrush();
        public SolidColorBrush SteelPink => "#be2edd".ToBrush();
        public SolidColorBrush Blurple => "#4834d4".ToBrush();
        public SolidColorBrush DeepCove => "#4834d4".ToBrush();
        public SolidColorBrush WizardGrey => "#535c68".ToBrush();



    }
}
