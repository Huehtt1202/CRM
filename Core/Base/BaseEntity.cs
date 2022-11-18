using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        T IBaseEntity<T>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBaseEntity<T>.CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime? IBaseEntity<T>.CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBaseEntity<T>.LastModificationUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DateTime? IBaseEntity<T>.LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IBaseEntity<T>.IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBaseEntity<T>.DeletetionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBaseEntity<T>.DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class BaseEntity : BaseEntity<string>
    {
        [Key]
        string Id = Guid.NewGuid().ToString();
    }
}
