using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    class Individual
    {
        private static Random rand = new Random();

        private int _size;
        private int[] _chrom;
        private int[] _f = new int[2];
        private Graph _graph;

        public int Size => _size;
        public int F1 => _f[0];
        public int F2 => _f[1];

        //3 opcje dostepu tak z ciekawosci
        public int this[int i] => _chrom[i];
        public List<int> GetChromosomeAsList() => _chrom.ToList();
        public int[] GetChromosomeAsArray() => _chrom;

        public string Text => string.Join("", _chrom);

        public Individual(Graph graph)
        {
            _graph = graph;
            _size = _graph.Size;
            _chrom = new int[_size];

            generateDNA();
            Mutate();
        }

        public Individual(Individual origin)
        {
            _graph = origin._graph;
            _size = _graph.Size;
            _chrom = new int[_size];

            for (int i = 0; i < _size; i++)
                _chrom[i] = origin._chrom[i];

            _f[0] = origin._f[0];
            _f[1] = origin._f[1];
        }

        public void Mutate()
        {
            int n1 = rand.Next(_size), n2;

            do n2 = rand.Next(_size);
            while (_chrom[n1] == _chrom[n2]);

            int t = _chrom[n1];
            _chrom[n1] = _chrom[n2];
            _chrom[n2] = t;

            calcFitneses();
        }

        public Individual BestCopy(Individual other, uint fitFuncNo)
        {
            if (other != null && fitFuncNo < 2)
            {
                if (this._f[fitFuncNo] < other._f[fitFuncNo])
                    return new Individual(this);
                else
                    return new Individual(other);
            }
            else throw new ArgumentException();
        }

        private void generateDNA()
        {
            int g = _size / 3;
            int[] c = { 0, 0, 0 };

            for (int i = 0; i < _size; i++)
            {
                int r = rand.Next(3);

                if (c[r] < g)
                {
                    _chrom[i] = r;
                    c[r]++;
                }
                else
                {
                    for (int n = 0; n < 3; n++) 
                        if (c[n] < g)
                        {
                            _chrom[i] = n;
                            c[n]++;
                            break;
                        }
                }
            }
        }

        private void calcFitneses()
        {
            _f[0] = _f[1] = 0;

            for (int i = 0; i < _size; i++)
            {
                for (int j = i + 1; j < _size; j++)
                {
                    if (_graph[i, j] != 0 && _chrom[i] != _chrom[j]) //krawędź łącząca grupy
                    {
                        _f[0]++;
                        _f[1] += _graph[i, j];
                    }
                }
            }
        }
    }
}
