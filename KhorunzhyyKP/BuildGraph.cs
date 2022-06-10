using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KhorunzhyyKP
{
    public class BuildGraph
    {
        private PictureBox panel;
        private readonly bool[,] matrix;
        private PointF[] pointNode;//координаты для построения вершин
        private Graphics graphics;//предоставление средств для рисования
        private readonly Bitmap bitmap;//хранение полного изображения графа
        private readonly int node;//Количество вершин

        public BuildGraph(PictureBox panel, bool[,] matrix){
            this.panel = panel;
            this.matrix = matrix;
            node = matrix.GetLength(0);
            bitmap = new Bitmap(this.panel.Width, this.panel.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
        
        /// <summary>
        /// Нарисовать граф
        /// </summary>
        /// <param name="AdjacencyMatrix">Матрица смежности</param>
        public void DrawGraph(){
            graphics.Clear(panel.BackColor);
            CalculatePointNodes();
            DrawEdges();
            DrawVerticles();
            panel.Image = bitmap;
        }

        /// <summary>
        /// Найти координаты для построения вершин на области для рисования
        /// </summary>
        private void CalculatePointNodes() {
            pointNode = new PointF[node];
            double degree = 360.0 / node, d = 0;
            Point xy = new Point(panel.Width / 2 - 12, panel.Height / 2 - 15);
            Point x0y0 = new Point(panel.Width - 40, panel.Height / 2 - 15);
            Point rxry = new Point((x0y0.X - xy.X), (x0y0.Y - xy.Y));
            for (int i = 0; i < node; i++, d += degree) {
                double cos = Math.Cos((Math.PI / 180) * d),
                       sin = Math.Sin((Math.PI / 180) * d),
                       tmps = (xy.X + rxry.X * cos - rxry.Y * sin),
                       tmp1 = (xy.Y + rxry.X * sin + rxry.Y * cos);
                Point x1y1 = new Point((int)tmps, (int)tmp1);
                pointNode[i] = new Point(x1y1.X, x1y1.Y);
            }
        }

        /// <summary>
        /// Нарисовать ребра
        /// </summary>
        private void DrawEdges(){
            for (int i = 0; i < node; i++)
                for (int j = 0; j < node; j++)
                    if (matrix[i, j])
                        graphics.DrawLine(Pens.Gray, 
                                          pointNode[i].X + 12, 
                                          pointNode[i].Y + 12, 
                                          pointNode[j].X + 12, 
                                          pointNode[j].Y + 12);
        }

        /// <summary>
        /// Нарисовать вершины
        /// </summary>
        private void DrawVerticles(){
            for (int i = 0; i < node; i++){
                Font font = new Font("Tahoma", 9f);
                Color colorForVerticle = Color.Tomato;
                graphics.FillEllipse(new SolidBrush(colorForVerticle), pointNode[i].X, pointNode[i].Y, 25, 25);
                var x = (i < 9) ? pointNode[i].X + 8 : pointNode[i].X + 4;
                graphics.DrawString((i + 1).ToString(), font, Brushes.GhostWhite, x, pointNode[i].Y + 5);
            }
        }
    }
}