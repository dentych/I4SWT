using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteApp
{
    public interface IBet
    {
        string PlayerName { get; }
        uint Amount { get; }

        uint WonAmount(Field f);
    }

    public abstract class Bet : IBet
    {
        private readonly string playerName;
        private readonly uint amount;

        protected Bet(string name, uint amount)
        {
            playerName = name;
            this.amount = amount;
        }

        public string PlayerName { get { return playerName; } }

        public uint Amount { get { return amount; } }

        public abstract uint WonAmount(Field f);
    }

    public class FieldBet : Bet
    {
        private uint fieldNumber;

        public FieldBet(string name, uint amount, uint fieldNumber) : base(name, amount)
        {
            this.fieldNumber = fieldNumber;
        }

        public override uint WonAmount(Field f)
        {
            if (f.Number == fieldNumber)
                return 36 * Amount;
            else
                return 0;
        }
    }

    public class ColorBet : Bet
    {
        private uint color;

        public ColorBet(string name, uint amount, uint color) : base(name, amount)
        {
            this.color = color;
        }

        public override uint WonAmount(Field f)
        {
            if (f.Color == color)
                return 2 * Amount;
            else
                return 0;
        }
    }

    public class EvenOddBet : Bet
    {
        private bool even;

        public EvenOddBet(string name, uint amount, bool even) : base(name, amount)
        {
            this.even = even;
        }

        public override uint WonAmount(Field f)
        {
            if (f.Even == even)
                return 2 * Amount;
            else
                return 0;
        }
    }
}
