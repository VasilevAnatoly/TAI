using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticGUI
{
    public class FunctionParser
    {
        public class MyException : Exception
        {
            public int exc_Id;

            public MyException(int id) : base()
            {
                exc_Id = id;
            }
        }
        public class FOperator
        {
            private int type;
            private double value;

            public FOperator(double val)
            {
                this.type = 0;
                this.value = val;
            }

            public FOperator(int val, int type)
            {
                this.value = val;
                this.type = type;
            }

            public int getInt()
            {
                int val = (int)this.value;
                return val;
            }

            public int getType()
            {
                return this.type;

            }

            public double getValue()
            {
                return this.value;

            }

            public bool isValue()
            {
                return this.type == 0;

            }

            public bool isAction()
            {
                return this.type == 1;

            }

            public bool isVariable()
            {
                return this.type == 2;

            }
        }

        public class xFunction
        {
            private List<Double> start_point = new List<Double>();

            private List<Double> current_point = new List<Double>();

            private static string[] xFunctionFunctions = { "sin", "cos", "tg", "ctg", "ln", "lg", "sqrt", "abs", "exp" };
            private static string[] xFunctionParsingErrors = { "Недостаточно данных для произведения математических операций!", "После знака математической операции нет данных!", "Данные для математических функций должны указываться в ()!", "Несоответствие числа ( и ) скобок!", "Ошибка в содержимом стека!", "Ошибка в знаке математической операции!", "Неизвестная переменная!", "Ошибка в вычислении математической функции!", "Введите выражение для функции!" };

            public List<FOperator> Data = new List<FOperator>();
            private int error_pos;
            public bool was_error;
            private int start_x;

            public xFunction()
            {
                this.init();
            }
            public xFunction(string src)
            {
                this.init();
                this.ReadString(src);
            }


            private void init()
            {
                this.start_x = 0;
                this.reset();
            }

            private void reset()
            {
                this.was_error = false;
                this.error_pos = -1;
            }

            private bool inArray(char a, string arr)
            {
                if (arr.Contains($"{a}"))
                    return true;
                else
                    return false;
            }

            private bool isDigit(char a)
            {
                return this.inArray(a, "0123456789");
            }

            private bool isAction(char a)
            {
                return this.inArray(a, "+-*/^");
            }

            private bool isNumeric(char a)
            {
                return this.isDigit(a) || a == '.';
            }

            private bool isSpace(char a)
            {
                return this.inArray(a, " \t\n\r");
            }

            private bool isVariable(char a)
            {
                return this.inArray(a, "xX");
            }

            private int getPriority(char a)
            {
                switch (a)
                {
                    case '(':
                    case ')':
                        return 4;
                    case '^':
                        return 3;
                    case '*':
                    case '/':
                        return 2;
                    case '+':
                    case '-':
                        return 1;
                }
                return 0;
            }


            private int getStartIndex()
            {
                return this.start_x;

            }

            private bool isFunct(string str, ref int get_id, ref int get_len)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (str.Length >= xFunctionFunctions[i].Length)
                    {
                        if (String.Compare(str.Substring(0, xFunctionFunctions[i].Length), xFunctionFunctions[i]) == 0)
                        {
                            get_id = i;
                            get_len = xFunctionFunctions[i].Length;
                            return true;
                        }
                    }
                }
                return false;
            }
            public int ReadString(string _in)
            {
                Stack<char> st = new Stack<char>();
                Stack<int> st_fun = new Stack<int>();
                int f_id = 0, f_len = 0;

                this.reset();
                char last = (0).ToString()[0];
                this.Data.Clear();

                if (_in == String.Empty || _in == null)
                {
                    this.was_error = true;
                    error_pos = 0;
                    return 0;
                }

                for (int i = 0; i < _in.Length;)
                {
                    try
                    {
                        if (this.isSpace(_in[i]))
                        {
                            i++;
                            continue;
                        }
                        if (i != 0)
                            last = _in[i - 1];
                        else
                            last = Char.Parse((0).ToString());

                        if (this.isNumeric(_in[i]) || (_in[i] == '-' && (last == '(' || this.isSpace(last) || (i == 0))))
                        {
                            string cache = String.Empty;
                            StringBuilder a = new StringBuilder(String.Empty);
                            while ((i < _in.Length) && (_in[i] == '-' || this.isNumeric(_in[i])))//пока "минус" либо цифра
                            {
                                if (i == 0 && _in[i] == '-')
                                {
                                    a.Append(_in[i++]);
                                }
                                else
                                {
                                    if (_in[i] == '-' && this.isNumeric(_in[i - 1]))//если после числа стоит знак минус, то прерваться
                                        break;
                                    a.Append(_in[i++]);
                                }
                            }

                            if (_in[i - 1] == '-')
                                a.Append((1).ToString()[0]);
                            cache = cache.Insert(0, a.ToString());
                            last = cache[cache.Length - 1];

                            /*if (_in[i] == 'x')
                            {
                                string cache1 = String.Empty;
                                StringBuilder a1 = new StringBuilder(String.Empty);
                                i++;

                                if (i < _in.Length && _in[i] == '[')
                                {
                                    i++;
                                    while (i < _in.Length && this.isDigit(_in[i]) && (_in[i] != ']'))
                                    {
                                        a1.Append(_in[i++]);
                                    }

                                    cache1 = cache1.Insert(0, a1.ToString());
                                    if (cache1 == String.Empty)
                                    {
                                        cache1 = (0).ToString();
                                    }

                                    this.Data.Add(new FOperator(int.Parse(cache1), 2));
                                    this.Data.Add(new FOperator(int.Parse(cache), 0));
                                    this.Data.Add(new FOperator('*', 1));

                                    i++;
                                    continue;
                                }
                                else
                                {
                                    cache1 = (0).ToString();
                                    this.Data.Add(new FOperator(int.Parse(cache1), 2));
                                    this.Data.Add(new FOperator(int.Parse(cache), 0));
                                    this.Data.Add(new FOperator('*', 1));
                                    continue;
                                }
                            }
                            else
                            {
                                if (cache[0] == '-' && cache[1] == '1')
                                {
                                    st.Push('*');
                                    this.Data.Add(new FOperator(int.Parse(cache)));
                                }
                                else
                                    this.Data.Add(new FOperator(int.Parse(cache)));//добавили число
                                continue;
                            }*/

                            if (cache[0] == '-' && cache[1] == '1')
                            {
                                st.Push('*');
                                this.Data.Add(new FOperator(Double.Parse(cache)));
                            }
                            else
                                this.Data.Add(new FOperator(Double.Parse(cache)));//добавили число
                            continue;
                        }

                        if (this.isAction(_in[i]))
                        {
                            if (this.Data.Count == 0 || this.isAction(last))
                            {
                                error_pos = i;
                                throw new MyException(0);
                            }
                            if (st.Count > 0 && st.Peek() != '(' && (this.getPriority(_in[i]) <= this.getPriority(st.Peek())))
                            {
                                while (st.Count > 0 && (this.getPriority(st.Peek()) >= this.getPriority(_in[i])))
                                {
                                    if (st.Peek() == '(')
                                    {
                                        st.Peek();
                                        break;
                                    }
                                    this.Data.Add(new FOperator(st.Peek(), 1));
                                    st.Pop();
                                }
                            }
                            st.Push(_in[i++]);
                            while (this.isSpace(_in[i]))
                                i++;
                            if (!this.isFunct(_in.Substring(i), ref f_id, ref f_len) && !this.isVariable(_in[i]) && !this.isNumeric(_in[i]) && !this.inArray(_in[i], "-("))
                            {
                                error_pos = i;
                                throw new MyException(1);
                            }
                            continue;
                        }

                        if (this.isFunct(_in.Substring(i), ref f_id, ref f_len))
                        {
                            i += f_len;
                            st_fun.Push(f_id);
                            while (this.isSpace(_in[i]))
                                i++;
                            if (_in[i] == '(')
                                st.Push(_in[i++]);
                            else
                            {
                                error_pos = i;
                                throw new MyException(2);
                            }
                            continue;
                        }

                        if (_in[i] == 'x')
                        {
                            string cache = String.Empty;
                            StringBuilder a = new StringBuilder(String.Empty);
                            i++;

                            if (i < _in.Length && _in[i] == '[')
                            {
                                i++;
                                while (i < _in.Length && this.isDigit(_in[i]) && (_in[i] != ']'))
                                {
                                    a.Append(_in[i++]);
                                }

                                cache = cache.Insert(0, a.ToString());
                                if (cache == String.Empty)
                                {
                                    cache = (0).ToString();
                                }

                                this.Data.Add(new FOperator(int.Parse(cache), 2));
                                i++;
                                continue;
                            }
                            else
                            {
                                cache = (0).ToString();
                                this.Data.Add(new FOperator(int.Parse(cache), 2));
                                continue;
                            }
                        }

                        if (_in[i] == '(')
                        {
                            st.Push(_in[i++]);
                            st_fun.Push(-1);
                            continue;
                        }

                        if (_in[i] == ')')
                        {
                            if (st.Count == 0)
                            {
                                error_pos = i;
                                throw new MyException(3);
                            }
                            while (st.Count > 0)
                            {
                                if (st.Peek() == '(')
                                {
                                    st.Pop();
                                    if (st_fun.Count == 0)
                                    {
                                        error_pos = i;
                                        throw new MyException(3);
                                    }
                                    break;
                                }
                                this.Data.Add(new FOperator(st.Peek(), 1));
                                st.Pop();
                            }
                            if (st_fun.Count > 0)
                            {
                                if (st_fun.Peek() != -1)
                                    this.Data.Add(new FOperator(st_fun.Peek(), 3));
                                st_fun.Pop();
                            }
                            else
                            {
                                error_pos = i;
                                throw new MyException(3);
                            }
                            i++;
                            continue;
                        }

                        throw new MyException(-1);
                    }
                    catch (MyException e)
                    {
                        this.error_pos = i;
                        if (e.exc_Id == -1)
                        {

                            this.was_error = false;
                            i++;
                        }
                        else
                        {
                            this.was_error = true;
                            return 0;
                        }
                    }
                }

                while (st.Count > 0)
                {
                    this.Data.Add(new FOperator(st.Peek(), 1));
                    st.Pop();
                }
                return 1;
            }

            public double exec_mnogomern(Double[] x)
            {
                Stack<double> st = new Stack<double>();
                double a, b;
                int t;

                try
                {
                    for (int i = 0; i < this.Data.Count; i++)
                    {
                        switch (this.Data[i].getType())
                        {
                            case 0:
                                st.Push(this.Data[i].getValue());
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
                                    throw new MyException(4);
                                }
                                switch (Convert.ToChar(this.Data[i].getInt()))
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
                                        throw new MyException(5);
                                }
                                break; ;
                            case 2:
                                t = this.Data[i].getInt() - 0;
                                t = t < 0 ? 0 : t;
                                if (t >= current_point.Count || t < 0)
                                {
                                    throw new MyException(6);
                                }
                                st.Push(x[t]);
                                break;
                            case 3:
                                if (st.Count >= 1)
                                {
                                    a = st.Peek();
                                    st.Pop();
                                }
                                else
                                {
                                    throw new MyException(6);
                                }
                                switch (this.Data[i].getInt())
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
                                        throw new MyException(7);
                                }
                                break;
                            default:
                                throw new MyException(7);
                        }
                    }
                }
                catch (MyException e)
                {
                    return 0;
                }

                return ((st.Count != 0) ? st.Peek() : 0);
            }
        }

    }
}
