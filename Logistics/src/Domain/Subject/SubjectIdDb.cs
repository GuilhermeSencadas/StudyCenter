using System;
using Logistics.Domain.Shared;
using Newtonsoft.Json;

namespace Logistics.Domain.Subjects
{
    //Esta classe apenas cria o Id destinado à Base de Dados
    public class SubjectCodeDb : EntityId
    {

        [JsonConstructor]
        public SubjectCodeDb(Guid value) : base(value)
        { }

        public SubjectCodeDb(String value) : base(value)
        { }
        override
           protected Object createFromString(String text)
        {
            return new Guid(text);
        }

        override
        public String AsString()
        {
            Guid obj = (Guid)base.ObjValue;
            return obj.ToString();
        }


        public Guid AsGuid()
        {
            return (Guid)base.ObjValue;
        }

    }
}