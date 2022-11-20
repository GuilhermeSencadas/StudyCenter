
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Logistics.Domain.Shared;
using System.Threading.Tasks;
using Logistics.Domain.Subjects;
using Logistics.Service;

namespace Logistics.Controllers
{

    [Route("Logistics/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        //TODO Change to interface
        private readonly SubjectService _service;


        public SubjectsController(SubjectService service) // IAppService
        {
            _service = service;
        }

        //GET: /Logistics/Subjects
        [HttpGet]
        public async Task<List<SubjectDto>> GetSubjects()
        {
            return await _service.GetSubjects();
        }

        //POST: api/Subject
        [HttpPost]
        public async Task<ActionResult<SubjectDto>> createSubject(SubjectDto dto)
        {
            try
            {
                var Subject = await _service.createSubject(dto);
                return Ok(Subject);
            }
            catch (BusinessRuleValidationException ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        //PUT: api/Subject/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<SubjectDto>> editarSubject(string id, SubjectDto dto)
        {

            if (id != dto.code)
            {
                return BadRequest();
            }

            try
            {
                var cat = await _service.EditSubject(dto);
                
                if (cat == null)
                {
                    return NotFound();
                }
                return Ok(cat);
            }
            catch(BusinessRuleValidationException ex)
            {
                return BadRequest(new {Message = ex.Message});
            }
        }

        //PATCH: api/Subject/{id}
        [HttpPatch("{id}")]
        public async Task<ActionResult<SubjectDto>> editarSubjectParcial(string id, SubjectDto dto)
        {

            if (id != dto.code)
            {
                return BadRequest();
            }

            try
            {
                var cat = await _service.EditSubjectPartial(dto);
                
                if (cat == null)
                {
                    return NotFound();
                }
                return Ok(cat);
            }
            catch(BusinessRuleValidationException ex)
            {
                return BadRequest(new {Message = ex.Message});
            }
        }
    }
}