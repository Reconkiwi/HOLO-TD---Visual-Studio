using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CanvasFadeIn : MonoBehaviour
{
    public Text text;
    public bool section1Finished = false;
    public bool section2Finished = false;
    public GameObject gmobj;
    bool section2stopupdate = false;
    bool section3stopupdate = false;
    public AudioSource section2;
    public AudioSource s3;
    public AudioSource s4;
    public AudioSource s5;
    public AudioSource s6;
    public AudioSource s7;
    private void Start()
    {
        StartCoroutine(fadeText());

    }

    IEnumerator fadeText()
    {
        
        text.text = "WELCOME TO HEARTBEAT";
        yield return new WaitForSeconds(2);
        text.CrossFadeAlpha(0, 1f, false);
        text.CrossFadeAlpha(1, 1.5f, false);
        text.text = "TAP TO START";
        yield return new WaitForSeconds(1);
        text.CrossFadeAlpha(0, 1f, false);
        text.text = "OR TAP AND HOLD TO PLACE";
        text.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(1);
        text.CrossFadeAlpha(0, 1f, false);
        section1Finished = true;
    }

    IEnumerator fadeText2()
    {
        section2.Play();
        section2stopupdate = true;
        text.CrossFadeAlpha(1, 0.5f, false);
        text.text = "YOUR HEART BEATS";
        yield return new WaitForSeconds(1);
        text.CrossFadeAlpha(1, 0.75f, false);
        text.text = "TWICE PER CYCLE";
        yield return new WaitForSeconds(1.5f);
        
        text.text = "AND CONSTANTLY";
        yield return new WaitForSeconds(0.75f);
        text.text = "PUMBS BLOOD AROUND";
        yield return new WaitForSeconds(0.6f);
        text.text = "THE BODY";
        yield return new WaitForSeconds(0.75f);
        text.text = "THIS IS CALLED";
        yield return new WaitForSeconds(0.55f);
        text.text = "CIRCULATION";
        yield return new WaitForSeconds(0.86f);
        text.text = "THE HEART BLOOD AND";
        yield return new WaitForSeconds(1.2F);
        text.text = "BLOOD VESSELS";
        yield return new WaitForSeconds(0.8f);
        text.text = "TOGETHER MAKE UP YOUR";
        yield return new WaitForSeconds(1.1f);
        text.text = "CARDIOVASCULAR SYSTEM";
        yield return new WaitForSeconds(1.1f);
        text.text = "THE RIGHT SIDE OF THE HEART";
        yield return new WaitForSeconds(1f);
        text.text = "RECIEVES BLOOD THAT IS";
        yield return new WaitForSeconds(0.8f);
        text.text = "LOW IN OXYGEN";
        yield return new WaitForSeconds(0.9f);
        text.text = "BECAUSE MOST HAS BEEN USED UP";
        yield return new WaitForSeconds(1f);
        text.text = "BY THE BRAIN AND BODY";
        yield return new WaitForSeconds(1.25f);
        text.text = "IT PUMPS THIS INTO YOUR LUNGS";
        yield return new WaitForSeconds(1.5f);
        text.text = "WHERE IT PICKS UP A";
        yield return new WaitForSeconds(1.5f);
        text.text = "FRESH SUPPLY OF OXYGEN";
        yield return new WaitForSeconds(1.5f);
        text.text = "THE BLOOD THEN RETURNS TO THE";
        yield return new WaitForSeconds(1.25f);
        text.text = "LEFT SIDE OF THE HEART";
        yield return new WaitForSeconds(1.15f);
        text.text = "READY TO BE PUMPED BACK";
        yield return new WaitForSeconds(0.8f);
        text.text = "TO THE BRAIN AND THE";
        yield return new WaitForSeconds(0.8f);
        text.text = "REST OF YOUR BODY";
        text.CrossFadeAlpha(0, 2f, false);
        yield return new WaitForSeconds(4);
        text.text = "TAP TO CONTINUE";
        s3.Play();
        text.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(2);
        text.CrossFadeAlpha(0, 2f, false);
        section2Finished = true;
    }

    IEnumerator fadeText3()
    {
        s4.Play();
        section3stopupdate = true;
        text.CrossFadeAlpha(1, 2f, false);
        text.text = "DURING EXCERCISE THE MUSCLES";
        yield return new WaitForSeconds(3);
        text.CrossFadeAlpha(1, 0.75f, false);
        text.text = "REQUIRE MORE ENERGY THAN USUAL";
        yield return new WaitForSeconds(1.75f);

        text.text = "THEREFORE, THEY NEED TO";
        yield return new WaitForSeconds(1f);
        text.text = "RESPIRE MORE";
        yield return new WaitForSeconds(1.4f);
        text.text = "THIS MEANS THE CELLS REQUIRE";
        yield return new WaitForSeconds(1.2f);
        text.text = "MORE OXYGEN AND GLUCOSE TO KEEP";
        yield return new WaitForSeconds(1.6f);
        text.text = "WORKING AT THE SAME SPEED";
        yield return new WaitForSeconds(1.6f);
        text.text = "BECAUSE OF THIS EXTRA WASTE";
        yield return new WaitForSeconds(1.6F);
        text.text = "CARBON DIOXIDE";
        yield return new WaitForSeconds(0.8f);
        text.text = "IS PRODUCED";
        yield return new WaitForSeconds(1.4f);
        text.text = "WHICH CAN BE HARMFUL";
        yield return new WaitForSeconds(0.9f);
        text.text = "TO THE BODY";
        yield return new WaitForSeconds(1.7f);
        text.text = "TO MEET THE DEMANDS OF";
        yield return new WaitForSeconds(0.8f);
        text.text = "THE BODY";
        yield return new WaitForSeconds(1.1f);
        text.text = "THE HEART MUST DO TWO THINGS ";
        yield return new WaitForSeconds(1.3f);
        text.text = "FIRSTLY";
        yield return new WaitForSeconds(1.25f);
        text.text = "THE HEART MUST CONTRACT MORE";
        yield return new WaitForSeconds(1.3f);
        text.text = "WHICH INCREASES THE HEART RATE";
        yield return new WaitForSeconds(1.3f);
        text.text = "INSIDE THE BODY";
        yield return new WaitForSeconds(1.5f);
        text.text = "SECONDLY";
        yield return new WaitForSeconds(1.25f);
        text.text = "THE HEART CONTRACTS MORE";
        yield return new WaitForSeconds(0.6f);
        text.text = "POWERFULLY";
        yield return new WaitForSeconds(1f);
        text.text = "THEREFORE, THE STROKE VOLUME";
        yield return new WaitForSeconds(0.7f);
        text.text = "INCREASES";
        yield return new WaitForSeconds(0.8f);
        text.text = "WHICH PUMPS";
        yield return new WaitForSeconds(0.8f);
        text.text = "GREATER VOLUMES OF BLOOD";
        yield return new WaitForSeconds(1f);
        text.text = "AROUND THE BODY";
        text.CrossFadeAlpha(0, 2f, false);
        yield return new WaitForSeconds(4);
        s5.Play();
        text.text = "HEART ATTACKS AND";
        text.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(1.6f);
        text.text = "CARDIAC ARRESTS CAN";
        yield return new WaitForSeconds(1.4f);
        text.text = "CAUSE SPORADIC CHANGES IN";
        yield return new WaitForSeconds(1f);
        text.text = "THE HEART RATE";
        yield return new WaitForSeconds(1.2f);
        text.text = "THESE PROBLEMS CAN BE";
        yield return new WaitForSeconds(0.8f);
        text.text = "CAUSED BY ELECTRICAL";
        yield return new WaitForSeconds(0.7f);
        text.text = "MALFUNCTIONS";
        yield return new WaitForSeconds(0.6f);
        text.text = "IN THE BODY";
        yield return new WaitForSeconds(1.2f);
        text.text = "OR WHEN ARTERY'S BLOCK THE";
        yield return new WaitForSeconds(0.8f);
        text.text = "FLOW OF BLOOD";
        yield return new WaitForSeconds(1.3f);
        text.text = "DURING THIS TIME";
        yield return new WaitForSeconds(0.8f);
        text.text = "A PERSON'S HEART RATE";
        yield return new WaitForSeconds(0.8f);
        text.text = "CAN BE MUCH FASTER OR";
        yield return new WaitForSeconds(0.8f);
        text.text = "MUCH SLOWER";
        yield return new WaitForSeconds(0.8f);
        text.text = "THAN USUAL";
        yield return new WaitForSeconds(1.2f);
        text.text = "SYMPTOMS OF THIS MAY INCLUDE";
        yield return new WaitForSeconds(1.3f);
        text.text = "CHEST PAIN, GENERAL PAIN";
        yield return new WaitForSeconds(1f);
        text.text = "DIZZINESS, SWEATING";
        yield return new WaitForSeconds(1.5f);
        text.text = "SHORTNESS OF BREATH AND";
        yield return new WaitForSeconds(1.3f);
        text.text = "COUGHING OR WHEEZING";
        yield return new WaitForSeconds(1.6f);
        text.text = "IF UNTREATED";
        yield return new WaitForSeconds(1.5f);
        text.text = "THE SEVERIY OF THESE CONDITIONS";
        yield return new WaitForSeconds(1.7F);
        text.text = "CAN BE FATAL";
        text.CrossFadeAlpha(0, 2f, false);
        yield return new WaitForSeconds(5);
        s6.Play();
        text.text = "TO IMPROVE YOUR CHANCES OF LIVING";
        text.CrossFadeAlpha(1, 1f, false);
        yield return new WaitForSeconds(1.7F);
        text.text = "WITH A HEALTHiER HEART";
        yield return new WaitForSeconds(1.3F);
        text.text = "SEVERAL THINGS CAN BE DONE";
        yield return new WaitForSeconds(1.5F);
        text.text = "FIRSTLY";
        yield return new WaitForSeconds(0.9F);
        text.text = "IF YOU ARE A SMOKER";
        yield return new WaitForSeconds(0.8F);
        text.text = "GIVING UP SMOKING CAN BE";
        yield return new WaitForSeconds(0.6F);
        text.text = "THE SINGLE BEST THING";
        yield return new WaitForSeconds(0.6F);
        text.text = "YOU CAN DO";
        yield return new WaitForSeconds(0.3F);
        text.text = "TO IMPROVE YOU HEARTS HEALTH";
        yield return new WaitForSeconds(1.6F);
        text.text = "AS WELL AS THIS";
        yield return new WaitForSeconds(1.4F);
        text.text = "REMAINING ACTIVE ACTIVE AND";
        yield return new WaitForSeconds(1F);
        text.text = "KEEPING A GOOD DIET";
        yield return new WaitForSeconds(1F);
        text.text = "CAN HELP YOU TO MANAGE";
        yield return new WaitForSeconds(1.2F);
        text.text = "YOUR WEIGHT AND";
        yield return new WaitForSeconds(0.9F);
        text.text = "REDUCE THE BUILD UP OF";
        yield return new WaitForSeconds(0.9F);
        text.text = "CHOLESTEROL";
        yield return new WaitForSeconds(0.5F);
        text.text = "IN YOUR ARTERIES";
        yield return new WaitForSeconds(1.5F);
        text.text = "MANAGING YOUR YOUR SALT AND";
        yield return new WaitForSeconds(1.1F);
        text.text = "SATURATED FAT INTAKES CAN";
        yield return new WaitForSeconds(1F);
        text.text = "ALSO HELP TO IMPROVE THIS";
        text.CrossFadeAlpha(0, 2f, false);
        yield return new WaitForSeconds(5);
        s7.Play();
        text.text = "THANKYOU FOR TAKING PART IN";
        text.CrossFadeAlpha(1, 0.5f, false);
        yield return new WaitForSeconds(1.2f);
        text.text = "THIS INTERACTIVE EXPERIENCE";
        yield return new WaitForSeconds(2.3F);
        text.text = "THERE ARE 7.442 BILLION";
        yield return new WaitForSeconds(1.3F);
        text.text = "BEATRING HEARTS IN THE WORLD";
        yield return new WaitForSeconds(1.9F);
        text.text = "MAKE YOURS COUNT.";
        yield return new WaitForSeconds(1.7F);
        text.CrossFadeAlpha(0, 2f, false);
    }

    public void Update()
    {
        if (GameObject.Find("Sphere").GetComponent<continueManager>().section2Begin && (!section2stopupdate))
        {
            StartCoroutine(fadeText2());
            Debug.Log("section2begin");
            
            
            
        }
        else
        {
            Debug.Log("notworking");
        }
        if (GameObject.Find("Sphere").GetComponent<continuemanager2>().section3Begin && (!section3stopupdate))
        {
            StartCoroutine(fadeText3());
            Debug.Log("section3begin");



        }
    }
    
}