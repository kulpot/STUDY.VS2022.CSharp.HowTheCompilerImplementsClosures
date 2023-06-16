using System;

//ref link:https://www.youtube.com/watch?v=ZQfhxD20v50&list=PLAE7FECFFFCBE1A54&index=11
//

class MainClass
{
    class DisplayClass
    {
        public int i;
        public void theMethodGeneratedFromTheLambdaExpressions()
        {
            i++;
        }
    }
    static void Main()
    {
        Action a = GiveMeAction();
        a();
        Action b = GiveMeAction();
        b(); a(); a(); b(); a();
    }
    static Action GiveMeAction()
    {
        //int i = 0;
        //return new Action(() => i++);
        return new Action(new DisplayClass().theMethodGeneratedFromTheLambdaExpressions);
    }
    /*static int i;
    static void waaaaaaaaa()
    {
        i++;
    }*/
}