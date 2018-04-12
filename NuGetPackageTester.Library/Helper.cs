using System;

namespace NuGetPackageTester.Library
{
    public class Helper
    {
        public static string ToJson(object value)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }
    }
}
