using System;
using calc.integration;

namespace calc.operations
{
    public class Subtraction : IOperation<Subtraction>
    {
        public float Operation(float numberX, float numberY)
        {
            try
            {
                Func<float, float, float> func = (x, y) => x - y;
                return func(numberX, numberY);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
