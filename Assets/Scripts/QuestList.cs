using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class QuestList
{
    public static Dictionary<int, Quest> questList;

    static QuestList()
    {
        Debug.Log("Instantiating the quest list");
        questList = new Dictionary<int, Quest>();

        #region find dr brewer
        Quest brewer = new Quest();
        brewer.name = "Find Dr Brewer";
        brewer.endText = "Dang. Gruesome! Who could have done such an horrible thing...";
        brewer.questNumber = 1;
        brewer.isItemQuest = false;
        brewer.targetItems = new List<Item>();
        brewer.targetPerson = "Docteur Brewer";
        brewer.isLaterQuest = false;
        brewer.questsToCompleteBefore = new int[0];
        brewer.startOtherQuests = true;
        brewer.questsToStart = new int[3] { 2, 6, 24 };
        brewer.hasSteps = false;
        brewer.subQuests = new int[0];
        brewer.hasCondition = false;
        brewer.statToRollAgainst = "";
        brewer.isLoseCondition = false;
        #endregion
        questList.Add(1, brewer);

        #region what happened to the nurses
        Quest nurses = new Quest();
        nurses.name = "Find what happened to the nurses";
        nurses.endText = "Well. That didn't went as expected.";
        nurses.questNumber = 2;
        nurses.isItemQuest = false;
        nurses.isPersonQuest = false;
        nurses.isLaterQuest = false;
        nurses.questsToCompleteBefore = new int[0];
        nurses.startOtherQuests = false;
        nurses.questsToStart = new int[0];
        nurses.hasSteps = true;
        nurses.subQuests = new int[3] { 3, 4, 5 };
        nurses.hasCondition = false;
        nurses.statToRollAgainst = "";
        nurses.isLoseCondition = false;
        #endregion
        questList.Add(2, nurses);

        #region bobbyBirch
        Quest bobbyBirch = new Quest();
        bobbyBirch.name = "Where is Bobby Birch ?";
        bobbyBirch.endText = "I'm pretty sure this isn't an accident. Unless he sneezed like VERY hard.";
        bobbyBirch.questNumber = 3;
        bobbyBirch.isItemQuest = false;
        bobbyBirch.targetItems = new List<Item>();
        bobbyBirch.isPersonQuest = true;
 
        bobbyBirch.targetPerson = "Bobby Birch";
        bobbyBirch.isLaterQuest = false;
        bobbyBirch.questsToCompleteBefore = new int[0];
        //bobbyBirch.hasConsequence = false;
        //bobbyBirch.questsCancelled = new int[0];
        bobbyBirch.startOtherQuests = false;
        bobbyBirch.questsToStart = new int[0];
        bobbyBirch.hasSteps = false;
        bobbyBirch.subQuests = new int[0];
        bobbyBirch.hasCondition = false;
        bobbyBirch.statToRollAgainst = "";
        bobbyBirch.isLoseCondition = false;
        #endregion
        questList.Add(3, bobbyBirch);

        #region catherine ames
        Quest cathAmes = new Quest();
        cathAmes.name = "Where is Catherine Ames ?";
        cathAmes.endText = "Ho f@#!. That must have hurt.";
        cathAmes.questNumber = 4;
        cathAmes.isItemQuest = false;
        cathAmes.targetItems = new List<Item>();
        cathAmes.isPersonQuest = true;
        //cathAmes.targetPerson = new List<string>();
        cathAmes.targetPerson = "Catherine Ames";
        cathAmes.isLaterQuest = false;
        cathAmes.questsToCompleteBefore = new int[0];
        //cathAmes.hasConsequence = false;
        //cathAmes.questsCancelled = new int[0];
        cathAmes.startOtherQuests = false;
        cathAmes.questsToStart = new int[0];
        cathAmes.hasSteps = false;
        cathAmes.subQuests = new int[0];
        cathAmes.hasCondition = false;
        cathAmes.statToRollAgainst = "";
        cathAmes.isLoseCondition = false;
        #endregion
        questList.Add(4, cathAmes);

        #region Charles Johnson
        Quest johnson = new Quest();
        johnson.name = "Where is Charles Johnson ?";
        johnson.endText = "That was a bad mothaf... ";
        johnson.questNumber = 5;
        johnson.isItemQuest = false;
        johnson.targetItems = new List<Item>();
        johnson.isPersonQuest = true;
        //johnson.targetPerson = new List<string>();
        johnson.targetPerson = "Charles Johnson";
        johnson.isLaterQuest = false;
        johnson.questsToCompleteBefore = new int[0];
        //johnson.hasConsequence = false;
        //johnson.questsCancelled = new int[0];
        johnson.startOtherQuests = false;
        johnson.questsToStart = new int[0];
        johnson.hasSteps = false;
        johnson.subQuests = new int[0];
        johnson.hasCondition = false;
        johnson.statToRollAgainst = "";
        johnson.isLoseCondition = false;
        #endregion
        questList.Add(5, johnson);

        #region Speak with the patients
        Quest patients = new Quest();
        patients.name = "Speak with the patients";
        patients.endText = "M'kay.... what now?";
        patients.questNumber = 6;
        patients.isItemQuest = false;
        patients.targetItems = new List<Item>();
        patients.isPersonQuest = false;
        //patients.targetPerson = new List<string>();
        patients.isLaterQuest = false;
        patients.questsToCompleteBefore = new int[0];
        //patients.hasConsequence = false;
        //patients.questsCancelled = new int[0];
        patients.startOtherQuests = false;
        patients.questsToStart = new int[0];
        patients.hasSteps = true;
        patients.subQuests = new int[7] { 7, 8, 9, 10, 11, 12, 13 };
        patients.hasCondition = false;
        patients.statToRollAgainst = "";
        patients.isLoseCondition = false;
        #endregion
        questList.Add(6, patients);

        //MADE SOME CHANGES IN THIS QUEST, 
        // Might have to invert questsToStart and SubQuests.
        #region allen harding
        Quest harding = new Quest();
        harding.name = "Speak with Harding";
        harding.endText = "That guy is nuts. But I feel like he might know some things.";
        harding.questNumber = 7;
        harding.isItemQuest = false;
        harding.targetItems = new List<Item>();
        harding.isPersonQuest = true;
        //harding.targetPerson = new List<string>();
        harding.targetPerson = "Allen Harding";
        harding.isLaterQuest = false;
        harding.questsToCompleteBefore = new int[0];
        //harding.hasConsequence = false;
        //harding.questsCancelled = new int[0];
        harding.startOtherQuests = true;
        harding.questsToStart = new int[1] { 16 };
        harding.hasSteps = false;
        harding.subQuests = new int[0];
        harding.hasCondition = false;
        harding.statToRollAgainst = "";
        harding.isLoseCondition = false;
        #endregion
        questList.Add(7, harding);

        #region henry adam barber
        Quest barber = new Quest();
        barber.name = "Speak with barber";
        barber.endText = "What. A. Douche.";
        barber.questNumber = 8;
        barber.isItemQuest = false;
        barber.targetItems = new List<Item>();
        barber.isPersonQuest = true;
        //barber.targetPerson = new List<string>();
        barber.targetPerson = "Henry Adam Barber III";
        barber.isLaterQuest = false;
        barber.questsToCompleteBefore = new int[0];
        //barber.hasConsequence = false;
        //barber.questsCancelled = new int[0];
        barber.startOtherQuests = false;
        barber.questsToStart = new int[0];
        barber.hasSteps = false;
        barber.subQuests = new int[0];
        barber.hasCondition = false;
        barber.statToRollAgainst = "";
        barber.isLoseCondition = false;
        #endregion  
        questList.Add(8, barber);

        #region Colonel Crandall Billing
        Quest colonel = new Quest();
        colonel.name = "Speak with the colonel";
        colonel.endText = "I feel so tired. This was the biggest loss of time EVER.";
        colonel.questNumber = 9;
        colonel.isItemQuest = false;
        colonel.targetItems = new List<Item>();
        colonel.isPersonQuest = true;
        //colonel.targetPerson = new List<string>();
        colonel.targetPerson = "Colonel Crandall Billings";
        colonel.isLaterQuest = false;
        colonel.questsToCompleteBefore = new int[0];
        //colonel.hasConsequence = false;
        //colonel.questsCancelled = new int[0];
        colonel.startOtherQuests = false;
        colonel.questsToStart = new int[0];
        colonel.hasSteps = false;
        colonel.subQuests = new int[0];
        colonel.hasCondition = false;
        colonel.statToRollAgainst = "";
        colonel.isLoseCondition = false;
        #endregion
        questList.Add(9, colonel);

        #region Blanche Goddard Richmond
        Quest blanche = new Quest();
        blanche.name = "Speak with Blanche Richmond";
        blanche.endText = "Obviously the sweet little lady wasn't just that. Obviously.";
        blanche.questNumber = 10;
        blanche.isItemQuest = false;
        blanche.targetItems = new List<Item>();
        blanche.isPersonQuest = true;
        //blanche.targetPerson = new List<string>();
        blanche.targetPerson = "Blanche Goddard Richmond";
        blanche.isLaterQuest = false;
        blanche.questsToCompleteBefore = new int[0];
        //blanche.hasConsequence = false;
        //blanche.questsCancelled = new int[0];
        blanche.startOtherQuests = false;
        blanche.questsToStart = new int[0];
        blanche.hasSteps = false;
        blanche.subQuests = new int[0];
        blanche.hasCondition = false;
        blanche.statToRollAgainst = "";
        blanche.isLoseCondition = false;
        #endregion
        questList.Add(10, blanche);

        #region cecil carla randolph
        Quest cecil = new Quest();
        cecil.name = "Speak with Cecil (Carla) Randolph";
        cecil.endText = "Guess I know why the bar is empty now.";
        cecil.questNumber = 11;
        cecil.isItemQuest = false;
        cecil.targetItems = new List<Item>();
        cecil.isPersonQuest = true;
        //cecil.targetPerson = new List<string>();
        cecil.targetPerson = "Cecil Carla Randolph";
        cecil.isLaterQuest = false;
        cecil.questsToCompleteBefore = new int[0];
        //cecil.hasConsequence = false;
        //cecil.questsCancelled = new int[0];
        cecil.startOtherQuests = false;
        cecil.questsToStart = new int[0];
        cecil.hasSteps = false;
        cecil.subQuests = new int[0];
        cecil.hasCondition = false;
        cecil.statToRollAgainst = "";
        cecil.isLoseCondition = false;
        #endregion
        questList.Add(11, cecil);

        #region Leonard Hawkins
        Quest hawkins = new Quest();
        hawkins.name = "Speak with Leonard Hawkins";
        hawkins.endText = "Is it okay if I hit him?";
        hawkins.questNumber = 12;
        hawkins.isItemQuest = false;
        hawkins.targetItems = new List<Item>();
        hawkins.isPersonQuest = true;
        //hawkins.targetPerson = new List<string>();
        hawkins.targetPerson = "Leonard Hawkins";
        hawkins.isLaterQuest = false;
        hawkins.questsToCompleteBefore = new int[0];
        //hawkins.hasConsequence = false;
        //hawkins.questsCancelled = new int[0];
        hawkins.startOtherQuests = false;
        hawkins.questsToStart = new int[0];
        hawkins.hasSteps = false;
        hawkins.subQuests = new int[0];
        hawkins.hasCondition = false;
        hawkins.statToRollAgainst = "";
        hawkins.isLoseCondition = false;
        #endregion
        questList.Add(12, hawkins);

        #region Darlene
        Quest darlene = new Quest();
        darlene.name = "Find Darlene";
        darlene.endText = "Amazing.";
        darlene.questNumber = 13;
        darlene.isItemQuest = false;
        darlene.targetItems = new List<Item>();
        darlene.isPersonQuest = true;
        //darlene.targetPerson = new List<string>();
        darlene.targetPerson = "Darlene";
        darlene.isLaterQuest = false;
        darlene.questsToCompleteBefore = new int[0];
        //darlene.hasConsequence = false;
        //darlene.questsCancelled = new int[0];
        darlene.startOtherQuests = true;
        darlene.questsToStart = new int[1] { 20 };
        darlene.hasSteps = false;
        darlene.subQuests = new int[0];
        darlene.hasCondition = false;
        darlene.statToRollAgainst = "";
        darlene.isLoseCondition = false;
        #endregion  
        questList.Add(13, darlene);

        //TODO : 14,15 quests to start find and kill beast
        #region The Creature
        Quest findBeast = new Quest();
        findBeast.name = "Find the Creature";
        findBeast.endText = "WHAT THE FUCKING FUCKITY FUCK IS THAT ? HO MY FUCKING GOD!";
        findBeast.questNumber = 14;
        findBeast.isItemQuest = false;
        findBeast.targetItems = new List<Item>();
        findBeast.isPersonQuest = true;
        //findBeast.targetPerson = new List<string>();
        findBeast.targetPerson = "The Unspeakable Creature";
        findBeast.isLaterQuest = false;
        findBeast.questsToCompleteBefore = new int[0];
        //findBeast.hasConsequence = false;
        //findBeast.questsCancelled = new int[0];
        findBeast.startOtherQuests = false;
        findBeast.questsToStart = new int[0];
        findBeast.hasSteps = false;
        findBeast.subQuests = new int[0];
        findBeast.hasCondition = true;
        findBeast.statToRollAgainst = "sanity";
        findBeast.isLoseCondition = true;

        questList.Add(14, findBeast);

        Quest killBeast = new Quest();
        killBeast.name = "Kill the Creature";
        killBeast.endText = "DIE! DIE WHATEVER YOU ARE! DIIIIIIIIIIIIE! AND DON'T KILL ME!";
        killBeast.questNumber = 15;
        killBeast.isItemQuest = false;
        killBeast.targetItems = new List<Item>();
        killBeast.isPersonQuest = false;
        //killBeast.targetPerson = new List<string>();
        killBeast.isLaterQuest = true;
        killBeast.questsToCompleteBefore = new int[1] { 14 };
        //killBeast.hasConsequence = false;
        //killBeast.questsCancelled = new int[0];
        killBeast.startOtherQuests = false;
        killBeast.questsToStart = new int[0];
        killBeast.hasSteps = false;
        killBeast.subQuests = new int[0];
        killBeast.hasCondition = true;
        killBeast.statToRollAgainst = "sanity";
        killBeast.isLoseCondition = true;

        questList.Add(15, killBeast);
        #endregion

        //todo : 16 17 18 19 sub-quests discuss with harding
        #region harding sub quests

        #region stepOne
        Quest hardingStepOne = new Quest();
        hardingStepOne.name = "Speak with Harding";
        hardingStepOne.endText = "That mad man has said something about opening a portal? ";
        hardingStepOne.questNumber = 16;
        hardingStepOne.isItemQuest = false;
        hardingStepOne.targetItems = new List<Item>();
        hardingStepOne.isPersonQuest = true;
        //hardingStepOne.targetPerson = new List<string>();
        hardingStepOne.targetPerson = "Allen Harding";
        hardingStepOne.isLaterQuest = true;
        hardingStepOne.questsToCompleteBefore = new int[1] { 7 };
        //hardingStepOne.hasConsequence = false;
        //hardingStepOne.questsCancelled = new int[0];
        hardingStepOne.startOtherQuests = true;
        hardingStepOne.questsToStart = new int[1] { 17 };
        hardingStepOne.hasSteps = false;
        hardingStepOne.subQuests = new int[0];
        hardingStepOne.hasCondition = true;
        hardingStepOne.statToRollAgainst = "psychology";
        hardingStepOne.isLoseCondition = false;
        #endregion
        questList.Add(16, hardingStepOne);

        #region stepTwo
        Quest hardingStepTwo = new Quest();
        hardingStepTwo.name = "Speak with Harding... again";
        hardingStepTwo.endText = "So Johnson went mad and killed everyone. I had figured that myself, honestly.";
        hardingStepTwo.questNumber = 17;
        hardingStepTwo.isItemQuest = false;
        hardingStepTwo.targetItems = new List<Item>();
        hardingStepTwo.isPersonQuest = true;
        //hardingStepTwo.targetPerson = new List<string>();
        hardingStepTwo.targetPerson = "Allen Harding";
        hardingStepTwo.isLaterQuest = true;
        hardingStepTwo.questsToCompleteBefore = new int[1] { 16 };
        //hardingStepTwo.hasConsequence = false;
        //hardingStepTwo.questsCancelled = new int[0];
        hardingStepTwo.startOtherQuests = true;
        hardingStepTwo.questsToStart = new int[1] { 18 };
        hardingStepTwo.hasSteps = false;
        hardingStepTwo.subQuests = new int[0];
        hardingStepTwo.hasCondition = true;
        hardingStepTwo.statToRollAgainst = "psychology";
        hardingStepTwo.isLoseCondition = false;
        #endregion
        questList.Add(17, hardingStepTwo);

        #region stepThree
        Quest hardingStepThree = new Quest();
        hardingStepThree.name = "Speak with Harding...who knows?";
        hardingStepThree.endText = "Didn't I read he was a drug abuser before?";
        hardingStepThree.questNumber = 18;
        hardingStepThree.isItemQuest = false;
        hardingStepThree.targetItems = new List<Item>();
        hardingStepThree.isPersonQuest = true;
        //hardingStepThree.targetPerson = new List<string>();
        hardingStepThree.targetPerson = "Allen Harding";
        hardingStepThree.isLaterQuest = true;
        hardingStepThree.questsToCompleteBefore = new int[1] { 17 };
        //hardingStepThree.hasConsequence = false;
        //hardingStepThree.questsCancelled = new int[0];
        hardingStepThree.startOtherQuests = true;
        hardingStepThree.questsToStart = new int[1] { 19 };
        hardingStepThree.hasSteps = false;
        hardingStepThree.subQuests = new int[0];
        hardingStepThree.hasCondition = true;
        hardingStepThree.statToRollAgainst = "psychology";
        hardingStepThree.isLoseCondition = false;
        #endregion
        questList.Add(18, hardingStepThree);

        #region stepFour
        Quest hardingStepFour = new Quest();
        hardingStepFour.name = "Speak with Harding...a last time?";
        hardingStepFour.endText = "That guy is definitely mad. There's NO WAY I believe his story about a giant interstellar slug coming out of the wall of his cell to feed on our souls.";
        hardingStepFour.questNumber = 19;
        hardingStepFour.isItemQuest = false;
        hardingStepFour.targetItems = new List<Item>();
        hardingStepFour.isPersonQuest = true;
        //hardingStepFour.targetPerson = new List<string>();
        hardingStepFour.targetPerson = "Allen Harding";
        hardingStepFour.isLaterQuest = true;
        hardingStepFour.questsToCompleteBefore = new int[1] { 18 };
        //hardingStepFour.hasConsequence = false;
        //hardingStepFour.questsCancelled = new int[0];
        hardingStepFour.startOtherQuests = true;
        hardingStepFour.questsToStart = new int[1] { 14 };
        hardingStepFour.hasSteps = false;
        hardingStepFour.subQuests = new int[0];
        hardingStepFour.hasCondition = true;
        hardingStepFour.statToRollAgainst = "psychology";
        hardingStepFour.isLoseCondition = false;
        #endregion
        questList.Add(19, hardingStepFour);
        #endregion

        //todo : 20->23 subquests discuss with Darlene
        #region darlene sub quests

        #region step one : darlene herself
        Quest darleneStepOne = new Quest();
        darleneStepOne.name = "Speak with Darlene";
        darleneStepOne.endText = "Well, that was useless.";
        darleneStepOne.questNumber = 20;
        darleneStepOne.isItemQuest = false;
        darleneStepOne.targetItems = new List<Item>();
        darleneStepOne.isPersonQuest = true;
        //darleneStepOne.targetPerson = new List<string>();
        darleneStepOne.targetPerson = "Darlene";
        darleneStepOne.isLaterQuest = false;
        darleneStepOne.questsToCompleteBefore = new int[1] { 13 };
        //darleneStepOne.hasConsequence = false;
        //darleneStepOne.questsCancelled = new int[0];
        darleneStepOne.startOtherQuests = true;
        darleneStepOne.questsToStart = new int[1] { 21 };
        darleneStepOne.hasSteps = false;
        darleneStepOne.subQuests = new int[0];
        darleneStepOne.hasCondition = true;
        darleneStepOne.statToRollAgainst = "psychology";
        darleneStepOne.isLoseCondition = false;
        #endregion
        questList.Add(20, darleneStepOne);

        #region step two : wait, she has multiple personalities?
        Quest darleneStepTwo = new Quest();
        darleneStepTwo.name = "Speak with Darlene...or whatever her name is.";
        darleneStepTwo.endText = "So she has multiple personalities... interesting! But is it useful?";
        darleneStepTwo.questNumber = 21;
        darleneStepTwo.isItemQuest = false;
        darleneStepTwo.targetItems = new List<Item>();
        darleneStepTwo.isPersonQuest = true;
        //darleneStepTwo.targetPerson = new List<string>();
        darleneStepTwo.targetPerson = "Darlene";
        darleneStepTwo.isLaterQuest = true;
        darleneStepTwo.questsToCompleteBefore = new int[1] { 20 };
        //darleneStepTwo.hasConsequence = false;
        //darleneStepTwo.questsCancelled = new int[0];
        darleneStepTwo.startOtherQuests = true;
        darleneStepTwo.questsToStart = new int[2] { 22, 27 };
        darleneStepTwo.hasSteps = false;
        darleneStepTwo.subQuests = new int[0];
        darleneStepTwo.hasCondition = true;
        darleneStepTwo.statToRollAgainst = "hypnosis";
        darleneStepTwo.isLoseCondition = false;
        #endregion
        questList.Add(21, darleneStepTwo);

        #region step three : Annephis
        Quest darleneStepThree = new Quest();
        darleneStepThree.name = "Speak with Annephis";
        darleneStepThree.endText = "Who would have guessed this mysterious lady was an egyptian princess!";
        darleneStepThree.questNumber = 22;
        darleneStepThree.isItemQuest = false;
        darleneStepThree.targetItems = new List<Item>();
        darleneStepThree.isPersonQuest = true;
        //darleneStepThree.targetPerson = new List<string>();
        darleneStepThree.targetPerson = "Annephis, Princess of Bastet";
        darleneStepThree.isLaterQuest = true;
        darleneStepThree.questsToCompleteBefore = new int[1] { 21 };
        //darleneStepThree.hasConsequence = false;
        //darleneStepThree.questsCancelled = new int[0];
        darleneStepThree.startOtherQuests = true;
        darleneStepThree.questsToStart = new int[1] { 23 };
        darleneStepThree.hasSteps = false;
        darleneStepThree.subQuests = new int[0];
        darleneStepThree.hasCondition = true;
        darleneStepThree.statToRollAgainst = "education";
        darleneStepThree.isLoseCondition = false;
        #endregion
        questList.Add(22, darleneStepThree);

        #region step four : Learn the spell
        Quest darleneStepFour = new Quest();
        darleneStepFour.name = "Learn From Annephis";
        darleneStepFour.endText = "Now I know how to defeat that monstrous creature! I have to press M in front of it...";
        darleneStepFour.questNumber = 23;
        darleneStepFour.isItemQuest = false;
        darleneStepFour.targetItems = new List<Item>();
        darleneStepFour.isPersonQuest = true;
        //darleneStepFour.targetPerson = new List<string>();
        darleneStepFour.targetPerson = "Annephis, Princess of Bastet";
        darleneStepFour.isLaterQuest = true;
        darleneStepFour.questsToCompleteBefore = new int[1] { 22 };
        //darleneStepFour.hasConsequence = false;
        //darleneStepFour.questsCancelled = new int[0];
        darleneStepFour.startOtherQuests = false;
        darleneStepFour.questsToStart = new int[0];
        darleneStepFour.hasSteps = false;
        darleneStepFour.subQuests = new int[0];
        darleneStepFour.hasCondition = true;
        darleneStepFour.statToRollAgainst = "power";
        darleneStepFour.isLoseCondition = false;
        #endregion
        questList.Add(23, darleneStepFour);
        #endregion

        //todo: 24 "find dr brewer's note about darlene"
        #region brewerNote big quest
        Quest brewerNotes = new Quest();
        brewerNotes.name = "Find Dr Brewer's Note";
        brewerNotes.questNumber = 24;
        brewerNotes.isItemQuest = false;
        brewerNotes.targetItems = new List<Item>();
        brewerNotes.isPersonQuest = false;
        //brewerNotes.targetPerson = new List<string>();
        brewerNotes.isLaterQuest = true;
        brewerNotes.questsToCompleteBefore = new int[1] { 1 };
        //brewerNotes.hasConsequence = false;
        //brewerNotes.questsCancelled = new int[0];
        brewerNotes.startOtherQuests = true;
        brewerNotes.questsToStart = new int[1] { 21 };
        brewerNotes.hasSteps = true;
        brewerNotes.subQuests = new int[4] { 25, 26, 27, 28 };
        brewerNotes.hasCondition = false;
        brewerNotes.statToRollAgainst = "";
        brewerNotes.isLoseCondition = false;
        #endregion
        questList.Add(24, brewerNotes);

        #region castro manuscript (brewer note subquest)
        Quest castroManuscript = new Quest();
        castroManuscript.name = "Find the Castro Manuscript";
        castroManuscript.questNumber = 25;
        castroManuscript.isItemQuest = true;
        castroManuscript.targetItems = new List<Item>();
        castroManuscript.targetItems.Add(ItemList.existingStuff["castromanuscript"]);
        castroManuscript.isPersonQuest = false;
        castroManuscript.isLaterQuest = false;
        castroManuscript.questsToCompleteBefore = new int[0];
        //castroManuscript.hasConsequence = false;
        //castroManuscript.questsCancelled = new int[0];
        castroManuscript.startOtherQuests = false;
        castroManuscript.questsToStart = new int[0];
        castroManuscript.hasSteps = false;
        castroManuscript.subQuests = new int[0];
        castroManuscript.hasCondition = false;
        castroManuscript.statToRollAgainst = "";
        castroManuscript.isLoseCondition = false;
        #endregion
        questList.Add(25, castroManuscript);

        #region harding file (brewer note subquest)
        Quest hardingFiles = new Quest();
        hardingFiles.name = "Find Harding Files";
        hardingFiles.questNumber = 26;
        hardingFiles.isItemQuest = true;
        hardingFiles.targetItems = new List<Item>();
        hardingFiles.targetItems.Add(ItemList.existingStuff["hardingfile"]);
        hardingFiles.isPersonQuest = false;
        hardingFiles.isLaterQuest = false;
        hardingFiles.questsToCompleteBefore = new int[0];
        //hardingFiles.hasConsequence = false;
        //hardingFiles.questsCancelled = new int[0];
        hardingFiles.startOtherQuests = false;
        hardingFiles.questsToStart = new int[0];
        hardingFiles.hasSteps = false;
        hardingFiles.subQuests = new int[0];
        hardingFiles.hasCondition = false;
        hardingFiles.statToRollAgainst = "";
        hardingFiles.isLoseCondition = false;
        #endregion
        questList.Add(26, hardingFiles);

        #region darlene file (brewer note subquest)
        Quest darleneFiles = new Quest();
        darleneFiles.name = "Find Darlene Files";
        darleneFiles.endText = "I found an extract of Darlene's interview by Dr Brewer! Might be worth reading.";
        darleneFiles.questNumber = 27;
        darleneFiles.isItemQuest = true;
        darleneFiles.targetItems = new List<Item>();
        darleneFiles.targetItems.Add(ItemList.existingStuff["darlenefile"]);
        darleneFiles.isPersonQuest = false;
        darleneFiles.isLaterQuest = false;
        darleneFiles.questsToCompleteBefore = new int[0];
        //darleneFiles.hasConsequence = false;
        //darleneFiles.questsCancelled = new int[0];
        darleneFiles.startOtherQuests = true;
        darleneFiles.questsToStart = new int[1] { 22 };
        darleneFiles.hasSteps = false;
        darleneFiles.subQuests = new int[0];
        darleneFiles.hasCondition = false;
        darleneFiles.statToRollAgainst = "";
        darleneFiles.isLoseCondition = false;
        #endregion
        questList.Add(27, darleneFiles);

        #region hawkins file (brewer note subquest)
        Quest hawkinsFiles = new Quest();
        hawkinsFiles.name = "Find Hawkins Files";
        hawkinsFiles.questNumber = 28;
        hawkinsFiles.isItemQuest = true;
        hawkinsFiles.targetItems = new List<Item>();
        hawkinsFiles.targetItems.Add(ItemList.existingStuff["hawkinsfile"]);
        hawkinsFiles.isPersonQuest = false;
        hawkinsFiles.isLaterQuest = false;
        hawkinsFiles.questsToCompleteBefore = new int[0];
        //hawkinsFiles.hasConsequence = false;
        //hawkinsFiles.questsCancelled = new int[0];
        hawkinsFiles.startOtherQuests = false;
        hawkinsFiles.questsToStart = new int[0];
        hawkinsFiles.hasSteps = false;
        hawkinsFiles.subQuests = new int[0];
        hawkinsFiles.hasCondition = false;
        hawkinsFiles.statToRollAgainst = "";
        hawkinsFiles.isLoseCondition = false;
        #endregion
        questList.Add(28, hawkinsFiles);

        #region newspaper clip (useless ? commented out)
        //Quest newsPaper= new Quest();
        //newsPaper.name = "Find the newspaper";
        //newsPaper.questNumber = 29;
        //newsPaper.isItemQuest = true;
        //newsPaper.targetItems = new List<Item>();
        //newsPaper.targetItems.Add(ItemList.existingStuff2["Newspaper clipping"]);
        //newsPaper.isPersonQuest = false;
        //newsPaper.isLaterQuest = false;
        //newsPaper.questsToCompleteBefore = new int[0];
        //newsPaper.hasConsequence = false;
        //newsPaper.questsCancelled = new int[0];
        //newsPaper.startOtherQuests = false;
        //newsPaper.questsToStart = new int[0];
        //newsPaper.hasSteps = false;
        //newsPaper.subQuests = new int[0];
        //newsPaper.hasCondition = false;
        //newsPaper.statToRollAgainst = "";
        //newsPaper.isLoseCondition = false;
        #endregion 
        //questList.Add(29, newsPaper);
    }
}