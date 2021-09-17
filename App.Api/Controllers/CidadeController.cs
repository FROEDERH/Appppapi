using App.Domain.DTO;
using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {
        private ICidadeService _service;

        public CidadeController(ICidadeService service)
        {
            _service = service;
        }

        [HttpGet("ListaCidades")]
        public JsonResult Get()
        {
            return Json(_service.listaCidades());
        }

        [HttpGet("ListaCidades")]
        [AllowAnonymous]

        public JsonResult ListaCidades()
        {
            try
            {
                var obj = _service.listaCidades();
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }


        [HttpPost("Salvar")]
        public JsonResult Salvar(string nomeCidade, string Cep, string Uf, bool ativo)
        {
            var obj = new Cidade
            {
                NomeCidade = nomeCidade,
                Cep = Cep,
                Uf = Uf,
                Ativo = ativo
            };
            _service.Salvar(obj);
            return Json(true);

        }
        [HttpDelete("Remove")]

        public JsonResult Remove(Guid id, bool ativo)
        {
            
            _service.Remove(id);
            return Json(true);



        }
    }
}

