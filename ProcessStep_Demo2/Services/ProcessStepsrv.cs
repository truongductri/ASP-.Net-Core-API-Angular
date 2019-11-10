using AutoMapper;
using ProcessStep_Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.Services
{
    public class ProcessStepSrv: IProcessStepSrv
    {
        readonly ProcessStepsContext _processContext;
        public ProcessStepSrv(ProcessStepsContext context)
        {
            _processContext = context;
        }

        public void Create(Models.ProcessStep model)
        {
            if (model != null)
            {
                _processContext.Add(model);
                _processContext.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            _processContext.ProcessStep.Remove(GetById(id));
            _processContext.SaveChanges();
        }

        public void Edit(Models.ProcessStep model)
        {
            if (model != null)
            {
                _processContext.Update(model);
                _processContext.SaveChanges();
            }
        }

        public List<Models.ProcessStep> GetAllProcessStep()
        {
            return _processContext.ProcessStep.ToList();
        }

        public Models.ProcessStep GetById(int id)
        {
            return _processContext.ProcessStep.Where(x => x.StepID.Equals(id)).SingleOrDefault();

        }
    }
}
