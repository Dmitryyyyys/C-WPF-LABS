using System;
using System.Collections.Generic;
using System.Linq;

namespace lab8
{
    public interface IStudentRepository
    {
        IEnumerable<Students> GetAll();
        Students GetById(int id);
        void Add(Students student);
        void Update(Students student);
        void Delete(int id);
    }

    public class StudentRepository : IStudentRepository
    {
        private Model1 context;

        public StudentRepository(Model1 context)
        {
            this.context = context;
        }

        public IEnumerable<Students> GetAll()
        {
            return context.Student.ToList();
        }

        public Students GetById(int id)
        {
            return context.Student.Find(id);
        }

        public void Add(Students student)
        {
            context.Student.Add(student);
        }

        public void Update(Students student)
        {
            context.Entry(student).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Students student = context.Student.Find(id);
            context.Student.Remove(student);
        }
    }
}
