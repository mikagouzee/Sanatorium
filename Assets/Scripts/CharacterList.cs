using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterList {

    public static Dictionary<int, Character> characterList;

    static CharacterList()
    {
        Debug.Log("Instantiating the character list");

        characterList = new Dictionary<int, Character>();

        Character drBrewer = new Character("Dr Brewer", false);
        characterList.Add(1, drBrewer);

        Character bobbyBirch = new Character("Bobby Birch", false);
        characterList.Add(2, bobbyBirch);

        Character cathAmes = new Character("Catherine Ames", false);
        characterList.Add(3, cathAmes);

        Character charlesJohnson = new Character("Charles Johnson", true);
        characterList.Add(4, charlesJohnson);

        Character allenHarding = new Character("Allen Harding", true);
        characterList.Add(5, allenHarding);

        Character henryBarber = new Character("Henry Adam Barber", true);
        characterList.Add(6, henryBarber);

        Character colonelBilling = new Character("Colonel Crandall Billing", true);
        characterList.Add(7, colonelBilling);

        Character blancheRichmond = new Character("Blanche Goddard Richmond", true);
        characterList.Add(8, blancheRichmond);

        Character cecilRandolph = new Character("Cecil Carla Randolph", true);
        characterList.Add(9, cecilRandolph);

        Character leonardHawkins = new Character("LeonardHawkins", true);
        characterList.Add(10, leonardHawkins);

        Character darlene = new Character("Darlene", true);
        characterList.Add(11, darlene);

    }

}
