using Newtonsoft.Json;

namespace g0rdan.Utilities
{
    public static class JsonHelper
    {
        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T Deserialize<T>(this string model)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(model);
            }
            catch
            {
                return default(T);
            }
        }
    }
}