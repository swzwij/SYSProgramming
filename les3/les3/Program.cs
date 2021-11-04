using System;

namespace les3
{
    class Room
    {
       public void kamer(int width, int heigth)
        {
            
            Tile[][] coordinations = new Tile[7][];
            for (int y = 0; y < coordinations.Length; y++)
            {
                coordinations[y] = new Tile[0];
                for (int coordI = 0; coordI < coordinations.Length; coordI++)
                {
                    coordinations[y][coordI] = new Tile();
                }
            }
        }
    }

    class Tile
    {
        

    }
}
