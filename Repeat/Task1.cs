namespace Repeat
{
    public class Task1
    {
        public static void Start()
        {
            int x1 = 1, y1 = 1, x2 = 4 , y2 = 4;
            Console.Write(
                $"Координаты точек: x1:{x1} y1:{y1} ; x2:{x2} y2:{y2}\n" +
                $"Координаты середины: x:{(x1+x2)/2f} ; y:{(y1+y2)/2f}\n");
        }
    }
}
