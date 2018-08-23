using System.Web.Mvc;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(TestOne.App_Start.StructuremapMvc), "Start")]

namespace TestOne.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            IContainer container = IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}