using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Day3_Lab.Domain.Model;
using EntityFramework_Day3_Lab.Infrastructure.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using User = EntityFramework_Day3_Lab.Domain.Model.User;

namespace EntityFramework_Day3_Lab.Infrastructure.Reposetrie
{
    internal class UserReposertrie
    {
        TaskManagerContext taskManagerContext = new TaskManagerContext();
        public void Add(User user)
        {
            taskManagerContext.Add(user);
            taskManagerContext.SaveChanges();
        }
        public User Login(User user)
        {
            var Result=taskManagerContext.Users.Where(u=>u.Name==user.Name && u.Email==user.Email).ToList().FirstOrDefault();
            if (Result!=null) 
                return Result;
            user.Id = -1;
            return user;
        }

        public User GetUser(int id)
        {
            return taskManagerContext.Users.FirstOrDefault(c => c.Id == id);
        }

        public List<TaskItem> GetTasks(int id)
        {
            return taskManagerContext.TaskItems.Where(t=>t.UserId==id).ToList();
        }
        public void deleteTaskitem(TaskItem task)
        {
                  taskManagerContext.TaskItems.Remove(task);
            taskManagerContext.SaveChanges();
        }
        public List<Category> GetCategories()
        {
            return taskManagerContext.categories.ToList();
        }
        public void AddTaskitem(TaskItem taskItem)
        {
            taskManagerContext.Add(taskItem);
            taskManagerContext.SaveChanges();
        }
        public TaskItem GetTask(int taskId)
        {
            return taskManagerContext.TaskItems.Where(t => t.Id == taskId).FirstOrDefault();
        }
        public void updatetask(TaskItem task)
        {
            taskManagerContext.Update(task);
            taskManagerContext.SaveChanges();
        }
        public List<TaskItem> SearchTasks(string str,int id)
        {
            return taskManagerContext.TaskItems.Where(T=>(T.Title.Contains(str) || T.Description.Contains(str)) && T.UserId==id).ToList();
        }
        public List<TaskItem> SearchTaskpriority(int num,int id)
        {
            return taskManagerContext.TaskItems.Where(T => ((int)T.Priority)==num && T.UserId==id).ToList();
        }
        public List<TaskItem> SearchTaskStatus(int num, int id)
        {
            return taskManagerContext.TaskItems.Where(T => ((int)T.Status) == num && T.UserId == id).ToList();
        }
        public List<TaskItem> SortDesc(int userid)
        {
            return taskManagerContext.TaskItems.Where(T=>T.UserId == userid).OrderByDescending(T=>T.DueDate).ToList();
        }
        public List<TaskItem> SortAsc(int userid)
        {
            return taskManagerContext.TaskItems.Where(T => T.UserId == userid).OrderBy(T => T.DueDate).ToList();

        }
    }
}
