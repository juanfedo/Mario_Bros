using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_create_ground
{
    class Random_Enemy
    {        
        List<Tuple<int, int>>  Fill_Coord()
        {
            //int prob = 15;
            //System.Random rnd = new System.Random();
            //List<Tuple<int, int>> coord = new List<Tuple<int, int>>();
            //for (int i = 0; i <= 10; i++)
            //{
            //    int x = rnd.Next(1, 100);
            //    int y = rnd.Next(1, 100);
            //    if (x <= prob)
            //    {
            //        while (coord.Exists(X => X.First == x && X.Second== y))
            //        {
            //            if (Validate(x, y))
            //            {
            //                x = rnd.Next(1, 100);
            //                y = rnd.Next(1, 100);
            //            }
            //        }
            //        coord.Add(new Tuple<int, int>(x, y));
            //    }
            //}
            //return coord;
            return null;
        }

        bool Validate(int x,int y)
        {
            return true;
            //if (Physics.OverlapSphere(new Vector2(x, y), Step).Length == 0)
            //{
            //    spawnablePositions.Add(new Vector2(x, y));
            //}
        }
    }
}
