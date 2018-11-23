using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMongoDB.Core.Repository;

namespace TestMongoDB.Test
{
    [TestClass]
    public class TestRepositoryTest
    {
        [TestMethod]
        public void Insert()
        {
            MongoDbContext.ConnectionString = "mongodb://localhost:27017/TestDb?connect=replicaSet";
            MongoDbContext.DatabaseName = "TestDb";
            MongoDbContext.IsSSL = false;
            MongoDbContext mongoDbContext = new Core.Repository.MongoDbContext();
            Core.Repository.TestRepository testRepository = new TestRepository(mongoDbContext);
            Core.Domain.Test test = new Core.Domain.Test();
            test.Name = "Teste Por mim feito!";
            testRepository.Insert(test);
        }
        [TestMethod]
        public void Update()
        {
            MongoDbContext.ConnectionString = "mongodb://localhost:27017/";
            MongoDbContext.DatabaseName = "TestDb";
            MongoDbContext.IsSSL = false;
            MongoDbContext mongoDbContext = new Core.Repository.MongoDbContext();
            Core.Repository.TestRepository testRepository = new TestRepository(mongoDbContext);

            foreach(var test in testRepository.Get())
            {
                System.Console.WriteLine(test.Name);
            }
            //test.Name = "Teste Por mim eito!";
            //Assert.IsTrue(testRepository.Update(test));
        }

        
    }
}
