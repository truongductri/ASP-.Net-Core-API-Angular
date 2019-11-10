using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProcessStep_Demo2.Models;
using ProcessStep_Demo2.Services;
using ProcessStep_Demo2.ViewModels;

namespace ProcessStep_Demo2.Controllers
{
    [Route("api/procsteps")]
    [ApiController]
    public class ProcessStepsController : ControllerBase
    {
        private readonly IProcessStepSrv _processStepSrv;
        private readonly IMapper _mapper;
        public ProcessStepsController(IProcessStepSrv processStepSvr, IMapper mapper)
        {
            _processStepSrv = processStepSvr;
            _mapper = mapper;
        }
        // GET api/values
        [HttpGet]

        [Route("")]
        public ActionResult GetAll()
        {
            var data = _processStepSrv.GetAllProcessStep();
            return Ok(_mapper.Map<IEnumerable<ProcessStepVM>>(data));
        }

        // GET api/values/5
        [HttpGet]
        [Route("{id}")]
        public ActionResult Get(int id)
        {
            var data = _processStepSrv.GetById(id);
            return Ok(_mapper.Map<ProcessStepVM>(data));
        }

        // POST api/values
        [HttpPut]
        [Route("update-procees")]
        public void Edit([FromBody] ProcessStepVM vm)
        {
            var model = _mapper.Map<ProcessStep>(vm);
           _processStepSrv.Edit(model);
           
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Route("del-step/{id}")]
        public void Delete(int id)
        {
            _processStepSrv.Delete(id);
        }
    }
}
