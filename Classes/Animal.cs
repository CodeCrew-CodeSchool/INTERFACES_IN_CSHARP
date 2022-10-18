using System;
using Interfaces.Attack;
namespace Classes.Animal
{

  class Animal : IAttack
        {
       public  string SignatureMove{get;set;}
       public  string Special{get;set;}
       public  string Alternate{get;set;}

       public  int LightAttack(){
        int Damage = 12;
        if(AnimalType == "Kay9"){
            Damage = Damage + 5;
        }else{
            Damage = Damage + 7;
        }
        return Damage;
       }

       public char Taunt(){
        char Damage = '1';
        return Damage;
       }

       public int StrongAttack(){
        int Damage = 21;
        if(AnimalType == "Kay9"){
            Damage = Damage + 15;
        }else{
            Damage = Damage + 11;
        }
        return Damage;
       }

       public  int JumpAttack(){
        int Damage = 32;
        if(AnimalType == "Kay9"){
            Damage = Damage + 10;
        }else{
            Damage = Damage + 17;
        }
        return Damage;
       }

       public  int Parry(){
        int Damage = 9;
        if(AnimalType == "Kay9"){
            Damage = Damage + 2;
        }else{
            Damage = Damage + 10;
        }
        return Damage;
       }


         public string Name;
         public int Age;
         public string AnimalType;
         public string Species; 
         public int PowerLevel;

         public Animal(string name, int age, string animaltype,string species,int powerlevel,string sig, string spec, string alt){

          Name = name;
          Age=age;
          AnimalType=animaltype;
          Species=species; 
          PowerLevel=powerlevel;
          SignatureMove = sig;
          Special = spec;
          Alternate = alt;

        }
          public static string Contest ( ){

            Animal Puppy = new Animal("Ku-joe",32,"Kay9","DogSon",100,"BellyRoll","FaceLick","AllBarkNoBite");
            Animal Kitty = new Animal("Viper",32,"Kitten","CatSon",100,"Scratch","HairBall","PureHell");


            int Scratch = Kitty.LightAttack();

            int Paw = Puppy.LightAttack();

            
            if(Scratch < Paw){
                 return ($"{Puppy.Name} is the winner ");

            }else{
                  return ($"{Kitty.Name} is the winner ");
            }
            

           
        }
        

        
        }

        

}

