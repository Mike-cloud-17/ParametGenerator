using System;

namespace ParameterGeneratorLibrary
{
    public class Inequalitiy
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
                    answer = $"при {nameOfParam} = -{rnd.Next(1, 5) + 0.5} U { rnd.Next(1, 7)}.";
                    condition = $"Найдите все значения {nameOfParam}, при каждом из которых решения неравенства |{rnd.Next(1, 17)} - a| + " +
                        $"{c} ≤ |x + {rnd.Next(1, 8)}| образуют отрезок длины 1.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: необходимо перенести {c} в правую строну и построить график" +
                            $" двух модулей, по которому легко видны необходимые критерии для нужной длины отрезка.";
                    }
                    if (Answer)
                    {
                        condition += Environment.NewLine + "Ответ: " + answer;
                    }
                    break;
                default:
                    answer = $"при {nameOfParam} ∈ ({b} , {-b}) U [{rnd.Next(1, 5) + 0.25} , {rnd.Next(7, 15)}).";
                    condition = $"Найдите все значения {nameOfParam}, при каждом из которых множеством решений неравенства:" +
                        $"\n√({a}-x) + |x - {nameOfParam}| = c.";
                    if (Prompt)
                    {
                        condition += Environment.NewLine + $"Подсказка: перенести модуль в правую часть неравенства, построить эскиз графика" +
                            $" и смотреть, что будет с ним происходить при монотонном уменьшении параметра.";
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
            string condition = string.Empty;
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            double c = rnd.Next(1, 50);
            answer = $"при {nameOfParam} ∈ (-∞ , {rnd.Next(-5,7)}) U [{rnd.Next(7,24)} , +∞).";
            condition = $"При каких значениях параметра {nameOfParam} неизвестная переменная из неравенства:" +
                $"\nх({nameOfParam} – {rnd.Next(1,16)}) / ({nameOfParam} – {c}) – 2{nameOfParam} / 3 ≤ {rnd.Next(1,7)}х – {nameOfParam}, " +
                $"при {nameOfParam} ≠ {c} принимает значение [({nameOfParam} – {c})/3, +∞)?";
            if (Prompt)
            {
                condition += Environment.NewLine + $"Подсказка: преобразовать исходное неравенство, приведя подобные слагаемые и" +
                    $"домножив на необходимое для упрощения число, после чего исследовать возможные случаи для {nameOfParam}.";
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
            string nameOfParam = ((char)rnd.Next('a', 'z' + 1)).ToString();
            string answer = "";
            double c = rnd.Next(1, 50);
            answer = $"при {nameOfParam} ∈ ({rnd.Next(-5, 7)} , {rnd.Next(7, 24)}].";
            condition = $"Найти все значения параметра {nameOfParam}, при которых неравенство:" +
                $"\n{rnd.Next(-9,12)} + log₂(x² + x + {rnd.Next(1,7)}) ≥ log₂({nameOfParam}x² + {c}{nameOfParam}) имеет решение.";
            if (Prompt)
            {
                condition += Environment.NewLine + $"Подсказка: используя свойства логарифма выполнить преобразования, получив систему" +
                    $" из 2 уравнений (с учетом одз) и рассмотреть всевозможные случаи.";
            }
            if (Answer)
            {
                condition += Environment.NewLine + "Ответ: " + answer;
            }
            return condition;
        }
        public Inequalitiy(bool prompt, bool reply)
        {
            Prompt = prompt;
            Answer = reply;
        }
    }
}

