using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingDiceRoller.Data
{
    public class DiceRollSetting
    {
        public int MaxValue { get; set; }

        public int NumberOfDice { get; set; }

        public int Modifier { get; set; }

        public int LastResult { get; set; }
    }
}
