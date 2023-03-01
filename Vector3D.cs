using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract12_Kovyazin
{
   public class Vector3D
    {
        public double x;
        public double y;
        public double z;

        public Vector3D(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        public Vector3D Add(Vector3D v)
        {
            return new Vector3D(this.x + v.x, this.y + v.y, this.z + v.z);

        }
        public Vector3D Subtract(Vector3D v)
        {
            return new Vector3D(this.x - v.x, this.y - v.y, this.z - v.z);

        }
        public double DotPr(Vector3D v)
        {
            return this.z * v.x + this.y * v.y + this.z * v.z;
        }
        public double Length()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);

        }
        public double Cosine(Vector3D v)
        {
            return this.DotPr(v) / (this.Length() * v.Length());

        }
        //public void Deduction()
        //{
        //    Vector3D v1 = new Vector3D(1, 2, 3);
        //    Vector3D v2 = new Vector3D(4, 5, 6);

        //    Vector3D sum = v1.Add(v2);
        //    Vector3D difference = v1.Subtract(v2);
        //    double dotPr = v1.DotPr(v2);
        //    double length = v1.Length();
        //    double cosine = v1.Cosine(v2);

        //    MessageBox.Show($"Сумма векторов: {sum}" + "\n" + $"Разность векторов: {difference}" + "\n" + $"Скалярное произведение: {dotPr}" + "\n" + $"Длина вектора: {length}" + "\n" + $"Косинус угла между векторами ");

        //}

    }
}
