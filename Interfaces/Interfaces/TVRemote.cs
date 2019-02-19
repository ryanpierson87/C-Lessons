using System;
namespace Interfaces
{
    class TVRemote
    {
            public static IElectronicDevice GetDevice()
            {
                return new Television();
            }
        
    }
}
