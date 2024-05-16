namespace XanTranslate.Models;

public class TranslationText
{
    public TranslationText(string text, TranslationLanguage translationLanguage)
    {
        Text = text;
        TranslationLanguage = translationLanguage;
    }

    public string Text { get; set; }
    public TranslationLanguage TranslationLanguage { get; set; }
}