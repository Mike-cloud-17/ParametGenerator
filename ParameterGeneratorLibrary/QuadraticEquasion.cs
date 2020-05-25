using System;

namespace ParameterGeneratorLibrary
{
    public class QuadraticEquasion
    {
        private bool prompt,answer;
        public bool Prompt { get; set; }
        public bool Answer { get; set; }
        static Random rnd = new Random();
        public string Easy()
        {
            string condition = string.Empty;
            double a = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double b = double.Parse((-70 + (100 + 70) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double c = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            int choose = rnd.Next(1, 4);
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = ""; 
            switch (choose)
            {
                case 1:
                        answer = $"при {nameOfParam} = {b * b / (4*c)}.";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {b}x + {c} = 0 имеет 1 корень.";
                        break;
                case 2:
                        if (a == 0)
                            answer = "при x ∈ R.";
                        else if (a*c < 0)
                            answer = "Нет решений.";
                        else
                            answer = $"при {nameOfParam} = {2*Math.Sqrt(a*c)} U {2 * Math.Sqrt(a * c)}.";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{a}x² + {nameOfParam}x + {c} = 0 имеет 1 корень.";
                        break;
                default:
                    if (a == 0)
                        answer = "при x ∈ R.";
                    else
                        answer = $"при {nameOfParam} = {b * b / (4 * a)}.";
                    condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n{a}x² + {b}x + {nameOfParam} = 0 имеет 1 корень.";
                    break;
            }
            if (Prompt)
            {
                condition += Environment.NewLine + $"Подсказка: необходимо найти дискриминант и приравнять его к нулю," +
                    $"ведь 1 корень может быть только в этом случае.";
            }
            if (Answer)
            {
                condition += Environment.NewLine + "Ответ: " + answer;
            }
            return condition;
        }
        public string Medium()
        {
            string condition = string.Empty;
            double a = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double b = double.Parse((-70 + (100 + 70) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double c = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            int choose = rnd.Next(1, 4);
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            switch (choose)
            {
                case 1:
                    if (b*b/(4*c) < 0)
                        answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}).";
                    else
                        answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}) U " + "{0}.";
                    condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n{nameOfParam}x² + {b}x + {c} = 0 имеет хотя бы 1 корень.";
                    break;
                case 2:
                    if (a == 0)
                        answer = "при x ∈ R.";
                    else if ((a * c < 0) & (-c / a < 0))
                        answer = "Нет решений.";
                    else if ((a * c < 0) & (-c / a >= 0))
                        answer = $"При {nameOfParam} = 0.";
                    else if ((a>0) & (-c / a < 0))
                        answer = $"при {nameOfParam} ∈ (-∞ , {-2 * Math.Sqrt(a * c)}) U ({2 * Math.Sqrt(a * c)} , +∞).";
                    else if ((a > 0) & (-c / a >= 0))
                        answer = $"при {nameOfParam} ∈ (-∞ , {-2 * Math.Sqrt(a * c)}) U ({2 * Math.Sqrt(a * c)} , +∞) U " + "{0}.";
                    else if ((a < 0) & (-c / a < 0))
                        answer = $"при {nameOfParam} ∈ ({-2 * Math.Sqrt(a * c)} , {2 * Math.Sqrt(a * c)}).";
                    else
                        answer = $"при {nameOfParam} ∈ ({-2 * Math.Sqrt(a * c)} , {2 * Math.Sqrt(a * c)}) U " + "{0}.";
                    condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n{a}x² + {nameOfParam}x + {c} = 0 имеет хотя бы 1 корень.";
                    break;
                default:
                    if (a == 0)
                        answer = "при x ∈ R.";
                    else if (b == 0)
                        answer = "при х ∈ [0,+∞).";
                    else
                    { if (b * b / (4 * a) < 0)
                            answer = $"при {nameOfParam} ∈ (-∞ , {-b * b / (4 * a)}] U " + "{0}.";
                      else
                            answer = $"при {nameOfParam} ∈ (-∞ , {-b * b / (4 * a)}].";
                    }
                    condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n{a}x² + {b}x + {nameOfParam} = 0 имеет хотя бы 1 корень.";
                    break;
            }
            if (Prompt)
            {
                condition += Environment.NewLine + $"Подсказка: необходимо найти дискриминант и решить неравенство " +
                    $"D ≥ 0.";
            }
            if (Answer)
            {
                condition += Environment.NewLine + "Ответ: " + answer;
            }
            return condition;
        }
        public string Hard()
        {
            string condition = string.Empty;
            double a = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double b = double.Parse((-70 + (100 + 70) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            double c = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
            int choose = rnd.Next(1, 4);
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            int oneOrTwo = rnd.Next(1, 3);
            switch (choose)
            {
                case 1:
                    if (oneOrTwo == 1)
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , 0) U ({4*c} , +∞).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {nameOfParam}x + {c} = 0 имеет ровно 2 корня.";
                        break;
                    }
                    else
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , 0] U [{4 * c} , +∞).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {nameOfParam}x + {c} = 0 имеет 1 и более корней.";
                        break;
                    }
                case 2:
                    if (oneOrTwo == 1)
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , 0) U ({4 * a} , +∞).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {nameOfParam}x + {c} = 0 имеет ровно 2 корня.";
                        break;
                    }
                    else
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , 0] U [{4 * a},+∞).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {nameOfParam}x + {c} = 0 имеет 1 и более корней.";
                        break;
                    }
                default:
                    if (oneOrTwo == 1)
                    {
                        if (b*b/(4*c)<0)
                            answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}).";
                        else
                            answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {b}x + {nameOfParam} = 0 имеет ровно 2 корня.";
                        break;
                    }
                    else
                    {
                        if (b * b / (4 * c) < 0)
                            answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}] U " + "{0}.";
                        else
                            answer = $"при {nameOfParam} ∈ (-∞ , {b * b / (4 * c)}].";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}x² + {b}x + {nameOfParam} = 0 имеет 1 и более корней.";
                        break;
                    }
            }
            if (Prompt)
            {
                condition += Environment.NewLine + $"Подсказка: необходимо найти дискриминант и решить неравенство " +
                    $"D > 0 (если в условии 2 корня) и D ≥ 0 (если в условии 1 и более корней).";
            }
            if (Answer)
            {
                condition += Environment.NewLine + "Ответ: " + answer;
            }
            return condition;
        }

        public QuadraticEquasion(bool prompt, bool reply)
        {
            Prompt = prompt;
            Answer = reply;
        }
    }
}
