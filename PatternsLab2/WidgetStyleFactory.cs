using System.Buffers;
using System.Collections;
using System.Collections.Generic;

namespace PatternsLab2
{
    public class WidgetStyleFactory
    {
        private List<WidgetStyle> styles = new List<WidgetStyle>();
        public WidgetStyle GetWidgetStyle(string op_sys)
        {
            WidgetStyle s = styles.Find(st => st.style.Equals(op_sys));
            if (s != null) return s;
            s = new WidgetStyle(op_sys);
            styles.Add(s);
            return s;
        }
    }
}