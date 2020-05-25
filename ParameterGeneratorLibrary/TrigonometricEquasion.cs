using System;

namespace ParameterGeneratorLibrary
{
    public class TrigonometricEquasion
    {
        private bool prompt, answer;
        public bool Prompt { get; set; }
        public bool Answer { get; set; }
        static Random rnd = new Random();
        public string Easy()
        {
            int choose = rnd.Next(1, 3);
            string condition = string.Empty;
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            switch (choose)
            {
                case 1:
                    double a = double.Parse((-1 + (2) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 4)}"));
                    int b = rnd.Next(1, 30);
                    double c = double.Parse((1 + (1) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"));
                    int point = rnd.Next(1, 4);
                    if (point == 1)
                    {
                        answer = $"при {nameOfParam} ∈ ({a} , 1].";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}2sin²(x) + sin(x) = {nameOfParam} имеет корени =" +
                            $" (-1)ⁿ⁺¹arcsin⁡((-{b}±√(1+{rnd.Next(3,10)}{nameOfParam})*0,25)+πn,n∈Z.";
                    }
                    else if (point == 2)
                    {
                        answer = $"при {nameOfParam} = {a}.";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}2sin²(x) + sin(x) = {nameOfParam} имеет корени =" +
                            $" (-1)ⁿ⁺¹arcsin⁡({c})+πn,n∈Z.";
                    }
                    else
                    {
                        answer = $"при {nameOfParam} ∈ ({rnd.Next(1,10)} , {rnd.Next(10,17)}].";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\n{nameOfParam}2sin²(x) + sin(x) = {nameOfParam} имеет корени =" +
                            $" (-1)ⁿ⁺¹arcsin⁡(-1+√(1+{rnd.Next(3, 10)}{nameOfParam})*0,25)+πn,n∈Z.";
                    }
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуется сделать замену sin(x) на t, не забыв при этом, " +
                            $"что |t| ≤ 1, и рассмотреть возможное количество корней исходя из значений дискриминанта.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    int d = rnd.Next(1, 18);
                    int point2 = rnd.Next(1, 3);
                    if (point2 == 1)
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , {d}) U ({d} , +∞).";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\ncos(2x) - {rnd.Next(5, 17)}arccos(x) + {nameOfParam}² + {rnd.Next(1,6)} = 0 не имеет корней.";
                    }
                    else
                    {
                        answer = $"при {nameOfParam} = {rnd.Next(-15,16)}.";
                        condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                            $"\ncos(2x) - {rnd.Next(5, 17)}arccos(x) + {nameOfParam}² + {rnd.Next(1, 6)} = 0 имеет хотя бы 1 корень.";
                    }
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуетсЯ сделать замену cos(x) на t, не забыв при этом, " +
                            $"что |t| ≤ 1, и рассмотреть возможное количество корней исходя из значений дискриминанта.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
            }
            return condition;
        }
        public string Medium()
        {
            int choose = rnd.Next(1, 4);
            string condition = string.Empty;
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            switch (choose)
            {
                case 1:
                    double a = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    answer = $"при {nameOfParam} = {rnd.Next(-5, 5)}.";
                    condition = $"При каком наибольшем значении параметра {nameOfParam} уравнение:" +
                        $"\n{a}cos⁴(x) + {nameOfParam}sin²(x) - 2{nameOfParam} = 1 имеет решение.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуется сделать замену cos(x) на t, не забыв при этом, " +
                            $"что |t| ≤ 1, сказать, что D ≥ 0 и проверить, попадают ли корни в отрезок [0, 1].";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                case 2:
                    double b = double.Parse((-70 + (100 + 70) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    answer = $"при {nameOfParam} = {rnd.Next(-99, 111)}.";
                    condition = $"При каком наименьшем значении параметра {nameOfParam} решением неравенства:" +
                        $"\n4sin(x) ≤ {b}{nameOfParam} + 1 является любое действительное число.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: заметить, что неравенство sin(x) ≤ 1 всегда верно и привести к нему исходное неравенство.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    double c = rnd.Next(-50, 50);
                    answer = $"при {nameOfParam} ∈ (0,5 , 0,5√(2) + {c}) U (0,5√(2) + {c} , +∞).";
                    condition = $"Найдте все значения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n(1 + (2 - 2{nameOfParam})sin(t))/({c}cos(t)-sin(t)) = 2{nameOfParam} имеет хотя бы 1 решение на интервале (0 ; 0,5π).";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуется сделать замену cos(t) на x b sin(t) на у, составить систему" +
                            $" уравнений, решить её и понять, что получившаяся прямая должна иметь с единичной окружностью ровно 1 общую точку " +
                            $"в заданном промежутке, ведь x² + y² = 1.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
            }
            return condition;
        }
        public string Hard()
        {
            int choose = rnd.Next(1, 3);
            string condition = string.Empty;
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            switch (choose)
            {
                case 1:
                    double a = double.Parse((10 + (30 + 30) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    double b = double.Parse((-150 + (150 + 150) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    double c = double.Parse((70 + (31 + 100) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    answer = $"при {nameOfParam} ∈ [0 , (4√(2) - 2)/21 + {a}) U ((4√(2) - 2)/21 + {a} , (4√(2) - 2)/21 + {c}) U ((4√(2) - 2)/21 + {c} , {0.33 + c}).";
                    condition = $"Найдте все значения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n({nameOfParam} - ({b} - 3{nameOfParam})cos(t))/(sin(t)-{c}cos(t)) = 2{nameOfParam} имеет хотя бы 1 решение на промежутке [0 ; 0,5π].";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: преобразовать уравнения, приведя подобные слогаемые и воспользоваться монотонностью.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    double d = rnd.Next(100, 200);
                    double e = rnd.Next(-31, -10);
                    double f = double.Parse((70 + (31 + 100) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    answer = $"при {nameOfParam} = {rnd.Next(-99, 111)}.";
                    condition = $"При каком наибольшем значении параметра {nameOfParam} функция:" +
                        $"\ny = {e}sin({d}x + 0.01{nameOfParam}π) имеет максимум в точке x0 = π?";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: использовать, что максимумы функции sin(t) достигаются " +
                            $"в точках вида 0,5π + 2πn, n ∈ Z.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
            }
            return condition;
        }
        public TrigonometricEquasion(bool prompt, bool reply)
        {
            Prompt = prompt;
            Answer = reply;
        }
    }
}
