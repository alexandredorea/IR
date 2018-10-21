using System;
using System.Collections.Generic;
using System.Text;

namespace IRRF.Domain.Entities
{
    public class IncomeTaxRate
    {
        private readonly decimal _percentage;
        private readonly int _quantitySalary;
        private IncomeTaxRate _nextIncomeTaxRate;

        public IncomeTaxRate(decimal percentage, int quantitySalary)
        {
            _percentage = percentage;
            _quantitySalary = quantitySalary;
        }

        public IncomeTaxRate(decimal percentage) : this(percentage, int.MaxValue)
        {
        }

        public IncomeTaxRate NextRange(IncomeTaxRate nextIncomeTaxRate)
        {
            _nextIncomeTaxRate = nextIncomeTaxRate;
            return this;
        }

        /// <summary>
        /// Obtem o imposto de renda
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="freeSalary"></param>
        /// <returns></returns>
        public decimal GetIncomeTax(decimal salary, decimal freeSalary)
        {
            if ((freeSalary / _quantitySalary) > salary)
                return _nextIncomeTaxRate?.GetIncomeTax(salary, freeSalary) ?? 0m;
            return CalculateIncomeTax(freeSalary);
        }

        /// <summary>
        /// Calcula o valor do imposto de renda
        /// </summary>
        /// <param name="freeSalary"></param>
        /// <returns></returns>
        private decimal CalculateIncomeTax(decimal freeSalary)
        {
            return (_percentage / 100) * freeSalary;
        }
    }
}
