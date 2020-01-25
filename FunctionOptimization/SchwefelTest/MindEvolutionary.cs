using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticGUI
{
    class GroupS
    {
        private GaussianRandom gauss;
        private static Random rnd = new Random();
        public List<List<double>> individuals;
        public List<double> scores;
        private int dimension;

        public List<double> bestPoint;
        public double bestFitness;

        public List<double> minVal;
        public List<double> maxVal;

        public static List<FunctionParser.FOperator> Data;

        public GroupS(int dim, List<double> minVal, List<double> maxVal, int individsCount, double mu = 0, double sigma = 1)
        {
            individuals = new List<List<double>>(individsCount);
            scores = new List<double>(individsCount);
            gauss = new GaussianRandom(null, mu, sigma);

            dimension = dim;
            this.minVal = minVal;
            this.maxVal = maxVal;

            individuals.Add(GetRandomPoint());

            for (int i = 0; i < individsCount; i++)
            {
                scores.Add(0);
            }

            for (int i = 1; i < individsCount; i++)
            {
                individuals.Add(GetRandomGaussPoint(individuals[0]));
            }

            CalculateScores();

            FindBestPoint();
        }

        public void SimilarTaxis()
        {
            for (int i = 0; i < individuals.Count; i++)
            {
                if (individuals[i] == bestPoint)
                    continue;

                individuals[i] = GetRandomGaussPoint(bestPoint);
            }

            CalculateScores();
            FindBestPoint();
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

        public List<double> GetRandomGaussPoint(List<double> startPoint)
        {
            List<double> point = new List<double>(dimension);

            for (int i = 0; i < dimension; i++)
            {
                var coord = startPoint[i] + gauss.NextGaussian() * (maxVal[i] - minVal[i]) + minVal[i];

                if (coord < minVal[i])
                    coord = minVal[i];

                if (coord > maxVal[i])
                    coord = maxVal[i];

                point.Add(coord);
            }

            return point;
        }

        public void CalculateScores()
        {
            for (int i = 0; i < individuals.Count; i++)
            {
                scores[i] = Calculate(individuals[i]);
            }
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

        public void FindBestPoint()
        {
            bestPoint = individuals[0];
            bestFitness = Calculate(individuals[0]);

            for (int i = 1; i < individuals.Count; i++)
            {
                double temp = Calculate(individuals[i]);

                if (temp < bestFitness)
                {
                    bestFitness = temp;
                    bestPoint = individuals[i];
                }
            }
        }
    }

    class MindEvolutionary
    {
        private int dimension;

        private int domainsNumber;
        private int sCount;

        public List<GroupS> leadingGroups;
        private List<GroupS> laggingGroups;

        private int leadingGroupsCount;
        private int laggingGroupsCount;

        private List<double> minVal;
        private List<double> maxVal;

        private double mu;
        private double sigma;

        private double oldMinimum;

        public MindEvolutionary(int dim, List<double> minVal, List<double> maxVal)
        {
            dimension = dim;
            this.minVal = minVal;
            this.maxVal = maxVal;
            this.oldMinimum = Double.MaxValue;
        }

        public void InitGaussian(double mu = 0, double sigma = 1)
        {
            this.mu = mu;
            this.sigma = sigma;
        }

        public void InitGroups(int domains, int s, int leadingGroupsCount, int laggingGroupsCount)
        {
            domainsNumber = domains;
            sCount = s;
            this.leadingGroupsCount = leadingGroupsCount;
            this.laggingGroupsCount = laggingGroupsCount;

            leadingGroups = new List<GroupS>(leadingGroupsCount);
            laggingGroups = new List<GroupS>(laggingGroupsCount);
        }


        public void Start(int individs, List<FunctionParser.FOperator> Data)
        {
            GroupS.Data = Data;

            List<GroupS> allGroups = new List<GroupS>(domainsNumber * sCount);

            for (int i = 0; i < domainsNumber; i++)
            {
                List<double> minVals = new List<double>(dimension);
                List<double> maxVals = new List<double>(dimension);

                for (int j = 0; j < dimension; j++)
                {
                    minVals.Add(minVal[j] + i * (maxVal[j] - minVal[j]) / domainsNumber);
                    maxVals.Add(minVal[j] + (i + 1) * (maxVal[j] - minVal[j]) / domainsNumber);
                }

                for (int j = 0; j < sCount; j++)
                {
                    allGroups.Add(new GroupS(dimension, minVals, maxVals, individs, mu, sigma));
                }
            }

            allGroups = allGroups.OrderBy(g => g.bestFitness).ToList();

            leadingGroups = allGroups.Take(leadingGroupsCount).ToList();
            laggingGroups = allGroups.Skip(leadingGroupsCount).Take(laggingGroupsCount).ToList();
        }

        public void Run()
        {
            do
            {
                oldMinimum = leadingGroups.Min(lg => lg.bestFitness);
                SimilarTaxis();
                Dissimilation();
            }
            while (leadingGroups[leadingGroups.Count - 1].bestFitness < oldMinimum);
        }

        public void SimilarTaxis()
        {
            for (int i = 0; i < leadingGroups.Count; i++)
            {
                leadingGroups[i].SimilarTaxis();
            }

            leadingGroups = leadingGroups.OrderBy(g => g.bestFitness).ToList();

            for (int i = 0; i < laggingGroups.Count; i++)
            {
                laggingGroups[i].SimilarTaxis();
            }
        }

        public void Dissimilation()
        {
            laggingGroups = laggingGroups.OrderBy(g => g.bestFitness).ToList();

            for (int i = 0; i < leadingGroups.Count; i++)
            {
                for (int j = 0; j < laggingGroups.Count; j++)
                {
                    if (leadingGroups[i].bestFitness > laggingGroups[j].bestFitness)
                    {
                        var temp = leadingGroups[i];
                        leadingGroups[i] = laggingGroups[j];
                        laggingGroups[j] = temp;
                    }
                }
            }

            leadingGroups = leadingGroups.OrderBy(g => g.bestFitness).ToList();

            var removedGroups = laggingGroups.Where(lg => lg.bestFitness > leadingGroups[leadingGroups.Count - 1].bestFitness).ToList();

            laggingGroups.RemoveAll(lg => lg.bestFitness > leadingGroups[leadingGroups.Count - 1].bestFitness);

            for (int i = 0; i < removedGroups.Count; i++)
            {
                laggingGroups.Add(new GroupS(dimension, removedGroups[i].minVal, removedGroups[i].maxVal, removedGroups[i].individuals.Count, mu, sigma));
            }
        }
    }
}
