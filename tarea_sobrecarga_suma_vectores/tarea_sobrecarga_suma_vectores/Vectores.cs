using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_sobrecarga_suma_vectores
{

    //comentario
    class Vectores
    {
        private int[] vec;
       
        public Vectores()
        {
           int[] vec = new int[5];
        }
    public void Cargar()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                vec[f] = vec[f];
            }
        }
        
        public static Vectores operator +(Vectores v1, Vectores v2)
        {
            Vectores su = new Vectores();
            for (int f = 0; f < su.vec.Length; f++)
            {
                su.vec[f] = v1.vec[f] + v2.vec[f];
            }
            return su;
        }
    }
}
