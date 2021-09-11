using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {

        private IRepositoryBase<Cidade> _Cidaderepository { get; set; }
        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _Cidaderepository = repository;
        }
        public Cidade BuscaPorId(Guid id)
        {
            var obj = _Cidaderepository.Query(x => x.Id == id).FirstOrDefault();
            return obj;
        }

        public List<Cidade> listaCidades()
        {
            return _Cidaderepository.Query(x => 1 == 1).ToList();
        }

        public void Salvar(Cidade obj)
        {
            if (String.IsNullOrEmpty(obj.NomeCidade))
            {
                throw new Exception("Informe o nome da cidade");
            }
            _Cidaderepository.Save(obj);
            _Cidaderepository.SaveChanges();
        }
        public void Remove(Guid id)
        {
            _Cidaderepository.Delete(id);
            _Cidaderepository.SaveChanges();
        }
    }
}