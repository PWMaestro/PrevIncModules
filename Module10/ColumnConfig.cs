using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class ColumnConfig<TRow>
    {
        public string Name { get; set; }
        public Func<TRow, string> ValueSelector { get; set; }
        public string DefauleValue { get; set; }

        public ColumnConfig(string name, Func<TRow, string> valueSelector, string defaultValue)
        {
            Name = name;
            ValueSelector = valueSelector;
            DefauleValue = defaultValue;
        }
    }
}
