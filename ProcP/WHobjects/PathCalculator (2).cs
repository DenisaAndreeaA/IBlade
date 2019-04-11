using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace ProcP.WHobjects
{
    class PathCalculator
    {
        public Tile[,] map;
       
       // List<Point> myPointList;

        // constructor with the start point and endpoint of the path
        public PathCalculator(Tile[,] TilesArray)
        {
            //StartPoint = st;
            //EndPoint = en;
            //myPointList = new List<Point>();
            this.map = TilesArray;
        }

        // add every point that needs to be reached to the point list
        //public void CalculatePath()
        //{
        //    int count = 0;
        //    int i = StartPoint.X;
        //    int j = StartPoint.Y;
        //    int x = EndPoint.X;
        //    int y = EndPoint.Y;
        //    while (i != x || j != y)
        //    {
        //        if (i < x) i++;
        //        if (i > x) i--;
        //        if (j < y) j++;
        //        if (j > y) j--;
        //        myPointList.Add(new Point(i, j));
        //    }
        //    //foreach (var item in myPointList)
        //    //{
        //    //    Debug.WriteLine(item.X + " " + item.Y);
        //    //}
        //}

        //public List<Point> GetPointList()
        //{
        //    return myPointList;
        //}

        public List<Tile> FindShortestPath(Point start, Point target)
        {
            NodeMap nMap = new NodeMap(map, target);
            List<Tile> ShortestPathTiles = new List<Tile>();

            var openNodes = new HashSet<Node>(); //nodes that this algo examines 
            var closedNodes = new HashSet<Node>(); //nodes that it already examined

            openNodes.Add(nMap.nodes[start.X/5, start.Y/5]); //adds the AGV's starting point to the list
            openNodes.First().G = 0;
            
            while (openNodes.Any())
            {
                Node currentNode = nMap.GetNodeWithSmallestF(openNodes); //returns the first point of the node(?)
                

                //if currentNode reaches the target, returns the reversed path that will be added to the AGV's tileList and it will traverse
                if (currentNode.Location.X == target.X && currentNode.Location.Y == target.Y)
                {
                    ShortestPathTiles = ReconstructPath(currentNode);
                    return ShortestPathTiles;
                }

                openNodes.Remove(currentNode);
                closedNodes.Add(currentNode);

                foreach (Node n in nMap.GetNeighbors(currentNode))
                {
                    if (closedNodes.Contains(n))
                    {
                        continue;
                    }

                    var tGscore = currentNode.G + 1;

                    if (!openNodes.Contains(n))
                    {
                        openNodes.Add(n);
                    }
                    else if (tGscore >= n.G)
                    {
                        continue;
                    }

                    n.Parent = currentNode;
                    n.G = tGscore;
                }
            }

            return ShortestPathTiles;
        }
        private List<Tile> ReconstructPath(Node lastNode)
        {
            List<Tile> path = new List<Tile>();
            //int x = 0;
            //int y = 0;
            while (lastNode.Parent != null)
            {
                path.Add(map[lastNode.Location.X, lastNode.Location.Y]);

                //x = lastNode.Location.X;
                //y = lastNode.Location.Y;
                //if (lastNode.Pixel.X < lastNode.Parent.Pixel.X)
                //{
                //    while (x < lastNode.Parent.Pixel.X)
                //    {
                //        x++;
                //        path.Add(new Tile(new Point(x, y)));
                //    }
                //}
                //else if (lastNode.Pixel.X > lastNode.Parent.Pixel.X)
                //{
                //    while (x > lastNode.Parent.Pixel.X)
                //    {
                //        x--;
                //        path.Add(new Tile(new Point(x, y)));
                //    }
                //}
                //else if (lastNode.Pixel.Y < lastNode.Parent.Pixel.Y)
                //{
                //    while (y < lastNode.Parent.Pixel.Y)
                //    {
                //        y++;
                //        path.Add(new Tile(new Point(x, y)));
                //    }
                //}
                //else if (lastNode.Pixel.Y > lastNode.Parent.Pixel.Y)
                //{
                //    while (y > lastNode.Parent.Pixel.Y)
                //    {
                //        y--;
                //        path.Add(new Tile(new Point(x, y)));
                //    }
                //}

                lastNode = lastNode.Parent;
            }

            path.Reverse();
            return path;
        }

        class NodeMap
        {
            public Node[,] nodes;
            public Tile[,] map;

            public NodeMap(Tile[,] map, Point target)
            {
                this.map = map;
                nodes = new Node[this.map.GetLength(0), this.map.GetLength(1)];

                for (int i = 0; i < this.map.GetLength(0); i++)
                {
                    for (int j = 0; j < this.map.GetLength(1); j++)
                    {
                        if (this.map[i, j] != null)
                        {
                            nodes[i, j] = new Node(this.map[i, j].Location, this.map[i,j].Pixel, target);
                        }
                    }
                }
            }

            public Node GetNodeWithSmallestF(HashSet<Node> collection)
            {
                Node currentSmallest = collection.First();

                foreach (Node n in collection)
                {
                    if (currentSmallest.F > n.F)
                    {
                        currentSmallest = n;
                    }
                }

                return currentSmallest;
            }

            public HashSet<Node> GetNeighbors(Node currentNode)
            {
                var neighbors = new HashSet<Node>();

                if (currentNode.Location.X < nodes.GetLength(0) - 1)
                {
                    if (TestNodeViability(nodes[currentNode.Location.X + 1, currentNode.Location.Y]))
                    {
                        neighbors.Add(nodes[currentNode.Location.X + 1, currentNode.Location.Y]);
                    }
                }

                if (currentNode.Location.X > 0)
                {
                    if (TestNodeViability(nodes[currentNode.Location.X - 1, currentNode.Location.Y]))
                    {
                        neighbors.Add(nodes[currentNode.Location.X - 1, currentNode.Location.Y]);
                    }
                }

                if (currentNode.Location.Y < nodes.GetLength(1) - 1)
                {
                    if (TestNodeViability(nodes[currentNode.Location.X, currentNode.Location.Y + 1]))
                    {
                        neighbors.Add(nodes[currentNode.Location.X, currentNode.Location.Y + 1]);
                    }
                }

                if (currentNode.Location.Y > 0)
                {
                    if (TestNodeViability(nodes[currentNode.Location.X, currentNode.Location.Y - 1]))
                    {
                        neighbors.Add(nodes[currentNode.Location.X, currentNode.Location.Y - 1]);
                    }
                }

                return neighbors;
            }


            private bool TestNodeViability(Node n)
            {
                
                //foreach (var item in iBlade.wh.GetRackList())
                //{
                //if ((item.Position.X < n.Location.X && item.Position.X + 30 > n.Location.X) && (item.Position.Y < n.Location.Y && item.Position.Y + 30 > n.Location.Y))
                //{
                //    return false;
                //}
                //    if(n.Location.X >100 && n.Location.X < 300 && n.Location.Y > 400 && n.Location.Y < 500)
                //    {
                //        return false;
                //    }
                ////}

                Tile t = map[n.Location.X, n.Location.Y];
                if(t is TileRack)
                {
                    return false;
                }
                return true;
            }




        }
        class Node
        {
            public int G { get; set; }
            public int H { get; }
            public int F { get { return H + G; } }
            public Node Parent { get; set; }
            public Point Location { get; }
            public Point Pixel { get; set; }

            public Node(Point location,Point pixel, Point target)
            {
                Pixel = pixel;
                G = int.MaxValue;
                H = Math.Abs(location.X - target.X) + Math.Abs(location.Y - target.Y);
                Parent = null;
                this.Location = location;
            }
        }
    }
}

