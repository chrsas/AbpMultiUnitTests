using System;
using System.ComponentModel.DataAnnotations;

namespace Sdt.Common
{
    public interface IRowVersion
    {
        [Timestamp]
        byte[] RowVersion { get; set; }
    }
}
