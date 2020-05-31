using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    class Graph
    {
        public int Size { get; private set; }
        public int Edges { get; private set; } = 0;

        private int[,] _weights;
        private List<Point> _points = null;

        public int this[int i, int j] => _weights[i, j];

        public Graph(int size, double edgeExistsProbability = 0.01, int weightMin = 1, int weightMax = 100)
        {
            Random rand = new Random();

            Size = size;
            _weights = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    if (rand.NextDouble() < edgeExistsProbability)
                    {
                        _weights[i, j] = _weights[j, i] = rand.Next(weightMin, weightMax);
                        Edges++;
                    }
                    else
                        _weights[i, j] = _weights[j, i] = 0;
                }
            }
        }

        public Graph(List<Point> points, double edgeExistsProbability = 0.01)
        {
            Random rand = new Random();

            _points = points;
            Size = _points.Count;
            _weights = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    if (rand.NextDouble() < edgeExistsProbability)
                    {
                        _weights[i, j] = _weights[j, i] = calcDist(_points[i], _points[j]);
                        Edges++;
                    }
                    else
                        _weights[i, j] = _weights[j, i] = 0;
                }
            }

        }

        public void Draw(Graphics g, Individual ind = null)
        {
            if (_points != null)
            {
                drawEdges(g, ind);
                DrawPoints(_points, g, ind);
            }
        }

        public void DrawImagGraph(Graphics g, Individual ind, int width, int height)
        {
            _points = Random3Points(ind, width, height);

            drawEdges(g, ind);
            DrawPoints(_points, g, ind);
        }

        private static List<Point> Random3Points(Individual ind, int width, int height)
        {
            List<Point> retPoints = new List<Point>();
            Random rand = new Random();

            int R = width / 6;
            Point[] CenterPoint = { 
                new Point(width / 2, R + 20),
                new Point(R + 20, height - 20 - R),
                new Point(width - 20 - R, height - 20 - R)
            };

            Point randPoint(int region)
            {
                int r = rand.Next(R / 3, R);
                double angle = rand.NextDouble() * 2 * Math.PI;

                int x = (int)(r * Math.Cos(angle)) + CenterPoint[region].X;
                int y = (int)(r * Math.Sin(angle)) + CenterPoint[region].Y;

                return new Point(x, y);
            }

            foreach (var allel in ind.GetChromosomeAsList())
            {
                retPoints.Add(randPoint(allel));
            }

            return retPoints;
        }

        public static List<Point> RandomPoints(int size, int width, int height)
        {
            Random rand = new Random();
            var ret = new List<Point>();

            for (int i = 0; i < size; i++)
                ret.Add(new Point(rand.Next(5, width - 5), rand.Next(5, height - 5)));

            return ret;
        }

        //public static void DrawPoints(List<Point> points, Graphics g) => points.ForEach(p => drawPoint(p, g, Color.Black));
        public static void DrawPoints(List<Point> points, Graphics g, Individual ind = null)
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Orange };

            if (ind == null)
            {
                points.ForEach(p => drawPoint(p, g, Color.Black));
            }
            else if (points.Count == ind?.Size)
            {
                var group = ind.GetChromosomeAsList().GetEnumerator();

                foreach (var p in points)
                {
                    group.MoveNext();
                    int colorIndex = group.Current;

                    if (colorIndex < 3) drawPoint(p, g, colors[colorIndex]);
                }
            }
            else throw new ArgumentException("points and ind sizes must be equal");
        }

        private int calcDist(Point p1, Point p2)
        {
            int x = p1.X - p2.X;
            int y = p1.Y - p2.Y;

            return (int)Math.Sqrt((x * x + y * y));
        }

        private static void drawPoint(Point point, Graphics g, Color color)
        {
            int size = 10;
            Brush brush = new SolidBrush(color);

            g.FillEllipse(brush, point.X - size / 2, point.Y - size / 2, size, size);
        }

        private static void drawEdge(Point p1, Point p2, Graphics g, Color color, int width = 2)
        {
            var pen = new Pen(color, width);
            g.DrawLine(pen, p1, p2);
        }

        private void drawEdges(Graphics g, Individual ind = null)
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Orange };

            if ( ind == null || Size == ind?.Size ) // ind == null mean all is RED
            {
                for (int i = 0; i < Size; i++)
                    for (int j = i + 1; j < Size; j++)
                        if (_weights[i, j] != 0)
                        {
                            if ( ind != null && ind[i] == ind[j])
                                drawEdge(_points[i], _points[j], g, colors[ind[i]]);
                            else
                                drawEdge(_points[i], _points[j], g, Color.Red, 3);
                        }
            }
            else throw new ArgumentException("points and ind sizes must be equal");
        }
    }
}
