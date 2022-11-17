using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTEst.StepDefinitions
{
    [Binding]
    internal class UserSeptDefiniton
    {
        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
           var person = new Fixture().Build<User>()
                .With(x => x.Email,"Hola@gmail.com")
                .Create();

            Console.WriteLine($"The User {person.Name} has email {person.Email} and his Address {person.Address} and The Phone is {person.Phone}");
        }

        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForHolaGmail_ComEmail(string email)
        {
            Console.WriteLine($"The random email address is : {email}");
        }


    }

    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
