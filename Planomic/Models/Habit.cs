using System;
using System.Collections.Generic;

namespace Planomic.Models
{
    public class Habit : TaskItem
    {
        public List<DayOfWeek> RepeatDays { get; set; } = new List<DayOfWeek>(); // Дни повторения
        public int Streak { get; set; } // Количество выполнений подряд
        public string Motivation { get; set; } // Мотивация пользователя
    }
}