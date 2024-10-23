using System;

namespace lab8
{
    public class UnitOfWork : IDisposable
    {
        private Model1 context;

        public UnitOfWork()
        {
            context = new Model1();
        }

        private IStudentRepository studentRepository;
        public IStudentRepository StudentRepository
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentRepository(context);
                return studentRepository;
            }
        }

        private IHostelRepository hostelRepository;
        public IHostelRepository HostelRepository
        {
            get
            {
                if (hostelRepository == null)
                    hostelRepository = new HostelRepository(context);
                return hostelRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
