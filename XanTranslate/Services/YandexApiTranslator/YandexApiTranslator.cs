using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XanTranslate.Models;

namespace XanTranslate.Services.YandexApiTranslator;

public class YandexApiTranslator : ITranslator
{
    private const string YandexApiDataFilePath = @"Services\YandexApiTranslator\YandexApiData.json";

    private readonly YandexApiDataModel _yandexApiDataModel;

    private readonly IList<TranslationLanguage> _allLanguages;

    private readonly WebClient _webClient = new()
    {
        Encoding = Encoding.UTF8,
    };

    public YandexApiTranslator()
    {
        _yandexApiDataModel = LoadYandexApiDataModel();
        _allLanguages = LoadAllLanguages();
    }

    public IList<TranslationLanguage> GetAllLanguages()
    {
        return _allLanguages;
    }

    public string Translate(TranslationText sourceTranslationText, TranslationLanguage destinationLanguage)
    {
        var apiRequest = GenerateTranslateApiRequest(sourceTranslationText, destinationLanguage);
        try
        {
            var response = _webClient.DownloadString(apiRequest);
            var responseText = JObject.Parse(response)["text"]![0]!.ToObject<string>()!;
            return responseText;
        }
        catch (WebException)
        {
        }

        return string.Empty;
    }

    public string Translate(string sourceText, TranslationLanguage destinationLanguage)
    {
        var apiRequest = GenerateAutoTranslateApiRequest(sourceText, destinationLanguage);
        try
        {
            var response = _webClient.DownloadString(apiRequest);
            var responseText = JObject.Parse(response)["text"]![0]!.ToObject<string>()!;
            return responseText;
        }
        catch (WebException)
        {
        }

        return string.Empty;
    }

    private YandexApiDataModel LoadYandexApiDataModel()
    {
        return JsonConvert.DeserializeObject<YandexApiDataModel>(File.ReadAllText(YandexApiDataFilePath))!;
    }

    private IList<TranslationLanguage> LoadAllLanguages()
    {
        var apiRequest = GenerateGetAllLanguagesApiRequest();
        try
        {
            var response = _webClient.DownloadString(apiRequest);
            var languagesJToken = JObject.Parse(response)["langs"]!;
            return GenerateAllLanguagesFromJToken(languagesJToken);
        }
        catch (WebException)
        {
        }

        return new List<TranslationLanguage>();
    }

    private string GenerateGetAllLanguagesApiRequest()
    {
        return string.Format(_yandexApiDataModel.LanguageListRequestFormat, _yandexApiDataModel.ApiKey);
    }

    private string GenerateTranslateApiRequest(TranslationText sourceTranslationText,
        TranslationLanguage destinationLanguage)
    {
        return string.Format(_yandexApiDataModel.TranslateRequestFormat, _yandexApiDataModel.ApiKey,
            sourceTranslationText.Text,
            sourceTranslationText.TranslationLanguage.Code, destinationLanguage.Code);
    }
    
    private string GenerateAutoTranslateApiRequest(string sourceText,
        TranslationLanguage destinationLanguage)
    {
        return string.Format(_yandexApiDataModel.AutoTranslateRequestFormat, _yandexApiDataModel.ApiKey, sourceText, destinationLanguage.Code);
    }

    private IList<TranslationLanguage> GenerateAllLanguagesFromJToken(JToken languagesJson)
    {
        var languages = new List<TranslationLanguage>();
        foreach (var language in languagesJson.ToObject<Dictionary<string, string>>()!)
        {
            languages.Add(new TranslationLanguage(language.Value, language.Key));
        }

        return languages;
    }
}