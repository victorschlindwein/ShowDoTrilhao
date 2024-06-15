using ShowDoTrilhao.Core.Enums;

namespace ShowDoTrilhao.Core
{
    public class TriviaQuestions
    {
        public TriviaCategoriesEn? Category { get; set; }
        public TypeEn? Type { get; set; } 
        public DifficultyEn? Difficulty { get; set; }
        public string Question { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public List<string> IncorrectAnswers { get; set; } = [];
    }
}
