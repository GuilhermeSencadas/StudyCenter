using System;
using Logistics.Domain.Shared;

namespace Logistics.Domain.Subjects
{

    public class Subject : Entity<SubjectCodeDb>, IAggregateRoot
    {
        private SubjectCode _code;
        
        public SubjectCode Code { get { return _code; } }

        protected Subject() { }

        public Subject(string code)
        {
            this.Id = new SubjectCodeDb(Guid.NewGuid());
            this._code = new SubjectCode(code);
        }

    }
}