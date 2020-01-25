using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticGUI
{
    public class Firefly
    {
        public List<double> position; // текущее положение в пространстве - вектор
        public double intensity;

        public Firefly(int dim)
        {
            position = new List<double>(dim);

            for (int i = 0; i < dim; i++)
            {
                position.Add(0);
            }
                
            intensity = 0.0; // интенсивность свечения светлячка
        }
    }

    public class FireFlyAlgorithm
    {
        private int dim;
        private List<double> minVal;
        private List<double> maxVal;

        private static Random rnd = new Random();

        public List<Firefly> swarm;

        public double bestIntensity;
        public List<double> bestPosition;

        private double B0;
        private double g;
        private double a;

        public static List<FunctionParser.FOperator> Data;

        public FireFlyAlgorithm(int dimension, List<double> minVals, List<double> maxVals, int numFireflies)
        {
            minVal = minVals;
            maxVal = maxVals;

            dim = dimension;

            bestIntensity = double.MaxValue;
            bestPosition = new List<double>(dimension);

            for (int i = 0; i < dimension; i++)
            {
                bestPosition.Add(0);
            }

            swarm = new List<Firefly>(numFireflies);

            for (int i = 0; i < numFireflies; ++i) // в цикле по всем светлячкам
            {
                swarm.Add(new Firefly(dim)); // создаем нового светлячка
                for (int k = 0; k < dim; ++k) // инициализируем каждую координату локальным значением
                    swarm[i].position[k] = (maxVal[k] - minVal[k]) * rnd.NextDouble() + minVal[k];
                swarm[i].intensity = 1;
            }

            for (int k = 0; k < dim; ++k)
                bestPosition[k] = swarm[0].position[k];
        }

        public void InitParams(double b0, double g, double a)
        {
            //double B0 = 1.0;  // beta (attractiveness base)
            //                  //double betaMin = 0.20;
            //double g = 1.0;   // gamma (absorption for attraction)
            //double a = 0.20;    // alpha
            //                    //double a0 = 1.0;    // base alpha for decay

            this.B0 = b0;
            this.a = a;
            this.g = g;
        }


        public List<double> Run(int maxEpochs)
        {
            int epoch = 1;

            // цикл по числу популяций
            while (epoch < maxEpochs) // main processing
            {
                for (int i = 0; i < swarm.Count; ++i)
                {
                    swarm[i].intensity = Calculate(swarm[i].position);
                }

                for (int i = 0; i < swarm.Count; ++i) // цикл по каждому светлячку
                {
                    for (int j = 0; j < swarm.Count; ++j) // зачем дважды сравнивать, к тому же самого с собой?
                    {
                        // если у текущего светлячка интенсивность свечения меньше - перемещаем его к соседнему
                        if (swarm[i].intensity > swarm[j].intensity)
                        {
                            // curr firefly i is less intense (i is worse) so move i toward j
                            double r = Distance(swarm[i].position, swarm[j].position); // эвклидово расстояние между светлячками
                            double beta = B0 * Math.Exp(-g * r * r); // original 
                                                                     //double beta = (B0 - betaMin) * Math.Exp(-g * r * r) + betaMin; // better
                                                                     //double a = a0 * Math.Pow(0.98, epoch); // better
                            for (int k = 0; k < dim; ++k)
                            {
                                swarm[i].position[k] += beta * (swarm[j].position[k] - swarm[i].position[k]);
                                swarm[i].position[k] += a * (rnd.NextDouble() - 0.5);
                                if (swarm[i].position[k] < minVal[k]) swarm[i].position[k] = (maxVal[k] - minVal[k]) * rnd.NextDouble() + minVal[k];
                                if (swarm[i].position[k] > maxVal[k]) swarm[i].position[k] = (maxVal[k] - minVal[k]) * rnd.NextDouble() + minVal[k];
                            }
                        }
                    } // j
                } // i each firefly

                // сортируем светлячков от малой ошибки к большой
                swarm = swarm.OrderBy(f => f.intensity).ToList(); // low error to high
                if (swarm[0].intensity < bestIntensity) // обновляем лучшую позицию светлячка
                {
                    bestIntensity = swarm[0].intensity;
                    for (int k = 0; k < dim; ++k)
                        bestPosition[k] = swarm[0].position[k];
                }
                ++epoch;
            } // while
            return bestPosition;
        }

        static double Distance(List<double> posA, List<double> posB)
        {
            double ssd = 0.0; // sum squared diffrences (Euclidean)
            for (int i = 0; i < posA.Count; ++i)
                ssd += (posA[i] - posB[i]) * (posA[i] - posB[i]);
            return Math.Sqrt(ssd);
        }

        public static double Calculate(List<double> point)
        {
            Stack<double> st = new Stack<double>();
            double a, b;
            int t;

            try
            {
                for (int i = 0; i < Data?.Count; i++)
                {
                    switch (Data[i].getType())
                    {
                        case 0:
                            st.Push(Data[i].getValue());
                            break;
                        case 1:
                            if (st.Count >= 2)
                            {
                                b = st.Peek();
                                st.Pop();
                                a = st.Peek();
                                st.Pop();
                            }
                            else
                            {
                                throw new FunctionParser.MyException(4);
                            }
                            switch (Convert.ToChar(Data[i].getInt()))
                            {
                                case '+':
                                    st.Push(a + b);
                                    break;
                                case '-':
                                    st.Push(a - b);
                                    break;
                                case '*':
                                    st.Push(a * b);
                                    break;
                                case '/':
                                    st.Push(a / b);
                                    break;
                                case '^':
                                    st.Push(Math.Pow(a, b));
                                    break;
                                default:
                                    throw new FunctionParser.MyException(5);
                            }
                            break; ;
                        case 2:
                            t = Data[i].getInt() - 0;
                            t = t < 0 ? 0 : t;
                            st.Push(point[t]);
                            break;
                        case 3:
                            if (st.Count >= 1)
                            {
                                a = st.Peek();
                                st.Pop();
                            }
                            else
                            {
                                throw new FunctionParser.MyException(6);
                            }
                            switch (Data[i].getInt())
                            {
                                case 0: // sin(x)
                                    st.Push(Math.Sin(a));
                                    break;
                                case 1: // cos(x)
                                    st.Push(Math.Cos(a));
                                    break;
                                case 2: // tg(x)
                                    st.Push(Math.Tan(a));
                                    break;
                                case 3: // ctg(x)
                                    st.Push(1 / Math.Tan(a));
                                    break;
                                case 4: // ln(x)
                                    st.Push(Math.Log(a));
                                    break;
                                case 5: // lg(x)
                                    st.Push(Math.Log10(a));
                                    break;
                                case 6: // sqrt(x)
                                    st.Push(Math.Sqrt(a));
                                    break;
                                case 7: // |x|
                                    st.Push(Math.Abs(a));
                                    break;
                                case 8: // e^x
                                    st.Push(Math.Exp(a));
                                    break;
                                default:
                                    throw new FunctionParser.MyException(7);
                            }
                            break;
                        default:
                            throw new FunctionParser.MyException(7);
                    }
                }
            }
            catch (FunctionParser.MyException e)
            {
                return 0;
            }

            return ((st.Count != 0) ? st.Peek() : 0);
        }
    }
}
