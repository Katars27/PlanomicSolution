using System;

namespace Planomic.Models
{
    public enum TaskType { OneTime, Habit, ProjectTask }
    public enum PriorityLevel { Low, Medium, High }
    public enum TaskStatus { NotStarted, InProgress, Completed }

    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный ID
        public string Title { get; set; } // Название задачи
        public string Description { get; set; } // Описание
        public DateTime StartDate { get; set; } // Дата начала
        public DateTime EndDate { get; set; } // Дата завершения
        public TaskType Type { get; set; } // Тип задачи
        public PriorityLevel Priority { get; set; } // Приоритет
        public TaskStatus Status { get; set; } // Статус
        public Guid? ProjectId { get; set; } // Связь с проектом (если есть)
    }
}