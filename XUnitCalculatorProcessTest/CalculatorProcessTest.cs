using calc.domain;
using calc.validation;
using System;
using Xunit;

namespace XUnitCalculatorProcessTest
{
    public class CalculatorProcessTest
    {
        private readonly calc.console.ConsoleProcessor _processor;

        public CalculatorProcessTest()
        {
            _processor = new calc.console.ConsoleProcessor(new Validator());
        }

        [Fact]
        public void UTCalculatorAdditionProcess()
        {

            //Addition 
            Operation _operation = new Operation
            {
                OperationType = "1",
                NumberX = "10.54",
                NumberY = "20.09"
            };

            _processor.Operation = _operation;
            _processor.Execute();

            Assert.Equal(float.Parse(_operation.NumberX) + float.Parse(_operation.NumberY), float.Parse(_operation.Result));


        }

        [Fact]
        public void UTCalculatorSubtractionProcess()
        {

            //Subtraction 
            Operation _operation = new Operation
            {
                OperationType = "2",
                NumberX = "20.43",
                NumberY = "5.543"
            };

            _processor.Operation = _operation;
            _processor.Execute();

            Assert.Equal(float.Parse(_operation.NumberX) - float.Parse(_operation.NumberY), float.Parse(_operation.Result));


        }

        [Fact]
        public void UTCalculatorMultiplyProcess()
        {

            //Subtraction 
            Operation _operation = new Operation
            {
                OperationType = "3",
                NumberX = "20.2",
                NumberY = "5.7"
            };

            _processor.Operation = _operation;
            _processor.Execute();

            Assert.Equal(float.Parse(_operation.NumberX) * float.Parse(_operation.NumberY), float.Parse(_operation.Result));

        }


        [Fact]
        public void UTCalculatorDivideProcess()
        {

            //Subtraction 
            Operation _operation = new Operation
            {
                OperationType = "4",
                NumberX = "21.2",
                NumberY = "3.7"
            };

            _processor.Operation = _operation;
            _processor.Execute();

            Assert.Equal(float.Parse(_operation.NumberX) / float.Parse(_operation.NumberY), float.Parse(_operation.Result));

        }

    }
}
