using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Grafy
{
    public partial class Form1 : Form
    {
        private Graph _graph;
        private List<Point> _points;
        private Graphics _gGraph, _gPareto;
        private int _paretoWidth, _paretoHeight;
        private GaEngine _GaEngine;
        private readonly SynchronizationContext synchronizationContext;
        private bool _graphIsImag = false;

        public Form1()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;

            chartPareto.Legends[0].Docking = Docking.Top;
            chartPareto.Legends[0].Alignment = StringAlignment.Center;
            chartPareto.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;

            _gGraph = panelGraphGraphics.CreateGraphics();
            _gGraph.Clear(Color.White);

            _gPareto = panelParetoGraphics.CreateGraphics();
            _paretoWidth = panelParetoGraphics.Width;
            _paretoHeight = panelParetoGraphics.Height;
            _gPareto.Clear(Color.White);;
        }

        private void buttonRandPoints_Click(object sender, EventArgs e)
        {
            _gGraph.Clear(Color.White);

            _points = Graph.RandomPoints((int)numericUpDownSize.Value, panelGraphGraphics.Width, panelGraphGraphics.Height);
            Graph.DrawPoints(_points, _gGraph);

            buttonRandGraph.Enabled = true;
        }

        private void buttonImagGraph_Click(object sender, EventArgs e)
        {
            _gGraph.Clear(Color.White);

            _graph = new Graph((int)numericUpDownSize.Value, (double)numericUpDownEdgeP.Value);

            label1.Text = $"Liczba krawędzi grafu: {_graph.Edges}";
            buttonGenPop.Enabled = true;
            _graphIsImag = true;
        }

        private void buttonRandGraph_Click(object sender, EventArgs e)
        {
            _gGraph.Clear(Color.White);

            _points = Graph.RandomPoints((int)numericUpDownSize.Value, panelGraphGraphics.Width, panelGraphGraphics.Height);
            _graph = new Graph(_points, (double)numericUpDownEdgeP.Value);
            _graph.Draw(_gGraph);

            label1.Text = $"Liczba krawędzi grafu: {_graph.Edges}";
            buttonGenPop.Enabled = true;
            _graphIsImag = false;
        }

        private void buttonGenPop_Click(object sender, EventArgs e)
        {
            _GaEngine = new GaEngine(_graph, (int)numericUpDownPopSize.Value);

            buttonOneGeneration.Enabled = true;
            buttonEvoluate.Enabled = true;
        }

        private void buttonOneGeneration_Click(object sender, EventArgs e)
        {
            _GaEngine.ProcessOneGeneration((double)numericUpDownMutP.Value);
            ShowResults();
        }

        private void ShowResults()
        {
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                GaEngine gaEng = (GaEngine)o;
                labelMinF.Text = $"Min - F1: {gaEng.MinF1}, F2:{gaEng.MinF2}";
                labelMaxF.Text = $"Max - F1: {gaEng.MaxF1}, F2:{gaEng.MaxF2}";
                labelAvgF.Text = $"Avg - F1: {gaEng.AvgF1}, F2:{gaEng.AvfF2}";

                chartPareto.Series.Clear();
                var series = gaEng.GetIterSeries();
                chartPareto.Series.Add(series[0]);
                chartPareto.Series.Add(series[1]);
                chartPareto.Invalidate();
            }), _GaEngine);

            _gGraph.Clear(Color.White);

            if (_graphIsImag)
                _graph.DrawImagGraph(_gGraph, _GaEngine.BestF1, panelGraphGraphics.Width, panelGraphGraphics.Height);
            else
                _graph.Draw(_gGraph, _GaEngine.BestF1);

            _gPareto.Clear(Color.White);
            _GaEngine.DrawPareto(_gPareto, _paretoWidth, _paretoHeight);
        }

        public async void MainEvo() // void, a Task
        {
            buttonEvoluate.Enabled = false;
            await Task.Run(() => { Evoluate(); });
            buttonEvoluate.Enabled = true;
        }

        private void Evoluate()
        {
            var watch = new Stopwatch();
            long ms = 500;
            int i = 0, iter = (int)numericUpDownGenerations.Value;
            double mutP = (double)numericUpDownMutP.Value;

            while (i < iter)
            {
                watch.Restart();
                while (watch.ElapsedMilliseconds < ms)
                {
                    _GaEngine.ProcessOneGeneration(mutP);
                    i++;
                }
                ShowResults();
            }
        }

        private void buttonEvoluate_Click(object sender, EventArgs e)
        {
            MainEvo();
        }
    }
}
