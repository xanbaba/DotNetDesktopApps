using System;
using System.ComponentModel;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace ToDoList;

public partial class Form1 : Form
{
    private readonly BindingList<Task> _tasks = TasksFileManager.LoadTasks();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (var priorityName in Enum.GetNames(typeof(Priority)))
        {
            priorityComboBox.Items.Add(priorityName);
        }

        priorityComboBox.SelectedIndex = 0;

        tasksListBox.DataSource = _tasks;
    }

    private void addTask_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleTextBox.Text))
        {
            infoLabel.Visible = true;
            
            var timer = new Timer();
            timer.Interval = 3000;
            timer.Elapsed += (_, _) =>
            {
                infoLabel.Visible = false;
            };
            timer.Start();
            return;
        }

        var newTask = new Task
        {
            Title = titleTextBox.Text,
            Description = descriptionTextBox.Text,
            TaskPriority = (Priority)priorityComboBox.SelectedIndex,
            IsUrgent = urgentlyCheckBox.Checked,
            ExpireDate = expireDateTimePicker.Value,
            IsDone = false
        };
        _tasks.Add(newTask);
        TasksFileManager.SaveToFile(_tasks);
    }

    private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender is not ListBox listBox) return;
        if (listBox.SelectedItem is not Task task) return;
        
        titleLabel.Text = task.Title;
        descriptionLabel.Text = task.Description;
        isUrgentLabel.Text = task.IsUrgent ? "Yes" : "No";
        priorityLabel.Text = Enum.GetName(typeof(Priority), task.TaskPriority);
        expireDateLabel.Text = task.ExpireDate.ToShortDateString();
        isDoneLabel.Text = task.IsDone ? "Yes" : "No";
    }

    private void doneButton_Click(object sender, EventArgs e)
    {
        if (_tasks.Count == 0)
        {
            return;
        }
        _tasks[tasksListBox.SelectedIndex].IsDone = true;
        TasksFileManager.SaveToFile(_tasks);
        tasksListBox_SelectedIndexChanged(tasksListBox, e);
    }

    private void removeButton_Click(object sender, EventArgs e)
    {
        if (_tasks.Count == 0)
        {
            return;
        }
        _tasks.RemoveAt(tasksListBox.SelectedIndex);
        TasksFileManager.SaveToFile(_tasks);
        tasksListBox_SelectedIndexChanged(tasksListBox, e);
    }
}