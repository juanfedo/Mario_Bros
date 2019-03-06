using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_create_ground
{
    class Enemy
    {
        List<int> Start()
        {
        
        }

        List<int, int> Fill_Coord()
        {
            int prob = 15;
            System.Random rnd = new System.Random();
            List<int,int> coord = new List<int,int>();
            coord.Add(0,0);
            coord.Add(10,30);
            for (int i = 0; i <= limite_superior; i++)
            {
                int x = rnd.Next(1, 100);
                int y = rnd.Next(1, 100);
                if ( x <= prob)
                    coord.Add(x,y);
            }
            return validate(coord);
        }

        public validate(List<int,int> coord)
        {

            if (Physics.OverlapSphere(new Vector2(x, y), Step).Length == 0)
            {
                spawnablePositions.Add(new Vector2(x, y));
            }
        }

    }
}
