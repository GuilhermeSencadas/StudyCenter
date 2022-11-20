using System.Threading.Tasks;
using System.Collections.Generic;
using Logistics.Domain.Shared;
using Logistics.Domain.Subjects;
using Logistics.Repository;

namespace Logistics.Service
{
    public class SubjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISubjectRepository _repo;

        public SubjectService(IUnitOfWork unitOfWork, ISubjectRepository repo)
        {
            this._unitOfWork = unitOfWork;
            this._repo = repo;
        }

        public async Task<SubjectDto> createSubject(SubjectDto dto)
        {
            if (this._repo.ExistsSubject(dto.code)){
                throw new BusinessRuleValidationException("ERROR: A Subject with that code already exists");
            }

            var subject = new Subject(dto.code);

            await this._repo.AddAsync(subject);
            await this._unitOfWork.CommitAsync();

            return SubjectMapper.ToDTO(subject);
        }


        public Task<List<Subject>> GetSubjects(SubjectDto dto)
        {
            throw new System.NotImplementedException();

        }


        public async Task<SubjectDto> EditSubject(SubjectDto creatingSubjectDto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SubjectDto> EditSubjectPartial(SubjectDto creatingSubjectDto)
        {
            throw new System.NotImplementedException();
        }

    }
}