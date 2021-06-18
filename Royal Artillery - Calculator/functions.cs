using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royal_Artillery___Calculator
{
    class functions
    {
        public List<Record> Init(List<Record> rangeCard)
        {
            try
            {
                using (var reader = new StreamReader("Artillery\\L118 Artillery Table.csv"))
                using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<Record>();

                    foreach (Record r in records)
                    {
                        rangeCard.Add(r);
                    }
                }
            } catch(Exception)
            {
                MessageBox.Show("Can not open file \"Artillery\\L118 Artillery Table.csv\"", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return rangeCard;
        }
    }
}
