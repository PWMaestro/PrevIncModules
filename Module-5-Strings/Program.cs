using System;
using System.Text;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task A
            //HandleText();

            // Task B
            //EditText();

            // Task C
            //Console.WriteLine(ReverseText());

            // Task D
            // Method deletes all spaces untill first dot will meet and print this new string.
            //Console.WriteLine(DeleteSpaces());

            // Task E
            // ShowUppercaseLatters();

            // Task F
            ShowEvenSymbols();
        }

        private static void ShowEvenSymbols()
        {
            ShowMessages("Please, enter some text:");
            StringBuilder text = new StringBuilder(Console.ReadLine());

            for (int i = 1; i < text.Length; i += 2)
            {
                if (char.IsLower(text[i]))
                {
                    text[i] = char.ToUpper(text[i]);
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                text.Remove(i, 1);
            }
            Console.WriteLine(text);
        }

        private static void ShowUppercaseLatters()
        {
            ShowMessages("Please, enter some text:");
            StringBuilder text = new StringBuilder(Console.ReadLine());
            int letterPointer = 0;

            while (letterPointer < text.Length)
            {
                if (char.IsUpper(text[letterPointer]))
                {
                    letterPointer++;
                    continue;
                }
                else
                {
                    text.Remove(letterPointer, 1);
                }
            }
            Console.WriteLine(text);
        }

        private static string DeleteSpaces()
        {
            ShowMessages("Please, enter some text:");
            string text = Console.ReadLine();
            int dotPosition =  text.IndexOf('.');

            return dotPosition >= 0
                ? text.Substring(0, dotPosition + 1).Replace(" ", "")
                : "";
        }

        private static string ReverseText()
        {
            ShowMessages("Please, enter some text:");
            string text = Console.ReadLine();
            int length = text.Length;
            char[] parsedText = new char[length];

            for (int i = 0; i < length; i++)
            {
                parsedText[i] = text[length - 1 - i];
            }
            return new string(parsedText);
            
        }

        static void EditText()
        {
            ShowMessages("Task 15. Text processor. Part B.");
            // Test cases
            // 1. Text: "Hello user! How are you?"
            //    Word for append: "Fine!"
            // 2. Text: "Hello user! How are you?"
            //    Word for insert: "dear"
            // 3. Text: "Hello user! How are you?"
            //    symbol for delete: "!"
            // 4. Text: "Hello user! How are you?"
            //    Word for replace: "user" to "programmer"
            ShowMessages("Please, enter some text:");
            string text = Console.ReadLine();

            do
            {
                Console.Clear();
                ShowMessages(text, "\n");
                ShowMenu();

                bool isAvalible = int.TryParse(Console.ReadLine(), out int option);
                if (isAvalible)
                {
                    Console.Clear();
                    switch (option)
                    {
                        case 0:
                            return;
                        case 1:
                            AppendText(ref text);
                            break;
                        case 2:
                            InsetText(ref text);
                            break;
                        case 3:
                            DeleteSymbol(ref text);
                            break;
                        case 4:
                            ReplaceSubstring(ref text);
                            break;
                        default:
                            ShowMessages("Error! Wrong input. Try one more time...");
                            break;
                    }
                }
            } while (true);
            
            
        }

        private static void ReplaceSubstring(ref string text)
        {
            ShowMessages("Please, enter fragment you want to replace:");
            string oldStr = Console.ReadLine();
            Console.Clear();
            ShowMessages("Please, enter new fragment you want to add:");
            string newStr = Console.ReadLine();

            text = text.Replace(oldStr, newStr);

        }

        private static void DeleteSymbol(ref string text)
        {
            ShowMessages("Please, enter a symbol you want replace:");
            string userSymbol = Console.ReadLine();

            if (userSymbol.Length > 0)
            {
                text = text.Replace(userSymbol, "");
            }
        }

        private static void InsetText(ref string text)
        {
            ShowMessages("Please, enter new fragment:");
            string userInput = Console.ReadLine();
            ShowMessages("Please, enter position of new fragment:");
            int position = int.Parse(Console.ReadLine());

            if (position > text.Length)
            {
                ShowMessages("Error! Position out of range.");
            }
            else
            {
                text = text.Insert(position, userInput);
            }
        }

        private static void AppendText(ref string text)
        {
            ShowMessages("Please enter the fragment you want to add:");
            text += Console.ReadLine();
        }

        static void HandleText()
        {
            ShowMessages("Task 15. Text processor. Part A.");
            // Test cases
            // hello hello user.
            // Hello user user! How are you?
            // I like like learn c#.
            // My favourite favourite programming programming language is c#.
            ShowMessages("Please, enter some text, ending with a dot:");
            string userInput = Console.ReadLine();

            string[] words = userInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                Console.Write(words[0]);
                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i] != words[i - 1])
                    {
                        Console.Write(' ');
                        Console.Write(words[i]);
                    }
                }
            }
        }

        static void ShowMenu()
        {
            ShowMessages("Please, choose an option:");
            ShowMessages("1. Add text to the end;");
            ShowMessages("2. Insert text at specific position;");
            ShowMessages("3. Delete character from text;");
            ShowMessages("4. Replace a substring with another substring;");
            ShowMessages("or press 0 to exit.");
        }

        static void ShowMessages(params string[] messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine("{0}", message);
            }
        }
    }
}
