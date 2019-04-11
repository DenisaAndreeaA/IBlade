using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcP.WHobjects
{
    public class Map
    {
        // ---------------------- Fields -----------------------
        private Tile[,] tilesArray;
        private int heightOfMap;
        private int lengthOfMap;
        // -------------------- Properties ---------------------
        public Tile[,] TilesArray { get { return tilesArray; } set { tilesArray = value; } }
        public int HeightOfMap { get { return heightOfMap; } set { heightOfMap = value; } }
        public int LengthOfMap { get { return lengthOfMap; } set { lengthOfMap = value; } }

        // -------------------- Constructors --------------------
        public Map()
        {

        }



        public bool checkRackList(int i, int j)
        {
            foreach (var item in iBlade.wh.GetRackList())
            {
                if (((item.Position.X-20) < i ) && ((item.Position.X + 60 ) > i ) && 
                    (item.Position.Y-40 < j) && (item.Position.Y+50) > j)
                {
                    return false;
                }
            }
            return true;
        }
        #region Map creation
        /// <summary>
    
        /// </summary>
        public void CreateMap(string map, int x,int y)
        {
            TilesArray = new Tile[x/5,y/5];
            HeightOfMap = x;
            LengthOfMap = y;
            int z = 0;
            int a = 0;
            for (int i = 0; i < x - 5; i = i + 5)
            {
                for (int j = 0; j < y - 5; j=j+ 5)
                {
                    if (checkRackList(i, j))
                    {
                        TilesArray[a, z] = new Tile(new Point(i/5, j/5), new Point(i,j));
                    }
                    else
                    {
                        TilesArray[a, z] = new TileRack(new Point(i/5, j/5), new Point(i,j));

                    }
                    z++;
                    if (z == y - 1)
                    {
                        z = 0; break;
                    }
                }
                z = 0;
                a++;
                if (a == x - 1) { a = 0; break; }
            }
        }
        #endregion



        private int[,] PopulateIntArray()
        {
            int[,] m = new int[tilesArray.GetLength(0), tilesArray.GetLength(1)];

            for (int i = 0; i < tilesArray.GetLength(0); i++)
            {
                for (int j = 0; j < tilesArray.GetLength(1); j++)
                {
                }
            }

            return m;
        }

        /// <summary>
        /// Helper method for reading a resource text file.
        /// </summary>
        /// <param name="resourceText"></param>
        /// <returns></returns>


        /// <summary>
        /// Gets a tile from a specified position.
        /// </summary>
        /// <param name="location">The location of the desired tile.</param>
        /// <returns>Will return null if no Tile could be found at the specified location, otherwise it will return the found Tile.</returns>
        public Tile GetTile(Point location)
        {
            for (int i = 0; i < tilesArray.GetLength(0); i++)
                for (int j = 0; j < tilesArray.GetLength(1); j++)
                    if (tilesArray[i, j].Location == location)
                        return tilesArray[i, j];

            return null;
        }
    }
}

