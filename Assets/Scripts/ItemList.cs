using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class ItemList {

    public static Dictionary<string, Item> existingStuff;

    static ItemList()
        {
            existingStuff = new Dictionary<string, Item>();

            #region books
            Book castroManuscript = new Book("The Castro Manuscript", "looks like an old book");
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Append("[...] And it was said when 'Those Who Wait' came unto the land of pharaoh, they laid waste to the country and were not stopped until faced and destroyed by the priestess Annephis of The Temple of Bast. They moved by night, fearing Ra, and shunned also the rushing water.");
            sBuilder.Append("And the stones were made by her and, carried by the priest, they drove the creatures into the Nile, which took them to the sea, and there they were destroyed");
            sBuilder.Append("Annephis died of her injuries and, so it is said, died the secret of the Stones. She was buried in a tomb in a place which has yet to be discovered. [...]");
            castroManuscript.bookContent = sBuilder.ToString();
            existingStuff.Add("castromanuscript", castroManuscript);
            sBuilder = new StringBuilder();

            Book patientFiles = new Book("Patients Records : Allen Harding", "notes taken by dr Brewer during his consultations with Allen.");
            sBuilder.Append("About the time of publication of his first (and only) book of poetry, Harding dropped out of sight and his where-abouts for the next six months were never established.");
            sBuilder.Append("It is thought that most of this time he spent in a drug and alcohol-induced stupor, this being the condition he was found in");
            sBuilder.Append("The deteriorated condition of Harding's mind seems to make drug therapy unnecessary, if not useless. He is, however, quite susceptible to hypnosis.");
            sBuilder.Append("He has not revealed the multiple personalities of Darlene, but reverts always to the same one. This personality speaks in a deep, intelligent voice, very commanding, and quite unlike Harding's own.");
            sBuilder.Append("Sometimes the personality does not speak, but the changed face and expression of the subject belie its presence.");
            sBuilder.Append("It always seems to be observing, contemplating. When finally induced to speak it will usually prefer to not answer any questions, but simply makes statements.");
            sBuilder.Append("These statements are usually of the darkest sort, predictions of doom, and the coming of 'He Who Waits' ");
            patientFiles.bookContent = sBuilder.ToString();
            existingStuff.Add("hardingfile", patientFiles);
            sBuilder.Length = 0;

            Book patientfiles2 = new Book("Patient Records : Darlene", "Notes taken by dr Brewer during his consultations with Darlene.");
            sBuilder.Append("She was initially brought to the state home by the police who had found her wandering naked in a downtown alley");
            sBuilder.Append("Repeated attempts over the years have failed to identify her and her last name is still unknown.");
            sBuilder.Append("She is now probably in her late twenties.");
            sBuilder.Append("Traditional therapies seemed incapable of reaching her, but under hypnosis, or the influence of the compounded drugs listed below, she seemed to open up.");
            sBuilder.Append("Repeated treatment brought forth what was at first thought to be Darlene, but, under questioning, the individual claimed to be a woman named Fanny, and said she lived in Ireland.");
            sBuilder.Append("Oddly enough, she also claimed the year was 1862.");
            sBuilder.Append("Over the course of treatments, even more personalities emerged and at last count the list numbered twenty-seven; although some of these have appeared only once and were never reached again.");
            sBuilder.Append("The oldest, and perhaps most interesting personality is Annephis, who is, if she's to be believed, a princess of Egypt,who has been dead for over 3000 years.");
            sBuilder.Append("When in this personality, Darlene has exhibited a startling knowledge of Egyptian history, including a number of facts that I have been unable to verify by any amounts of research.");
            sBuilder.Append("Perhaps most mystifying was Darlen's prediction of the finding of King Tutankhamen's tomb.");
            sBuilder.Append("She made this prediction after reading in the newspaper the expedition's plan to explore the area.");
            sBuilder.Append("Much of the odd mythology that 'Annephis' speaks of brings to mind the possessions experienced by the patient Harding, and seems hinted at in the occasional ravings of Hawkins.");
            sBuilder.Append("This possibly indicates a root mythic form common to all men and would go a long way toward supporting the theory of the collective unconscious mind.");
            patientfiles2.bookContent = sBuilder.ToString();
            existingStuff.Add("darlenefile", patientfiles2);
            sBuilder.Length = 0;

            Book patientfiles3 = new Book("Patient records : Leonard Hawkins", "Notes taken by Dr Brewer during his consultations with Leonard Hawkins");
            sBuilder.Append("Leading a fairly normal and secure life until the sudden breakdown, Hawkins was unconscious for more than a week and upon awakening, displayed signs of intense paranoïa.");
            sBuilder.Append("He was unable to recognize even his wife for the first few days, although most of his memory seems to have returned over the next two months.");
            sBuilder.Append("Not long after returning to his job (an accountant with a major firm) he began displaying signs of a religious conversion and before long joined an obscure sect of ultra-conservative Baptists.");
            sBuilder.Append("His wife and children were, against their wishes, also compelled to join.");
            sBuilder.Append("Not long after, he was reprimanded by his supervisor; his continued proselytizing on the job was beginning to irritate the other employees.");
            sBuilder.Append("Two weeks later Hawkins quit his church, accusing them of stupidity and began to preach on the streets.");
            sBuilder.Append("His family was completely alienated and he soon after lost his job.");
            sBuilder.Append("He moved out of the house and several months later was arrested for arresting several police officers.");
            sBuilder.Append("A hatred of his wife, ostensibly stemming from her cmomitting him to North Island, with overt violent tendencies.");
            sBuilder.Append("He will not talk about the source of his knowledge of 'the coming of those who wait' but continues to preach his faith in his vision.");
            patientfiles3.bookContent = sBuilder.ToString();
            existingStuff.Add("hawkinsfile", patientfiles3);
            sBuilder.Length = 0;

            Book johnsonRecords = new Book("Excerpts from the personnel record of Charles Johnson", "Some fragments of Johnson's records");
            sBuilder.Append("Dear Dr Brewer");
            sBuilder.Append("I can recommend Mr Johnson whole-heartedly.");
            sBuilder.Append("His work at this institution has been exemplary and I'm sure you would find him more than satisfactory.");
            sBuilder.Append("Perhaps his own years spent in an institution developed within him a special sympathy.");
            sBuilder.Append("I have seen him handle even the most violent patients always in a way to minimize injury.");
            sBuilder.Append("Of course, I needn't mention that his size and strength also stand in his favor.");
            johnsonRecords.bookContent = sBuilder.ToString();
            existingStuff.Add("Personnel record of Charles Johnson", johnsonRecords);
            sBuilder.Length = 0;

            Book newspaperClipping = new Book("A newspaper clipping found in Brewer's office", "Some extract of a news paper");
            sBuilder.Append("CAIRO -- An unusual archaeological find was reported today by the privately funded Huntsford expediton.");
            sBuilder.Append("Operating some twenty miles west of the Valley of the Kings, the expedition has uncovered the ruins of a temple and several colossal statues.");
            sBuilder.Append("It is suspected that this find may answer a number of questions about Egyptian history.");
            sBuilder.Append("One of the first pieces uncovered was a broken stella originally raised in honor of a Princess Annephis.");
            sBuilder.Append("Unknown until now, Annephis, around 1400 bc, was apparently responsible for the routing of an enemy that then threatened the Egyptian people.");
            sBuilder.Append("The enemy is not identified on the stela, but it is speculated that perhaps they were Hyksos raiders or perhaps even the mysterious Sea Peoples mentioned in other records.");
            sBuilder.Append("Work at the site is expected to continue for at least another two years, or longer.");
            newspaperClipping.bookContent = sBuilder.ToString();
            existingStuff.Add("Newspaper clipping", newspaperClipping);
            sBuilder.Length = 0;

            Book ebenezerLetter = new Book("A letter found in Ebenezer's shed", "A letter from an old friend");
            sBuilder.Append("Dear Ebenezer,");
            sBuilder.Append("I'm leaving this letter with friends at port, and I'm sure you'll get it when you return home.");
            sBuilder.Append("I'll probably be gone by then and don't know when I'll see you so I'll wish you good luck now.");
            sBuilder.Append("In this envelope is a small present. It's a good luck charm given to me by one of those Kanakys we ran into in the islands.");
            sBuilder.Append("I don't know if it's any damn good, but I always wore it, especially anytime I was around those islands.");
            sBuilder.Append("It's been said that some of the ships that sailed out of Innsmouth had something similar attached to their bottoms.");
            sBuilder.Append("I don't know what my address will be but after I get to Cincinatty I'll write to let you know.");
            sBuilder.Append("Your friend, William");
            ebenezerLetter.bookContent = sBuilder.ToString();
            existingStuff.Add("Ebenezer Letter", ebenezerLetter);
            sBuilder.Length = 0;

        #endregion

        #region torche

        #endregion
    }
}