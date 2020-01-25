using System;
using System.Collections.Generic;

namespace GeneticGUI
{
    public class HillClimb
    {
        private static Random rnd = new Random();

        public int dimension;

        public List<double> minVal;

        public List<double> maxVal;

        public List<double> candidates;

        public List<double> stepSize;

        public double acceleration;

        public double bestFitness;

        public List<double> bestPoint;

        public static List<FunctionParser.FOperator> Data;

        public HillClimb(int dim, List<double> minVal, List<double> maxVal)
        {
            dimension = dim;
            this.minVal = minVal;
            this.maxVal = maxVal;

            acceleration = 1.2;

            stepSize = new List<double>(dim);

            for (int i = 0; i < dim; i++)
            {
                stepSize.Add(1);
            }

            candidates = new List<double>(5)
            {
                -acceleration, -1/acceleration, 0, 1/acceleration, acceleration
            };
        }

        public void NextStep()
        {
            for (int i = 0; i < dimension; i++)
            {
                double bestFitness = Double.MaxValue;

                int bestIdx = -1;

                for (int j = 0; j < candidates.Count; j++)
                {
                    bestPoint[i] += stepSize[i] * candidates[j];

                    double temp = Calculate(bestPoint);

                    bestPoint[i] -= stepSize[i] * candidates[j];

                    if (temp < bestFitness)
                    {
                        bestFitness = temp;
                        bestIdx = j;
                    }
                }

                if ((int)(candidates[bestIdx]) == 0)
                {
                    stepSize[i] /= acceleration;
                }
                else
                {
                    stepSize[i] *= candidates[bestIdx];
                    bestPoint[i] += stepSize[i];
                }
            }
        }

        public void Run(int maxIterations, double epsilon)
        {
            bool flag = true;

            bestPoint = GetRandomStartPoint();

            int i = 0;

            while (flag && i < maxIterations)
            {
                bestFitness = Calculate(bestPoint);

                NextStep();

                i++;

                var currFitness = Calculate(bestPoint);

                if (Math.Abs(currFitness - bestFitness) < epsilon)
                    flag = false;
            }
        }

        public List<double> GetRandomStartPoint()
        {
            List<double> startPoint = new List<double>(dimension);

            for (int i = 0; i < dimension; i++)
            {
                var coord = rnd.NextDouble() * (maxVal[i] - minVal[i]) + minVal[i];

                if (coord < minVal[i])
                    coord = minVal[i];

                if (coord > maxVal[i])
                    coord = maxVal[i];

                startPoint.Add(coord);
            }

            return startPoint;
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
    }
}
