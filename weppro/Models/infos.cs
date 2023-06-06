using System.ComponentModel.DataAnnotations;

namespace weppro.Models

{
    public class infos
{

    public int Steps { get; set; }
    [Key]
        public DateTime Date { get; set; }
    }
}
