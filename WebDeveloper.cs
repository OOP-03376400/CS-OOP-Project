using System;

namespace CS_OOP
{
    public class WebDeveloper : Developer, ISelfDeveloping
    {
        public WebDeveloper(string mainDev): base(mainDev){

        }
        public void Develop(){
                Console.WriteLine("I develop by Udemy");
        }
        
    }
}