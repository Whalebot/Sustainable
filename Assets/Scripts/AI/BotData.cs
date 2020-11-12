using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class BotData 
{
    public int[] ProbsActBot01_05;
    public int[] ProbsUpgBot01_05;
    public float waitBot01_05 = 2.62f;
    public int[] ProbsActBot01_10;
    public int[] ProbsUpgBot01_10;
    public float waitBot01_10 = 11.93f;
    public int[] ProbsActBot01_15;
    public int[] ProbsUpgBot01_15;
    public float waitBot01_15 = 12.16f;
    public int[] ProbsActBot01_20;
    public int[] ProbsUpgBot01_20;
    public float waitBot01_20 = 8.18f;
    public int[] ProbsActBot01_25;
    public int[] ProbsUpgBot01_25;
    public float waitBot01_25 = 8.8f;
    public int[] ProbsActBot01_30;
    public int[] ProbsUpgBot01_30;
    public float waitBot01_30 = 16.6f;
    public int[] ProbsActBot01_3x;
    public int[] ProbsUpgBot01_3x;
    public float waitBot01_3x = 13.53f;

    public void AssignBotValues(BotTypes bot)
    {
        
        switch (bot)
        {
            case BotTypes.Vegetarian:
                VegetarianBot();
                break;
            case BotTypes.Meat:
                MeatBot();
                break;
            case BotTypes.Money:
                MoneyBot();
                break;
            case BotTypes.Clean:
                CleanBot();
                break;
            case BotTypes.Sustainable:
                SustainabilityBot();
                break;
        }
    }

    
    private void VegetarianBot()
    {
        ProbsActBot01_05 = new int[] { 3,0,2,622,11,0,
            1,0,0,0,0,0,511,10,0,
            192,6,2,0,0 };

        ProbsUpgBot01_05 = new int[] { 0,1,0,5,
            1,1,0,0,0,
            0,0,0,4,1,
            0,3,0,0 };

        ProbsActBot01_10 = new int[] { 64,0,0,745,6,0,
            2,0,0,14,0,0,908,5,7,
            116,5,2,4,1 };

        ProbsUpgBot01_10 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,1,
            0,1,1,1 };

        ProbsActBot01_15 = new int[] { 0,0,0,400,2,0,
            0,0,0,32,0,0,654,1,11,
            198,3,0,0,0 };

        ProbsUpgBot01_15 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,2,
            3,0,0,0 };

        ProbsActBot01_20 = new int[] { 58,1,0,219,1,0,
            32,0,0,22,0,0,539,3,2,
            177,1,1,2,1 };

        ProbsUpgBot01_20 = new int[] { 1,0,0,0,
            0,1,0,0,0,
            0,0,0,0,0,
            0,0,1,1 };

        ProbsActBot01_25 = new int[] { 135,7,0,10,0,0,
            2,0,0,16,0,0,423,0,2,
            201,4,1,1,3 };

        ProbsUpgBot01_25 = new int[] { 1,0,1,0,
            1,0,0,0,0,
            0,0,0,0,0,
            0,0,0,0 };
        ProbsActBot01_30 = new int[] { 46,0,0,68,1,0,
            0,0,0,33,0,0,248,2,6,
            235,0,1,9,4 };

        ProbsUpgBot01_30 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,1,0 };
        ProbsActBot01_3x = new int[] { 0,0,0,125,0,0,
            0,0,0,42,0,0,261,0,2,
            311,1,1,2,2 };
        ProbsUpgBot01_3x = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,0,0 };
        waitBot01_05 = 2.62f;
        waitBot01_10 = 11.93f;
        waitBot01_15 = 12.16f;
        waitBot01_20 = 8.18f;
        waitBot01_25 = 8.8f;
        waitBot01_30 = 16.6f;
        waitBot01_3x = 13.53f;
}

    private void MeatBot()
    {
        ProbsActBot01_05 = new int[] { 65,7,10,0,0,0,
            0,0,0,38,0,0,733,9,6,
            450,9,0,0,0 };

        ProbsUpgBot01_05 = new int[] { 3,5,0,0,
            0,0,0,0,0,
            0,0,0,4,2,
            0,1,0,0 };

        ProbsActBot01_10 = new int[] { 337,13,10,28,2,3,
            58,0,0,0,0,0,511,9,16,
            517,8,3,8,2 };

        ProbsUpgBot01_10 = new int[] { 0,0,2,1,
            1,0,0,0,0,
            0,0,0,0,1,
            2,2,2,1 };

        ProbsActBot01_15 = new int[] { 261,2,5,5,0,0,
            190,0,3,0,0,0,628,1,5,
            666,5,2,5,1 };

        ProbsUpgBot01_15 = new int[] { 1,0,0,0,
            0,0,1,1,0,
            0,0,0,0,1,
            0,0,0,1 };

        ProbsActBot01_20 = new int[] { 157,1,3,1,0,0,
            0,0,0,209,3,3,282,0,4,
            919,1,0,1,1 };

        ProbsUpgBot01_20 = new int[] { 0,0,0,0,
            0,1,0,0,1,
            1,1,1,0,0,
            0,0,0,0 };

        ProbsActBot01_25 = new int[] { 224,0,1,0,1,0,
            0,0,0,184,0,1,622,0,5,
            499,1,1,4,7 };

        ProbsUpgBot01_25 = new int[] { 0,0,1,0,
            0,0,0,0,0,
            0,0,0,0,1,
            1,1,0,1 };

        ProbsActBot01_30 = new int[] { 427,1,18,27,2,3,
            28,0,0,49,0,0,464,3,5,
            480,0,2,2,1 };

        ProbsUpgBot01_30 = new int[] { 0,0,0,0,
            1,0,0,0,0,
            1,1,0,0,0,
            0,0,0,0 };
        ProbsActBot01_3x = new int[] { 943,0,2,0,0,0,
            0,0,0,59,0,0,339,0,4,
            437,0,4,2,6 };
        ProbsUpgBot01_3x = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,0,0 };
        waitBot01_05 = 4.1f;
        waitBot01_10 = 2.3f;
        waitBot01_15 = 2.1f;
        waitBot01_20 = 12.7f;
        waitBot01_25 = 2.8f;
        waitBot01_30 = 3.2f;
        waitBot01_3x = 3.8f;
    }

    private void MoneyBot()
    {
        ProbsActBot01_05 = new int[] { 55,7,3,167,5,1,
            169,4,0,43,4,3,666,15,2,
            184,12,2,0,0 };

        ProbsUpgBot01_05 = new int[] { 2,1,0,3,
            1,0,2,0,0,
            1,1,0,5,2,
            0,3,0,0 };

        ProbsActBot01_10 = new int[] { 59,2,6,27,3,4,
            464,4,3,14,1,0,1019,7,3,
            196,5,2,1,0 };

        ProbsUpgBot01_10 = new int[] { 1,2,0,0,
            1,1,1,2,1,
            0,0,1,0,1,
            2,0,1,0 };

        ProbsActBot01_15 = new int[] { 201,3,1,300,1,4,
            113,3,1,35,5,0,439,3,7,
            106,3,5,1,2 };

        ProbsUpgBot01_15 = new int[] { 0,0,1,0,
            1,0,0,0,0,
            2,0,1,0,0,
            0,1,0,2 };

        ProbsActBot01_20 = new int[] { 133,0,10,7,0,0,
            401,3,2,109,5,2,643,2,3,
            287,0,1,0,3 };

        ProbsUpgBot01_20 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,1,0,0,0,
            1,0,0,0 };

        ProbsActBot01_25 = new int[] { 188,4,7,84,1,0,
            314,0,2,94,0,1,898,1,13,
            282,3,2,2,5 };

        ProbsUpgBot01_25 = new int[] { 1,1,0,0,
            0,0,0,0,0,
            0,0,0,0,1,
            1,0,0,0 };

        ProbsActBot01_30 = new int[] { 138,3,2,70,2,1,
            17,1,1,172,0,1,527,0,4,
            185,0,5,5,3 };

        ProbsUpgBot01_30 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,1,0 };
        ProbsActBot01_3x = new int[] { 6,0,0,7,0,0,
            0,0,0,131,0,0,20,0,0,
            128,0,0,0,0 };
        ProbsUpgBot01_3x = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,0,0 };
        waitBot01_05 = 2.8f;
        waitBot01_10 = 1.7f;
        waitBot01_15 = 3.3f;
        waitBot01_20 = 5.6f;
        waitBot01_25 = 2.3f;
        waitBot01_30 = 1.9f;
        waitBot01_3x = 4.3f;
    }

    private void CleanBot()
    {
        ProbsActBot01_05 = new int[] { 45,7,0,120,2,1,
            158,2,0,319,6,8,878,11,5,
            428,9,4,1,1 };

        ProbsUpgBot01_05 = new int[] { 1,0,0,1,
            1,0,1,0,0,
            2,1,1,4,1,
            1,2,0,0 };

        ProbsActBot01_10 = new int[] { 26,0,0,24,1,0,
            250,1,0,802,4,7,804,6,9,
            540,6,0,6,0 };

        ProbsUpgBot01_10 = new int[] { 0,0,0,1,
            0,1,0,0,0,
            0,3,0,0,3,
            1,0,2,0 };

        ProbsActBot01_15 = new int[] { 47,2,0,0,0,0,
            265,3,0,534,0,9,666,3,4,
            521,2,0,5,2 };

        ProbsUpgBot01_15 = new int[] { 1,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,1,2 };

        ProbsActBot01_20 = new int[] { 0, 0, 10, 0, 0, 0,
            204, 0, 0, 341, 2, 2, 876, 0, 5,
            584, 8, 2, 8, 2 };

        ProbsUpgBot01_20 = new int[] { 0,1,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            0,0,1,0 };

        ProbsActBot01_25 = new int[] { 2,0,0,5,1,0,
            173,1,0,361,2,7,1156,2,5,
            232,0,1,2,4 };

        ProbsUpgBot01_25 = new int[] { 0,0,0,0,
            0,0,0,0,0,
            0,0,0,0,0,
            2,1,0,0 };

        ProbsActBot01_30 = new int[] { 0,0,0,0,0,0,
            154,0,1,305,0,1,1071,0,21,
            340,0,2,3,8 };

        ProbsUpgBot01_30 = new int[] { 0,0,0,0,
            0,0,0,1,1,
            0,0,0,0,0,
            1,0,0,1 };
        ProbsActBot01_3x = new int[] { 0,0,0,0,0,0,
            228,0,2,63,0,3,239,0,1,
            637,0,4,3,3 };
        ProbsUpgBot01_3x = new int[] { 0,0,0,0,
            0,0,0,1,1,
            0,0,0,0,0,
            0,1,0,0 };
        waitBot01_05 = 5f;
        waitBot01_10 = 0.98f;
        waitBot01_15 = 0.89f;
        waitBot01_20 = 0.65f;
        waitBot01_25 = 1.2f;
        waitBot01_30 = 0.66f;
        waitBot01_3x = 3.4f;
    }

    private void SustainabilityBot()
    {
        ProbsActBot01_05 = new int[] { 24, 0, 2, 4, 0, 1,
            389, 0, 5, 100, 11, 6, 721, 14, 5,
            369, 12, 1, 2, 0 };

        ProbsUpgBot01_05 = new int[] { 0, 2, 0, 0,
            1, 0, 1, 1, 1,
            4, 4, 0, 5, 2,
            1, 1, 1, 0 };

        ProbsActBot01_10 = new int[] { 7,3,2,1,2,1,
            467,7,1,137,2,2,478,10,7,
            407,8,2,1,0 };

        ProbsUpgBot01_10 = new int[] { 2,1,0,1,
            0,0,2,1,1,
            0,0,2,1,2,
            1,1,0,0 };

        ProbsActBot01_15 = new int[] { 24,0,1,1,0,0,
            269,15,2,195,9,1,637,3,6,
            423,7,3,2,0 };

        ProbsUpgBot01_15 = new int[] { 0,0,0,0,
            0,0,2,2,1,
            1,0,0,0,0,
            1,0,0,0 };

        ProbsActBot01_20 = new int[] { 82,0,0,39,0,3,
            41,0,11,204,0,2,526,4,1,
            911,3,3,4,0 };

        ProbsUpgBot01_20 = new int[] { 0,0,0,0,
            1,1,0,0,0,
            0,0,0,0,1,
            1,1,2,1 };

        ProbsActBot01_25 = new int[] { 5,0,0,49,0,0,
            111,0,0,220,0,0,587,2,7,
            330,0,0,1,0};

        ProbsUpgBot01_25 = new int[] { 0,0,0,0,
            0,1,0,0,0,
            0,0,0,0,1,
            0,0,1,1 };

        ProbsActBot01_30 = new int[] { 50,0,0,1,0,0,
            157,0,3,452,0,0,672,1,11,
            340,0,3,6,4 };

        ProbsUpgBot01_30 = new int[] {0,0,0,0,
            0,0,0,1,0,
            0,0,0,1,0,
            0,1,2,1};
        ProbsActBot01_3x = new int[] { 25,0,0,223,0,0,
            53,0,9,389,5,3,442,6,5,
            828,7,4,2,0 };
        ProbsUpgBot01_3x = new int[] { 0,0,0,0,
            0,0,0,0,0,
            1,1,0,0,0,
            1,1,0,0 };
        waitBot01_05 = 2.7f;
        waitBot01_10 = 2.6f;
        waitBot01_15 = 2.9f;
        waitBot01_20 = 1.04f;
        waitBot01_25 = 1.03f;
        waitBot01_30 = 0.66f;
        waitBot01_3x = 1.43f;
    }

}
