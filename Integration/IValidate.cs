using System;
using System.Collections.Generic;
using System.Text;

// Injection Inteface for validation
namespace calc.integration
{
    public interface IValidate
    {
      
        bool IsValid(string Operation,string Xnumber, string Ynumber);

        bool IsValid(string OperationType);

       // bool IsOperationTypeValid(string OperationType);
    }
}