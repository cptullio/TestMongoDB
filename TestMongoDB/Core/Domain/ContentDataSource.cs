using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMongoDB.Core.Domain
{
    public class ContentDataSource : DomainBase
    {
        public string Chave { get; set; }
        public string Alvo { get; set; }
        public string Valor { get; set; }
        public DataSource Datasource { get; set; }
    }
}
