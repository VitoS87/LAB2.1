Console.WriteLine("Введите сумму грн: ");
long x = long.Parse(Console.ReadLine());
long y;
if (x>400 && x<600) { y = x - (x / 100 * 5); Console.WriteLine("Стоимость покупки: "+y+" грн"); }
if (x>600 && x<1000) { y = x - (x / 100 * 10); Console.WriteLine("Стоимость покупки: "+y+" грн"); }
if (x<400 || x>1000) { Console.WriteLine("Стоимость покупки: "+x+" грн"); }; 


