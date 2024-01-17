namespace ОС2
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            bool positiveOnly = args.Contains("--positive-only");

            // Читаємо дані з stdin
            string input = Console.In.ReadToEnd();

            // Розділяємо слова за допомогою пробілів та нових рядків
            string[] words = input.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (int.TryParse(word, out int number))
                {
                    // Якщо слово можна перетворити в число
                    if (positiveOnly)
                    {
                        // Якщо вказано --positive-only, виводимо тільки додатні числа
                        if (number > 0)
                            Console.Write($"{number} ");
                    }
                    else
                    {
                        // Якщо не вказано --positive-only, виводимо всі числа
                        Console.Write($"{number} ");
                    }
                }
            }
        }
    }
}

