using System;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public class INPalette
    {
        static INPalette _INST;
        public static INPalette INST => _INST ?? new INPalette();
        public SolidColorBrush OrchidOrange => "#FEA47F".ToBrush();
        public SolidColorBrush SpiroDiscoBall => "#25CCF7".ToBrush();
        public SolidColorBrush HoneyGlow => "#EAB543".ToBrush();
        public SolidColorBrush SweetGarden=> "#55E6C1".ToBrush();
        public SolidColorBrush FallingStar=> "#CAD3C8".ToBrush();


        public SolidColorBrush RichGardenia=> "#F97F51".ToBrush();
        public SolidColorBrush ClearChill=> "#1B9CFC".ToBrush();
        public SolidColorBrush SarawaxWhitePepper=> "#F8EFBA".ToBrush();
        public SolidColorBrush Keppel => "#58B19F".ToBrush();
        public SolidColorBrush ShipsOfficer=> "#2C3A47".ToBrush();


        public SolidColorBrush FieryFuchsia => "#B33771".ToBrush();
        public SolidColorBrush BlueBell=> "#3B3B98".ToBrush();
        public SolidColorBrush GeorgiaPeach=> "#FD7272".ToBrush();
        public SolidColorBrush OasisStream => "#9AECDB".ToBrush();
        public SolidColorBrush BrightUBE=> "#D6A2E8".ToBrush();


        public SolidColorBrush MagentaPurple => "#6D214F".ToBrush();
        public SolidColorBrush EndingNavyBlue => "#182C61".ToBrush();
        public SolidColorBrush SasquatchSocks=> "#FC427B".ToBrush();
        public SolidColorBrush PineGlade => "#BDC581".ToBrush();
        public SolidColorBrush HighlighterLavender => "#82589F".ToBrush();



    }
}
