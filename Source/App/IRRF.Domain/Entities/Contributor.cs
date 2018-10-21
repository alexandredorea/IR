using Flunt.Br.Validation;
using Flunt.Validations;
using IRRF.Domain.Entities.Base;
using IRRF.Domain.Interfaces.Entities;
using System;

namespace IRRF.Domain.Entities
{
    public class Contributor : EntityBase<int>, IContributor
    {
        #region Construtor

        public Contributor()
        {
            SetId(0);
            IncomeTax = 0;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public Contributor(string cpf, string name, short numberDependents, decimal salary)
        {
            SetId(0);
            Cpf = cpf;
            Name = name;
            NumberDependents = numberDependents;
            Salary = salary;
            IncomeTax = 0;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public Contributor(int id, string cpf, string name, short numberDependents, decimal salary)
        {
            SetId(id);
            Cpf = cpf;
            Name = name;
            NumberDependents = numberDependents;
            Salary = salary;
            IncomeTax = 0;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        #endregion

        #region Atributos

        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public short NumberDependents { get; private set; }
        public decimal Salary { get; private set; }
        public decimal IncomeTax { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        #endregion

        #region Métodos

        public void SetCpf(string cpf)
        {
            AddNotifications(new Contract()
                .Requires().IsCpf(cpf, "Contributor.Cpf", "O CPF é inválido."));

            if (Valid)
                Cpf = cpf;
        }

        public void SetName(string name)
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(string.IsNullOrWhiteSpace(Name) ? string.Empty : Name, 3, "Contributor.Name", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(name ?? string.Empty, 50, "Contributor.Name", "O nome deve ter até 50 caracteres"));

            if (Valid)
                Name = name;
        }

        public void SetNumberDependents(short numberDependents)
        {
            NumberDependents = numberDependents;
        }

        public void SetSalary(decimal salary)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0, salary, "Contributor.Salary", "O salário deve ser maior que zero."));

            if (Valid)
                Salary = salary;
        }

        public void SetIncomeTax(decimal incomeTax)
        {
            IncomeTax = incomeTax;
        }

        public void SetCreated(DateTime date)
        {
            Created = date;
        }

        public void SetUpdated(DateTime date)
        {
            Updated = date;
        }

        #endregion
    }
}