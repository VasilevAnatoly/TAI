using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGUI
{
    public class EdgePrim
    {
        public int v1, v2;
        public int weight;

        public EdgePrim(int v1, int v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }
    }

    //List<Edge> MST = new List<Edge>();
    //algorithmByPrim(V.Count, E, MST);

    public class Prim
    {
        //алгоритм Прима
        public void Algorithm(int numberV, List<EdgePrim> E, List<EdgePrim> MST)
        {

            //неиспользованные ребра
            List<EdgePrim> notUsedE = new List<EdgePrim>(E);

            //использованные вершины
            List<int> usedV = new List<int>();

            //неиспользованные вершины
            List<int> notUsedV = new List<int>();

            for (int i = 0; i < numberV; i++)
                notUsedV.Add(i);

            //выбираем случайную начальную вершину
            Random rand = new Random();

            usedV.Add(rand.Next(0, numberV));
            notUsedV.RemoveAt(usedV[0]);

            while (notUsedV.Count > 0)
            {
                int minE = -1; //номер наименьшего ребра

                //поиск наименьшего ребра
                for (int i = 0; i < notUsedE.Count; i++)
                {
                    if ((usedV.IndexOf(notUsedE[i].v1) != -1) && (notUsedV.IndexOf(notUsedE[i].v2) != -1) ||
                    (usedV.IndexOf(notUsedE[i].v2) != -1) && (notUsedV.IndexOf(notUsedE[i].v1) != -1))
                    {
                        if (minE != -1)
                        {
                            if (notUsedE[i].weight < notUsedE[minE].weight)
                                minE = i;
                        }
                        else
                            minE = i;
                    }
                }

                //заносим новую вершину в список использованных и удаляем ее из списка неиспользованных
                if (usedV.IndexOf(notUsedE[minE].v1) != -1)
                {
                    usedV.Add(notUsedE[minE].v2);
                    notUsedV.Remove(notUsedE[minE].v2);
                }
                else
                {
                    usedV.Add(notUsedE[minE].v1);
                    notUsedV.Remove(notUsedE[minE].v1);
                }

                //заносим новое ребро в дерево и удаляем его из списка неиспользованных
                MST.Add(notUsedE[minE]);
                notUsedE.RemoveAt(minE);
            }
        }
    }
}
