using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
