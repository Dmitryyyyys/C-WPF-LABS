using System;
using System.Collections.Generic;
using System.Linq;

namespace lab8
{
    public interface IHostelRepository
    {
        IEnumerable<Hostel> GetAll();
        Hostel GetById(int id);
        void Add(Hostel hostel);
        void Update(Hostel hostel);
        void Delete(int id);
    }

    public class HostelRepository : IHostelRepository
    {
        private Model1 context;

        public HostelRepository(Model1 context)
        {
            this.context = context;
        }

        public IEnumerable<Hostel> GetAll()
        {
            return context.Hostels.ToList();
        }

        public Hostel GetById(int id)
        {
            return context.Hostels.Find(id);
        }

        public void Add(Hostel hostel)
        {
            context.Hostels.Add(hostel);
        }

        public void Update(Hostel hostel)
        {
            context.Entry(hostel).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            Hostel hostel = context.Hostels.Find(id);
            context.Hostels.Remove(hostel);
        }
    }
}
