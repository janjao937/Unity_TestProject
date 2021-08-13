using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAction : MonoBehaviour
{
    public delegate void TestDelegate();
    private TestDelegate testFunction;

    public delegate bool TestDelegateBool(int i);
    private TestDelegateBool testDelegateBool;

    public delegate int TestDelegateInt(int i);
    private TestDelegateInt controlHp;

    public delegate void TestHp();
    private TestHp TestHpCal;

    private int hp = 100;
    void Start()
    {
        TestHpCal += () => hp -= 15;
        TestHpCal += HpCalTest;

        testFunction = delegate() {  Debug.Log("Function"); };

        testFunction += () => { Debug.Log("Lamda"); };

        // testDelegateBool += (int i) => i == 5;
        //testDelegateBool += FuctionBool;
        testDelegateBool += FalseFunction;
        Debug.Log(testDelegateBool(5));

      //  controlHp += (int i) => i -= 5;
        // controlHp += (int i) => i += 10;
       // controlHp += CalHp;
       // controlHp += MinusCalHp;
        testFunction();


       // controlHp(hp);
        //Debug.Log(controlHp(hp));

        Debug.Log(hp);
        CalHp(hp);
        Debug.Log(hp);

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.W))
        {
            //HpCalTest();
            TestHpCal();
            Debug.Log(hp);
        }
    
    }




    private bool FuctionBool(int i)
    {
        return i <= 5;
    }
    private bool FalseFunction(int i)
    {
        return i > 5;
    }

    private int CalHp(int i)
    {
        i += 15;
        return i ;
    }
    private int MinusCalHp(int i)
    {
       
        return i -= 5;
    }
    private void HpCalTest()
    {
        int i = 10;
        hp += i;
        Debug.Log("plust"+i);
    }


}
