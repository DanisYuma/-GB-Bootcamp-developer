Console.Clear();

int QuickEuclideanAlgorithm(int x, int y)
{
  int count = 0;

  int t;

  while (y != 0)
  {
    count++;

    t = x % y;
    x = y;
    y = t;
  }
  Console.WriteLine($"QuickEuclideanAlgorithm, count: {count}");

  return x;
}

int from = 21, to = 14;

Console.WriteLine(QuickEuclideanAlgorithm(from, to));