using System.Threading.Tasks;
using System.Collections.Generic;
using Logistics.Domain.Shared;
using Logistics.Domain.Subjects;
using Logistics.Repository;

namespace Logistics.Service
{
    public class SubjectService : ISubjectService
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

            var subject = new Subject(dto.code, dto.name, dto.description);

            await this._repo.AddAsync(subject);
            await this._unitOfWork.CommitAsync();

            return SubjectMapper.ToDTO(subject);
        }


        public async Task<List<SubjectDto>> GetSubjects()
        {
           
            List<Subject> list = await this._repo.GetAllAsync();
            return SubjectMapper.ToDTO(list);
        }


        public async Task<SubjectDto> EditSubject(SubjectDto subjectDto)
        {
            //TODO test when subject doesn't exist
            Subject subject = await this._repo.GetBySubjectCode(subjectDto.code);
            subject.FullUpdate(subjectDto.name, subjectDto.description);
            return SubjectMapper.ToDTO(subject);
        }

        public async Task<SubjectDto> EditSubjectPartial(SubjectDto subjectDto)
        {
            Subject subject = await this._repo.GetBySubjectCode(subjectDto.code);
            subject.PartialUpdate(subjectDto.name, subjectDto.description);
            return SubjectMapper.ToDTO(subject);
        }

    }
}