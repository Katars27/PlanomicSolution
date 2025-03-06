using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planomic.Data;
using Planomic.Models;

namespace Planomic.Services
{
    public class DatabaseService
    {
        private readonly AppDbContext _context;

        public DatabaseService(AppDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated(); // Гарантирует, что база создана
        }

        // Добавление проекта
        public async Task AddProjectAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        // Получение всех проектов
        public async Task<List<Project>> GetProjectsAsync()
        {
            return await _context.Projects.Include(p => p.Tasks).ToListAsync();
        }

        // Обновление проекта
        public async Task UpdateProjectAsync(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        // Удаление проекта
        public async Task DeleteProjectAsync(Guid projectId)
        {
            var project = await _context.Projects.FindAsync(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }

        // Добавление задачи
        public async Task AddTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        // Получение всех задач
        public async Task<List<TaskItem>> GetTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        // Обновление задачи
        public async Task UpdateTaskAsync(TaskItem task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        // Удаление задачи
        public async Task DeleteTaskAsync(Guid taskId)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        // Добавление привычки
        public async Task AddHabitAsync(Habit habit)
        {
            _context.Habits.Add(habit);
            await _context.SaveChangesAsync();
        }

        // Получение всех привычек
        public async Task<List<Habit>> GetHabitsAsync()
        {
            return await _context.Habits.ToListAsync();
        }

        // Обновление привычки
        public async Task UpdateHabitAsync(Habit habit)
        {
            _context.Habits.Update(habit);
            await _context.SaveChangesAsync();
        }

        // Удаление привычки
        public async Task DeleteHabitAsync(Guid habitId)
        {
            var habit = await _context.Habits.FindAsync(habitId);
            if (habit != null)
            {
                _context.Habits.Remove(habit);
                await _context.SaveChangesAsync();
            }
        }
    }
}