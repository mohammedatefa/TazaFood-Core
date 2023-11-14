using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TazaFood_Core.Models.Order_Aggregate
{
    public enum DeliveryStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "PaymentRecived")]
        PaymentRecived,
        [EnumMember(Value = "PaymentFailed")]
        PaymentFailed
    }
}
