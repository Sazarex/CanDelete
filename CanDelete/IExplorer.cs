using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanDelete
{
    /// <summary>
    /// Интерфейс, который реализуют все классы, изучающие IP
    /// </summary>
    interface IExplorer
    {
        void ExploreInfo(string ip);

        string ReturnIPInfo();
    }
}
