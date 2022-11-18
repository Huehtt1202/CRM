using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    internal interface IBaseEntity<T>
    {
        T Id { get; set; }
        string CreatorUserId { get; set; }
        DateTime? CreationTime { get; set; }
        string LastModificationUserId { get; set; }

        DateTime? LastModificationTime { get; set; }

        bool IsDeleted { get; set; }
        string DeletetionTime { get; set; }

        string DeleterUserId { get; set; }
    }
}
