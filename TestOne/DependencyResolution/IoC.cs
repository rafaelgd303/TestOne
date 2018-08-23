using StructureMap;
using System;
using System.Threading;
using TestOne.Controllers;
using TestOne.Interfaces;
using TestOne.Repository;

namespace TestOne
{
    public static class IoC
    {
        public static IContainer Initialize()
        {

            return new Container(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IFizzBuzzRepository>().Use<FizzBuzzRepository>();
                        });
        }
    }
}