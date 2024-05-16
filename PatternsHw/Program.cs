// See https://aka.ms/new-console-template for more information

using PatternsHw;

/*var singletonLogger = SingletonLogger.Instance;
SingletonLogger.FilePath = "log.txt";
singletonLogger.Log(LogType.Error, "Hello");
singletonLogger.Log(LogType.Info, "Hello");
singletonLogger.Log(LogType.Warning, "Hello");*/

SingletonConfigReader.ConfigFilePath = "Config.json";
Console.WriteLine(SingletonConfigReader.Instance.Read("Key"));