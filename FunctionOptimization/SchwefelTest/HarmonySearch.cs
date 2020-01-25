using System;
using System.Collections.Generic;

namespace GeneticGUI
{
    public class HarmonySearch
    {
        public int NVAR { get; set; }
        public int HMS { get; set; }
        public int maxIter { get; set; }
        public double PAR { get; set; }
        public double BW { get; set; }
        public double HMCR { get; set; }
        private List<double> minVal;
        private List<double> maxVal;
        private double[] NCHV;
        private double[] bestFitHistory;
        public double[] bestHarmony { get; set; }
        private double[] worstFitHistory;
        private double[,] HM;
        public int generation { get; set; }
        private bool terminationCriteria = true;
        private static Random randGen = new Random();

        public static List<FunctionParser.FOperator> Data;

        public HarmonySearch(double bw, int dim, double hmcr, int hms, double par, int maxIterCount)
        {
            BW = bw;
            NVAR = dim;
            HMCR = hmcr;
            HMS = hms;
            PAR = par;
            maxIter = maxIterCount;
            generation = 0;
        }

        private void setArrays()
        {
            minVal = new List<double>(NVAR);
            maxVal = new List<double>(NVAR);
            NCHV = new double[NVAR];
            bestHarmony = new double[NVAR + 1];
            bestFitHistory = new double[maxIter + 1];
            worstFitHistory = new double[maxIter + 1];
            HM = new double[HMS, NVAR + 1];
        }

        public void setBounds(List<double> minVal, List<double> maxVal)
        {
            setArrays();
            this.minVal = minVal;
            this.maxVal = maxVal;
        }

        private void initiator()
        {
            int i;
            double curFit;

            for (i = 0; i < HMS; i++)
            {
                for (int j = 0; j < NVAR; j++)
                {
                    HM[i, j] = randGen.NextDouble() * (maxVal[j] - minVal[j]) + minVal[j];

                    if (HM[i, j] < minVal[j])
                        HM[i, j] = minVal[j];

                    if (HM[i, j] > maxVal[j])
                        HM[i, j] = maxVal[j];

                    NCHV[j] = HM[i, j];
                }
                curFit = Calculate(NCHV);
                HM[i, NVAR] = curFit;
            }
        }

        public double Calculate(double[] point)
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

        public bool stopCondition()
        {
            if (generation > maxIter)
                terminationCriteria = false;
            return terminationCriteria;
        }

        public void updateHarmonyMemory(double newFitness)
        {

            // find worst harmony
            double worst = HM[0, NVAR];
            int worstIndex = 0;
            for (int i = 0; i < HMS; i++)
                if (HM[i, NVAR] > worst)
                {
                    worst = HM[i, NVAR];
                    worstIndex = i;
                }
            worstFitHistory[generation] = worst;
            // update harmony
            if (newFitness < worst)
            {
                for (int k = 0; k < NVAR; k++)
                    HM[worstIndex, k] = NCHV[k];
                HM[worstIndex, NVAR] = newFitness;
            }

            // find best harmony
            double best = HM[0, NVAR];
            int bestIndex = 0;
            for (int i = 0; i < HMS; i++)
                if (HM[i, NVAR] < best)
                {
                    best = HM[i, NVAR];
                    bestIndex = i;
                }
            bestFitHistory[generation] = best;
            if (generation > 0 && best != bestFitHistory[generation - 1])
            {
                for (int k = 0; k < NVAR; k++)
                    bestHarmony[k] = HM[bestIndex, k];
                bestHarmony[NVAR] = best;
            }
        }

        private void memoryConsideration(int varIndex)
        {
            NCHV[varIndex] = HM[(int)(randGen.NextDouble() * (HMS - 1)), varIndex];
        }

        private void pitchAdjustment(int varIndex)
        {
            double rand = randGen.NextDouble();
            double temp = NCHV[varIndex];

            if (rand < 0.5)
            {
                temp += rand * BW;
                if (temp < maxVal[varIndex])
                    NCHV[varIndex] = temp;
            }
            else
            {
                temp -= rand * BW;
                if (temp > minVal[varIndex])
                    NCHV[varIndex] = temp;
            }
        }

        private void randomSelection(int varIndex)
        {
            NCHV[varIndex] = randGen.NextDouble() * (maxVal[varIndex] - minVal[varIndex]) + minVal[varIndex];

            if (NCHV[varIndex] < minVal[varIndex])
                NCHV[varIndex] = minVal[varIndex];

            if (NCHV[varIndex] > maxVal[varIndex])
                NCHV[varIndex] = maxVal[varIndex];
        }

        public void Run()
        {
            initiator();

            while (stopCondition())
            {

                for (int i = 0; i < NVAR; i++)
                {
                    if (randGen.NextDouble() < HMCR)
                    {
                        memoryConsideration(i);
                        if (randGen.NextDouble() < PAR)
                            pitchAdjustment(i);
                    }
                    else
                        randomSelection(i);
                }

                double currentFit;
                currentFit = Calculate(NCHV);
                updateHarmonyMemory(currentFit);
                generation++;
            }
        }
    }
}
