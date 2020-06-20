using System;
using System.Collections;
using System.Collections.Generic;
using DialogueStuff;


namespace DialogueStuff {
    public class DialogueSequence {
        private DialogueManager dialogueManager;
        private OptionManager optionManager;
        public string Name { get; set; }
        private Queue<Dialogue> Dialogues;
        public Options Options;

        public DialogueSequence () {
            dialogueManager = new DialogueManager();
            optionManager = new OptionManager();
            Dialogues = new Queue<Dialogue>();
            Options = new Options(new Dictionary<string, DialogueSequence>() {

            });
        }

        public void AddDialogue(Dialogue dialogue) {
            Dialogues.Enqueue(dialogue);
        }

        public void AddDialogue(Dialogue[] dialogues) {
            foreach (Dialogue dialogue in dialogues) {
                Dialogues.Enqueue(dialogue);
            }
        }

        public void StartDialogues() {
            if (Dialogues.Count == 0) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Note to dev: Are you fucking stupid you didn't set any dialogues for this Event why would you call the StartDialogues() function?");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            while (true) {
                if (dialogueManager.ConversationEnded) 
                    StartNextDialogue();
                if (Dialogues.Count == 0)
                    break;
            }

            DisplayOptions();
        }

        void StartNextDialogue() {
            dialogueManager.StartDialogue(Dialogues.Dequeue());
        }

        public void DisplayOptions() {
            if (Options.options.Count > 0)
                optionManager.StartOptions(Options);
        }
    }
}