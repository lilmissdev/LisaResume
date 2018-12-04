using System;

using LisaResume.Back_End_Code.Interfaces;

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

namespace LisaResume.Back_End_Code.Classes
{
    class HtmlTranslator : Translator, ITranslatable
    {
        public HtmlTranslator(CurrentDocType current, FutureDocType future, string path)
        {
            CurrentDocumentType = current;
            FutureDocumentType = future;
        }
        public bool isSaved { get; set; }
        public string FilePath { get; set; }
        public void Translate(Enum @enum)
        {
            throw new NotImplementedException();
        }

        public void Publish(string Path)
        {
            throw new NotImplementedException();
        }


        public void Save(string text, string Path)
        {
            throw new NotImplementedException();
        }

        public void Load(string path, Enum @enum)
        {
            throw new NotImplementedException();
        }

        public Enum CheckDocType(string Path)
        {
            throw new NotImplementedException();
        }
    }
}
