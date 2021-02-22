using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSAssignment4
{
    [Serializable]
    public class SavingSchedule
    {
        private string accountUsername;
        private string totalIncome;
        private string fixedCost;
        private string variableCost;
        private string savingGoal;
        private string savingDuration;

        public string AccountUsername
        {
            get => accountUsername;
            set => accountUsername = value;
        }

        public string TotalIncome
        {
            get => totalIncome;
            set => totalIncome = value;
        }
        
        public string FixedCost
        {
            get => fixedCost;
            set => fixedCost = value;
        }

        public string VariableCost
        {
            get => variableCost;
            set => variableCost = value;
        }

        public string SavingGoal
        {
            get => savingGoal;
            set => savingGoal = value;
        }

        public string SavingDuration
        {
            get => savingDuration;
            set => savingDuration = value;
        }

    }
}