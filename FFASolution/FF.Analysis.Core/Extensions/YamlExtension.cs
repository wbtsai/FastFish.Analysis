// -----------------------------------------------------------------------
// <copyright file="YamlExtension.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using System.IO;
    using System.Xml;
    using System.Yaml.Serialization;
    using System.Yaml;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class YamlExtension
    {
        /// <summary>
        /// Object To Xml String
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string SerializeAsYaml(this object element)
        {
            return SerializeAsYaml(element,null);
        }

        /// <summary>
        /// Object to Xml String
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="extraTypes"></param>
        /// <returns></returns>
        public static string SerializeAsYaml(this object element, YamlConfig config) 
        {
           YamlSerializer serializer=new YamlSerializer(config);

            return serializer.Serialize(element);

        }

        /// <summary>
        /// Object to xml File
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="xmlPath"></param>
        public static void SerializeAsYamlToFile(this object element, string yamlPath)
        {
            SerializeAsYamlToFile(element, yamlPath, null);
        }

        /// <summary>
        /// Object to xml File
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="xmlPath"></param>
        /// <param name="extraTypes"></param>
        public static void SerializeAsYamlToFile(this object element, string yamlPath, YamlConfig config)
        {
            YamlSerializer serializer=new YamlSerializer(config);

            serializer.SerializeToFile(yamlPath,element);
        }

        

        /// <summary>
        /// Xml Path to Object
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static TDestination DeserializeYamlFromPath<TDestination>(this string yamlPath) where TDestination : new()
        {
            return DeserializeYamlFromPath<TDestination>(yamlPath,null);
                        
        }

        

        public static TDestination DeserializeYamlFromPath<TDestination>(this string yamlPath,YamlConfig config) where TDestination : new()
        {
            YamlSerializer serializer=new YamlSerializer(config);

            object[] obj=serializer.DeserializeFromFile(yamlPath,typeof(TDestination));

            return (TDestination)obj[0];
        }

        public static TDestination DeserializeYaml<TDestination>(this string yamlString) where TDestination : new()
        {
            return DeserializeYaml<TDestination>(yamlString,null);
        }

        public static TDestination DeserializeYaml<TDestination>(this string yamlString,YamlConfig config) where TDestination : new()
        {
            YamlSerializer serializer=new YamlSerializer(config);

            object[] obj= serializer.Deserialize(yamlString,typeof(TDestination));

            return (TDestination)obj[0];

        }
    }
}
