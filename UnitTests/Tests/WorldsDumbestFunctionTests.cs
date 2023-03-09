using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        //Naming Convention - ClassName_MethodName_ExpectedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                /*Tripple A
                Arrange - Go get your variables , whatever you need, your classes, functions*/
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute this 
                string result = worldsDumbest.ReturnsPikachuIfZero(num);    

                //Assert - Whatever is returned is it what you want.
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");

                } else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero_ReturnsString");

                }


            }
            catch (Exception ex)
            {
               Console.WriteLine(ex);
            }
        }
    }
}
