using JobNet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=JobNet");
            optionsBuilder.LogTo(m => Debug.WriteLine(m));
        }
        //public DataContext() 
        //{
        //    Employers = new List<Employer> {
        //        new Employer { EmployerID = 1, UserID = 1,CompanyName="mabruk", Industry ="aaa" },
        //        new Employer { EmployerID = 2, UserID = 2,CompanyName="company2", Industry = "bbb" }
        //    };

        //    Jobs = new List<Job> {
        //        new Job { JobID = 1, EmployerID = 1,Title="mabruk",Description="aaa", Location ="aaa",Salary=3000,PostedDate=DateTime.Today },
        //        new Job { JobID = 2, EmployerID = 2,Title="company2",Description="bbb", Location = "bbb",Salary=15500,PostedDate=DateTime.Today }
        //    };

        //    Requests = new List<Request> {
        //    new Request { RequestID=1, JobID=1, UserID=1, Message="violintist",RequestDate=DateTime.Today },
        //    new Request { RequestID = 2, JobID = 2, UserID =2, Message = "computer",RequestDate=DateTime.Today  } };

        //    Subscriptions = new List<Subscription> {
        //    new Subscription { SubscriberID = 1,  UserId=1,SubscriptionDate=DateTime.Today },
        //    new Subscription { SubscriberID = 2 ,UserId =2, SubscriptionDate=DateTime.Today  } };

        //    Users = new List<User> {
        //    new User { UserID=1, UserName="efrat", Password="54321", Email="efrat4945@gmail.com", Role="violintist" },
        //    new User { UserID = 2, UserName = "Dasi", Password = "123", Email = "Dasi4945@gmail.com", Role = "computer" } };

        //}
    }
}
