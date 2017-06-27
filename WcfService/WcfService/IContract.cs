using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IIContract" в коде и файле конфигурации.
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}
