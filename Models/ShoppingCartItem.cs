using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MIST.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }
        public Game Game { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int Quantity { get; set; }
    }
}
