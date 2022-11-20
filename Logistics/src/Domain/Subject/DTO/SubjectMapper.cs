namespace Logistics.Domain.Subjects
{
    public class SubjectMapper
    {
        public static SubjectDto ToDTO(Subject Subject)
        {
            return new SubjectDto
            {
                code = Subject.Code.code

            };
        }
    }
}