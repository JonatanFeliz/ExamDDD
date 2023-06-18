using ExamDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDDD.Application.Services.Contracts
{
    public interface IAdd
    {
        Student Add(Student model);
    }
}
