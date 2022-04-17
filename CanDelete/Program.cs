using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CanDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test1
            //string ip = Console.ReadLine();
            //string line = "";

            //using (WebClient cl = new WebClient())
            //{
            //    line = cl.DownloadString($"http://ipwhois.app/xml/{ip}");
            //}

            //Match matchOfip = Regex.Match(line, "country>(.*?)</country>(.*?)<currency_code>(.*?)</currency_code>");
            //Console.WriteLine(matchOfip.Groups[1] + " " + matchOfip.Groups[3]);
            #endregion

            #region test2
            //string ip = Console.ReadLine();
            //string line = "";
            //using (WebClient wc = new WebClient())
            //{
            //    line = wc.DownloadString($"http://ipwhois.app/json/{ip}");
            //}

            //Match matchOfCountry = Regex.Match(line, "\"country\":\"(.*?)\",\"country_code\"(.*?)\"latitude\":(.*?),\"longitude\":(.*?),\"asn\"");
            //Console.WriteLine(matchOfCountry.Groups[1].Value);
            //Console.WriteLine("Latitude is: " + matchOfCountry.Groups[3].Value);
            //Console.WriteLine("Longitude is: " + matchOfCountry.Groups[4].Value);

            //var latidute = matchOfCountry.Groups[3].Value;
            //var longitude = matchOfCountry.Groups[4].Value;

            //System.Diagnostics.Process.Start($"https://www.google.com/maps/search/?api=1&query={latidute}%2C{longitude}");
            #endregion

            #region ipFindPlace
            string ip = "";


            while (true)
            {
                try
                {
                    while (true)
                    {

                        Exit4Exit();//Сообщение для выхода
                        ip = Console.ReadLine();//Вводим ip-адрес

                        if (ip == "exit" || ip=="выход")//проверяем на условие выхода из программы
                            Environment.Exit(0);

                        ///Создаем объект класса, который узнает всю информацию об ip-адресе
                        JsonPlaceExplorer placeExplorer = new JsonPlaceExplorer();

                        ///Узнаем всю информацию об ip.
                        placeExplorer.ExploreInfo(ip);

                        ///Ищем местоположением по широте и долготе ip-адреса и открываем гугл карту с местоположением хоста
                        PlaceFinder.FindPlace(placeExplorer);
                    }
                }
                catch (IpException ex)
                {
                    Console.WriteLine($"Error. {ex.Message} Перезапустите программу.");

                }
            }
            #endregion

        }

        public static void Exit4Exit()
        {
            Console.WriteLine("Введите \"exit\" или \"выход\" чтобы выйти..."); 
                
        }
    }
}
