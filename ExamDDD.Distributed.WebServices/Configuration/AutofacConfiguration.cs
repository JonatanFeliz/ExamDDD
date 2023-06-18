using Autofac.log4net;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamDDD.Application.Services.AutofacModules;
using ExamDDD.Application.Services.Implementations;
using ExamDDD.Application.Services.Contracts;

namespace ExamDDD.Distributed.WebServices.Configuration
{
    public class AutofacConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ApplicationModule());
            builder.RegisterModule<Log4NetModule>();
            // register types
            builder.RegisterType<StudentWebService>().
                As<IStudentWebService>().InstancePerDependency();
            builder.RegisterType<StudentAppService>().
                As<IStudentAppService>().InstancePerDependency();

            // build container
            return builder.Build();
        }
    }
}