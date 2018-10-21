namespace IRRF.Domain.Entities
{
    public class IncomeTax
    {
        private readonly decimal _percentDiscounte;
        private readonly IncomeTaxRate _aliquota;
        private readonly decimal _salary;

        public IncomeTax(decimal salary)
        {
            _salary = salary;
            _percentDiscounte = 5;
            _aliquota = new IncomeTaxRate(0, 2)
                            .NextRange(new IncomeTaxRate(7.5m, 4)
                            .NextRange(new IncomeTaxRate(15, 5)
                            .NextRange(new IncomeTaxRate(22.5m, 7)
                            .NextRange(new IncomeTaxRate(27.5m)))));
        }

        public void CalculateIncomeTax(Contributor contributer)
        {
            var discount = ((contributer.NumberDependents * _percentDiscounte) / 100) * _salary;
            var freeSalary = contributer.Salary - discount;
            var incomeTax = _aliquota.GetIncomeTax(_salary, freeSalary);
            contributer.SetIncomeTax(incomeTax);
        }
    }
}
