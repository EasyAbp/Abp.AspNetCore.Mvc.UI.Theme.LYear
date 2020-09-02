using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LYearUiSample.EntityFrameworkCore
{
    public static class LYearUiSampleDbContextModelCreatingExtensions
    {
        public static void ConfigureLYearUiSample(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LYearUiSampleConsts.DbTablePrefix + "YourEntities", LYearUiSampleConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}