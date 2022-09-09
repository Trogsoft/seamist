using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trogsoft.SeaMist.Core.Abstractions;

namespace Trogsoft.SeaMist.Core.Services
{
    public class SeaMistContentService : ISeaMistContentService
    {

        private readonly IOptions<SeaMistConfiguration> smc;

        public SeaMistContentService(IOptions<SeaMistConfiguration> smc)
        {
            this.smc = smc;
        }

    }
}
