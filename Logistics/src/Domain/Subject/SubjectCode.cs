using Logistics.Domain.Shared;

namespace Logistics.Domain.Subjects
{

    public class SubjectCode : ValueObject
    {
        private const int MAX_LENGHT = 5;

        private string _code;

        
        public string Code{get { return _code; } }

        public SubjectCode(string code)
        {
            if (code.Length != MAX_LENGHT)
            {
                throw new BusinessRuleValidationException("ERRO: O Identificador do Armazém precisa de ter ' "
                                                            + MAX_LENGHT +
                                                            " ' caracteres alfanuméricos.");
            }
            this._code = code;
        }
        protected SubjectCode()
        { }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }
            var other = (SubjectCode)obj;

            return this._code.Equals(other.Code);
        }

        public override int GetHashCode()
        {
            return this._code.GetHashCode();
        }

        
        

    }
}