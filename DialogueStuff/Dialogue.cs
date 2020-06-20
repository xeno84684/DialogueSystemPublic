using System;
using System.Collections;
using System.Collections.Generic;


namespace DialogueStuff {
    public class Dialogue {
        public string Name { get; set; }
        public readonly List<string> Sentences;

        public Dialogue (string name, List<string> sentences) {
            this.Name = name;
            this.Sentences = sentences;
        } 
    }
}