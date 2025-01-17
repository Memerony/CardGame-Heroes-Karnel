﻿using CardGame_Heroes.Kernel.Cards;
using System.Collections.Generic;

namespace CardGame_Heroes.Kernel.Components
{
    public interface ICardFieldComponent
    {
        public List<Card> Cards { get; set; }
    }
}
