using AcgPlaySimulator.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcgPlaySimulator.Field
{
    public class PlayingDeck
    {
        public PlayingDeck(Deck deck)
        {
            MainDeck = new List<PlayingCard>();
            foreach (var card in deck.BaseCards)
            {
                MainDeck.Add(new PlayingCard()
                {
                    CardInfo = card,
                });
            }
            LandDeck = new List<PlayingCard>();
            foreach (var card in deck.LandCards)
            {
                LandDeck.Add(new PlayingCard()
                {
                    CardInfo = card,
                });
            }

            MainDeckShuffle();
            LandDeckShuffle();

            Life = 20;
            Logs = new List<string>();
        }

        public List<PlayingCard> MainDeck { get; set; }

        public List<PlayingCard> LandDeck { get; set; }

        public List<PlayingCard> HandCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> FieldCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> LandCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> FreeCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> CemeteryCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> RemoveCards { get; set; } = new List<PlayingCard>();
        public List<PlayingCard> MovingCards { get; set; } = new List<PlayingCard>();

        public int Life { get; set; }

        public List<string> Logs { get; set; } = new List<string>();

        public void RemoveCard(PlayingCard card)
        {
            MainDeck.Remove(card);
            LandDeck.Remove(card);
            HandCards.Remove(card);
            FieldCards.Remove(card);
            LandCards.Remove(card);
            FreeCards.Remove(card);
            CemeteryCards.Remove(card);
            RemoveCards.Remove(card);
            MovingCards.Remove(card);
        }

        public void MoveCard(PlayingCard card, CardArea area)
        {
            RemoveCard(card);
            if (card.IsToken &&
                (
                    area != CardArea.Field_Token
                    && area != CardArea.Field
                    && area != CardArea.Moving
                )
              )
            {
                return;
            }

            switch (area)
            {
                case CardArea.Hand:
                    HandCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = false,
                        IsReversed = false,
                        CanTap = false,
                    }
                    );
                    break;
                case CardArea.Field:
                    FieldCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        IsReversed = false,
                        IsToken = card.IsToken,
                        CanTap = true,
                    }
                    );
                    break;
                case CardArea.Field_Token:
                    FieldCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        IsReversed = false,
                        IsToken = true,
                        CanTap = true,
                    }
                    );
                    break;
                case CardArea.Land:
                    LandCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        CanTap = true,
                    });
                    break;
                case CardArea.FreeOpen:
                    FreeCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        CanTap = false,
                    });
                    break;
                case CardArea.FreeClose:
                    FreeCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = false,
                        CanTap = false,
                    });
                    break;
                case CardArea.Cemetery:
                    CemeteryCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        IsReversed = false,
                        CanTap = false,
                    }
                    );
                    break;
                case CardArea.Remove:
                    RemoveCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = true,
                        IsReversed = false,
                        CanTap = false,
                    }
                    );
                    break;
                case CardArea.Moving:
                    MovingCards.Add(
                    new PlayingCard()
                    {
                        CardInfo = card.CardInfo,
                        IsMoved = false,
                        IsOpen = false,
                        IsReversed = false,
                        IsToken = card.IsToken,
                        CanTap = false,
                    }
                    );
                    break;
            }
        }

        public void MainDeckShuffle()
        {
            MainDeck = MainDeck.OrderBy(x => Guid.NewGuid()).ToList();
            AddLog("メインデッキをシャッフルしました");
        }

        public void LandDeckShuffle()
        {
            LandDeck = LandDeck.OrderBy(x => Guid.NewGuid()).ToList();
            AddLog("領地デッキをシャッフルしました");
        }

        public void MainDeckSort()
        {
            MainDeck = MainDeck.OrderBy(x => x.CardInfo.Id).ToList();
        }

        public void CemeterySort()
        {
            CemeteryCards = CemeteryCards.OrderBy(x => x.CardInfo.Id).ToList();
        }

        public void Wake()
        {
            foreach(var card in FieldCards)
            {
                card.IsMoved = false;
                card.IsReversed = false;
            }
            foreach (var card in LandCards)
            {
                card.IsMoved = false;
                card.IsReversed = false;
            }
        }

        public void AddLog(string log)
        {
            Logs.Add(log);
            if (3 < Logs.Count)
            {
                Logs.RemoveAt(0);
            }
        }

        internal void Reset()
        {
            foreach(var card in
                HandCards
                .Concat(FieldCards)
                .Concat(LandCards)
                .Concat(FreeCards)
                .Concat(CemeteryCards)
                .Concat(RemoveCards)
                .Concat(MovingCards))
            {
                if (card.IsToken)
                {
                    continue;
                }

                if(card.CardInfo is BaseDeckCard)
                {
                    MainDeck.Add(card);
                }
                else
                {
                    LandDeck.Add(card);
                }
            }

            HandCards.Clear();
            FieldCards.Clear();
            LandCards.Clear();
            FreeCards.Clear();
            CemeteryCards.Clear();
            RemoveCards.Clear();
            MovingCards.Clear();
        }
    }

    public enum CardArea
    {
        Hand,
        Field,
        Field_Token,
        Land,
        FreeOpen,
        FreeClose,
        Cemetery,
        Remove,
        Moving,
    }

    public class PlayingCard
    {
        public CardBase CardInfo { get; set; } = new CardBase();
        public bool IsOpen { get; set; } = true;
        public bool IsReversed { get; set; }
        public bool IsMoved {  get; set; }
        public bool CanTap { get; set; }
        public bool IsToken { get; set; }
        public List<KeyValuePair<string, int>> Counters { get; set; } = new List<KeyValuePair<string, int>>();
    }
}
