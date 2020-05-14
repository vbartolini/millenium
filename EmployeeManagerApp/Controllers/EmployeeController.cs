using System.Linq;
using EmployeeManagerApp.Mock;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using EmployeeManagerApp.Models;
using EmployeeManagerApp.Entities;
using System.Collections.Generic;

namespace EmployeeManagerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _empoyeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _empoyeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var model = new EmployeeListModel();
            var employees =  _empoyeeRepository.EmployeeList.ToList();
            model.List = employees.Adapt<List<EmployeeListItemModel>>();
            return Ok(model.List);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var employee = _empoyeeRepository.Get(id);
            if (employee != null)
            {
                return Ok(employee.Adapt<EmployeeDetailsModel>());
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Post(EmployeeUpdateModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                var employee = _empoyeeRepository.Get(employeeModel.Id);
                if (employee != null)
                {
                    employee.FirstName = employeeModel.FirstName;
                    employee.LastName = employeeModel.LastName;
                    _empoyeeRepository.Update(employee);
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public ActionResult Put(EmployeeCreationModel employeeModel)
        {
            if(ModelState.IsValid)
            {
                var employee = employeeModel.Adapt<Employee>();
                _empoyeeRepository.Create(employee);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = _empoyeeRepository.Get(id);
            if (employee != null)
            {
                _empoyeeRepository.Delete(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
