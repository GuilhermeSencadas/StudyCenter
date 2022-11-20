using Logistics.Domain.Shared;
using System.Threading.Tasks;
using System.Collections.Generic;
using Logistics.Domain.Subjects;

namespace Logistics.Repository
{

    public interface ISubjectRepository : IRepository<Subject, SubjectCodeDb>
    {
        public bool ExistsSubject(string Id);
        public Task<Subject> GetBySubjectCode(string Id);

        public Task<List<Subject>> ListSubjectsAsync(string IdSubject, string designacao);


    }
}