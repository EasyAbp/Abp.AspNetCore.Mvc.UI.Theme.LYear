using System.Threading.Tasks;

namespace LYearUiSample.Data
{
    public interface ILYearUiSampleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
