using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HRManagement
{
    public class FileHelper<T> where T : new()
    {
        private readonly string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T workers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, workers);
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                return (T)serializer.Deserialize(streamReader);
            }
        }
    }
}
