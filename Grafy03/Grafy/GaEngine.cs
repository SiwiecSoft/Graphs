using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafy
{
    class GaEngine
    {
        private static Random rand = new Random();
        private List<Individual> _pop = new List<Individual>();
        private List<Individual> _newPop = new List<Individual>();

        private List<int> _f1Results = new List<int>();
        private List<int> _f2Results = new List<int>();

        public int PopSize { get; private set; }

        public int MinF1 => _pop.Min(ind => ind.F1);
        public int MinF2 => _pop.Min(ind => ind.F2);
        public int MaxF1 => _pop.Max(ind => ind.F1);
        public int MaxF2 => _pop.Max(ind => ind.F2);
        public int AvgF1 => (int)_pop.Average(ind => ind.F1);
        public int AvfF2 => (int)_pop.Average(ind => ind.F2);

        public Individual BestF1 => _pop.Find(ind => ind.F1 == MinF1);
        public Individual BestF2 => _pop.Find(ind => ind.F2 == MinF2);

        public GaEngine(Graph graph, int popSize)
        {
            PopSize = popSize;
            generatePop(graph, PopSize);
        }

        public void ProcessOneGeneration(double mutPobability)
        {
            _newPop.Clear();

            for (int i = 0; i < PopSize / 2; i++)
            {
                select(0);
                select(1);
            }

            _pop.Clear();
            _newPop.ForEach(i => _pop.Add(i));

            foreach (var ind in _pop)
                if (rand.NextDouble() < mutPobability) ind.Mutate();
            
            _f1Results.Add(MinF1);
            _f2Results.Add(MinF2);
        }

        public void Evoluate(int generations, double mutPobability)
        {
            for (int i = 0; i < generations; i++)
                ProcessOneGeneration(mutPobability);
        }

        public Series GetSeriesF1F2()
        {
            var series1 = new Series
            {
                Name = "F2 = f(F1)",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Point
            };

            foreach (var ind in _pop.OrderBy(i => i.F1))
                series1.Points.AddXY(ind.F1, ind.F2);

            return series1;
        }

        public Series[] GetIterSeries()
        {
            Series[] series = new Series[]
            {
                new Series()
                {
                    Name = "F1-min = f(t)",
                    Color = Color.Green,
                    BorderWidth = 3,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Primary
                },
                new Series()
                {
                    Name = "F2-min = f(t)",
                    Color = Color.Blue,
                    BorderWidth = 3,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Line,
                    YAxisType = AxisType.Secondary
                }
            };

            foreach (var i in _f1Results) series[0].Points.Add(i);
            foreach (var i in _f2Results) series[1].Points.Add(i);

            return series;
        }

        public void DrawPareto(Graphics g, int width, int height)
        {
            int minf1 = MinF1, minf2 = MinF2;
            int maxf1 = MaxF1, maxf2 = MaxF2;

            var font = new Font(FontFamily.GenericSansSerif, 10);
            g.DrawString($"F1({minf1} - {maxf1}), F2({minf2} - {maxf2})", font, Brushes.Black, 1f, 1f);

            int diff1 = maxf1 - minf1;
            int diff2 = maxf2 - minf2;
            int margin = 30;

            minf1 -= 1;
            minf2 -= diff2 / 10;
            maxf1 += 1;
            maxf2 += diff2 / 10;

            diff1 = maxf1 - minf1;
            diff2 = maxf2 - minf2;

            g.DrawLine(Pens.Black, margin - 5, height - margin, width - margin, height - margin);
            g.DrawLine(Pens.Black, margin, margin, margin, height - margin + 5);          

            width = width - margin*2;
            height = height - margin*2;

            //Draw best non-dominated RED
            for (int i = 0, n = _pop.Count; i < n; i++)
            {
                bool isDominated = false;
                
                for (int j = 0; j < n; j++)
                {
                    if (_pop[i].F1 > _pop[j].F1 && _pop[i].F2 > _pop[j].F2)
                    {
                        isDominated = true;
                        break;
                    }
                }

                int x = margin + (int)((double)width / (double)diff1 * (double)(_pop[i].F1 - minf1));
                int y = margin + height - (int)((double)height / (double)diff2 * (double)(_pop[i].F2 - minf2));

                g.DrawRectangle(isDominated ? Pens.Black : Pens.Red, x - 1, y - 1, 3, 3);
            }

        }

        private void generatePop(Graph graph, int popSize)
        {
            _f1Results.Clear();
            _f2Results.Clear();

            for (int i = 0; i < popSize; i++)
                _pop.Add(new Individual(graph));
        }

        private void select(uint fitFuncNo)
        {
            if (fitFuncNo < 2)
            {
                int ind1 = rand.Next(PopSize), ind2;

                do ind2 = rand.Next(PopSize);
                while (ind2 == ind1);

                _newPop.Add(_pop[ind1].BestCopy(_pop[ind2], fitFuncNo));
            }
            else throw new ArgumentException();
        }
    }
}
