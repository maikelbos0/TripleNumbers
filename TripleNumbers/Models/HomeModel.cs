using System.ComponentModel.DataAnnotations;

namespace TripleNumbers.Models {
    public class HomeModel {
        [Required(ErrorMessage = "Please provide a sequence of numbers")]
        [RegularExpression("^\\[-?\\d+(,-?\\d+)*\\]$", ErrorMessage = "Please provide a sequence of numbers in the format [1,3,2,3,4,3,5]")]
        public string? Input { get; set; }
        public string? Output { get; set; }
    }
}
