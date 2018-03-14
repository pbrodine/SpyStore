using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpyStore.Models.Entities.Base
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public byte[] TimeStamp { get; set; }
    }

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public interface Id { get; set; }

    [Timestamp]
    public byte[] TimeStamp { get; set; }
}
