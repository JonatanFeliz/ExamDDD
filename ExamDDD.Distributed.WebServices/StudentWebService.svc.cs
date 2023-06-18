using ExamDDD.Application.Services.Implementations;
using ExamDDD.Domain.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamDDD.Distributed.WebServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class StudentWebService : IStudentWebService
    {
        private readonly StudentAppService _studentAppService;
        private readonly ILog _log;

        public StudentWebService() { }

        public StudentWebService(StudentAppService studentAppService, ILog log) 
        {
            _studentAppService = studentAppService;
            _log = log;
        }

        public Student AddStudent(int id, string name, string surname, string DNI)
        {
            _log.Info($"Student data: {id},{name},{surname},{DNI}");
            Student student = new Student
            {
                Id = id,
                Name = name,
                Surname = surname,
                DNI = DNI
            };

            return _studentAppService.Add(student);

        }
    }
}
