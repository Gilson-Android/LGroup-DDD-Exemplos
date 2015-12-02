using System;
using LGroup.Arquitetura.DDD.Domain.Entities.Core;
using LGroup.Arquitetura.DDD.Domain.ValueObjects;

namespace LGroup.Arquitetura.DDD.Domain.Entities
{
    public class PessoaEntity : Entity<int>
    {
        private string _nome;
        private int _idade;

        private PessoaEntity() { }

        public PessoaEntity(int idade, string nome, SexoValueObject sexo)
        {
            Nome = nome;
            Sexo = sexo;
            _idade = idade;
        }

        public SexoValueObject Sexo { get; set; }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value <= 0)
                    throw new ApplicationException("Idade inválida");
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ApplicationException("O nome deve ser solicitado");

                _nome = value;
            }
        }
    }
}
