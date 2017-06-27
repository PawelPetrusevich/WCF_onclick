using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "IContract" в коде и файле конфигурации.
    public class Contract : IContract
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
