using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Base
{
    public class BaseEntity
    {
        public int Id { get; protected set; } 
        public bool IsDeleted { get; protected set; }
        public DateTime createdAt { get; protected set; } 
    }
}
