using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Models
{
    public class PlayerDetail
    {
        [Key]
        public int PlayerDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PlayerName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string PlayerCountry { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Position { get; set; }

        [Column(TypeName = "int")]
        public int JerseyNo { get; set; }
        
        [Column(TypeName = "int")]
        public int Games { get; set; }

        [Column(TypeName = "int")]
        public int Goals { get; set; }
    }
}
