using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Model
{
    public class StudentDB: DbContext
    {
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine("D:", "student.db");
            var conString = " Data source ="+ path;
            optionsBuilder.UseSqlite(conString);
        }
        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Classroom c1 = new Classroom
            {
                Id = 1,
                Name = "ThaiCongTuan" ,
                Room= "Lab1", 
                Teacher = "Nguyễn Dũng"

            };
            Classroom c2 = new Classroom
            {
                Id = 2,
                Name = "ThaiCongTuan1",
                Room = "Lab2",
                Teacher = "Bảo Dũng"
                
            };
            modelBuilder.Entity<Classroom>().HasData(c1,c2);
        }
    }
}
