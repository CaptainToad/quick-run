using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuickRun.Classes
{
    class CustomAutoCompleteCollection : AutoCompleteStringCollection
    {
        private readonly List<Dictionary<String, String>> _DataSource;

        public CustomAutoCompleteCollection(IDataReader dataSource, string display)
            : base()
        {
            int lIndex;
            Dictionary<string, string> lDataRow = new Dictionary<string, string>();

            while (dataSource.Read())
            {
                lIndex = base.Add(dataSource[display].ToString());
                lDataRow = new Dictionary<string, string>();

                for (int lItem = 0; lItem < dataSource.FieldCount; lItem++)
                {
                    lDataRow.Add(dataSource.GetName(lItem), dataSource.GetValue(lItem).ToString());
                }

                _DataSource.Insert(lIndex, lDataRow);
            }
        }

        public string GetValue(string shortName, string key)
        {
            string lReturn;

            if (!base.Contains(shortName))
            { return string.Empty; }

            lReturn = _DataSource[base.IndexOf(shortName)][key];

            return lReturn;
        }
    }
}
