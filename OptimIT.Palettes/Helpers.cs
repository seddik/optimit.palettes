using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Media;

namespace OptimIT.Palettes
{
    public static class Helpers
    {
        static BrushConverter bc = new BrushConverter();

        public static SolidColorBrush ToBrush(this string color)
        {
            return (SolidColorBrush)bc.ConvertFromString(color);
        }
        public static List<PaletteColor> ClassToPalette<T>()
        {
            var lst = new List<PaletteColor>();
            var tt = typeof(T);
            var instance = Activator.CreateInstance(tt);
            foreach (var item in tt.GetProperties().Where(X => X.PropertyType == typeof(SolidColorBrush)))
            {
                var brush = (SolidColorBrush)instance.GetValueByProperty(item.Name);
                lst.Add(new PaletteColor
                {
                    Name = item.Name,
                    Brush = brush,
                    Hex = "#" + bc.ConvertToString(brush).TrimStart('#', 'F', 'F'),
                    Foreground = brush.ForegroundFromBrightness()
                });
            }

            return lst;
        }
        public static SolidColorBrush ForegroundFromBrightness(this Brush brush)
        {
            return brush.PerceivedBrightness() ? Brushes.Black : Brushes.White;
        }
        public static bool PerceivedBrightness(this Brush brush)
        {
            try
            {
                var c = ((SolidColorBrush)brush).Color;
                var iii = (int)Math.Sqrt(
                c.R * c.R * .241 +
                c.G * c.G * .691 +
                c.B * c.B * .068);
                return iii > 200;
            }
            catch
            {

                return false;
            }


        }
        public static object GetValueByProperty(this object obj, string propertyName)
        {
            if (propertyName == ".")
            {
                return obj;
            }

            try
            {
                if (propertyName.Contains("."))
                {
                    foreach (var prop in propertyName.Split('.').Select(s => obj.GetType().GetProperty(s)))
                    {
                        obj = prop.GetValue(obj, null);
                    }
                }
                else
                {
                    return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
                }
            }
            catch
            {
                return null;
            }

            return obj;
        }

    }
}
