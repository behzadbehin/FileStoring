using Volo.Abp.Settings;

namespace FileStoring.Settings
{
    public class FileStoringSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FileStoringSettings.MySetting1));
        }
    }
}
