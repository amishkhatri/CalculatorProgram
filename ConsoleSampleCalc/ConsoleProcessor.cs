using calc.domain;
using calc.validation;
using System;
using calc.integration;
using calc.operations;
using System.Collections.Generic;

namespace calc.console
{
    //Console processor - Core logic of calculator (limited operations)

    public class ConsoleProcessor 
    {
        // Injector and domain
        private Operation _operation;
        private readonly IValidate _valdiator;

        public ConsoleProcessor(IValidate Validator)
        {
            this.Operation = new Operation();
            _valdiator = Validator;
        }

        public Operation Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }

        public bool IsValidOperation
        {
            get { return ValidateOperation(); }            
        }

        public bool AreValidNumbers
        {
            get { return ValidateNumber(); }
        }

        public void StartOperation()
        {
            try
            { 
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
                Console.WriteLine("Please enter your choice");
                this.Operation.OperationType = Console.ReadLine();                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void SetNumbers()
        {
            try
            {
                Console.WriteLine("Please enter first number");
                this.Operation.NumberX = Console.ReadLine();

                Console.WriteLine("Please enter second number");
                this.Operation.NumberY = Console.ReadLine();

             //   return ValidateNumber();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        bool ValidateOperation()
        {    
            return _valdiator.IsValid(this.Operation.OperationType);
        }

        bool ValidateNumber()
        {
            return _valdiator.IsValid(this.Operation.OperationType, this.Operation.NumberX, this.Operation.NumberY);            
        }

        public void Execute()
        {

            float x, y;

            x = float.Parse(this.Operation.NumberX);
            y = float.Parse(this.Operation.NumberY);

            switch (int.Parse(this.Operation.OperationType))
            {
                case (int)OperationEnum.Addition:
                    this.Operation.Result =  new Addition().Operation(x, y).ToString();
                    break;

                case (int)OperationEnum.Subtraction:
                    this.Operation.Result = new Subtraction().Operation(x, y).ToString();
                    break;

                case (int)OperationEnum.Multiply:
                    this.Operation.Result = new Multiply().Operation(x, y).ToString();                    
                    break;

                case (int)OperationEnum.Division:
                    this.Operation.Result = new Division().Operation(x, y).ToString();                    
                    break;
            }
            Console.WriteLine("The result is : " + this.Operation.Result);
         

        }


    }
}
