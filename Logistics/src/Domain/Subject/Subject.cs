using System;
using Logistics.Domain.Shared;

namespace Logistics.Domain.Subjects
{

    public class Subject : Entity<SubjectIdDb>, IAggregateRoot
    {
        private SubjectCode _code;
        private SubjectName _name;
        private SubjectDescription _description;

        public SubjectCode Code { get { return _code; } }
        public SubjectName Name { get { return _name; } }
        public SubjectDescription Description { get { return _description; } }


        protected Subject() { }

        public Subject(string code, string name, string description)
        {
            this.Id = new SubjectIdDb(Guid.NewGuid());
            this._code = new SubjectCode(code);
            this._name = new SubjectName(name);
            this._description = new SubjectDescription(description);
        }

    }
}