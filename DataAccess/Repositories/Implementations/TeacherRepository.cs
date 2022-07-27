using Core.Entities;
using DataAccess.Contexts;
using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Repositories.Implementations
{
    public class TeacherRepository : IRepository<Teacher>

    {
        private static int id;

        public Teacher Create(Teacher entity)
        {
            id++;
            entity.Id = id;
            try
            {
                DbContext.Teachers.Add(entity);
            }
            catch (Exception)
            {

                Console.WriteLine("Something write wrong");
            }
           
            return entity;
        }
        public void Delete(Teacher entity)
        {
            try
            {
                DbContext.Teachers.Remove(entity);
            }
            catch (Exception)
            {
                Console.WriteLine("Something write wrong");
            }
         
             }

        public void Update(Teacher entity)
        {
            try
            {
            var Teacher = DbContext.Teachers.Find(a => a.Id == entity.Id);
            if (Teacher == null)
      
            
            {
                Teacher.Name = Teacher.Name;
                Teacher.Surname = Teacher.Surname;
                    Teacher.Age = Teacher.Age;
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Something write wrong");
                
            }

        }
        public List<Teacher> GetAll(Predicate<Teacher> filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return DbContext.Teachers;
                }
                else
                {
                    return DbContext.Teachers.FindAll(filter);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Something write wrong");
                return null;

            }

        }
        public Teacher Get(Predicate<Teacher> filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return DbContext.Teachers[0];
                }
                else
                {
                    return DbContext.Teachers.Find(filter);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Something went wrong");
                return null;
            }
        }

    }
}
