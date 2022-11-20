using System.Collections.Generic;

namespace Logistics.Domain.Subjects
{
    public class SubjectMapper
    {
        public static SubjectDto ToDTO(Subject subject)
        {
            return new SubjectDto
            {
                code = subject.Code.Code,
                name = subject.Name.Name,
                description = subject.Description.Descripion
            };
        }

        public static List<SubjectDto> ToDTO(List<Subject> list){
            List<SubjectDto> dtoList = new List<SubjectDto>();
            foreach(Subject subject in list){
                dtoList.Add(ToDTO(subject));
            }
            return dtoList;
        }
    }
}