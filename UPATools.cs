using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_EXTERNAL_MODELS
{
    public static class UPATools
    {
        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".PNG" };

        public static bool InvalidFileExtension(this List<string> files)
        {
            foreach (var f in files)
                if (!ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                    return true;
            return false;
        }

        public static string GetImageExtension(this string FilePath)
        {
            return "image/" + Path.GetExtension(FilePath).TrimStart('.').ToLower();
        }
        public static bool IsEmptyList(this List<string> files)
        {
            return files == null || files.Count == 0;
        }
        public static bool NE(this object obj)
        {
            if (obj == null)
                return false;
            var st = obj.ToString();
            return !string.IsNullOrEmpty(st) && !string.IsNullOrWhiteSpace(st);
        }
        /// <summary>
        /// Empty
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool EM(this object obj)
        {
            if (obj == null)
                return true;
            var st = obj.ToString();
            return string.IsNullOrEmpty(st) || string.IsNullOrWhiteSpace(st);
        }
        public static bool IsEmpty(this DataTable dt)
        {
            return dt == null || dt.Rows.Count < 1;
        }
        public static int? ToInt(this object d)
        {
            return IntGet(d);
        }
        public static double? ToDouble(this object d)
        {
            return DoubleGet(d);
        }
        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        public static double? DoubleGet(object obj)
        {
            try
            {
                return double.Parse(obj.ToString());
            }
            catch
            {
                return null;
            }
        }
        public static int? IntGet(object obj)
        {
            try
            {
                return int.Parse(obj.ToString());
            }
            catch
            {
                return null;
            }
        }
        public static void ToFile(this string date, string path)
        {
            File.WriteAllText(path, date);
        }
        public static string SerializeObject<T>(this T toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize, Formatting.Indented);
        }

        public static object DeserializeObject(this string toDeSerialize)
        {
            return JsonConvert.DeserializeObject(toDeSerialize);
        }
        public static string NoFormatSerialize<T>(this T toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize, Formatting.None);
        }
    }
}
