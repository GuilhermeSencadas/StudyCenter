using Logistics.Domain.Shared;

namespace Logistics.Domain.Subjects
{
    public class SubjectName : ValueObject
    {
        private int MAX_LENGHT = 20;

        private string _name;

        public string Name { get { return _name; } }

        public SubjectName(string name)
        {
            if(name == null || name == "")
                throw new BusinessRuleValidationException("ERROR: Subject name cannot be empty.");

            if (name.Length > MAX_LENGHT)
            {
                throw new BusinessRuleValidationException("ERROR: Subject name cannot be longer than ' " + MAX_LENGHT+ " ' chars.");
            }
            this._name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            return ((SubjectName)obj).Name.Equals(this._name);
        }

        public override int GetHashCode()
        {
            return this._name.GetHashCode();
        }
    }
}