Jet jet = new Jet("F15", "cold trust", 1.3);
Bomber bomber = new Bomber("B2", "rotor", 0.4);

for (int i = 0; i < 6; i++)
{
    jet.Attack();
    bomber.Attack();
}