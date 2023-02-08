using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnGame
{
    public static class MyOnwGame
    {
        public static event EventHandler<GameStartedEventArgs>? GameStarted;
        public static event Action<string>? NotifyGame;
        
        private static List<Team> _teams = new List<Team>();
        private static Question[,] _questions = new Question[4, 5]
        {
            {
                new Question("Где Дмитрий Менделеев родился?", "Тобольск", Complexity.VeryEasy),
                new Question("В каком городе д.И.Менделеев начал " +
                    "свою трудовую деятельность в качестве учителя в гимназии?", "В Симферополе", Complexity.Easy),
                new Question("Из какого города Д.И.Менделеев отправился" +
                    " в полет на воздушном шаре для изучения солнечного затмения?", "Из г.Клина", Complexity.Normal),
                new Question("В 1893 году Дмитрий Иванович Менделеев по " +
                    "заказу Морского министерства начинает разработку " +
                    "бездымного пороха, пироколлодия. Для проведения " +
                    "испытаний Дмитрий Иванович выбирает именно Бондюжский" +
                    " химический завод. В каком городе находится этот завод?", "Менделеевск - город в Татарстане", Complexity.Hard),
                new Question("В каком городе с 1893г д.И.Менделеев " +
                    "был управляющим Главной палатой мер и весов?", "В г.Санкт-Петербург", Complexity.Expert),
            },
            {
                new Question("В честь какого штата был назван элемент калифорний (98)?", "Штат в США - Калифорния", Complexity.VeryEasy),
                new Question("В честь какой страны назван элемент полоний (84)", "В честь Польши", Complexity.Easy),
                new Question("В память успехов астрономии было названо много " +
                    "элементов в честь астрономических объектов. Какой элемент " +
                    "назван в честь астеройда Паллада?", "Палладий (46)", Complexity.Normal),
                new Question("Впервые этот высокорадиоактивный металл был произведен" +
                    " в США в 1952 году. Группе ученых, включая Бернарда Харви, " +
                    "Грегори Чоппена и Стэнли" +
                    " Томпсона, удалось получить его путем бомбардировки плутония. " +
                    "Элемент назвали в честь Альберта Эйнштейна. Какой это был элемент?", "Эйнштейний (99)", Complexity.Hard),
                new Question("Серебристо – белый металл. " +
                    "В природе встречается  только исключительно в виде соединений. " +
                    "По распространенности в земной коре он занимает шестое место. " +
                    "Его минералы очень разнообразны. Простое вещество ,  " +
                    "бурно реагирующее с водой.", "Натрий (11)", Complexity.Expert),
            },
            {
                new Question("Считается, что Д.И.Менделеев открыл периодический закон во сне. Это правда или легенда?", "Правда", Complexity.VeryEasy),
                new Question("На каком факультете учился Д.И.Менделеев в педагогическом институте?", "На физико –математическом", Complexity.Easy),
                new Question("Чем любил заниматься Д.И.Менделеев в свободное от науки время?", "Учёный любил переплетать книги, клеить рамки для портретов, изготавливать чемоданы", Complexity.Normal),
                new Question("Какое открытие Д.И. Менделеева при его жизни не было использовано?", "Принцип дробной перегонки при переработке нефтей", Complexity.Hard),
                new Question("Кто сказал, что Менделеев – это «воплощение глубокого ума и тонкого восприятия всей действительности»?", "А.А.Блок", Complexity.Expert),
            },
            {
                new Question("Самое известное научное достижение Менделеева", "Периодическая таблица химических элементов", Complexity.VeryEasy),
                new Question("Какому закону, по словам Д.И.Менделеева, «будущее не грозит разрушением, а только надстройка и развитие обещаются»?", "Периодическому закону", Complexity.Easy),
                new Question("Какое изобретение содействовало усилению мощи огнестрельного оружия?", "Изобретение бездымного пороха", Complexity.Normal),
                new Question("За что Д.И.Менделееву в 1862г была присуждена Демидовская премия?", "За учебник «Органическая химия»", Complexity.Hard),
                new Question("Назовите научное общество, инициатором создания и одним из организаторов которого был Д.И.Менделеев в 1868г?", "Русское химическое общество", Complexity.Expert),
            },
        };
        private static int index = 0;

        public static int TeamCount => _teams.Count;
        public static bool IsStarted { get; set; }
        public static Team CurrentTeam => _teams[index];

        public static void AddTeam(Team team) => _teams.Add(team);

        public static void StartGame()
        {
            foreach (var team in _teams)
            {
                team.Notify += Team_Notify;
            }
            GameStarted?.Invoke(index, new GameStartedEventArgs() { Teams = _teams });
            IsStarted = true;
        }

        private static void Team_Notify(object? sender, TeamDataChangedEventArgs e)
        {
            NotifyGame?.Invoke(e.Message);

        }

        public static List<Team> GetTeams() => _teams;

        public static void Next() 
        {
            if(index >= TeamCount - 1)
            {
                index = -1;
            }
            index++;
        }

        public static void ShowQuestionDialog(int categoryIndex, int complexityIndex)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.Team = _teams[index];
            questionForm.Teams = _teams;

            if (categoryIndex < 4 && complexityIndex < 5)
            {
                Question question = _questions[categoryIndex, complexityIndex];
                questionForm.Question.Text += "\n" + question.Text;
                questionForm.Answer.Text = question.Answer;
                questionForm.Complexity = (Complexity)question.Cost;
            }

            questionForm.ShowDialog();
            Next();
        }
    }  

    public class GameStartedEventArgs
    {
        public required List<Team> Teams { get; set; }
    }
}
