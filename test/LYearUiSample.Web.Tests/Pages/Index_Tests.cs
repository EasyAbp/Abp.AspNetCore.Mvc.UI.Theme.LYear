using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LYearUiSample.Pages
{
    public class Index_Tests : LYearUiSampleWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
