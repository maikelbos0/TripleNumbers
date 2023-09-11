using System.ComponentModel.DataAnnotations;

namespace TripleNumbers.Models {
    public class HomeModel {
        [Required(ErrorMessage = "Please provide a sequence of numbers")]
        public string? Input { get; set; }
        public string? Output { get; set; }
    }
}
