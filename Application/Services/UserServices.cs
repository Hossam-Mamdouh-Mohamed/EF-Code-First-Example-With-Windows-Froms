using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework_Day3_Lab.Domain.Model;
using EntityFramework_Day3_Lab.Infrastructure.Reposetrie;
using Microsoft.VisualBasic.ApplicationServices;
using User = EntityFramework_Day3_Lab.Domain.Model.User;

namespace EntityFramework_Day3_Lab.application.Services
{
    public class UserServices
    {
        UserReposertrie reposetrie = new UserReposertrie();
        public void Adduser(User user)
        {
            reposetrie.Add(user);
        }
        public User userlogin(User user)
        {
            return reposetrie.Login(user);
        }
        public User GetUser(int id)
        {
            return reposetrie.GetUser(id);
        }
        public List<TaskItem> GetTasks(int id)
        {
            return reposetrie.GetTasks(id);
        }
        public void deleteTaskitem(TaskItem task)
        {
            reposetrie.deleteTaskitem(task);
        }
        public List<Category> GetCategories()
        {
            return reposetrie.GetCategories();
        }
        public void AddTaskitem(TaskItem taskItem)
        {
            reposetrie.AddTaskitem(taskItem);

        }
        public TaskItem GetTask(int taskId)
        {
            return reposetrie.GetTask(taskId);
        }
        public void updatetask(TaskItem task)
        {
            reposetrie.updatetask(task);
        }
        public List<TaskItem> SearchTasks(string str,int id)
        {
            return reposetrie.SearchTasks(str,id);
        }
        public List<TaskItem> SearchTaskpriority(int num,int id)
        {
            return reposetrie.SearchTaskpriority(num,id);
        }
        public List<TaskItem> SearchTaskStatus(int num, int id)
        {
            return reposetrie.SearchTaskStatus(num, id);
        }
        public List<TaskItem> SortDesc(int userid)
        {
            return reposetrie.SortDesc(userid);
        }
        public List<TaskItem> SortAsc(int userid)
        {
            return reposetrie.SortAsc(userid);
        }
    }
}
