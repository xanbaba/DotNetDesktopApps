using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace ToDoList;

public static class TasksFileManager
{
    private const string TasksFilePath = "tasks.json";

    public static BindingList<Task> LoadTasks()
    {
        if (!File.Exists(TasksFilePath))
        {
            ResetFile();
        }

        using var streamReader = new StreamReader(TasksFilePath);
        var fileContent = streamReader.ReadToEnd();

        var tasksData = JsonConvert.DeserializeObject<BindingList<Task>>(fileContent);
        if (tasksData == null)
        {
            ResetFile();
            tasksData = new BindingList<Task>();
        }
        return tasksData;
    }

    public static void SaveToFile(BindingList<Task> data)
    {
        File.WriteAllText(TasksFilePath, JsonConvert.SerializeObject(data));
    }

    private static void ResetFile()
    {
        File.WriteAllText(TasksFilePath, @"[]");
    }
}