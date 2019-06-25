using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
