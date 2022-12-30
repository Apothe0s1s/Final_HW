// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо ровна 3 символа.

string[] A = { "Happy", "New", "Year", "to", "you"};
List<string> B = new List<string>();

for (int i = 0; i < A.Length; i++)
    if (A[i].Length <= 3)
    {
        B.Add(A[i]);
    }

Console.WriteLine("[{0}]", string.Join(",", B));