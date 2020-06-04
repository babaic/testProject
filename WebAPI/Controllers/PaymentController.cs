using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost("pay")]
        public ActionResult Pay(string stripeToken)
        {
            var token = GetToken();
            StripeConfiguration.ApiKey = "sk_test_ZYySFlXrQCDciqzHKybrdcWU";

            // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
            var options = new ChargeCreateOptions
            {
                Amount = 2000,
                Currency = "usd",
                Source = token,
                Description = "My First Test Charge (created for API docs)",
            };
            var service = new ChargeService();
            service.Create(options);

            return Ok();
        }

        [HttpGet("token")]
        public IActionResult Token()
        {
            StripeConfiguration.ApiKey = "sk_test_4eC39HqLyjWDarjtT1zdp7dc";

            var options = new TokenCreateOptions
            {
                Card = new CreditCardOptions
                {
                    Number = "4242424242424242",
                    ExpYear = 2021,
                    ExpMonth = 5,
                    Cvc = "123"
                }
            };

            var service = new TokenService();
            Token stripeToken = service.Create(options);
            var token = stripeToken.Id;
            return Ok(stripeToken);
        }

        public string GetToken()
        {
            StripeConfiguration.ApiKey = "sk_test_ZYySFlXrQCDciqzHKybrdcWU";

            var options = new TokenCreateOptions
            {
                Card = new CreditCardOptions
                {
                    Number = "4242424242424242",
                    ExpYear = 2021,
                    ExpMonth = 5,
                    Cvc = "123"
                }
            };

            var service = new TokenService();
            Token stripeToken = service.Create(options);
            return stripeToken.Id;
        }



    }
}