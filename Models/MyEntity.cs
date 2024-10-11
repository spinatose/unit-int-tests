using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEFDataLibrary.Models
{
    public abstract class MyEntity
    {

        public bool? Active { get; set; }

        [Column("CreateUserID")]
        public int CreateUserId { get; set; }

        public DateTime CreateDatetime { get; set; }

        [Column("UpdateUserID")]
        public int? UpdateUserId { get; set; }

        public DateTime? UpdateDatetime { get; set; }
    }
}
