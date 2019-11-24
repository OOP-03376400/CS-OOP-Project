using System;

public abstract class Developer
{
    private string _mainLanguage;

    public Developer(string mainDev){
        this._mainLanguage = mainDev;
    }
    public virtual void Code(){
        Console.WriteLine(string.Format("I am codin using my main Dev lang {0}", this._mainLanguage));
    }

}