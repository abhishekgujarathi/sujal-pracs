using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public interface IDesignationRepository
    {
        List<Designation> GetAllDesignations();
        void AddDesignation(Designation desg);
        void UpdateDesignation(Designation desg);
        void DeleteDesignation(int id);
        Designation GetDesignationById(int id);
        bool HasEmployees(int id);
        void Save();
    }
}
