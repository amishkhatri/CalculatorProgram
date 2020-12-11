using calc.integration;
using calc.validation;

namespace calc.console
{
    
    public class ConsoleValidator
    {

        private readonly IValidate _valdiator;
        public ConsoleValidator()
        {          

        }

        public ConsoleValidator(IValidate Valdiator)
        {
            Valdiator = _valdiator;
        }

        public bool Valid(string Operation)
        {
            _valdiator.IsValid(Operation);
            return _valdiator.Valid;

        }

        public bool Valid(string Operation, string Xnumber, string Ynumber)
        {
            _valdiator.IsValid(Operation,Xnumber,Ynumber);
            return _valdiator.Valid;
        }


    }

}
