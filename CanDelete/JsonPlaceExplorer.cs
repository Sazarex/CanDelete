using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CanDelete
{
    class JsonPlaceExplorer : IExplorer
    {
        private string IpInfo { get; set; }//Json информация об ip

        public void ExploreInfo(string ip)//Пробиваем всю инфу за ip
        {
            Regex patternForIp = new Regex(@"^((1\d\d|2([0-4]\d|5[0-5])|\d\d?)\.?){4}$");


            if (!(patternForIp.IsMatch(ip)))
                throw new IpException("Неверно введен IP-адрес.");


            using (WebClient wc = new WebClient())
            {
                IpInfo = wc.DownloadString($"http://ipwhois.app/json/{ip}");
            }
        }

        public string ReturnIPInfo()//Возвращаем Json инфу об ip
        {
            return IpInfo;
        }

    }
}
