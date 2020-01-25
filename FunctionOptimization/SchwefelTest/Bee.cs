using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGUI
{
    class Bee
    {
        private static Random rnd = new Random();

        public List<double> position;
        public List<double> minVal;
        public List<double> maxVal;

        public double fitness;

        public static List<FunctionParser.FOperator> Data;

        public Bee(int nvar, List<double> minVal, List<double> maxVal)
        {
            fitness = 0;
            position = new List<double>(nvar);
            this.minVal = minVal;
            this.maxVal = maxVal;

            for (int i = 0; i < nvar; i++)
            {
                position.Add(rnd.NextDouble() * (maxVal[i] - minVal[i]) + minVal[i]);
            }

            fitness = Calculate(position);
        }

        public List<double> GetPosition()
        {
            return this.position;
        }

        public void Goto(List<double> otherPos, List<double> varRangesList)
        {
            for (int i = 0; i < position.Count; i++)
            {
                position[i] = otherPos[i] + rnd.NextDouble() * (varRangesList[i] - (-varRangesList[i])) + (-varRangesList[i]);
            }

            CheckPosition();
            fitness = Calculate(position);
        }

        public void GotoRandom()
        {
            for (int i = 0; i < position.Count; i++)
            {
                position[i] = rnd.NextDouble() * (maxVal[i] - minVal[i]) + minVal[i];
            }

            CheckPosition();
            fitness = Calculate(position);
        }

        public void CheckPosition()
        {
            for (int i = 0; i < position.Count; i++)
            {
                if (position[i] < minVal[i])
                {
                    position[i] = minVal[i];
                }

                if (position[i] > maxVal[i])
                {
                    position[i] = maxVal[i];
                }
            }
        }

        public bool CheckAnotherBees(List<Bee> bees, List<double> varRangesList)
        {
            if (bees.Count == 0)
                return true; ;

            bool flag = true;

            foreach (var currBee in bees)
            {
                if (flag == false)
                    break;

                for (int i = 0; i < position.Count; i++)
                {
                    if (Math.Abs(position[i] - currBee.position[i]) < varRangesList[i])
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return flag;
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
