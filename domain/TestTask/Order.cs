using System.ComponentModel.DataAnnotations;


namespace TestTask
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        public string SenderCity { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        public string SenderAddress { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        public string AddresseeCity { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        public string AddresseeAddress { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        public int? Weight { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        [RegularExpression(@"^\d{2}.\d{2}.\d{4}$", ErrorMessage = "Date must be in fotmat xx.xx.xxxx")]
        public string Date { get; set; }
    }
}
