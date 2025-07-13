using System.Drawing;

namespace programacionFPII1._44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Ejemplo1
            //// Dibujamos un arco
            //g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 180);

            ////// Dibujamos una linea
            //g.DrawLine(Pens.Blue, 125, 25, 150, 200);

            ////// Dibujamos un rectagulo
            //g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));

            ////// Dibujamos una serie de lineas
            //point[] puntos = { new point(30, 45), new point(110, 75), new point(175, 200) };
            //g.DrawLines(Pens.Green, puntos);

            //// Fin de ejemplo1

            //// Ejemplo2
            //// Dibuja Bezier con cuatro puntos
            //g.DrawBezier(Pens.Blue, 100, 100, 130, 175, 147, 20, 200, 230);

            //// Dibuja una curva cerrada
            //point[] puntos = { new point(30, 45), new point(110, 75), new point(175, 200) };
            //g.DrawClosedCurve(Pens.Red, puntos);

            //// Dibujamos una curva
            //point[] puntos2 = { new point(10, 25), new point(50, 200), new point(150, 230) };
            //g.DrawCurve(Pens.Purple, puntos2);

            //// Dibujamos un segmento de pie
            g.DrawPie(Pens.Green, new Rectangle(100, 100, 100, 100), 30, 90);

            //// Dibujamos un poligono
            //point[] puntos3 = { new point(10, 175), new point(70, 50), new point(150, 30) };
            //g.DrawPolygon(Pens.Orange, puntos3);

            //// Fin de ejemplo2
        }
    }
