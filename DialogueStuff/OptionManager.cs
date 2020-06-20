using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace DialogueStuff {
    public class OptionManager {
        public bool OptionsEnded = true;
        public DialogueSequence targetEvent;

        public void StartOptions(Options options) {
            OptionsEnded = false;
            int index = 0;
            int targetIndex;

            foreach (KeyValuePair<string, DialogueSequence> option in options.options) {
                index += 1;
                Console.WriteLine("{0}. {1}", index, option.Key);
            }
            
            while (true) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Choose an option");
                var choice = Console.ReadLine();

                if (!int.TryParse(choice, out int choiceInt)) {
                    Console.WriteLine("Invalid option");
                }
                else if (choiceInt < 1 || choiceInt > options.options.Count) {
                    Console.WriteLine("Invalid Option");
                }
                else {
                    targetIndex = choiceInt - 1;
                    break;
                }
            } 

            targetEvent = options.options.ElementAt(targetIndex).Value;
            StartTargetEvent();
        }

        void StartTargetEvent() {
            targetEvent.StartDialogues();
        }
    }
}