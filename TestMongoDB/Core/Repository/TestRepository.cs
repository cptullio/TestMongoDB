using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMongoDB.Core.Domain;

namespace TestMongoDB.Core.Repository
{
    public class TestRepository
    {
        private readonly MongoDbContext context;

        public TestRepository(MongoDbContext context)
        {
            this.context = context;
        }

        public List<Test> Get()
        {

            return context.Test.AsQueryable().ToList();
        }
        public Test Get(String Id)
        {
            var f = new MongoDB.Driver.FilterDefinitionBuilder<Test>().Exists(x => x.Id == Id);
            return context.Test.FindSync<Test>(f).Current.First();
        }

        public void Insert(Test test)
        {
            context.Test.InsertOne(test);
        }

        public bool Update(Test test)
        {
            var result = context.Test.ReplaceOne(new FilterDefinitionBuilder<Test>().Where(x => x.Id == test.Id), test);
            return result.IsAcknowledged;
        }
        public bool Delete(String Id)
        {
            var result = context.Test.DeleteOne(new FilterDefinitionBuilder<Test>().Where(x => x.Id == Id));
            return result.IsAcknowledged;
        }
    }
}
