using System;
public class program
{
    public static void Main()
    {
        //ifelse class object
        Ifelse ifelse = new Ifelse();
        ifelse.ifcondtion();

        //if else 2 class object
        Ifelse2 ifelse2 = new Ifelse2();
        ifelse2.ifcondition2();

        //else condition class object
        ElseCondition elseCondition= new ElseCondition();
        elseCondition.elsecon();

        //else if condition class object
        ElseifCondition elseifCondition= new ElseifCondition();
        elseifCondition.elseifcon();

        //Nested if else condition class object
        Nestedifelsecondition nestedifelsecondition= new Nestedifelsecondition();
        nestedifelsecondition.nestedifelsecon();

        //Ternary operator class object
        Ternaryoperator ternaryoperator= new Ternaryoperator();
        ternaryoperator.ternary();

        //Switch case class object
        SwitchCase switchCase= new SwitchCase();
        switchCase.switchcasecon();

        //switch case2 class object
        SwitchCase2 switchcase2 = new SwitchCase2();
        switchcase2.switchcase2con();

        //switch case3 class object
        SwitchCase3 switchcase3= new SwitchCase3();
        switchcase3.switchcase3con();

        //switch case4 class object
        SwitchCase4.switchcase4con(); //Print either "even value" or "odd value"

        //switch case 5 class object
        SwitchCase5 switchCase5= new SwitchCase5();
        switchCase5.switchcase5con();//Print 5, 4, 3

        //For loop class object
        ForLoop forloop = new ForLoop();
        forloop.forloop1();

        //For loop 2 class object
        Forloop2 forloopx= new Forloop2();
        forloopx.forloop2();

        //While loop class object
        WhileLoop whileloop = new WhileLoop();
        whileloop.whileloopcond();

        //Do While loop class object
        DoWhile dowhile1= new DoWhile();
        dowhile1.dowhilecond();

    }
}