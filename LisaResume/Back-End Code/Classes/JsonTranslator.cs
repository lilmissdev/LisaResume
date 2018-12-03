using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using LisaResume.Back_End_Code.Classes;
using LisaResume.Back_End_Code.Interfaces;
using Newtonsoft.Json;
using System.Globalization;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using LisaResume.Back_End_Code.Classes.Serializable_Classes;
using Formatting = System.Xml.Formatting;


/*
 *      If you are reading this:
 *
 *      Thank you for taking the time to review my code! In this code set, I do the same thing several different ways sometimes so I can show off the various ways of doing any given task.
 *
 *      An example of this would be the public bool isSaved has the method-style getters and setters whereas the public string FilePath uses the auto getters and setters.
 *
 *      Additionally, please take the time to review Translator.cs, Singleton.cs, Itranslatable.cs, and Classbuilder.cs. I made those classes to to demonstrate some Object Oriented programming techniques.
 *          •   Translator.cs is a parent class. I could have made it abstract, as it is never instantiated. Instead, it contains properties and methods that all the translator classes inherit.
 *          •   Singleton.cs is just what it sounds like. It's a singleton. I use it to hold certain properties that I need to access regardless of what class I'm currently using.
 *          •   Itranslatable.cs is an interface with methods such as Save(), Translate(), Load() and Publish() which I want all of my translator classes to implement.
 *          •   ClassBuilder.cs has a variety of methods that I use for the implementation of my code. Ultimately, several methods are unused, as I decided to go a different route in code. But I left them there as they showcase other c# concepts.
 *
 *
 *      Thanks again for taking the time to read my code. I really hope it impresses you and I would love to get the chance to come in for an interview.
 *          Lisa Connell
 * */





namespace LisaResume.Back_End_Code
{
    class JsonTranslator : Translator, ITranslatable
    {
        //The constructor for this class asks for the current document type, so I can select the right type of object, the future document type so I can choose the right method, and the FilePath of the file I will use to translate.
        public JsonTranslator(CurrentDocType current, FutureDocType future, string path)
        {
            CurrentDocumentType = current;
            FutureDocumentType = future;
            FilePath = path;
        }

        private LisaResume.Back_End_Code.Classes.Serializable_Classes.Rootobject JsonObject { get; set; }
        public bool isSaved
        {
            get { return mIsSaved; }
            set { mIsSaved = value; }
        }

        private bool mIsSaved = false;
        public string FilePath { get; set; }

        private void ToXml()
        {
            Load(FilePath, CurrentDocumentType);
            var rootLevelJson = new RootLevel();
            XmlDocument xml;
            string xmlString;

            rootLevelJson.root.Add(JsonObject);

            xml = (XmlDocument)JsonConvert.DeserializeXmlNode(JsonConvert.SerializeObject(rootLevelJson));
            xmlString = JsonConvert.SerializeXmlNode(xml);


            XmlElement root = xml.DocumentElement;
            XmlComment comment = xml.CreateComment("Comment");
            root.AppendChild(comment);

            using (MemoryStream mStream = new MemoryStream())
            using (XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                xml.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();
                mStream.Position = 0;
                StreamReader sReader = new StreamReader(mStream);
                string formattedXml = sReader.ReadToEnd();
                xmlString = formattedXml;
            }

            FilePath = Path.Combine(Path.GetDirectoryName(FilePath),
                                       Path.GetFileNameWithoutExtension(FilePath) + "." + GetFutureDocType(FutureDocumentType));

            Save(xmlString, FilePath);

            Publish(FilePath);
        }

        private void ToHtml()
        {
            FilePath = Path.Combine(Path.GetDirectoryName(FilePath),
                                    Path.GetFileNameWithoutExtension(FilePath) + "." + GetFutureDocType(FutureDocumentType));
            throw new NotImplementedException();
        }

        public void Translate(Enum @enum)
        {
            var myEnum = @enum.ToFutureDocType();
            FutureDocumentType = myEnum;
            var singleton = Singleton.GetSingleton();
            singleton.CurrentDocumentType = CurrentDocumentType;
            singleton.FutureDocumentType = FutureDocumentType;
            var newClass = ClassBuilder.ChooseClass(FutureDocumentType, CurrentDocumentType, FilePath);

            switch (FutureDocumentType)
            {
                case FutureDocType.Xml:
                    {
                        ToXml();
                        singleton.CurrentDocumentType = CurrentDocType.Xml;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
                case FutureDocType.Html:
                    {
                        ToHtml();
                        singleton.CurrentDocumentType = CurrentDocType.Html;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
                case FutureDocType.Json:
                    {
                        Load(FilePath, FutureDocumentType);
                        Publish(FilePath);
                        singleton.CurrentDocumentType = CurrentDocType.Json;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
                case FutureDocType.Binary:
                {
                    break;
                }
                case FutureDocType.Hex:
                {
                    break;
                }
            }
        }


        public void Publish(string path)
        {
            //Process notepad = Process.Start("notepad.exe", path);
        }

        public void Save(string text, string path)
        {
            File.WriteAllText(path, text);
        }

        public void Load(string path, Enum @enum)
        {
            if (!File.Exists(path))
                return;
            JsonObject = JsonConvert.DeserializeObject<LisaResume.Back_End_Code.Classes.Serializable_Classes.Rootobject>(File.ReadAllText(path));

            if (JsonObject == null)
            {
                JsonObject =
                    JsonConvert
                       .DeserializeObject<Classes.Serializable_Classes.Rootobject
                        >(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                                        @"Components\LisaResume.json")));
            }
        }

        public Enum CheckDocType(string path)
        {
            var suffix = Path.GetExtension(path);
            return (CurrentDocType)Enum.Parse(typeof(CurrentDocType), suffix, true);
        }
    }
}
