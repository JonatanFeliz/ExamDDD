using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExamDDD.Domain.Entities
{
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string DNI { get; set; }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Surname:{Surname},DNI:{DNI}";
        }
    }
}
