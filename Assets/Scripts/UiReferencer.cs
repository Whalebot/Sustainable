using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UiReferencer : MonoBehaviour
{
    public GameObject cursor;

    public GameObject[] stationModule;
    // 0 food
    // 1 energy
    // 2 waste

    public GameObject[] foodTypeButton;
    // 0 meat
    // 1 veggies
    // 2 insects
    // 3 algae

    public GameObject[] produceButton;
    // 0 meat
    // 1 veggies
    // 2 insects
    // 3 algae
    // 4 energy/oil/biogas
    // 5 collect waste

    public GameObject[] offButtonProduce0Meat;
    // 7 in total

    public GameObject[] offButtonProduce1Veggies;
    // 7 in total

    public GameObject[] offButtonProduce2Insects;
    // 7 in total

    public GameObject[] offButtonProduce3Algae;
    // 7 in total

    public GameObject[] offButtonProduce4Energy;
    // 7 in total

    public GameObject[] offButtonProduce5Collectwaste;
    // 7 in total

    public GameObject[] plusButton;
    // 0 meat smallscale
    // 1 meat industrial
    // 2 veggies smallscale
    // 3 veggies industrial
    // 4 ins small
    // 5 ins ind
    // 6 alg small
    // 7 alg ind
    // 8 energy small
    // 9 energy ind
    // 10 garbage trucks
    // 11 recycle
    // 12 compost
    // 13 upcycle

    public GameObject[] offButtonPlus0MeatS;
    // 8 in total

    public GameObject[] offButtonPlus1MeatInd;
    // 7 in total

    public GameObject[] offButtonPlus2VeggiesS;
    // 8 in total

    public GameObject[] offButtonPlus3VeggiesInd;
    // 7 in total

    public GameObject[] offButtonPlus4InsectsS;
    // 8 in total

    public GameObject[] offButtonPlus5InsectsInd;
    // 7 in total

    public GameObject[] offButtonPlus6AlgaeS;
    // 8 in total

    public GameObject[] offButtonPlus7AlgaeInd;
    // 7 in total

    public GameObject[] offButtonPlus8EnergyS;
    // 8 in total

    public GameObject[] offButtonPlus9EnergyInd;
    // 7 in total

    public GameObject[] offButtonPlus10GarbagetrucksS;
    // 8 in total

    public GameObject[] offButtonPlus11RecycleInd;
    // 7 in total

    public GameObject[] offButtonPlus12CompostInd;
    // 7 in total

    public GameObject[] offButtonPlus13UpcycleInd;
    // 7 in total

    public GameObject[] upgradeModule;
    // 0 food1 ZOOM IN
    // 1 food2 ZOOM OUT
    // 2 energy1 ZOOM IN
    // 3 energy2 ZOOM OUT
    // 4 waste1 ZOOM IN
    // 5 waste2 ZOOM OUT

    public GameObject[] upgradeButton0Meat;
    // 0 smallscale
    // 1 industrial
    // 2 agroecology

    public GameObject[] upgradeButton1Veggies;
    // 0 smallscale
    // 1 industrial
    // 2 agroecology

    public GameObject[] upgradeButton2Insects;
    // 0 smallscale
    // 1 industrial
    // 2 agroecology

    public GameObject[] upgradeButton3Algae;
    // 0 smallscale
    // 1 industrial
    // 2 agroecology

    public GameObject[] upgradeButton4Energy;
    // 0 smallscale
    // 1 industrial
    // 2 biogas

    public GameObject[] upgradeButton5Waste;
    // 0 recycle
    // 1 compost
    // 2 upcycle

    public GameObject[] offButtonUpgrade0Meat;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] offButtonUpgrade1Veggies;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] offButtonUpgrade2Insects;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] offButtonUpgrade3Algae;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] offButtonUpgrade4Energy;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] offButtonUpgrade5Waste;
    // 0 lock SMALL
    // 1 requirement 1 SMALL
    // 2 requirement 2 SMALL
    // 3 requirement 3 SMALL
    // 4 lock INDUSTRIAL
    // 5 requirement 1 INDUSTRIAL
    // 6 requirement 2 INDUSTRIAL
    // 7 requirement 3 INDUSTRIAL
    // 8 lock BIO/AGROECOLOGY
    // 9 requirement 1 BIO/AGROECOLOGY
    // 10 requirement 2 BIO/AGROECOLOGY
    // 11 requirement 3 BIO/AGROECOLOGY

    public GameObject[] closeUpgradeModule;
    // 0 food
    // 1 energy
    // 2 waste

    public GameObject[] closeStation;
    // 0 food1 NORMAL
    // 1 food2 ZOOM OUT
    // 2 energy1 NORMAL
    // 3 energy2 ZOOM OUT
    // 4 waste1 NORMAL
    // 5 waste2 ZOOM OUT

    public bool move_now = false;
    public bool activeCursor = false;
    private float speed = 100;
    private int idx = 0;
    private GameObject[] trackObjects;
    
    public void Start()
    {
        
        //RectTransform rectillo = offButton[1].GetComponent<RectTransform>();
        //stationModule[0].GetComponent<LocatorClicker>().OnMouseDown();
        trackObjects = new GameObject[] { stationModule[0], foodTypeButton[1], produceButton[1], closeStation[1] };

        //trackObjects = new GameObject[] { stationModule[0], upgradeModule[0], upgradeButton0Meat[0], closeUpgradeModule[0], closeStation[0] };
    }


    // Update is called once per frame
    void Update()
    {
        if (activeCursor)
        {
            cursor.SetActive(true);
            if (move_now)
            {
                // Move our position a step closer to the target.
                float step = speed * Time.deltaTime; // calculate distance to move
                var target = trackObjects[idx];
                Vector3 screenpos;
                if (idx == 0) screenpos = Camera.main.WorldToScreenPoint(target.transform.position);
                
                else screenpos = target.transform.position;
                cursor.transform.position = Vector3.MoveTowards(cursor.transform.position, screenpos, step);

                if (Vector3.Distance(cursor.transform.position, screenpos) < 0.001f)
                {
                    if (idx == 0) target.GetComponent<LocatorClicker>().OnMouseDown();
                    if (target.GetComponent<CursorChanger>() != null) target.GetComponent<Button>().onClick.Invoke();
                    idx = (idx + 1) % trackObjects.Length;

                }
            }
        }
        else
        {
            cursor.SetActive(false);
        }

        // Check if the position of the cube and sphere are approximately equal.
        //{
        //    // Swap the position of the cylinder.
        //    target.transform.position *= -1.0f;
        //}
        //if (Input.GetKeyDown("k"))
        //{
        //    LeanTween.moveLocalY(;
        //}
    }
    IEnumerator move(GameObject item)
    {
        yield return new WaitForSeconds(1.0f);
    }
}
