using System;

namespace ParameterGeneratorLibrary
{
    public class ModuleEquasion
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
            int a = rnd.Next(-15, 18);
            int b = rnd.Next(-31, -10);
            int c = rnd.Next(10, 133);
            switch (choose)
            {
                case 1:
                    int point = rnd.Next(1, 4);
                    if (point == 1)
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , {b}) U " + "{eln(" + $"{a}" + ")}";
                        condition = $"Определите, при каких занчениях параметра {nameOfParam}, уравнение:" +
                            $"\n|x-2| = {nameOfParam}log₂|x-{c}|имеет ровно 2 решения.";
                    }
                    else if (point == 2)
                    {
                        answer = $"при {nameOfParam} ∈ (-∞ , {b}) U " + "{eln(" + $"{a}" + ")} U " + $"({c} , +∞)";
                        condition = $"Определите, при каких занчениях параметра {nameOfParam}, уравнение:" +
                            $"\n|x-2| - {-b}|{a}x+7| = 3{nameOfParam}log₂|x-{c}|-1 имеет хотя бы 2 решения.";
                    }
                    else
                    {
                        {
                            answer = $"при {nameOfParam} ∈ (-∞ , {b}) U " + $"({c} , +∞)";
                            condition = $"Определите, при каких занчениях параметра {nameOfParam}, уравнение:" +
                                $"\n|x-2| - |{a}x-14| = {nameOfParam}log₂|x-{c}|+5 имеет хотя бы 2 решения.";
                        }
                    }
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуется сделать замену |x-2| на t и построить грфик" +
                            $" левой и правой частей уравенний в осях Оyt в зависимости от значений параметра.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    answer = $"при {nameOfParam} ∈ ({double.Parse((-10 + (-10 + 28) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 4)}"))} , " +
                        $"{rnd.Next(50, 75)}) U ({rnd.Next(90, 100)} , +∞).";
                    condition = $"Найдите все занчения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n|x - {nameOfParam}² + {nameOfParam} + {c}| + |x - {nameOfParam}² + {nameOfParam} + {-b}{nameOfParam} - 1| = " +
                        $"{c}{nameOfParam}-3 имеет корни, не принадлежащие интервалу ({rnd.Next(-10, 25)} , {rnd.Next(25, 50)}.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуетсЯ сделать замену m = x - {nameOfParam}² " +
                            $"+ {-b}{nameOfParam} - 1 и n = x - {nameOfParam}² + {nameOfParam} + {c} и понять, что означает получившееся условие.";
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
            int choose = rnd.Next(1, 3);
            string condition = string.Empty;
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            switch (choose)
            {
                case 1:
                    int b = rnd.Next(1, 23);
                    double a = double.Parse((-5 + (-5 + 7) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"));
                    answer = $"при {nameOfParam} ∈ ({double.Parse((-1 + (-1 + 3) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"))} , " +
                        $"{rnd.Next(5, 15)}).";
                    condition = $"Найдите все значения {nameOfParam}, при каждом из которых уравнение:" +
                        $"\n|{a} / (x + {rnd.Next(1,7)}) - {rnd.Next(1,70)}| = {nameOfParam}x + {nameOfParam} - {b} имеет больше" +
                        $" {rnd.Next(2,4)} корней в промежутке ({rnd.Next(-15,-5)} , +∞).";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: построить график функции и посмотреть зависимость семейства" +
                            $" полученных прямых от значений параметра.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    double c = rnd.Next(-50, 50);
                    answer = $"при {nameOfParam} = {rnd.Next(1,3)} , {rnd.Next(5, 7) + 0.5} , {rnd.Next(8, 19)}.";
                    condition = $"Найдте все значения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n{c}x² - {rnd.Next(1,30)}x = 2|x - {rnd.Next(1,3)}{nameOfParam}| - {rnd.Next(1,30)} имеет ровно 3 различных решения.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: переписать уранение в виде |...| = (x - ...)² " +
                            $"и рассмотреть количество точек пересечения графика модуля модуля с параболой.";
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
                    double c = double.Parse((70 + (31 + 100) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 5)}"));
                    int a = rnd.Next(1, 30);
                    answer = $"при {nameOfParam} ∈ [0 , {rnd.Next(1,50)}) U [{c} , +∞).";
                    condition = $"При каких значениях параметра {nameOfParam} уравнение:" +
                        $"\n|x² - {a}x - {rnd.Next(1,8)} - {a}{nameOfParam} = |x - {nameOfParam}| - {rnd.Next(1,9)} имеет ровно 3 корня?";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: преобразовать уравнения, построить графики левой и правой частей" +
                            $" и тщательно отследить движение вершин графиков модулей.";
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
                    answer = $"при {nameOfParam} ∈ ({rnd.Next(-17, -2)} , {rnd.Next(-2, 3)}) U " + "{0,5(√(13) - " + $"{f})" + "}.";
                    condition = $"Найдите все значения параметра {nameOfParam}, при каждом из которых уравнение:" +
                        $"\n{nameOfParam}({nameOfParam} + {d}) - {nameOfParam}|{-e}x - 4| = ({rnd.Next(5,12)}x - x² - 10)|{-e}x - 4| - " +
                        $" {rnd.Next(5, 12)}x - x² - 10({d}{nameOfParam} + 3) имеет ровно 2 корня.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: перегруппировать уравения, чтобы получились по 2 множителя, равные" +
                            $" нулю, рассмотреть 3 подходящих случая, решая системы уравнений.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
            }
            return condition;
        }
        public ModuleEquasion(bool prompt, bool reply)
        {
            Prompt = prompt;
            Answer = reply;
        }
    }
}
