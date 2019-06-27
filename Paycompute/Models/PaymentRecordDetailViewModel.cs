using Paycompute.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Paycompute.Models
{
    public class PaymentRecordDetailViewModel
    {
        public int Id { get; set; }        
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Display(Name = "Employee")]
        public string FullName { get; set; }
        public string NiNo { get; set; }
        [DataType(DataType.Date), Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; }
        [Display(Name = "Pay Month")]
        public string PayMonth { get; set; }
        [Display(Name = "Tax Year")]
        public int TaxYearId { get; set; }
        public string Year { get; set; }
        public TaxYear TaxYear { get; set; }
        [Display(Name = "Tax Code")]
        public string TaxCode { get; set; } 
        [Display(Name = "Hourly Rate")]
        public decimal HourlyRate { get; set; }
        [Display(Name = "Hours Worked")]
        public decimal HoursWorked { get; set; }
        [Display(Name = "Contractual Hours")]
        public decimal ContractualHours { get; set; }
        [Display(Name = "Overtime Hours")]
        public decimal OvertimeHours { get; set; }
        [Display(Name = "Overtime Rate")]
        public decimal OvertimeRate { get; set; }

        [Display(Name = "Contractual Earnings")]
        public decimal ContractualEarnings { get; set; }
        [Display(Name = "Overtime Earnings")]
        public decimal OvertimeEarnings { get; set; }
        public decimal Tax { get; set; }
        public decimal NIC { get; set; }
        [Display(Name = "Union Fee")]
        public decimal? UnionFee { get; set; }
        public Nullable<decimal> SLC { get; set; }
        [Display(Name = "Total Earnings")]
        public decimal TotalEarnings { get; set; }
        [Display(Name = "Total Deductions")]
        public decimal TotalDeduction { get; set; }
        [Display(Name = "Net Payment")]
        public decimal NetPayment { get; set; }
    }
}
