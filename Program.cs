
NumberGenerator theNumberGenerator = new NumberGenerator();
BattleLog theLog = new BattleLog();

Hero theHero = new Hero(theNumberGenerator, theLog);
Beast theBeast = new Beast(theNumberGenerator, theLog);

// Now battle...How do we do that (Hint: You need a loop)
while (!theHero.Dead && !theBeast.Dead)
{
    theHero.ReceiveDamage(theBeast.DealDamage());
    theBeast.ReceiveDamage(theHero.DealDamage());
}


theLog.PrintLog();
