using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Samples.Demo3.Impl
{
    public abstract class XmlDataSource
    {
        public string Name = "XML";
    }

    public class XmlReferenceDataSource : XmlDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code = "xyz", Description = "from XML" },
                new ReferenceDataItem { Code = "xyz", Description = "from XML 2"}
            };
        }
    }
}
