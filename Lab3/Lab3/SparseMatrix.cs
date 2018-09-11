using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Linq;
namespace Lab3
{
    public class Matrix3D<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        
        int maxX;
        int maxY;
        int maxZ;
        IMatrixCheckEmpty<T> checkEmpty;
        
        public Matrix3D(int px, int py, int pz, IMatrixCheckEmpty<T> checkEmptyParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.checkEmpty = checkEmptyParam;
        }
        
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.checkEmpty.getEmptyElement();
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }
        
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) 
                throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) 
                throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxZ) 
                throw new Exception("z=" + z + " выходит за границы");
        }
        
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + " " + z.ToString();
        }
        
        public override string ToString()
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием
            //большого количества обычных строк
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append($"\nZ: {k}\n");
                for (int j = 0; j < this.maxY; j++)
                {
                    b.Append("[");
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0) b.Append("\t");
                        if (checkEmpty.checkEmptyElement(this[i, j, k]) != true)
                        {
                            b.Append(this[i, j, k].ToString());
                        }
                        else
                        {
                            b.Append(" - ");
                        }
                    }

                    b.Append("]\n");
                }
            }

            return b.ToString();
        }
    }
}