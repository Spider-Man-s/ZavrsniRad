using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Dreamteck.Splines;
using UnityEngine.SceneManagement;
using BNG;
using System.IO;
public class GAMESCRIPT : MonoBehaviour
{
    int scene = GlobalMemory.scenario;
    private bool Night;

    int FriendsHelped = 0;

    public GameObject RemyCloud;
    public TextMeshProUGUI RemyText;
    public GameObject CharlieCloud;
    public TextMeshProUGUI CharlieText;
    public GameObject ElsaCloud;
    public TextMeshProUGUI ElsaText;

    public GameObject PlayerObjective;
    public TextMeshProUGUI PlayerObjectiveText;

    public GameObject Remy;
    public GameObject Elsa;
    public GameObject Charlie;

    private Animator RemyAnim;
    private Animator CharlieAnim;
    private Animator ElsaAnim;

    private SplineFollower CharlieSpline;
    private SplineFollower ElsaSpline;
    private SplineFollower RemySpline;

    public GameObject CharlieMission;
    public GameObject RemyMission;
    public GameObject ElsaMission;

    public GameObject CharlieMissionBTN;
    public GameObject RemyMissionBTN;
    public GameObject ElsaMissionBTN;
    public TextMeshProUGUI CharlieMissionText;
    public TextMeshProUGUI RemyMissionText;
    public TextMeshProUGUI ElsaMissionText;



    public GameObject missionItems1;
    public GameObject missionItems2;
    public GameObject missionItems3;

    private bool inMission = false;

    private int booksFound = 0;
    private int coconutsFound = 0;
    private int woodFound = 0;
    public GameObject part2;

    private float task1StartTime;
    private float task2StartTime;
    private float task3StartTime;

    private float task1FinishTime;
    private float task2FinishTime;
    private float task3FinishTime;

    private float task1Time;
    private float task2Time;
    private float task3Time;

    void WriteElapsedTime(string elapsedTime)
    {
        string filePath = "C:/Users/Win11/Desktop/FER/GitHub/ZavrsniRad/ZR/Assets/Zavrsni rad/MissionTimes/Mission_time.txt";

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
        using (StreamWriter writer = File.AppendText(filePath))
        {
            writer.WriteLine(elapsedTime);
        }
    }

    public void book()
    {
        booksFound++;
        PlayerObjectiveText.text = "Find books: " + booksFound + "/3";
        if (booksFound == 3)
        {
            PlayerObjectiveText.text = "Talk to Charlie";
        }

    }
    public void coconut()
    {
        coconutsFound++;
        PlayerObjectiveText.text = "Find coconuts: " + coconutsFound + "/4";
        if (coconutsFound == 4)
        {
            PlayerObjectiveText.text = "Talk to Elsa";
        }
    }
    public void wood()
    {
        woodFound++;
        PlayerObjectiveText.text = "Find wood: " + woodFound + "/4";
        if (woodFound == 4)
        {
            PlayerObjectiveText.text = "Talk to Remy";
        }
    }

    public void check()
    {
        if (FriendsHelped == 3)
        {
            StartCoroutine(MissionsComplete());
        }
    }


    public void Begin()
    {
        if (scene == 1)
        {
            Night = false;
        }
        else
        {
            Night = true;
        }
        WriteElapsedTime("New play\n");
        StartCoroutine(Checkpoint1());
    }


