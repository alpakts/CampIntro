using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{  // referans tutsun ve interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır
    // loglama
    interface ICreditManager
    {
        void Calculate();
        void pay();

    }
}
