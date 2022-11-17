using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTEst.Transformer
{
    [Binding]
    public class EmailTransformer
    {

        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAdrees(string emailAddress)
        {
            return emailAddress.Split("@")[0] + "@" +GetrandomDomain();
        }

        private string GetrandomDomain()
        {
            return new Fixture().Create<MailAddress>().Host;
        }
    }
}
