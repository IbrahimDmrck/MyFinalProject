using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
        /*Burada sadece get olara yazmamızın nedeni daha sonra bu projeyi geliştirecek bir programcı bunu bir constructor yapısı ile kullansın ve kafasına göre metotlar 
        eklemesin tamamen standart isimler olsun diye*/
    }
}
