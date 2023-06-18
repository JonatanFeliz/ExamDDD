using ExamDDD.Domain.Entities;
using ExamDDD.Infrastructure.Repository.Contracts;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDDD.Infrastructure.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ILog _log;

        public StudentRepository() { }

        public StudentRepository(ILog log) 
        { 
            _log = log;
        }
        public Student Add(Student model)
        {
            string filePath = "./students.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    writer.WriteLine(model.ToString());

                    _log.Info("Student save succesfully");

                    return model;
                }
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
