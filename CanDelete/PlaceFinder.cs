using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CanDelete
{

    static class PlaceFinder
    {

        public static void FindPlace(IExplorer placeExplorer)//Ищем место на карте по широте и долготе
        {
            Regex patternForFindPlace = null;

            if (placeExplorer is JsonPlaceExplorer)//Проверка на формат explorer'a
            {
                patternForFindPlace = new Regex("\"latitude\":(.*),\"longitude\":(.*),\"asn\"");
            }

            Match matchOfCountry = patternForFindPlace.Match(placeExplorer.ReturnIPInfo());

            var latidute = matchOfCountry.Groups[1].Value;
            var longitude = matchOfCountry.Groups[2].Value;

            System.Diagnostics.Process.Start($"https://www.google.com/maps/search/?api=1&query={latidute}%2C{longitude}");

        }
    }
}
