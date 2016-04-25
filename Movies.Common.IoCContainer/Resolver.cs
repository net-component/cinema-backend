using Movies.BusinessLayer.BL2016;
using Movies.BusinessLayer.Contracts;
using Movies.DataLayer.Contracts;
using Movies.DataLayer.EF;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Common.IoCContainer
{
    public static class Resolver
    {
        private static Container container = new Container(x =>
        {
            x.For<IUnitOfWork>().Add<UnitOfWork>();
            x.For<IBusinessObjectFactory>().Add<BusinessObjectFactory>();
        });

        public static T Get<T>()
        {
            return container.GetInstance<T>();
        }
    }
}
