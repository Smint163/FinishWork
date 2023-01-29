/*
Это программа, которая на вход принимает любые значения/символы/буквы,
а на выходе показыват только те строки, где число символов меньше или равно 3.

Алгоритм: FinishWork.drawio.png
*/

Console.WriteLine("Введите, что хотите через ПРОБЕЛ");

string symbol = Convert.ToString(Console.ReadLine());
string[] text = symbol.Split(' ');

    for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length > 3)
                {
                    text[i] = "";
                }
        Console.Write(text[i] + " ");
        }