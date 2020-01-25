using System;
using System.Collections.Generic;

namespace GeneticGUI
{
    class ElectroMagnetism
    {
        private static Random rnd = new Random();

        private int dimension;
        private int samplePointsCount;

        private List<double> minVal;
        private List<double> maxVal;

        private List<List<double>> points;

        public List<double> bestPoint;
        public double bestFitness;

        public static List<FunctionParser.FOperator> Data;

        public ElectroMagnetism(int dim, int samplPointsCount, List<double> minVal, List<double> maxVal)
        {
            dimension = dim;
            this.minVal = minVal;
            this.maxVal = maxVal;

            this.samplePointsCount = samplPointsCount;
        }

        public void Init(int samplePointsCount)
        {
            points = new List<List<double>>(samplePointsCount);

            for (int i = 0; i < samplePointsCount; i++)
            {
                points.Add(GetRandomPoint());
            }

            FindBestPoint();
        }

        public void Run(int maxIterations, int localSearchIterations)
        {
            Init(samplePointsCount);

            int i = 0;

            while (i < maxIterations)
            {
                NextStep(localSearchIterations);
                MoveForceVector(CalculateForceVector());
                i++;
            }
        }

        public void NextStep(int localSearchIterations)
        {
            int counter = 1;

            double length = FindMaximumInRanges();

            for (int i = 0; i < samplePointsCount; i++)
            {
                for (int k = 0; k < dimension; k++)
                {
                    var stepOne = rnd.NextDouble();

                    while (counter < localSearchIterations)
                    {
                        var y = points[i];

                        var stepTwo = rnd.NextDouble();

                        if (stepOne > 0.5)
                        {
                            for (int j = 0; j < dimension; j++)
                            {
                                y[j] += stepTwo * length;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < dimension; j++)
                            {
                                y[j] -= stepTwo * length;
                            }
                        }

                        if (Calculate(y) < Calculate(points[i]))
                        {
                            points[i] = y;
                            counter = localSearchIterations;
                        }
                        counter++;
                    }
                }
            }

            FindBestPoint();
        }

        public void FindBestPoint()
        {
            bestPoint = points[0];
            bestFitness = Calculate(points[0]);

            for (int i = 1; i < points.Count; i++)
            {
                double temp = Calculate(points[i]);

                if (temp < bestFitness)
                {
                    bestFitness = temp;
                    bestPoint = points[i];
                }
            }
        }


        public List<double> GetRandomPoint()
        {
            List<double> point = new List<double>(dimension);

            for (int i = 0; i < dimension; i++)
            {
                var coord = rnd.NextDouble() * (maxVal[i] - minVal[i]) + minVal[i];

                if (coord < minVal[i])
                    coord = minVal[i];

                if (coord > maxVal[i])
                    coord = maxVal[i];

                point.Add(coord);
            }

            return point;
        }

        public double Calculate(List<double> point)
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


        public double FindMaximumInRanges()
        {
            double max = Math.Abs(maxVal[0] - minVal[0]);

            for (int i = 1; i < dimension; i++)
            {
                if (Math.Abs(maxVal[i] - minVal[i]) > max)
                    max = Math.Abs(maxVal[i] - minVal[i]);
            }

            return max;
        }

        public List<List<double>> CalculateForceVector()
        {
            List<double> q = new List<double>(samplePointsCount);
            List<List<double>> F = new List<List<double>>(samplePointsCount);

            for (int i = 0; i < samplePointsCount; i++)
            {
                F.Add(new List<double>(dimension));

                for (int k = 0; k < dimension; k++)
                {
                    F[i].Add(0);
                }
            }

            double summ = 0;

            for (int i = 0; i < samplePointsCount; i++)
            {
                summ += Calculate(points[i]) * Calculate(bestPoint);
            }

            for (int i = 0; i < samplePointsCount; i++)
            {
                q.Add(Math.Exp(-dimension * (Calculate(points[i]) * Calculate(bestPoint)) / (summ)));
            }

            for (int i = 0; i < samplePointsCount; i++)
            {
                for (int j = 0; j < samplePointsCount; j++)
                {
                    if (i == j)
                        continue;

                    var calc = (q[i] * q[j]) / (GetDistanceBetweenVectors(points[j], points[i]));

                    if (Calculate(points[j]) < Calculate(points[i]))
                    {
                        for (int k = 0; k < dimension; k++)
                        {
                            F[i][k] = F[i][k] + (points[j][k] - points[i][k]) * calc;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < dimension; k++)
                        {
                            F[i][k] = F[i][k] - (points[i][k] - points[j][k]) * calc;
                        }
                    }
                }
            }

            return F;
        }

        public void MoveForceVector(List<List<double>> F)
        {
            for (int i = 0; i < samplePointsCount; i++)
            {
                if (!points[i].Equals(bestPoint))
                {
                    var step = rnd.NextDouble();

                    for (int j = 0; j < F.Count; j++)
                    {
                        var delim = GetVectorNorma(F[j]);

                        for (int x = 0; x < F[j].Count; x++)
                        {
                            F[j][x] = F[j][x] / delim;
                        }
                    }

                    for (int k = 0; k < dimension; k++)
                    {
                        if (F[i][k] > 0)
                        {
                            points[i][k] += step * F[i][k] * (maxVal[k] - points[i][k]);
                        }
                        else
                        {
                            points[i][k] += step * F[i][k] * (points[i][k] - minVal[k]);
                        }
                    }
                }
            }
        }

        public double GetDistanceBetweenVectors(List<double> first, List<double> second)
        {
            double summ = 0;

            for (int i = 0; i < dimension; i++)
            {
                summ += Math.Pow(first[i] - second[i], 2);
            }

            return summ;
        }

        public double GetVectorNorma(List<double> vector)
        {
            double summ = 0;

            for (int i = 0; i < dimension; i++)
            {
                summ += Math.Abs(vector[i]);
            }

            return summ;
        }
    }
}
