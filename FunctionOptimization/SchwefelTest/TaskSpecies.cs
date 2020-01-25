using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticGUI
{
    class TaskSpecies : BaseDoubleSpecies<TaskSpecies>
    {
        public TaskSpecies() :
            base()
        {
        }

        public static List<FunctionParser.FOperator> Data;

        public TaskSpecies(double[] chromosomes) :
            base(chromosomes)
        {
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < m_Chromosomes.Length; i++)
            {
                builder.AppendFormat("x[{0:D4}] = {1}\r\n", i, m_Chromosomes[i]);
            }

            builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}", m_FuncVal);

            return builder.ToString();
        }

        protected  override double CalcFinalFunc()
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
                            st.Push(m_Chromosomes[t]);
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
