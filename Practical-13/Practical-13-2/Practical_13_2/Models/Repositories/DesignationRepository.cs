using System.Collections.Generic;
using System.Linq;

namespace Practical_13_2.Models
{
    public class DesignationRepository : IDesignationRepository
    {
        private readonly AppDbContext _context;

        public DesignationRepository(AppDbContext context)
        {
            _context = context;
        }
       
        public List<Designation> GetAllDesignations()
        {
            return _context.Designations.AsNoTracking().ToList();
        }
        public Designation GetDesignationById(int id)
        {
            return _context.Designations.Find(id);
        }
        public void AddDesignation(Designation desg)
        {
            _context.Designations.Add(desg);
        }
        public void UpdateDesignation(Designation desg)
        {
            var existing = _context.Designations.Find(desg.Id);

            if (existing != null)
            {
                existing.DesignationName = desg.DesignationName;
            }
        }
        public void DeleteDesignation(int id)
        {
            var d = _context.Designations.Find(id);

            if (d != null)
            {
                _context.Designations.Remove(d);
            }
        }
        public bool HasEmployees(int id)
        {
            return _context.Employees.Any(e => e.DesignationId == id);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
