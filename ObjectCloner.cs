using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lrt_Ilukste
{
    internal static class ObjectCloner
    {
        /// 
        /// Clones an object by using the .
        /// 
        /// The object to clone.
        /// 
        /// The object to be cloned must be serializable.
        /// 
        public static object Clone(object obj)
        {
            using (MemoryStream buffer = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(buffer, obj);
                buffer.Position = 0;
                object temp = formatter.Deserialize(buffer);
                return temp;
            }
        }
    }
}
