using System.Collections.Generic;

namespace Practical_13_2.Models
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository _repo;
        public DesignationService(IDesignationRepository repo)
        {
            _repo = repo;
        }
        public List<Designation> GetAllDesignations()
        {
            return _repo.GetAllDesignations();
        }
        public string CreateDesignation(Designation desg)
        {
            if (desg == null)
                return "Designation data is null";

            _repo.AddDesignation(desg);
            _repo.Save();

            return $"{desg.DesignationName} :: Added Successfully";
        }
        public string UpdateDesignation(Designation desg)
        {
            if (desg == null)
                return "Designation data is null";

            var e = _repo.GetDesignationById(desg.Id);

            if (e == null)
                return $"Designation with ID {desg.Id} :: Not Found";

            _repo.UpdateDesignation(desg);
            _repo.Save();

            return $"{e.Id} :: Updated Successfully";
        }
        public string DeleteDesignation(int id)
        {
            if (_repo.HasEmployees(id))
                return "Cannot delete designation. Employees are assigned to it.";

            var e = _repo.GetDesignationById(id);

            if (e == null)
                return $"Designation with ID {id} not found";

            _repo.DeleteDesignation(id);
            _repo.Save();

            return $"{e.DesignationName} deleted successfully";
        }
        public Designation GetDesignationById(int id)
        {
            return _repo.GetDesignationById(id);
        }
    }
}
