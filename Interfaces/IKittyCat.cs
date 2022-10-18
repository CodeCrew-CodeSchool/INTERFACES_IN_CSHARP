using System;

namespace Interfaces.Attack
{

public interface IAttack
{
string SignatureMove{get;set;}
string Alternate{get;set;}
string Special{get;set;}

int LightAttack();

char Taunt();

int StrongAttack();

int JumpAttack();

int Parry();

}


}