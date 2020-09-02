using Volo.Abp.Settings;

namespace LYearUiSample.Settings
{
    public class LYearUiSampleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LYearUiSampleSettings.MySetting1));
        }
    }
}
