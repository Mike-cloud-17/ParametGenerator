using System;

namespace ParameterGeneratorLibrary
{
    public class Monotony
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
                    int b = rnd.Next(1, 23);
                    double d = double.Parse((-1 + (-1 + 3) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"));
                    double a = double.Parse((-5 + (-5 + 7) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"));
                    int e = rnd.Next(10, 16);
                    answer = $"при {nameOfParam} ∈ ({d} - √({e}) , {d} + √({e}).";
                    condition = $"Найдите все значения {nameOfParam}, при каждом из которых уравнение:" +
                        $"\n{nameOfParam}² + {rnd.Next(5,14)}|x - {rnd.Next(1, 7)}| + {rnd.Next(1, 5)}√(x² - 6x + 13) = " +
                        $"{rnd.Next(1,7)}{nameOfParam} + 2|x - 2{nameOfParam} - {b}| имеет хотя бы 1 корень.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рекоммендуется сделать замену переменной: t = |x - " +
                            $"{rnd.Next(1,6)}|, после чего будет необходимо разбить уравнение на 2 функции: монотонно убывающую " +
                            $"и монотонно возрастающую, а дальше рассмотреть минимальные и максимальыне значения и найти условие для параметра.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    int c = rnd.Next(1, 35);
                    int l = rnd.Next(2, 7);
                    answer = $"при {nameOfParam} = {rnd.Next(1, 3)} , {rnd.Next(5, 7) + 0.5} , {rnd.Next(8, 19)}.";
                    condition = $"Найдте все значения параметра {nameOfParam}, при каждом из котрых уравнение:" +
                        $"\n64x⁶ - ({l}x + {c}{nameOfParam}) =  ({l}x + {c}{nameOfParam})³ - 4x² имеет более 1 корня.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: переписать условие в виде функции f(t), которая будет" +
                            $" задана суммой либо разностью так, чтобы она монотонно возрастала/убывала. После чего говорим, что" +
                            $"у нас получились 2 монотонно возрастающие/уывающие функции, которые должны быть равны. Получаем квад" +
                            $"ратное уравнение и говорим, что D > 0.";
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
                    answer = $"при {nameOfParam} ∈ ({double.Parse((-1 + (-1 + 3) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 3)}"))} , " +
                        $"{rnd.Next(5, 15)}).";
                    condition = $"Найдите все значения {nameOfParam}, для каждого из которых существует хотя бы одна пара чисел x и y, " +
                        $"удовлетворяющих неравенству:" +
                        $"\n{b}|x - 2| + {rnd.Next(2,8)}|x + {nameOfParam}| ≤ √(4 - y²) + {rnd.Next(5,12)}.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: разбить неравенство на 2 функции, одна из котрых будет" +
                            $" кусочно-линейной и найти значения параметра путем подстановки различных значений в функции.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    answer = $"при {nameOfParam} ∈ [{rnd.Next(-19, -8)}, 0,5(-{rnd.Next(3,8)} + √({rnd.Next(50,64)})).";
                    condition = $"Найдите все значения параметра {nameOfParam}, при каждом из котрых неравенство:" +
                        $"\n|x² - 4x + {nameOfParam}| ≤ {rnd.Next(1, 26)} выполняется для всех х из промежутка [{nameOfParam} , {nameOfParam} + {rnd.Next(3, 8)}].";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: рассмотреть функцию f(x) = x² - 4x + {nameOfParam} и, в зависимости от мест" +
                            $", где она убывает и возрастает прикинуть ее график. После этого можно будет легко понять, в каких пределах она должна располагаться.";
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
                    double c = double.Parse((70 + (31 + 100) * rnd.NextDouble()).ToString($"F{rnd.Next(1, 2)}"));
                    int a = rnd.Next(1, 30);
                    answer = $"при {nameOfParam} ∈ ({rnd.Next(1,9)} , +∞).";
                    condition = $"При каких значениях параметра {nameOfParam} уравнение:" +
                        $"\nsin(x + {rnd.Next(1, 8)}{nameOfParam}) + sin({c}(x² - {a}x - 7{nameOfParam})) = " +
                        $"{rnd.Next(1, 9)}x - x² - {nameOfParam} не имеет дейстивтельных решений?";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: сделать замену y = {c}(x² - {a}x - 7{nameOfParam})" +
                            $", упростить полученное уравнение и заметить, что новая функция возрастает на всей числовой прямой.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    double d = rnd.Next(1, 15);
                    answer = $"при {nameOfParam} ∈ [{rnd.Next(-17, -2)} , {rnd.Next(-2, 7)}).";
                    condition = $"Найдите все значения параметра {nameOfParam}, при каждом из которых уравнение:" +
                        $"\nsin¹⁴(x) + ({nameOfParam} - {d}sin(x))⁷ + sin²(x) + {nameOfParam} = {d}sin(x) + {rnd.Next(15,97)} имеет хотя бы 1 решение.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: переписать условие в виде функции f(t), которая будет" +
                            $" задана суммой либо разностью так, чтобы она монотонно возрастала/убывала. После чего говорим, что" +
                            $"у нас получились 2 монотонно возрастающие/уывающие функции, которые должны быть равны. Получаем стандартное" +
                            $"тригонометрическое уравнение с ограничением на абсциссы/ординаты для sin и cos и решаем его.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
            }
            return condition;
        }
        public Monotony(bool prompt, bool reply)
        {
            Prompt = prompt;
            Answer = reply;
        }
    }
}

