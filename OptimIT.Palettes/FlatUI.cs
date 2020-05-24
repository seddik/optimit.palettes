using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class FlatUI
    {
        static FlatUI _INST;
        public static FlatUI INST => _INST ?? new FlatUI();
        public SolidColorBrush Turquoise => "#1abc9c".ToBrush();
        public SolidColorBrush Emerald => "#2ecc71".ToBrush();
        public SolidColorBrush PeterRiver => "#3498db".ToBrush();
        public SolidColorBrush Amethst => "#9b59b6".ToBrush();
        public SolidColorBrush WetAsphalt => "#34495e".ToBrush();


        public SolidColorBrush GreenSea => "#16a085".ToBrush();
        public SolidColorBrush Nephritis => "#27ae60".ToBrush();
        public SolidColorBrush BelizeHole => "#2980b9".ToBrush();
        public SolidColorBrush Wisteria => "#8e44ad".ToBrush();
        public SolidColorBrush MidnightBlue => "#2c3e50".ToBrush();


        public SolidColorBrush SunFlower => "#f1c40f".ToBrush();
        public SolidColorBrush Carrot => "#e67e22".ToBrush();
        public SolidColorBrush Alizarin => "#e74c3c".ToBrush();
        public SolidColorBrush Clouds => "#ecf0f1".ToBrush();
        public SolidColorBrush Concrete => "#95a5a6".ToBrush();


        public SolidColorBrush Orange => "#f39c12".ToBrush();
        public SolidColorBrush Pumpkin => "#d35400".ToBrush();
        public SolidColorBrush Pomegranate => "#c0392b".ToBrush();
        public SolidColorBrush Silver => "#bdc3c7".ToBrush();
        public SolidColorBrush Asbestos => "#7f8c8d".ToBrush();



    }
}
