using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Dreamteck.Splines;

public class GAMESCRIPT : MonoBehaviour
{
    int scene = GlobalMemory.scenario;

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
    public TextMeshProUGUI CharlieMissionText;
    public TextMeshProUGUI RemyMissionText;
    public TextMeshProUGUI ElsaMissionText;

    private bool inMission = false;

    private int booksFound = 0;
    private int coconutsFound = 0;
    private int woodFound = 0;
    public GameObject part2;


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
    }
    public void wood()
    {
        woodFound++;
    }


    public void Begin()
    {
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
        /*
        RemyCloud.SetActive(true);
        Good morning Alex. Did you manage to get some sleep?
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "I don't know how anyone could sleep tonight.";
        yield return new WaitForSeconds(4f);
        ElsaText.text = "The whole plane crashed down.";
        yield return new WaitForSeconds(4f);
        ElsaCloud.SetActive(false);
        CharlieCloud.SetActive(true);
        CharlieText.text = "I agree with Elsa, it was horrible.";
        yield return new WaitForSeconds(4f);
        CharlieCloud.SetActive(false);
        RemyCloud.SetActive(true);
        RemyText.text = "Well, it seems we're the only survivors left.";
        yield return new WaitForSeconds(4f);
        RemyText.text = "We should stick together further on.";
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "I agree, we should clear our heads and focus.";
        yield return new WaitForSeconds(4f);
        ElsaCloud.SetActive(false);
        CharlieCloud.SetActive(true);
        CharlieText.text = "Yeah, let's see what we know for now.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "So, we are in the middle of the ocean";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "on some random deserted island.";
        yield return new WaitForSeconds(4f);
        CharlieCloud.SetActive(false);
        RemyCloud.SetActive(true);
        RemyText.text = "And all our stuff was destroyed in the crash";
        yield return new WaitForSeconds(4f);
        RemyText.text = "so we can't call for help.";
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "Only thing we can do is seek shelter in this village.";
        yield return new WaitForSeconds(4f);
        ElsaText.text = "Maybe we can find a way to survive for some time.";
        yield return new WaitForSeconds(4f);
        ElsaCloud.SetActive(false);
        RemyCloud.SetActive(true);
        RemyText.text = "Elsa's right. This place is our only option";
        yield return new WaitForSeconds(4f);
        RemyText.text = "even though it gives me the creeps.";
        yield return new WaitForSeconds(4f);
        RemyText.text = "Why would such a place be here, and who built it?";
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        CharlieCloud.SetActive(true);
        CharlieText.text = "I don't know, it's bugging me as well.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "Maybe we can find some clues inside.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "It should be faster if we split up.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "Each of us can then focus on one thing.";
        yield return new WaitForSeconds(4f);
        CharlieCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        ElsaText.text = "I will search for food then.";
        yield return new WaitForSeconds(4f);
        ElsaCloud.SetActive(false);
        RemyCloud.SetActive(true);
        RemyText.text = "Alright, I will look for shelter.";
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        CharlieCloud.SetActive(true);
        CharlieText.text = "Then I will search for some clues about the place.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "Alex, since you're the only one left,";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "you can go and help each one of us.";
        yield return new WaitForSeconds(4f);
        CharlieCloud.SetActive(false);
        RemyCloud.SetActive(true);
        RemyText.text = "I'm with Charlie here. Okay, we know what to do.";
        yield return new WaitForSeconds(4f);
        RemyText.text = "Let's group up later when we finish our tasks.";
        yield return new WaitForSeconds(4f);
        RemyText.text = "Good luck.";
        yield return new WaitForSeconds(4f);
        RemyCloud.SetActive(false);
        ElsaCloud.SetActive(true);
        CharlieCloud.SetActive(true);
        CharlieText.text = "Thanks, you too.";
        ElsaText.text = "Good luck guys.";
        yield return new WaitForSeconds(4f);
        ElsaCloud.SetActive(false);
        CharlieCloud.SetActive(false);
*/

        PlayerObjective.SetActive(true);
        PlayerObjectiveText.text = "Help friends: " + FriendsHelped + "/3";

        CharlieAnim.SetTrigger("start walking");
        CharlieSpline.follow = true;
        /*
         yield return new WaitForSeconds(3f);
         RemyAnim.SetTrigger("start walking");
         RemySpline.follow = true;
         yield return new WaitForSeconds(2f);
         ElsaAnim.SetTrigger("start walking");
         ElsaSpline.follow = true;
 */
        part2.SetActive(true);

    }

    public void Mission1()
    {
        if (!inMission)
        {
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
        yield return new WaitForSeconds(4f);
        CharlieText.text = "However, it's incomplete. It seems there should be";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "at least 3 more books here somewhere.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "Would you please search for them?";
        CharlieAnim.SetTrigger("please");
        yield return new WaitForSeconds(4f);
        CharlieText.text = "They should be located in the other houses.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "When you find them, please bring them inside here.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "I will stay and examine them.";
        yield return new WaitForSeconds(4f);
        CharlieText.text = "Good luck Alex.";
        yield return new WaitForSeconds(4f);
        CharlieCloud.SetActive(false);
        PlayerObjective.SetActive(true);
        CharlieMission.SetActive(false);

        while (booksFound != 3)
        {
            yield return new WaitForSeconds(1);
        }

        CharlieMission.SetActive(true);

    }

    IEnumerator Task12()
    {
        FriendsHelped++;
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
    }



    public void Mission2()
    {
        if (!inMission)
        {
            StartCoroutine(Taks2());
        }


    }

    IEnumerator Taks2()
    {
        yield return new WaitForSeconds(3f);
    }

    public void Mission3()
    {
        if (!inMission)
        {
            StartCoroutine(Task3());
        }
    }

    IEnumerator Task3()
    {
        yield return new WaitForSeconds(3f);
    }


}
