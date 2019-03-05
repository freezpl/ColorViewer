using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ColorViewer
{
    internal sealed class TodayExtention : MarkupExtension
    {
        private int shift;

        public TodayExtention() : this(0){}

        public TodayExtention(int shift)
        {
            this.shift = shift;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return DateTime.Now.AddDays(shift).DayOfWeek.ToString();
        }
    }
}
