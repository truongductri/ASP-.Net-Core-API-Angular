using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.Services
{
    public interface IProcessStepSrv
    {
        List<Models.ProcessStep> GetAllProcessStep();
        void Create(Models.ProcessStep model);
        void Edit(Models.ProcessStep model);
        void Delete(int id);
        Models.ProcessStep GetById(int id);
    }
}
