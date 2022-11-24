
using Logistics.Domain.Shared;

namespace Logistics.Domain.Subjects{

    public class SubjectDescription : ValueObject
    {
        private int MAX_LENGHT = 50;
        private string _description;

        public string Descripion{get { return _description; }}

        public SubjectDescription(string descripion){
            if(descripion == null)
                throw new BusinessRuleValidationException("ERROR: Description cannot be null.");

            if(descripion.Length > MAX_LENGHT)
                throw new BusinessRuleValidationException("ERROR: Description is too long.");

            this._description = descripion;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }
            var other = (SubjectDescription)obj;

            return this._description.Equals(other.Descripion);
        }

        public override int GetHashCode()
        {
            return this._description.GetHashCode();
        }
    }
}