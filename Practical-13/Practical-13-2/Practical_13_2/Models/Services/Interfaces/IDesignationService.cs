using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public interface IDesignationService
    {
        List<Designation> GetAllDesignations();
        string CreateDesignation(Designation desg);
        string UpdateDesignation(Designation desg);
        string DeleteDesignation(int id);
        Designation GetDesignationById(int id);
    }
}
