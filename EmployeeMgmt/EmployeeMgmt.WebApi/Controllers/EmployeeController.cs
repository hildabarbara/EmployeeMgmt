using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeMgmt.WebApi.Controllers
{
    using EmployeeMgmt.WebApi.Models;
    using EmployeeMgmt.Domain.Entities;
    using EmployeeMgmt.Application.Contracts;

    [AllowAnonymous]
    [RoutePrefix("api/funcionario")]
    public class EmployeeController : ApiController
    {
        private IAppEmployee appEmployee;

        public EmployeeController(IAppEmployee appEmployee)
        {
            this.appEmployee = appEmployee;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(EmployeeModelCreate model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee e = new Employee()
                    {
                        Name = model.Name,
                        Occupation = model.Occupation,
                        Email = model.Email,
                        Birth = model.Birth
                    };

                    appEmployee.Create(e);

                    return Request.CreateResponse(HttpStatusCode.OK, "Funcionário cadastrado com sucesso.");
                }
                else
                {
                    var errors = new List<string>();

                    foreach (var state in ModelState)
                    {
                        foreach (var e in state.Value.Errors)
                        {
                            errors.Add(e.ErrorMessage);
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.Forbidden, errors);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpPut]
        [Route("editar")]
        public HttpResponseMessage Put(EmployeeModelEdit model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee e = appEmployee.GetById(model.Id);

                    if(e != null)
                    {
                        e.Name = model.Name;
                        e.Occupation = model.Occupation;
                        e.Email = model.Email;
                        e.Birth = model.Birth;

                        appEmployee.Update(e);

                        return Request.CreateResponse(HttpStatusCode.OK, "Funcionário atualizado com sucesso.");
                    }
                    else
                    {
                        throw new Exception("Erro. Funcionário não encontrado.");
                    }
                    
                }
                else
                {
                    var errors = new List<string>();

                    foreach (var state in ModelState)
                    {
                        foreach (var e in state.Value.Errors)
                        {
                            errors.Add(e.ErrorMessage);
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.Forbidden, errors);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                Employee e = appEmployee.GetById(id);

                if(e != null)
                {
                    appEmployee.Delete(e);

                    return Request.CreateResponse(HttpStatusCode.OK, "Funcionário excluido com sucesso.");
                }
                else
                {
                    throw new Exception("Erro. Funcionário não encontrado.");
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpGet]
        [Route("obter")]
        public HttpResponseMessage GetOne(int id)
        {
            try
            {
                Employee e = appEmployee.GetById(id);

                if(e != null)
                {
                    var model = new EmployeeModelGet()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Occupation = e.Occupation,
                        Email = e.Email,
                        Birth = e.Birth
                    };

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    throw new Exception("Erro. Funcionário não encontrado.");
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        [HttpGet]
        [Route("listar")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var list = new List<EmployeeModelGet>();

                foreach (Employee e in appEmployee.GetAll())
                {
                    var model = new EmployeeModelGet()
                    {
                        Name = e.Name,
                        Occupation = e.Occupation,
                        Email = e.Email,
                        Birth = e.Birth
                    };
                    list.Add(model);

                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
