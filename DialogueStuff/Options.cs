using System;
using System.Collections;
using System.Collections.Generic;


namespace DialogueStuff {
    public class Options {
        public Dictionary<string, DialogueSequence> options;

        public Options (Dictionary<string, DialogueSequence> options) {
            this.options = options;
        }
    }
}