using System.Collections.Generic;

namespace TestMongoDB.Core.Domain
{
    public class DataSource : DomainBase
    {
        public string Name { get; set; }
        public Test Test { get; set; }
        public IList<ContentDataSource> ContentDataSourceList { get; set; }
    }
}