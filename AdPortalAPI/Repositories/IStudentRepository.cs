using AdPortalAPI.DataModels;

namespace AdPortalAPI.Repositories
{
    public interface IStudentRepository
    {
       Task <List<Student>> GetStudentsAsync();
    }
}
