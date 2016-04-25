using Movies.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.BL2016
{
    public class BusinessObjectBase
    {
        protected IUnitOfWork unitOfWork;

        public BusinessObjectBase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
