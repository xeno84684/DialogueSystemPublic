using System;
using System.Collections;
using System.Collections.Generic;
using DialogueStuff;


namespace TextRPG {
    public static class Events {
        public static DialogueSequence felix = new DialogueSequence() {
            Name = "Felix"
        };
        public static DialogueSequence John = new DialogueSequence() {
            Name = "John"
        };
        public static void DefineDialogues () {
            
            //Felix
            felix.AddDialogue(new Dialogue("Felix", new List<string>() {
                "Sample Dialogue",
                "Test Dialogue",
                "..."
            }));
            felix.AddDialogue(new Dialogue("Leal Coates", new List<string>() {
                "Test Dialogue",
                "Test Dialogue",
                "Blah blah blah",
                "Test Dialogue"
            }));
            felix.AddDialogue(new Dialogue("Felix", new List<string>() {
                "Sample Dialogue",
                "Sample Dialogue"
            }));
            felix.AddDialogue(new Dialogue("Leal Coates", new List<string>() {
                "...",
                "...",
                "..."
            }));
            felix.AddDialogue(new Dialogue("Felix", new List<string>() {
                "..."
            }));
        

            //John
            John.AddDialogue(new Dialogue("Leal Coates", new List<string>() {
                "...",
                "..."
            }));

            John.AddDialogue(new Dialogue("John", new List<string>() {
                "...",
                "...",
                "..."
            }));

        }

        public static void DefineOptions() {
            felix.Options = new Options(new Dictionary<string, DialogueSequence>() {
                {"I need to tell this to John", John},
                {"Another option which leads to same sequence cuz i was too lazy to define another sequence", John}
            });   
        }

        public static void SetupAndStart() {
            DefineDialogues();
            DefineOptions();
            StartMain();
        }

        public static void StartMain() {
            felix.StartDialogues();
        }
    }
}