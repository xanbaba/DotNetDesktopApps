using System.Collections.Generic;
using System.ComponentModel;
using XanTranslate.Models;

namespace XanTranslate.Services;

public interface ITranslator
{
    IList<TranslationLanguage> GetAllLanguages();

    string Translate(TranslationText sourceTranslationText, TranslationLanguage destinationLanguage);
    
    // source language will be determined automatically
    string Translate(string sourceText, TranslationLanguage destinationLanguage);
}