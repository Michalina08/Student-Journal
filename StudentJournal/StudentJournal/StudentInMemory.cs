﻿namespace StudentJournal
{
    public class StudentInMemory : StudentBase
    {
        private List<float> gradesMath = new List<float>();
        private List<float> gradesPolish = new List<float>();
        private List<float> gradesEnglish = new List<float>();
        private List<float> gradesIT = new List<float>();
        private List<float> gradesPhysics = new List<float>();
        public StudentInMemory(string name, string surename, string age)
            : base(name, surename, age)
        {

        }
        public override void AddGradeMath(float gradeMath)
        {
            if (gradeMath >= 1 && gradeMath <= 6)
            {
                this.gradesMath.Add(gradeMath);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
       
        public override void AddGradePolish(float gradePolish)
        {
            if (gradePolish >= 1 && gradePolish <= 6)
            {
                this.gradesPolish.Add(gradePolish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        

        public override void AddGradeEnglish(float gradeEnglish)
        {
            if (gradeEnglish >= 1 && gradeEnglish <= 6)
            {
                this.gradesEnglish.Add(gradeEnglish);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        
        public override void AddGradeIT(float gradeIT)
        {
            if (gradeIT >= 1 && gradeIT <= 6)
            {
                this.gradesIT.Add(gradeIT);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
        
        public override void AddGradePhysics(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                this.gradesIT.Add(grade);
            }
            else
            {
                throw new Exception("This grade doesn't exist. Give a rating from 1 to 6.");
            }
        }
       
        public override Statistics GetStatisticsMath()
        {
            var statisticsMath = new Statistics();

            foreach (var grade in this.gradesMath)
            {
                statisticsMath.Average += grade;
                statisticsMath.Add(grade);
            }
           
                statisticsMath.Average = statisticsMath.Average / this.gradesMath.Count;
           

            return statisticsMath;
        }
        public override Statistics GetStatisticsPolish()
        {
            var statisticsPolish = new Statistics();
            
            foreach (var grade in this.gradesPolish)
            {
                statisticsPolish.Add(grade);
                statisticsPolish.Average += grade;
            }

            statisticsPolish.Average = statisticsPolish.Average / this.gradesPolish.Count;



            return statisticsPolish;

        }
        public override Statistics GetStatisticsEnglish()
        {
            var statisticsEnglish = new Statistics();

            foreach (var grade in this.gradesEnglish)
            {
                statisticsEnglish.Add(grade);
                statisticsEnglish.Average += grade;

            }

            statisticsEnglish.Average = statisticsEnglish.Average / this.gradesEnglish.Count;

            return statisticsEnglish;

        }
        public override Statistics GetStatisticsIT()
        {
            var statisticsIT = new Statistics();

            foreach (var grade in this.gradesIT)
            {
                statisticsIT.Add(grade);
                statisticsIT.Average += grade;

            }

            statisticsIT.Average = statisticsIT.Average / this.gradesIT.Count;

            return statisticsIT;

        }
        public override Statistics GetStatisticsPhysics()
        {
            var statisticsPhysics = new Statistics();

            foreach (var grade in this.gradesPhysics)
            {
                statisticsPhysics.Add(grade);
                statisticsPhysics.Average += grade;

            }

            statisticsPhysics.Average = statisticsPhysics.Average / this.gradesPhysics.Count;

            return statisticsPhysics;

        }
    }
}