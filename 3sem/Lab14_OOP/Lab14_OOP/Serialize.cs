using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab14_OOP
{
    public static class Serialize
    {
        public static void toXML(string filename, Train obj)
        {
            XmlSerializer sr = new XmlSerializer(typeof(Train));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                sr.Serialize(fs, obj);
            }
        }
        public static void toJSON(string filename, Train obj)
        {
            var json = new JavaScriptSerializer().Serialize(obj);
            File.WriteAllText(filename, json);
        }
        public static void toSOAP(string filename, Train obj)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream(filename,FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, obj);
            }
        }
        public static void toBinary(string filename, Train obj)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, obj);
            }
        }
    }
}
