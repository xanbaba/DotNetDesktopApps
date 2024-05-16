namespace XanTranslate.Services.YandexApiTranslator;

public class YandexApiDataModel
{
    public string ApiKey { get; set; } = null!;
    public string LanguageListRequestFormat { get; set; } = null!;
    public string TranslateRequestFormat { get; set; } = null!;
    public string AutoTranslateRequestFormat { get; set; } = null!;
}