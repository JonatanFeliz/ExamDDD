using ExamDDD.Application.Services.Contracts;
using ExamDDD.Domain.Entities;
using ExamDDD.Infrastructure.Repository.Implementations;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDDD.Application.Services.Implementations
{
    public class StudentAppService : IStudentAppService
    {
        private readonly StudentRepository _studentRepository;
        private readonly ILog _log;

        public StudentAppService() { }

        public StudentAppService(StudentRepository studentRepository, ILog log)
        {
            _studentRepository = studentRepository;
            _log = log;
        }

        public Student Add(Student model)
        {
            if (model != null)
            {
                _log.Info("Student is not null");
                _studentRepository.Add(model);
            }

            _log.Error("Student is null");
            return null;
            
        }
    }
}