    IEnumerator Checkpoint1()
    {

        RemyAnim = Remy.GetComponent<Animator>();
        CharlieAnim = Charlie.GetComponent<Animator>();
        ElsaAnim = Elsa.GetComponent<Animator>();

        CharlieSpline = Charlie.GetComponent<SplineFollower>();
        ElsaSpline = Elsa.GetComponent<SplineFollower>();
        RemySpline = Remy.GetComponent<SplineFollower>();


        yield return new WaitForSeconds(1f);
        if (!Night)
        {
            RemyCloud.SetActive(true);
            RemyText.text = "Good morning Alex.Did you manage to get some sleep?";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            ElsaCloud.SetActive(true);
            ElsaText.text = "I don't know how anyone could sleep tonight.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "The whole plane crashed down.";
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
            CharlieCloud.SetActive(true);
            CharlieText.text = "I agree with Elsa, it was horrible.";
            yield return new WaitForSeconds(3f);
            CharlieCloud.SetActive(false);
            RemyCloud.SetActive(true);
            RemyText.text = "Well, it seems we're the only survivors left.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "We should stick together further on.";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            ElsaCloud.SetActive(true);
            ElsaText.text = "I agree, we should clear our heads and focus.";
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
            CharlieCloud.SetActive(true);
            CharlieText.text = "Yeah, let's see what we know for now.";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "So, we are in the middle of the ocean";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "on some random deserted island.";
            yield return new WaitForSeconds(3f);
            CharlieCloud.SetActive(false);
            RemyCloud.SetActive(true);
            RemyText.text = "And all our stuff was destroyed in the crash";
            yield return new WaitForSeconds(3f);
            RemyText.text = "so we can't call for help.";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            ElsaCloud.SetActive(true);
            ElsaText.text = "Only thing we can do is seek shelter in this village.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "Maybe we can find a way to survive for some time.";
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
            RemyCloud.SetActive(true);
            RemyText.text = "Elsa's right. This place is our only option";
            yield return new WaitForSeconds(3f);
            RemyText.text = "even though it gives me the creeps.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "Why would such a place be here, and who built it?";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            CharlieCloud.SetActive(true);
            CharlieText.text = "I don't know, it's bugging me as well.";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "Maybe we can find some clues inside.";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "It should be faster if we split up.";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "Each of us can then focus on one thing.";
            yield return new WaitForSeconds(3f);
            CharlieCloud.SetActive(false);
            ElsaCloud.SetActive(true);
            ElsaText.text = "I will search for food then.";
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
            RemyCloud.SetActive(true);
            RemyText.text = "Alright, I will look for shelter.";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            CharlieCloud.SetActive(true);
            CharlieText.text = "Then I will search for some clues about the place.";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "Alex, since you're the only one left,";
            yield return new WaitForSeconds(3f);
            CharlieText.text = "you can go and help each one of us.";
            yield return new WaitForSeconds(3f);
            CharlieCloud.SetActive(false);
            RemyCloud.SetActive(true);
            RemyText.text = "I'm with Charlie here. Okay, we know what to do.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "Let's group up later when we finish our tasks.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "Good luck.";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
            ElsaCloud.SetActive(true);
            CharlieCloud.SetActive(true);
            CharlieText.text = "Thanks, you too.";
            ElsaText.text = "Good luck guys.";
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
            CharlieCloud.SetActive(false);
        }


        PlayerObjective.SetActive(true);
        PlayerObjectiveText.text = "Help friends: " + FriendsHelped + "/3";
        CharlieAnim.SetTrigger("start walking");
        CharlieSpline.follow = true;
        yield return new WaitForSeconds(3f);
        RemyAnim.SetTrigger("start walking");
        RemySpline.follow = true;
        yield return new WaitForSeconds(2f);
        ElsaAnim.SetTrigger("start walking");
        ElsaSpline.follow = true;

        part2.SetActive(true);

    }

    public void Mission1()
    {
        if (!inMission)
        {
            task1StartTime = Time.time;
            StartCoroutine(Task1());
        }
        if (booksFound == 3)
        {
            StartCoroutine(Task12());
        }

    }

    IEnumerator Task1()
    {
        inMission = true;
        PlayerObjective.SetActive(false);
        missionItems1.SetActive(true);
        CharlieMission.SetActive(false);
        ElsaMissionText.text = "Help Charlie first.";
        RemyMissionText.text = "Help Charlie first.";
        PlayerObjectiveText.text = "Find books: " + booksFound + "/3";


        CharlieCloud.SetActive(true);
        CharlieText.text = "Hi Alex, I'm glad you're here.";
        yield return new WaitForSeconds(1f);
        CharlieAnim.SetTrigger("thank");
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Look what I found. See this book over there?";
        yield return new WaitForSeconds(1f);
        CharlieAnim.SetTrigger("point");
        yield return new WaitForSeconds(3f);
        CharlieText.text = "I think we can learn something useful from it.";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "However, it's incomplete. It seems there should be";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "at least 3 more books here somewhere.";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Would you please search for them?";
        CharlieAnim.SetTrigger("please");
        yield return new WaitForSeconds(3f);
        CharlieText.text = "They should be located in the other houses.";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "When you find them, please bring them inside here.";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "I will stay and examine them.";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Good luck Alex.";
        yield return new WaitForSeconds(3f);
        CharlieCloud.SetActive(false);


        PlayerObjective.SetActive(true);
        CharlieMission.SetActive(false);
        while (booksFound != 3)
        {
            yield return new WaitForSeconds(1);
        }
        CharlieMission.SetActive(true);
        CharlieMissionBTN.SetActive(false);
    }

