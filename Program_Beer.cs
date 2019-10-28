using System;
public interface IHomework05
{
    string DisplayLEDOnScreen(string ledNo);
}
class Program
{
    static void Main(string[] args)
    {
        led ledd = new led();
        ledd.DisplayLEDOnScreen("LED");

    }
}
