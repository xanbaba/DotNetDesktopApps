namespace XanTranslate.Models;

public class TranslationLanguage
{
    public TranslationLanguage(string name, string? code)
    {
        Name = name;
        Code = code;
    }

    public string? Code { get; set; }
    public string Name { get; set; }

    public override string ToString() => Name;
}