    IEnumerator Task12()
    {
        task1FinishTime = Time.time;
        task1Time = task1FinishTime - task1StartTime;
        Debug.Log("Charlie Time: " + task1Time + " seconds");
        WriteElapsedTime("Charlie Time: " + task1Time + " seconds\n");

        FriendsHelped++;
        PlayerObjective.SetActive(false);
        CharlieMission.SetActive(false);

        CharlieCloud.SetActive(true);
        CharlieText.text = "Whoa. You found them all!";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Thank you so much Alex";
        yield return new WaitForSeconds(1f);
        CharlieAnim.SetTrigger("thank");
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Let's hope I can dig some info out";
        yield return new WaitForSeconds(3f);
        CharlieText.text = "Thanks again, see you later";
        yield return new WaitForSeconds(1f);
        CharlieAnim.SetTrigger("wawe");
        yield return new WaitForSeconds(3f);
        CharlieCloud.SetActive(false);


        PlayerObjective.SetActive(true);
        PlayerObjectiveText.text = "Help friends: " + FriendsHelped + "/3";
        inMission = false;
        ElsaMissionText.text = "Talk to Elsa.";
        RemyMissionText.text = "Talk to Remy.";

        check();
        yield return new WaitForSeconds(1f);
    }



    public void Mission2()
    {
        if (!inMission)
        {
            task2StartTime = Time.time;
            StartCoroutine(Task2());
        }
        if (woodFound == 4)
        {
            StartCoroutine(Task22());
        }

    }

    IEnumerator Task2()
    {
        inMission = true;
        PlayerObjective.SetActive(false);
        missionItems2.SetActive(true);
        RemyMission.SetActive(false);
        CharlieMissionText.text = "Help Remy first.";
        ElsaMissionText.text = "Help Remy first.";
        PlayerObjectiveText.text = "Find wood: " + woodFound + "/4";

        if (!Night)
        {
            RemyCloud.SetActive(true);
            RemyText.text = "Hey there, you feeling any better?";
            yield return new WaitForSeconds(3f);
            RemyText.text = "I hope you do. Anyways, I looked around the village.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "All the houses are in pretty good condition";
            yield return new WaitForSeconds(3f);
            RemyText.text = "so I think we're going to sleep under a roof tonight.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "The only problem we have is the cold.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "We are in the middle of the ocean,";
            yield return new WaitForSeconds(3f);
            RemyText.text = "so it's freezing at night.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "Luckily, we have these furnaces over here.";
            yield return new WaitForSeconds(1f);
            RemyAnim.SetTrigger("point");
            yield return new WaitForSeconds(3f);
            RemyText.text = "We only need some fuel, like wood.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "Do you mind looking for some while I try";
            yield return new WaitForSeconds(3f);
            RemyText.text = "to figure out how these work?";
            yield return new WaitForSeconds(3f);
            RemyText.text = "If you find wood bring it in the hut over there.";
            yield return new WaitForSeconds(1f);
            RemyAnim.SetTrigger("pointLeft");
            yield return new WaitForSeconds(3f);
            RemyText.text = "We should keep it dry in case it rains.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "You should find some wood laying around the houses.";
            yield return new WaitForSeconds(3f);
            RemyText.text = "See you later and good luck.";
            yield return new WaitForSeconds(3f);
            RemyCloud.SetActive(false);
        }

        PlayerObjective.SetActive(true);
        RemyMission.SetActive(false);

        while (woodFound != 4)
        {
            yield return new WaitForSeconds(1);
        }

        RemyMission.SetActive(true);
        RemyMissionBTN.SetActive(false);
    }


    IEnumerator Task22()
    {
        task2FinishTime = Time.time;
        task2Time = task2FinishTime - task2StartTime;
        Debug.Log("Remy Time: " + task2Time + " seconds");
        WriteElapsedTime("Remy Time: " + task2Time + " seconds\n");

        FriendsHelped++;
        PlayerObjective.SetActive(false);
        RemyMission.SetActive(false);

        RemyCloud.SetActive(true);
        RemyText.text = "Nice work there!";
        yield return new WaitForSeconds(3f);
        RemyText.text = "Thank you Alex.";
        yield return new WaitForSeconds(1f);
        RemyAnim.SetTrigger("thank");
        yield return new WaitForSeconds(3f);
        RemyText.text = "Thanks to you we aren't going to freeze tonight.";
        yield return new WaitForSeconds(3f);
        RemyText.text = "Anyways, I'm going to get to work now, see you!";
        yield return new WaitForSeconds(1f);
        RemyAnim.SetTrigger("wawe");
        yield return new WaitForSeconds(3f);
        RemyCloud.SetActive(false);

        PlayerObjective.SetActive(true);
        PlayerObjectiveText.text = "Help friends: " + FriendsHelped + "/3";
        CharlieMissionText.text = "Talk to Charlie";
        ElsaMissionText.text = "Talk to Elsa";
        inMission = false;
        check();
        yield return new WaitForSeconds(1f);
    }


