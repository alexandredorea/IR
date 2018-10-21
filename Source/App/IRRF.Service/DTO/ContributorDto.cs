using System;
using System.Collections.Generic;
using System.Text;

namespace IRRF.Service.DTO
{
    public class ContributorDto
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public short NumberDependents { get; set; }
        public decimal Salary { get; set; }
        public decimal IncomeTax { get; set; }
    }
}
