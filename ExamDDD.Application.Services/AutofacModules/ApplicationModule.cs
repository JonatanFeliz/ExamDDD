using Autofac;
using Autofac.log4net;
using ExamDDD.Domain.Entities;
using ExamDDD.Infrastructure.Repository.Contracts;
using ExamDDD.Infrastructure.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDDD.Application.Services.AutofacModules
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<StudentRepository>()
                .As<IStudentRepository>().InstancePerDependency();

            builder.RegisterModule<Log4NetModule>();

            base.Load(builder);
        }
    }
}
