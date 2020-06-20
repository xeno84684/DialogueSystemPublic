using System;
using System.Collections;
using System.Collections.Generic;


namespace DialogueStuff {
    public class DialogueManager {
        public Queue<string> Sentences;
        public Dialogue Dialogue;
        public bool ConversationEnded = true;

        public DialogueManager () {
            Sentences = new Queue<string>();
        }

        public void StartDialogue(Dialogue dialogue) {
            ConversationEnded = false;
            
            this.Dialogue = dialogue;
            Sentences.Clear();
            
            foreach (string sentence in dialogue.Sentences) {
                Sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
        }

        public void DisplayNextSentence() {
            if (Sentences.Count == 0) {
                EndDialogue();
                return;
            }
            
            string sentence = Sentences.Dequeue();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write ("{0} ", Dialogue.Name);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine (": {0}", sentence);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("Press enter to continue");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            DisplayNextSentence();
        }

        void EndDialogue() {
            ConversationEnded = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The current Dialogue has ended \nPress Enter to Continue...");
            Console.ReadKey();
        }
    } 
}