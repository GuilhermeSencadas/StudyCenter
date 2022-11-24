using Logistics.Domain.Shared;
using System.Threading.Tasks;
using System.Collections.Generic;
using Logistics.Domain.Subjects;

namespace Logistics.Repository
{

    public interface ISubjectRepository : IRepository<Subject, SubjectIdDb >
    {
        public bool ExistsSubject(string code);
        public Task<Subject> GetBySubjectCode(string code);

        public Task<List<Subject>> ListSubjectsAsync(string IdSubject, string designacao);


    }
}