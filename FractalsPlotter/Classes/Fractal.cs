using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsPlotter.Classes
{
    /// <summary>
    /// Базовый класс фрактала
    /// </summary>
    class Fractal
    {
        #region Поля
        #region Private
        int x;
        int y;
        int depth;
        int size;
        Color color;
        #endregion
        #region Public
        /// <summary>
        /// Начальная позиция по X
        /// </summary>
        public int X
        {
            set
            {
                if (value >= 0)
                    this.x = value;
                else
                    this.x = 0;
            }
            get
            {
                return this.x;
            }
        }
        /// <summary>
        ///  Начальная позиция по Y
        /// </summary>
        public int Y
        {
            set
            {
                if (value >= 0)
                    this.y = value;
                else
                    this.y = 0;
            }
            get
            {
                return this.y;
            }
        }
        /// <summary>
        /// Начальный размер
        /// </summary>
        public int Size
        {
            set
            {
                if (value > 0)
                    this.size = value;
                else
                    this.size = 0;
            }
            get
            {
                return this.size;
            }
        }
        /// <summary>
        /// Глубина рекурсии - сколько повторов фрактала будет отрисовано
        /// </summary>
        public int Depth
        {
            set
            {
                if (value > 0)
                    this.depth = value;
                else
                    this.depth = 0;
            }
            get
            {
                return this.depth;
            }
        }
        /// <summary>
        /// Цвет отрисовки фрактала
        /// </summary>
        public Color Color { set { this.color = value; } get { return this.color; } }
        #endregion
        #endregion
        #region Конструкторы
        /// <summary>
        /// Создает фрактал с указанными параметрами
        /// </summary>
        /// <param name="x">начальная координата по X</param>
        /// <param name="y">начальная координата по Y</param>
        /// <param name="size">начальный размер</param>
        /// <param name="depth">глубина рекурсии при построении фрактала</param>
        public Fractal(int x, int y, int size, int depth, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.Depth = depth;
            this.Color = color;
        }
        public Fractal() : this(0, 0, 1, 10, Color.Blue)
        {

        }
        #endregion
        #region Методы
        /// <summary>
        /// Конвертирует угол из градусов в радианы
        /// </summary>
        /// <param name="angle">угол в градусах</param>
        /// <returns></returns>
        public double GetRadians(double angle)
        {
            return Math.PI * angle / 180;
        }
        /// <summary>
        /// Заливает pictureBox указанным цветом
        /// </summary>
        /// <param name="pictureBox">элемент управления для заливки</param>
        /// <param name="backgroundColor">цвет</param>
        public void Fill(PictureBox pictureBox, Color backgroundColor)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(backgroundColor);
        }
        /// <summary>
        /// Отрисовывает фрактал
        /// </summary>
        public void Draw(PictureBox pictureBox)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
