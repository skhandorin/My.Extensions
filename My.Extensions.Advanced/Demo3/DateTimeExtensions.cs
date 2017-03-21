using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace My.Extensions.Advanced.Demo3
{
    public static class DateTimeExtensions
    {
        public static string ToXmlDateTime(this DateTime datetime)
        {
            return XmlConvert.ToString(datetime, XmlDateTimeSerializationMode.Utc);
        }
    }
}
