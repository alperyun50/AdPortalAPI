using AdPortalAPI.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AdPortalAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _studentDb;

        public SqlStudentRepository(StudentAdminContext studentDb)
        {
            _studentDb = studentDb;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentDb.Students.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
            
        }

    }
}
