using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Samples.Demo3.Impl
{
    public abstract class ApiDataSource
    {
        public string Name = "API";
    }

    public class ApiReferenceDataSource : ApiDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code = "xyz", Description = "from API" },
                new ReferenceDataItem { Code = "xyz", Description = "from API 2"}
            };
        }
    }
}
