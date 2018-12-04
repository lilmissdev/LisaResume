using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

using LisaResume.Back_End_Code;
using LisaResume.Back_End_Code.Classes;
using LisaResume.Back_End_Code.Classes.Serializable_Classes;
using LisaResume.Back_End_Code.Interfaces;

using Newtonsoft.Json;

using Formatting = Newtonsoft.Json.Formatting;

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

namespace LisaResume
{
    class XmlTranslator : Translator, ITranslatable
    {
        public root XmlRoot { get; set; }
        public XmlTranslator(CurrentDocType current, FutureDocType future, string path)
        {
            CurrentDocumentType = current;
            FutureDocumentType = future;
            FilePath = path;
        }
        public bool isSaved { get; set; }
        public string FilePath { get; set; }

        public void ToJson()
        {
            XmlDocument doc = new XmlDocument();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Components\LisaResume.xml");
            var xmlString = File.ReadAllText(path);
            doc.LoadXml(xmlString);
            doc.RemoveChild(doc.FirstChild);
            doc.RemoveChild(doc.FirstChild);
            path = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                                 @"Components\DefaultLisaResume.json"));
            var json = JsonConvert.DeserializeObject<Back_End_Code.Classes.Serializable_Classes.Rootobject>(path);
            var jsonText = JsonConvert.SerializeObject(json, Formatting.Indented);

            FilePath = Path.Combine(Path.GetDirectoryName(FilePath),
                                    Path.GetFileNameWithoutExtension(FilePath) + "." + GetFutureDocType(FutureDocumentType));

            Save(jsonText, FilePath);

            Publish(FilePath);
        }

        public void ToHtml()
        {
            FilePath = Path.Combine(Path.GetDirectoryName(FilePath),
                                    Path.GetFileNameWithoutExtension(FilePath) + "." + GetFutureDocType(FutureDocumentType));
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
                case FutureDocType.Json:
                    {
                        ToJson();
                        singleton.CurrentDocumentType = CurrentDocType.Xml;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
                case FutureDocType.Html:
                    {
                        ToHtml();
                        singleton.CurrentDocumentType = CurrentDocType.Xml;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
                case FutureDocType.Xml:
                    {
                        Load(FilePath, FutureDocumentType);
                        Publish(FilePath);
                        singleton.CurrentDocumentType = CurrentDocType.Xml;
                        singleton.DocumentClass = newClass;
                        FilePath = Path.ChangeExtension(FilePath, GetFutureDocType(FutureDocumentType));
                        break;
                    }
            }
        }

        public void Publish(string Path)
        {
            //Process notepad = Process.Start("notepad.exe", path);
        }

        public void Save(string text, string Path)
        {
            System.IO.File.WriteAllText(Path, text);
        }

        public void Load(string path, Enum @enum)
        {
            switch (@enum)
            {
                case CurrentDocType.Json:
                    {
                        var json = new JsonTranslator(CurrentDocumentType, FutureDocumentType, FilePath);
                        json.Translate(FutureDocumentType);
                        break;
                    }
                case CurrentDocType.Xml:
                    {
                        var serializer = new XmlSerializer(typeof(root));
                        StreamReader reader = new StreamReader(FilePath);
                        XmlRoot = (root)serializer.Deserialize(reader);
                        reader.Close();
                        break;
                    }
                case CurrentDocType.Html:
                    {
                        var html = new HtmlTranslator(CurrentDocumentType, FutureDocumentType, FilePath);
                        html.Translate(FutureDocumentType);
                        break;
                    }
            }
        }

        public Enum CheckDocType(string Path)
        {
            throw new NotImplementedException();
        }
    }
}
