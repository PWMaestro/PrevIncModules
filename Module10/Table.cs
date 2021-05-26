using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Table<TRow>
    {
        private readonly List<ColumnConfig<TRow>> columnConfigs = new List<ColumnConfig<TRow>>();
        private readonly List<TRow> rows = new List<TRow>();

        public Table<TRow> AddColumnConfig(string name, Func<TRow, string> valueSelector, string defaultValue = null)
        {
            columnConfigs.Add(new ColumnConfig<TRow>(name, valueSelector, defaultValue));
            return this;
        }

        public Table<TRow> AddRow(TRow row)
        {
            rows.Add(row);
            return this;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendJoin(" | ", columnConfigs.Select(columnConfig => columnConfig.Name).Prepend("ID"));
            output.Append(Environment.NewLine);
            for (int i = 0; i < rows.Count; i++)
            {
                var row = columnConfigs.Select(columnConfig =>
                {
                    var row = rows[i];
                    var cellValue = columnConfig.ValueSelector(row);
                    return cellValue ?? columnConfig.DefauleValue;
                }).Prepend(i.ToString());

                output.AppendJoin("   ", row);
                output.Append(Environment.NewLine);
            }
            return output.ToString();
        }
    }
}
