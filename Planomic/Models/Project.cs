using System;
using System.Collections.Generic;

namespace Planomic.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Уникальный ID
        public string Title { get; set; } // Название проекта
        public string Description { get; set; } // Описание проекта
        public DateTime StartDate { get; set; } // Дата начала
        public DateTime EndDate { get; set; } // Дата завершения
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>(); // Список задач
        public double Progress { get; set; } // Прогресс выполнения
    }
}