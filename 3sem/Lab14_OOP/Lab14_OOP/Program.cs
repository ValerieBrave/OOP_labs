using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Lab14_OOP
{
    [Serializable]
    [XmlRoot]
    public class Train
    {
        public int passengers;
        public int carriages;
        public string destination;
        public DateTime departure;
        public Train()
        {
            this.passengers = 0;
            this.carriages = 0;
            this.destination = "";
        }
        public Train(int p, int c, string d, DateTime time)
        {
            this.passengers = p;
            this.carriages = c;
            this.destination = d;
            this.departure = time;
        }
        public override string ToString()
        {
            return "destination: "+this.destination+" departure: "+ this.departure.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train(300, 10, "Minsk", new DateTime(2019, 12, 31, 23, 0, 0));
            Serialize.toXML("train.xml", train);
            Serialize.toJSON("train.json", train);
            Serialize.toSOAP("train.dat", train);
            Serialize.toBinary("trainBIN.dat", train);
            //-------------------------------------------------
            Train[] trainstofile = new Train[]
            {
                new Train(244, 7, "Moscow", new DateTime(2019, 12, 2, 14, 30, 0) ),
                new Train(100, 4, "Moscow", new DateTime(2019, 12, 6, 18, 0, 0) ),
                new Train(80, 4, "Moscow", new DateTime(2019, 12, 10, 12, 0, 0) ),
                new Train(100, 4, "Brest", new DateTime(2019, 12, 5, 22, 15, 0) ),
                new Train(314, 10, "Adler", new DateTime(2019, 12, 2, 14, 30, 0) ),
                new Train(100, 4, "Tallin", new DateTime(2019, 12, 3, 12, 30, 0) ),
                new Train(400, 12, "Warsaw", new DateTime(2019, 12, 13, 20, 50, 0) ),
                new Train(170, 5, "Mogilev", new DateTime(2019, 12, 15, 21, 30, 0) ),
                new Train(100, 4, "Moscow", new DateTime(2019, 12, 3, 12, 0, 0) ),
                new Train(324, 9, "Saint-Petersburg", new DateTime(2019, 12, 25, 19, 45, 0) ),
            };
            XmlSerializer sr = new XmlSerializer(typeof(Train[]));
            using (FileStream fs = new FileStream("trains.xml", FileMode.Create))
            {
                sr.Serialize(fs, trainstofile);
            }
            Train[] trainsfromfile;
            using (FileStream fs = new FileStream("trains.xml", FileMode.OpenOrCreate))
            {
               trainsfromfile = (Train[])sr.Deserialize(fs);
            }
            foreach (Train t in trainsfromfile) Console.WriteLine(t.ToString());
            //-----------------------------------------------------------------------------------------
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D:\\OOP\\Lab14_OOP\\Lab14_OOP\\bin\\Debug\\trains.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList trains = xRoot.SelectNodes("Train[destination='Moscow']");
            foreach (XmlNode t in trains) Console.WriteLine(t.InnerXml);
            XmlNode tallin = xRoot.SelectSingleNode("Train[destination ='Tallin']");
            if (tallin != null) Console.Write(tallin.InnerXml);
            //----------------------------------------------------------------------------------------
            XDocument xdoc = new XDocument();
            XElement train1 = new XElement("Train");
            XAttribute train1_num = new XAttribute("number", "12453");
            XElement dest1 = new XElement("destination", "Adler");
            train1.Add(train1_num);
            train1.Add(dest1);

            XElement train2 = new XElement("Train");
            XAttribute train2_num = new XAttribute("number", "10983");
            XElement dest2 = new XElement("destination", "Tbilisi");
            train2.Add(train2_num);
            train2.Add(dest2);

            XElement train3 = new XElement("Train");
            XAttribute train3_num = new XAttribute("number", "18543");
            XElement dest3 = new XElement("destination", "Baku");
            train3.Add(train3_num);
            train3.Add(dest3);

            XElement all = new XElement("dests");
            all.Add(train1);
            all.Add(train2);
            all.Add(train3);

            xdoc.Add(all);
            xdoc.Save("dests.xml");
            Console.ReadKey();
        }
    }
}
