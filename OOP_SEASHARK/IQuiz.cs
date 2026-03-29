using System;

namespace OOP_GroupProject
{
    public interface IQuiz
    {
        string GetCategory();
        string GetQuestion(int index);
        string[] GetOptions(int index);
        bool CheckAns(int questionIndex, int answerIndex);
        string GetHint(int questionIndex);
        int TotalQuestions();
        void UpdateScore();
        int GetScore();
    }
}
