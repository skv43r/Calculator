using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers.api
{
    public class CalculatorController : ApiController
    {
        [HttpPost]

        public CalculatorResponse Calculate (CalculatorRequest request)
        {
            decimal result;

            switch (request.Action)
            {
                case "+":
                    result = request.DigA + request.DigB;
                    break;
                case "-":
                    result = request.DigA - request.DigB;
                    break;
                case "*":
                    result = request.DigA * request.DigB;
                    break;
                case "/":
                    result = request.DigA / request.DigB;
                    break;
                case "^":
                    result = (decimal)Math.Pow ((double)request.DigA, (double)request.DigB);
                    break;
                default:
                    throw new InvalidOperationException();
            }

            return new CalculatorResponse { Result = result };
        }
    }
}
