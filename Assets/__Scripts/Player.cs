using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum PlayerType
{
	human,
	ai
}

//the individual player of the game
//does NOT extend MonoBehaviour

[System.Serializable]
public class Player{
	public PlayerType		type = PlayerType.ai;
	public int				playerNum;

	public List<CardBartok>	hand;

	public SlotDef			handSlotDef;

	//Add card to hand
	public CardBartok AddCard(CardBartok eCB)
	{
		if (hand == null) {
			hand = new List<CardBartok>();		
		}

		hand.Add (eCB);

		return(eCB);
	}

	//Remove card from hand
	public CardBartok RemoveCard(CardBartok cb)
	{
		hand.Remove (cb);
		return(cb);
	}

}
