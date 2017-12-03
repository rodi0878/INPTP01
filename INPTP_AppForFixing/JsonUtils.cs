﻿using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace INPTP_AppForFixing
{
    /// <summary>
    /// Singleton containing methods for exporting data objets to JSON file.
    /// </summary>
    public class JsonUtils
    {
        private static JsonUtils instance = new JsonUtils();

        /// <summary>
        /// Default target file for serializing methods such as SerializeBossToFile()
        /// </summary>
        public const string DEFAULT_EXPORT_FILE = "exported_boss.json";

        private DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Boss));
        private JsonUtils() {}

        ///  <returns> Instance of this singleton </returns>
        public static JsonUtils Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Serializes given Boss object as JSON and saves it to targetFile. 
        /// If file already exists, new content will be appended.
        /// Default targetFile is ExportUtils.DEFAULT_EXPORT_FILE.
        /// </summary>
        /// <param name="boss"> Boss object to serialize </param>
        /// <param name="targetFile"> File, which will contain serialized data </param>
        public void SerializeBossToFile(Boss boss, string targetFile = DEFAULT_EXPORT_FILE)
        {
            if (boss == null) throw new ArgumentNullException("Given Boss object was null!");
            if (targetFile == null) throw new ArgumentNullException("Given target path was null!");

            FileStream target = File.OpenWrite(targetFile);

            jsonSerializer.WriteObject(target, boss);

            target.Close();
        }

         /// <summary>
         /// Deserialize Boss from given file.
         /// Default targetFile is ExportUtils.DEFAULT_EXPORT_FILE.
         /// </summary>
         /// <param name="targetFile"> File, which will contain serialized data </param>
         /// <returns> Boss including his employees</returns>
         public Boss DeserializeBossFromFile(string targetFile = DEFAULT_EXPORT_FILE)
         {
            
             if (targetFile == null) throw new ArgumentNullException("Given target path was null!");
 
             FileStream source = File.OpenRead(targetFile);
             Boss deserializedBoss = (Boss)jsonSerializer.ReadObject(source);
             source.Close();
 
             return deserializedBoss;
         }
    }
}
