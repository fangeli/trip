using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TripMakerJson
{
    public class JsonUtility
    {
        /// <summary>
        /// Deserializza il JSON nello specifico .NET type
        /// </summary>
        /// <typeparam name="T">Classe dell'oggetto</typeparam>
        /// <param name="txt">Valore oggetto da serializzare</param>
        /// <returns></returns>
        public static T DeserializeObjectByText<T>(string txt)
        {
            return JsonConvert.DeserializeObject<T>(txt);
        }

        /// <summary>
        /// Deserializza il JSON  letto dal path nello specifico .NET type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T DeserializeObjectByPath<T>(string path)
        {
            T retval = default(T);
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                retval = JsonConvert.DeserializeObject<T>(readText);

            }
            return retval;
        }

        /// <summary>
        /// Serializza l'oggetto in una stringa JSON
        /// </summary>
        /// <typeparam name="T">.NET type</typeparam>
        /// <param name="obj">Valore oggetto da serializzare</param>
        /// <returns></returns>
        public static string SerializeObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }
}
