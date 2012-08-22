// -----------------------------------------------------------------------
// <copyright file="XmlExtension.cs" company="yuanta">
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

    /// <summary>
    /// Xml extension
    /// </summary>
    public static class XmlExtension
    {
        /// <summary>
        /// Object To Xml String
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string SerializeAsXml<TSource>(this object element) where TSource : new()
        { 
            return SerializeAsXml<TSource>(element, new Type[] { }); 
        }  
        
        /// <summary>
        /// Object to Xml String
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="extraTypes"></param>
        /// <returns></returns>
        public static string SerializeAsXml<TSource>(this object element, Type[] extraTypes) where TSource : new() 
        { 
            var serializer = new XmlSerializer(typeof(TSource), extraTypes);
            
            var output = new StringBuilder(); 
            
            using (StringWriter writer = new XmlStringWriter(output)) 
            { 
                serializer.Serialize(writer, element); 
            } 
            
            return output.ToString(); 
        }

        /// <summary>
        /// Object to xml File
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="xmlPath"></param>
        public static void SerializeAsXml<TSource>(this object element,string xmlPath) where TSource : new()
        {
            SerializeAsXml<TSource>(element,xmlPath,new Type[] { });
        }

        /// <summary>
        /// Object to xml File
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="element"></param>
        /// <param name="xmlPath"></param>
        /// <param name="extraTypes"></param>
        public static void SerializeAsXml<TSource>(this object element, string xmlPath, Type[] extraTypes) where TSource : new()
        {
            var serializer = new XmlSerializer(typeof(TSource), extraTypes);

            using (TextWriter writer = new StreamWriter(xmlPath))
            {
                serializer.Serialize(writer, element);
            }
        }
        
        /// <summary>
        /// Xml Path to Object
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static TDestination DeserializeFromPath<TDestination>(this string xmlPath) where TDestination : new() 
        {
            return DeserializeFromPath<TDestination>(xmlPath, new Type[] { }); 
        }  
        
        /// <summary>
        /// Xml String Object
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="xmlPath"></param>
        /// <param name="extraTypes"></param>
        /// <returns></returns>
        public static TDestination DeserializeFromPath<TDestination>(this string xmlPath, Type[] extraTypes) where TDestination : new() 
        { 
            using (var fs = new FileStream(xmlPath, FileMode.Open)) 
            { 
                var reader = XmlReader.Create(fs); 
                var serializer = new XmlSerializer(typeof(TDestination), extraTypes); 
                
                if (serializer.CanDeserialize(reader))
                { 
                    return (TDestination)serializer.Deserialize(reader); 
                } 
            } 
            
            return default(TDestination); 
        }

        public static TDestination Deserialize<TDestination>(this string xmString) where TDestination : new()
        {
            return Deserialize<TDestination>(xmString, new Type[] { });
        }

        public static TDestination Deserialize<TDestination>(this string xmlString, Type[] extraTypes) where TDestination : new()
        {
            StringReader read = new StringReader(xmlString);

            XmlReader reader = new XmlTextReader(read);

            var serializer = new XmlSerializer(typeof(TDestination), extraTypes);

            if (serializer.CanDeserialize(reader))
            {
                return (TDestination)serializer.Deserialize(reader);
            }
            
            return default(TDestination);
        }
    }

    public class XmlStringWriter : StringWriter
    { 
        public XmlStringWriter(StringBuilder builder) : base(builder)
        { } 
        
        public override Encoding Encoding { get { return Encoding.UTF8; } } 
    } 
}
