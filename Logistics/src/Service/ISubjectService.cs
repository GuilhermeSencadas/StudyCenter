using System.Collections.Generic;
using System.Threading.Tasks;
using Logistics.Domain.Subjects;

namespace Logistics.Service
{
    public interface ISubjectService
    {
        public Task<SubjectDto> createSubject(SubjectDto dto);
        public Task<List<SubjectDto>> GetSubjects();
        public Task<SubjectDto> EditSubject(SubjectDto creatingSubjectDto);
        public Task<SubjectDto> EditSubjectPartial(SubjectDto creatingSubjectDto);
    }
}
