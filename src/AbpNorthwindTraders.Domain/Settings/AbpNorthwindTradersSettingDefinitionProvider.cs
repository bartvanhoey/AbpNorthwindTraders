using Volo.Abp.Settings;

namespace AbpNorthwindTraders.Settings
{
    public class AbpNorthwindTradersSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpNorthwindTradersSettings.MySetting1));
        }
    }
}
