using System;
using System.Collections;

namespace jackPotBot
{

    class Program
    {

		public static string checkPackType(string barCode)
		{
			string ans = "";
			bool prefix = true;
			int ind = 0;
            while (prefix && ind<barCode.Length)
            {
                if (Char.IsLetter(barCode[ind]))
                {
					ans += barCode[ind];
					ind++;
                }
                else
                {
					prefix = false;
                }
            }
			return ans;
		}

		static void Main(string[] args)
        {
			LinAct[] allLinActs = new LinAct[13];
			for (int i=0; i<13; i++)
            {
				allLinActs[i] = new LinAct(i);
            }
			int actToUse = -1;
			while (true)
			{
				string curr = Console.ReadLine();
				curr = checkPackType(curr);
				double countdown;

				//Find out which Linear Actuator to use for this package:
				if (curr == "csXP")
				{
					actToUse = 0;
				}
				else if (curr == "tsBAXT" || curr == "tsDON")
				{
					actToUse = 1;
				}
				else if (curr == "tsTDST")
				{
					actToUse = 2;
				}
				else if (curr == "tsTEST")
				{
					actToUse = 3;
				}
				else if (curr == "tsPINN")
				{
					actToUse = 4;
				}
				else if (curr == "tsHEAT")
				{
					actToUse = 5;
				}
				else if (curr == "tsGWHO")
				{
					actToUse = 6;
				}
				else if (curr == "tsWDREF" || curr == "tsREF")
				{
					actToUse = 7;
				}
				else if (curr == "tsTDST")
				{//*and in a tote
					actToUse = 8;
				}
				else if (curr == "tsAUDIT")
				{
					actToUse = 9;
				}
				else if (curr == "tsSRT")
				{
					actToUse = 10;
				}
				else if (curr == "tsSRTU")
				{//<-unsellable tote
					actToUse = 11;
				}
				else if (curr == "csXPG")
				{//<-sellable tote
					actToUse = 12;
				}
                else
                {
					actToUse = -1;
                }


				//Call Linear Actuator to action:
				if(actToUse != -1) {
					countdown = 10 + ( 0.5 * actToUse );
					Console.WriteLine("Pushing Linear Actuator #" + actToUse + " in " + countdown + " seconds.");
					allLinActs[actToUse].extend();
					allLinActs[actToUse].retract();

				}

			}

		}
	}
}