    public void Mission3()
    {
        if (!inMission)
        {
            task3StartTime = Time.time;
            StartCoroutine(Task3());
        }
        if (coconutsFound == 4)
        {
            StartCoroutine(Task32());
        }
    }

    IEnumerator Task3()
    {
        inMission = true;
        PlayerObjective.SetActive(false);
        missionItems3.SetActive(true);
        ElsaMission.SetActive(false);
        CharlieMissionText.text = "Help Elsa first.";
        RemyMissionText.text = "Help Elsa first.";
        PlayerObjectiveText.text = "Find coconuts: " + coconutsFound + "/4";

        if (!Night)
        {
            ElsaCloud.SetActive(true);
            ElsaText.text = "Hi Alex, mind giving me a hand?";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "You see, I found this house that looks like a kitchen.";
            yield return new WaitForSeconds(1f);
            ElsaAnim.SetTrigger("point");
            yield return new WaitForSeconds(3f);
            ElsaText.text = "I found some food, but there isn't any water or drinks.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "I don't know how the people before us lived here,";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "maybe they took water from ocean and proccesed it.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "Since we're new here, we need to find some alternative,";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "until we find a way to extract drinkable water.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "I see some palms around, so maybe we can find some coconuts.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "We can then extract coconut water from them.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "It should cover our needs for a while.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "While I was searching through this kitchen, I found this hammer.";
            yield return new WaitForSeconds(1f);
            ElsaAnim.SetTrigger("pointLeft");
            yield return new WaitForSeconds(3f);
            ElsaText.text = "I think they used it for opening coconuts.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "However, we can use it to break down these boxes that are around.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "By \"we\" I mean you Alex. I know you can do it.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "Search the boxes and bring coconuts inside on the shelf.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "But carefull, not all the boxes contain coconuts.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "I'm going to try to make us some lunch in the meantime.";
            yield return new WaitForSeconds(3f);
            ElsaText.text = "Good luck.";
            ElsaAnim.SetTrigger("salute");
            yield return new WaitForSeconds(3f);
            ElsaCloud.SetActive(false);
        }

        PlayerObjective.SetActive(true);
        ElsaMission.SetActive(false);
        while (coconutsFound != 4)
        {
            yield return new WaitForSeconds(1);
        }
        ElsaMission.SetActive(true);
        ElsaMissionBTN.SetActive(false);
    }

    IEnumerator Task32()
    {
        task3FinishTime = Time.time;
        task3Time = task3FinishTime - task3StartTime;
        Debug.Log("Elsa Time: " + task3Time + " seconds");
        WriteElapsedTime("Elsa Time: " + task3Time + " seconds\n");
        FriendsHelped++;
        PlayerObjective.SetActive(false);
        ElsaMission.SetActive(false);

        ElsaCloud.SetActive(true);
        ElsaText.text = "Good job!";
        yield return new WaitForSeconds(3f);

        ElsaText.text = "I knew you could do it.";
        yield return new WaitForSeconds(1f);
        ElsaAnim.SetTrigger("clap");
        yield return new WaitForSeconds(3f);
        ElsaText.text = "Now we don't have to worry about food and water for a while.";
        yield return new WaitForSeconds(3f);
        ElsaText.text = "And the other good news, lunch is almost ready!";
        yield return new WaitForSeconds(3f);
        ElsaText.text = "Hope you're hungry! But first let me finish it.";
        yield return new WaitForSeconds(3f);
        ElsaText.text = "I'm gonna call you when it's ready. See you later.";
        yield return new WaitForSeconds(1f);
        ElsaAnim.SetTrigger("wawe");
        yield return new WaitForSeconds(3f);
        ElsaCloud.SetActive(false);

        PlayerObjective.SetActive(true);
        PlayerObjectiveText.text = "Help friends: " + FriendsHelped + "/3";
        CharlieMissionText.text = "Talk to Charlie";
        RemyMissionText.text = "Talk to Remy";
        inMission = false;
        check();
        yield return new WaitForSeconds(1f);
    }

    ScreenFader sf;
    IEnumerator MissionsComplete()
    {
        PlayerObjectiveText.text = "Congratulations!";
        yield return new WaitForSeconds(3f);
        if (sf == null)
        {
            sf = FindObjectOfType<ScreenFader>();
            if (sf != null)
            {
                sf.DoFadeIn();
            }
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu 1", LoadSceneMode.Single);
    }


}
