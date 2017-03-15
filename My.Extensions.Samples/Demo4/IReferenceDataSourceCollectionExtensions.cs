using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Samples.Demo3
{
    public static class IReferenceDataSourceCollectionExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IReferenceDataSource[] sources, string code)
        {
            var items = new List<ReferenceDataItem>();
            foreach (var source in sources)
            {
                items.AddRange(source.GetItemsByCode(code));
            }
            return items;
        }
    }
}
