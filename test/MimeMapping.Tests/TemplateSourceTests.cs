using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TemplateSourceTests
    {
        [TestMethod]
        public async Task TestMimeDbMimeTypesAsync()
        {
            var keyPairs = await MimeDbTestHelper.FetchMimeTypesAsync();
            Assert.IsNotEmpty(keyPairs);
        }
    }
}
