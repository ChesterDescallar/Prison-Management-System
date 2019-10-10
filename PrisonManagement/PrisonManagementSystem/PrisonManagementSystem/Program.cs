using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace PrisonManagementSystem
{
    class Program
    {
        //general class used for everyone single person class
        public class Person
        {

            public string firstname;
            public string surname;
            public string gender;
            public string DOB;
            public string address;
            public string contactno;


            //methods for this class
            public void setfirstName()
            {
                Console.WriteLine("Set First Name: ");
                firstname = Console.ReadLine();

            }

            public void setsurName()
            {
                Console.WriteLine("Set Surname: ");
                surname = Console.ReadLine();
            }

            public void setGender()
            {
                Console.WriteLine("Set Gender: ");
                gender = Console.ReadLine();
            }


            public void setDOB()
            {
                Console.WriteLine("Set Date of Birth (in DD/MM/YY format): ");
                DOB = Console.ReadLine();
            }


            public void setAddress()
            {
                Console.WriteLine("Set Address: ");
                address = Console.ReadLine();
            }


            public void setContactNo()
            {
                Console.WriteLine("Set Mobile Number: ");
                contactno = Console.ReadLine();
            }

        }


        private class Governor : Person //this class is inheriting the person class allowing it to use the person class' methods
        {
            //creates are the variable needed for this class
            public int listCount = 0;
            public string GovID;
            public int rowCount = 0;

            public void setGovID()
            {

                GovID = "G" + listCount.ToString();
                Console.WriteLine("Governor's ID: " + GovID);

            }
            //appends user input into the array
            public void addGovtoList()
            {

                rowCount = 1;
                listCount++;

            }


            //displays what the user has input
            public void showGovDetails()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Governor Details: ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int loopCount = 0;
                while (loopCount == 0)
                {
                    if (rowCount == 1)
                    {
                        Console.WriteLine("Governor ID:" + GovID);
                        Console.WriteLine("First Name: " + firstname);
                        Console.WriteLine("Surname: " + surname);
                        Console.WriteLine("Gender: " + gender);
                        Console.WriteLine("DOB: " + DOB);
                        Console.WriteLine("Address: " + address);
                        Console.WriteLine("Contact No: " + contactno);
                        Console.WriteLine("");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        loopCount++;
                    }
                    else
                    {
                        Console.WriteLine("No Governors Available");
                        loopCount++;
                    }
                }
            }
        }

        private class HeadWarden : Person //this class is inheriting the person class allowing it to use the person class' methods
        {
            public string[,] HeadWardens = new string[100, 100]; //array for user input regarding head warden details
            //creates are the variable needed for this class
            public int rowCount1 = 0;
            public int listCount1 = 0;
            public string HeadWardenID;
            public int x = 0;



            //methods for this class
            public void setHeadWardenID()
            {

                HeadWardenID = "H" + listCount1.ToString();
                Console.WriteLine("Head Warden's ID: " + HeadWardenID);

            }

            public void addHWardentoList()
            {
                HeadWardens[listCount1, 0] = HeadWardenID;
                HeadWardens[listCount1, 1] = firstname;
                HeadWardens[listCount1, 2] = surname;
                HeadWardens[listCount1, 3] = gender;
                HeadWardens[listCount1, 4] = DOB;
                HeadWardens[listCount1, 5] = address;
                HeadWardens[listCount1, 6] = contactno;
                HeadWardens[listCount1, 7] = "NONE";
                listCount1++;
                rowCount1++;

            }

            public void showHWardenDetails()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Head Warden Details: ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int loopCount1 = 0;
                int rowCount1 = 0;
                while (loopCount1 == 0)
                {
                    if (rowCount1 < listCount1)
                    {
                        Console.WriteLine("Head Warden ID: " + HeadWardens[rowCount1, 0]);
                        Console.WriteLine("First Name: " + HeadWardens[rowCount1, 1]);
                        Console.WriteLine("Surname: " + HeadWardens[rowCount1, 2]);
                        Console.WriteLine("Gender: " + HeadWardens[rowCount1, 3]);
                        Console.WriteLine("DOB: " + HeadWardens[rowCount1, 4]);
                        Console.WriteLine("Address: " + HeadWardens[rowCount1, 5]);
                        Console.WriteLine("Contact No: " + HeadWardens[rowCount1, 6]);
                        Console.WriteLine("");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        rowCount1++;

                    }
                    else
                    {
                        loopCount1++;
                    }
                }
            }
            public void assignHWardenWing()
            {
                string HWardeninputCheck;
                int loopForWing = 0;
                int loopforAnswer = 0;
                string HeadWardenWing;


                Console.WriteLine("Input Head Warden ID: ");
                HWardeninputCheck = Console.ReadLine();
                while (loopForWing == 0)
                {
                    if (x < rowCount1)
                    {
                        if (HeadWardens[x, 0].Contains(HWardeninputCheck))
                        {
                            Console.WriteLine("First Name: " + HeadWardens[x, 1]);
                            Console.WriteLine("Surname: " + HeadWardens[x, 2]);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                            while (loopforAnswer == 0)
                            {
                                Console.WriteLine("Assign Head Warden to wing (A or B):");
                                HeadWardenWing = Console.ReadLine();
                                HeadWardenWing = HeadWardenWing.ToUpper();

                                if (HeadWardenWing == "A" | HeadWardenWing == "a")
                                {
                                    HeadWardens[x, 7] = HeadWardenWing;
                                    Console.WriteLine("Head Warden Assigned to : " + HeadWardenWing);
                                    loopforAnswer++;
                                    x++;
                                    loopForWing++;


                                }
                                else if (HeadWardenWing == "B" | HeadWardenWing == "b")
                                {
                                    HeadWardens[x, 7] = HeadWardenWing;
                                    Console.WriteLine("Head Warden Assigned to : " + HeadWardenWing);
                                    loopforAnswer++;
                                    x++;
                                    loopForWing++;
                                }
                                else
                                {
                                    Console.WriteLine("Please input the appropriate wing.");
                                    Console.WriteLine(" ");

                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Input a valid ID.");
                            loopForWing++ ;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no records available.");
                        loopForWing++;
                    }
                   
                }

            }
            //shows the head wardens in a wing
            public void showHWardenWing()
            {
                string HWardeninputCheck2;
                int loopAnswer = 0;
                int loopForWing2 = 0;
                int x2 = 0;
                int found = 0;

                while (loopAnswer == 0)
                {
                    Console.WriteLine("Input Wing Area (A or B): ");
                    HWardeninputCheck2 = Console.ReadLine();
                    HWardeninputCheck2 = HWardeninputCheck2.ToUpper();
                    if (HWardeninputCheck2 == "A" | HWardeninputCheck2 == "a")
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount1)
                            {

                                if (HeadWardens[x2, 7].Contains(HWardeninputCheck2))
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Wardens in Wing " + HWardeninputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Head Warden ID: " + HeadWardens[x2, 0]);
                                    Console.WriteLine("First Name: " + HeadWardens[x2, 1]);
                                    Console.WriteLine("Surname: " + HeadWardens[x2, 2]);
                                    Console.WriteLine("Gender: " + HeadWardens[x2, 3]);
                                    Console.WriteLine("DOB: " + HeadWardens[x2, 4]);
                                    Console.WriteLine("Address: " + HeadWardens[x2, 5]);
                                    Console.WriteLine("Contact No: " + HeadWardens[x2, 6]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                                loopForWing2++;
                            }
                        }
                        loopAnswer++;
                    }
                    else if (HWardeninputCheck2 == "B" | HWardeninputCheck2 == "b")
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount1)
                            {

                                if (HeadWardens[x2, 7].Contains(HWardeninputCheck2))
                                {
                                     Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Wardens in Wing " + HWardeninputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Head Warden ID: " + HeadWardens[x2, 0]);
                                    Console.WriteLine("First Name: " + HeadWardens[x2, 1]);
                                    Console.WriteLine("Surname: " + HeadWardens[x2, 2]);
                                    Console.WriteLine("Gender: " + HeadWardens[x2, 3]);
                                    Console.WriteLine("DOB: " + HeadWardens[x2, 4]);
                                    Console.WriteLine("Address: " + HeadWardens[x2, 5]);
                                    Console.WriteLine("Contact No: " + HeadWardens[x2, 6]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                                loopForWing2++;
                            }
                        }
                        loopAnswer++;
                    }
                    else
                    {
                        Console.WriteLine("Please input the appropriate wing area.");
                        Thread.Sleep(1500);
                        Console.Clear();

                    }
                }
            }
        }

        private class Warden : Person //this class is inheriting the person class allowing it to use the person class' methods
        {
            public string[,] Wardens = new string[100, 100]; //array for user input regarding warden details
              //creates all the variables for this class
            public int rowCount2 = 0;
            public int listCount2 = 0;
            public int x = 0;

            public string WardenID;

            //methods for this class
            public void setWardenID()
            {

                WardenID = "W" + listCount2.ToString();
                Console.WriteLine("Warden's ID: " + WardenID);

            }

            public void addWardentoList() //appends the user input into the array
            {
                Wardens[listCount2, 0] = WardenID;
                Wardens[listCount2, 1] = firstname;
                Wardens[listCount2, 2] = surname;
                Wardens[listCount2, 3] = gender;
                Wardens[listCount2, 4] = DOB;
                Wardens[listCount2, 5] = address;
                Wardens[listCount2, 6] = contactno;
                Wardens[listCount2, 7] = "NONE";
                listCount2++;
                rowCount2++;

            }


            public void setWardenWing() //
            {
                string WardenIDChoice = "";
                string WardenWingChoice = "";
                Console.WriteLine("Input Warden ID: ");
                WardenIDChoice = Console.ReadLine();
                Console.WriteLine("Assign Warden to wing (A / B): ");
                WardenWingChoice = Console.ReadLine();

            }
            public void showWardenDetails() //displays all the warden details
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Warden Details: ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int loopCount2 = 0;
                rowCount2 = 0;
                while (loopCount2 == 0)
                {
                    if (rowCount2 < listCount2)
                    {
                        Console.WriteLine("Warden ID: " + Wardens[rowCount2, 0]);
                        Console.WriteLine("First Name: " + Wardens[rowCount2, 1]);
                        Console.WriteLine("Surname: " + Wardens[rowCount2, 2]);
                        Console.WriteLine("Gender: " + Wardens[rowCount2, 3]);
                        Console.WriteLine("DOB: " + Wardens[rowCount2, 4]);
                        Console.WriteLine("Address: " + Wardens[rowCount2, 5]);
                        Console.WriteLine("Contact No: " + Wardens[rowCount2, 6]);
                        Console.WriteLine("");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        rowCount2++;
                    }
                    else
                    {
                        loopCount2++;
                    }
                }
            }

            public void assignWardenWing() //assigns the warden into a wing
            {
                string WardeninputCheck;
                int loopForWing = 0;
                int loopforAnswer = 0;

                string WardenWing;


                Console.WriteLine("Input Warden ID: ");
                WardeninputCheck = Console.ReadLine();
                while (loopForWing == 0)
                {
                    if (x < rowCount2)
                    {
                        if (Wardens[x, 0].Contains(WardeninputCheck))
                        {
                            Console.WriteLine("First Name: " + Wardens[x, 1]);
                            Console.WriteLine("Surname: " + Wardens[x, 2]);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                            while (loopforAnswer == 0)
                            {
                                Console.WriteLine("Assign Warden to wing (A or B):");
                                WardenWing = Console.ReadLine();
                                WardenWing = WardenWing.ToUpper();

                                if (WardenWing == "A" | WardenWing == "a")
                                {
                                    Wardens[x, 7] = WardenWing;
                                    Console.WriteLine("Warden Assigned to : " + WardenWing);
                                    loopforAnswer++;
                                    x++;
                                    loopForWing++;
                                }
                                else if (WardenWing == "B" | WardenWing == "b")
                                {
                                    Wardens[x, 7] = WardenWing;
                                    Console.WriteLine("Warden Assigned to : " + WardenWing);
                                    loopforAnswer++;
                                    x++;
                                    loopForWing++;
                                }
                                else
                                {
                                    Console.WriteLine("Please input the appropriate wing.");
                                    Console.WriteLine(" ");

                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Input a valid ID.");
                            loopForWing++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no records availble.");
                        loopForWing++;
                    }
                }

            }
            public void showWardenWing() //displays the wardens in a certain wing
            {
                string WardeninputCheck2;
                int loopAnswer = 0;
                int loopForWing2 = 0;
                int x2 = 0;
                int found = 0;

                while (loopAnswer == 0)
                {
                    Console.WriteLine("Input Wing Area (A or B): ");
                    WardeninputCheck2 = Console.ReadLine();
                    WardeninputCheck2 = WardeninputCheck2.ToUpper();
                    if ((WardeninputCheck2 == "A") | (WardeninputCheck2 == "a"))
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount2)
                            {

                                if (Wardens[x2, 7].Contains(WardeninputCheck2))
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Wardens in Wing " + WardeninputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Warden ID: " +Wardens[x2, 0]);
                                    Console.WriteLine("First Name: " + Wardens[x2, 1]);
                                    Console.WriteLine("Surname: " + Wardens[x2, 2]);
                                    Console.WriteLine("Gender: " + Wardens[x2, 3]);
                                    Console.WriteLine("DOB: " + Wardens[x2, 4]);
                                    Console.WriteLine("Address: " + Wardens[x2, 5]);
                                    Console.WriteLine("Contact No: " + Wardens[x2, 6]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                            }
                        }
                        loopAnswer++;
                    }
                    else if (WardeninputCheck2 == "B" | WardeninputCheck2 == "b")
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount2)
                            {

                                if (Wardens[x2, 7].Contains(WardeninputCheck2))
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Wardens in Wing " + WardeninputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Warden ID: " + Wardens[x2, 0]);
                                    Console.WriteLine("First Name: " + Wardens[x2, 1]);
                                    Console.WriteLine("Surname: " + Wardens[x2, 2]);
                                    Console.WriteLine("Gender: " + Wardens[x2, 3]);
                                    Console.WriteLine("DOB: " + Wardens[x2, 4]);
                                    Console.WriteLine("Address: " + Wardens[x2, 5]);
                                    Console.WriteLine("Contact No: " + Wardens[x2, 6]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                            }
                        }
                        loopAnswer++;
                    }
                    else
                    {
 
                        Console.WriteLine("Please input the appropriate wing area.");
                        Thread.Sleep(1500);
                        Console.Clear();

                    }
                }
            }
        }

        private class Prisoner : Person //this class is inheriting the person class allowing it to use the person class' methods
        {
            public string[,] Prisoners = new string[100, 100]; //array for user input to be stored regarding prisoner details
            //creates the variable for this class
            public int rowCount3 = 0;
            public int listCount3 = 0;
            public int x = 0;
            public string pConviction = "";

            public string PrisonerID;

            //methods for this class
            public void setPrisonerID()
            {

                PrisonerID = "P" + listCount3.ToString();
                Console.WriteLine("Prisoner's ID: " + PrisonerID);

            }

            public void setPrisonerConviction()
            {
                Console.WriteLine("Set Prisoner Conviction: ");
                pConviction = Console.ReadLine();

            }

            public void addPrisonertoList() //appends the user input into the array
            {
                Prisoners[listCount3, 0] = PrisonerID;
                Prisoners[listCount3, 1] = firstname;
                Prisoners[listCount3, 2] = surname;
                Prisoners[listCount3, 3] = gender;
                Prisoners[listCount3, 4] = DOB;
                Prisoners[listCount3, 5] = pConviction;
                Prisoners[listCount3, 6] = "NONE";
                listCount3++;

            }


            public void setPrisonerWing()
            {
                string PrisonerIDChoice = "";
                string PrisonerWingChoice = "";
                Console.WriteLine("Input Prisoner ID: ");
                PrisonerIDChoice = Console.ReadLine();
                Console.WriteLine("Assign Warden to wing: ");
                PrisonerWingChoice = Console.ReadLine();

            }
            public void showPrisonerDetails() //displays all the prisoner details that has been stored into the array
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Prisoner Details: ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                int loopCount3 = 0;
                rowCount3 = 0;
                while (loopCount3 == 0)
                {
                    if (rowCount3 < listCount3)
                    {
                        Console.WriteLine("Prisoner's ID: " + Prisoners[rowCount3, 0]);
                        Console.WriteLine("First Name: " + Prisoners[rowCount3, 1]);
                        Console.WriteLine("Surname: " + Prisoners[rowCount3, 2]);
                        Console.WriteLine("Gender: " + Prisoners[rowCount3, 3]);
                        Console.WriteLine("DOB: " + Prisoners[rowCount3, 4]);
                        Console.WriteLine("");
                        Console.WriteLine("Conviction: " + Prisoners[rowCount3, 5]);
                        Console.WriteLine("");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        rowCount3++;
                    }
                    else
                    {
                        loopCount3++;
                    }
                }
            }

            public void assignPrisonerWing() //assigns a prisoner into a wing
            {
                string PrisonerinputCheck;
                int loopForWing = 0;
                int loopforAnswer = 0;
                string PrisonerWing;


                Console.WriteLine("Input Prisoner ID: ");
                PrisonerinputCheck = Console.ReadLine();
                while (loopForWing == 0)
                {
                    if (x < rowCount3)
                    {
                        if (Prisoners[x, 0].Contains(PrisonerinputCheck))
                        {
                            Console.WriteLine("First Name: " + Prisoners[x, 1]);
                            Console.WriteLine("Surname: " + Prisoners[x, 2]);
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                            while (loopforAnswer == 0)
                            {
                                Console.WriteLine("Assign Prisoner to wing (A or B):");
                                PrisonerWing = Console.ReadLine();
                                PrisonerWing = PrisonerWing.ToUpper();

                                if (PrisonerWing == "A" || PrisonerWing == "a")
                                {
                                    Prisoners[x, 7] = PrisonerWing;
                                    Console.WriteLine("Prisoner Assigned to : " + PrisonerWing);
                                    loopforAnswer++;
                                    x++;
                                    loopForWing++;
                                }
                                else if (PrisonerWing == "B" || PrisonerWing == "b")
                                {
                                    Prisoners[x, 7] = PrisonerWing;
                                    Console.WriteLine("Prisoner Assigned to : " + PrisonerWing);
                                    loopforAnswer++;
                                    loopForWing++;
                                }
                                else
                                {
                                    Console.WriteLine("Please input the appropriate wing.");
                                    Console.WriteLine(" ");
                                    x++;

                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Input a valid ID.");
                            loopForWing++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no records available.");
                        loopForWing++;
                    }
                }

            }

            public void showPrisonerWing() //displays all the prisoner in a certain wing
            {
                string PrisonerinputCheck2;
                int loopAnswer = 0;
                int loopForWing2 = 0;
                int x2 = 0;
                int found = 0;

                while (loopAnswer == 0)
                {
                    Console.WriteLine("Input Wing Area (A or B): ");
                    PrisonerinputCheck2 = Console.ReadLine();
                    PrisonerinputCheck2 = PrisonerinputCheck2.ToUpper();
                    if (PrisonerinputCheck2 == "A" || PrisonerinputCheck2 == "a")
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount3)
                            {

                                if (Prisoners[x2, 7].Contains(PrisonerinputCheck2))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Prisoners in Wing " + PrisonerinputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Prisoner ID: " + Prisoners[x2, 0]);
                                    Console.WriteLine("First Name: " + Prisoners[x2, 1]);
                                    Console.WriteLine("Surname: " + Prisoners[x2, 2]);
                                    Console.WriteLine("Gender: " + Prisoners[x2, 3]);
                                    Console.WriteLine("DOB: " + Prisoners[x2, 4]);
                                    Console.WriteLine("Conviction: " + Prisoners[x2, 5]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                                loopForWing2++;
                            }
                        }
                        loopAnswer++;
                    }
                    else if (PrisonerinputCheck2 == "B" || PrisonerinputCheck2 == "b")
                    {
                        while (loopForWing2 == 0)
                        {
                            if (x2 < rowCount3)
                            {

                                if (Prisoners[x2, 7].Contains(PrisonerinputCheck2))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Prisoners in Wing " + PrisonerinputCheck2);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Prisoner ID: " + Prisoners[x2, 0]);
                                    Console.WriteLine("First Name: " + Prisoners[x2, 1]);
                                    Console.WriteLine("Surname: " + Prisoners[x2, 2]);
                                    Console.WriteLine("Gender: " + Prisoners[x2, 3]);
                                    Console.WriteLine("DOB: " + Prisoners[x2, 4]);
                                    Console.WriteLine("Conviction: " + Prisoners[x2, 5]);
                                    Console.WriteLine("");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    found = 1;
                                }

                                x2++;


                            }
                            else
                            {
                                loopForWing2++;
                                x2 = 0;
                            }
                            if (found == 1)
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wing Area doesn't have any details or it is not found.");
                            }
                        }
                        loopAnswer++;
                    }
                    else
                    {
                        
                        Console.WriteLine("Please input the appropriate wing area.");
                        Thread.Sleep(1500);
                        Console.Clear();

                    }
                }
            }

        }

        //main menu class - added to make navigation of the system a lot easier
        public class Menu
        {
            //all the methods in this class outputs a string to the user telling them which buttons to press to progress when using the program
            public void displayMenu()
            {
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"                       MENU                       
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Press 1 to Appoint Governor
Press 2 to Appoint Head Wardens
Press 3 to Appoint Wardens
Press 4 to go to Governor's Area
Press 5 to go to Head Warden's Area
Press 6 to go to Warden's Area
Press 7 to get Help
Press 8 to Exit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
            }

            public void displayGovMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"Governor Area
Press 1 to View Governor Details
Press 2 to View All Head Warden Details
Press 3 to Assign Head Warden to a wing
Press 4 to View Head Wardens in a wing
Press 5 to go Back");
            }

            public void displayHeadWMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"Head Warden Area
Press 1 to View All Wardens Details
Press 2 to Assign Warden to Wing
Press 3 to View Wardens in a wing
Press 4 to go Back");
            }

            public void displayWardenMenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"Warden Area
Press 1 to Add a prisoner
Press 2 to View all prisoners
Press 3 to Assign a prisoner to a wing
Press 4 to View prisoners in a wing
Press 5 to go Back");
            }

        }


        static void Main(string[] args)
        {
            int loop = 0;
            string userChoice = "";
            //creating an object using the classes
            Governor newGovernor = new Governor();
            HeadWarden newHeadWarden = new HeadWarden();
            Warden newWarden = new Warden();
            Prisoner newPrisoner = new Prisoner();
            Menu mainMenu = new Menu();
            mainMenu.displayMenu();

            while (loop == 0) //loop to allow the user to see the main menu
            {
                int loop2 = 0;
                userChoice = Console.ReadLine();
                {
                    //asks the user to input the details of the governor that they want to appoint
                    if (userChoice == "1")
                    {
                        Console.Clear();
                        newGovernor.setGovID();
                        newGovernor.setfirstName();
                        newGovernor.setsurName();
                        newGovernor.setGender();
                        newGovernor.setDOB();
                        newGovernor.setAddress();
                        newGovernor.setContactNo();
                        newGovernor.addGovtoList();

                        Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.displayMenu();


                    }
                        //asks the user to input the details of the head warden they want to appoint
                    else if (userChoice == "2")
                    {
                        Console.Clear();
                        newHeadWarden.setHeadWardenID();
                        newHeadWarden.setfirstName();
                        newHeadWarden.setsurName();
                        newHeadWarden.setGender();
                        newHeadWarden.setDOB();
                        newHeadWarden.setAddress();
                        newHeadWarden.setContactNo();
                        newHeadWarden.addHWardentoList();

                        Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.displayMenu();


                    }
                    //asks the user to input the details of the warden they want to appoint
                    else if (userChoice == "3")
                    {
                        Console.Clear();
                        newWarden.setWardenID();
                        newWarden.setfirstName();
                        newWarden.setsurName();
                        newWarden.setGender();
                        newWarden.setDOB();
                        newWarden.setAddress();
                        newWarden.setContactNo();
                        newWarden.addWardentoList();

                        Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                        Console.ReadLine();
                        Console.Clear();
                        mainMenu.displayMenu();


                    }
                        //displays the governor area sub menu
                    else if (userChoice == "4")
                    {
                        while (loop2 == 0)
                        {
                            mainMenu.displayGovMenu();
                            string userChoice2 = "";
                            userChoice2 = Console.ReadLine(); //allows the user to choose another option from the sub menu
                           //displays the governor details upon user input
                            if (userChoice2 == "1")
                            {
                                Console.Clear();
                                newGovernor.showGovDetails();
                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                Console.Clear();
                                mainMenu.displayGovMenu();
           

                            //displays all the head warden details upon user input
                            }
                            else if (userChoice2 == "2")
                            {
                                Console.Clear();
                                newHeadWarden.showHWardenDetails();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayGovMenu();



                            }
                                //allows the user to assign the head warden into a wing
                            else if (userChoice2 == "3")
                            {
                                Console.Clear();
                                newHeadWarden.assignHWardenWing();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayGovMenu();


                                //allows the user to view records of head warden in a certain wing
                            }

                            else if (userChoice2 == "4")
                            {
                                Console.Clear();
                                newHeadWarden.showHWardenWing();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayGovMenu();



                            }
                                //sends the user back to the main menu
                            else if (userChoice2 == "5")
                            {
                                Console.Clear();
                                mainMenu.displayMenu();
                                loop2++; //ends the loop sending the user back to the main menu


                            }
                                //allows the user to input another option if they input an invalid option
                            else
                            {
                                Console.WriteLine("Invalid Option. Please input one of the options.");
                                Thread.Sleep (1500);

                            }
                        }
                    }
                    //displays the head warden area sub menu
                    else if (userChoice == "5")
                    {
                     
                        while (loop2 == 0) {
                        mainMenu.displayHeadWMenu();
                        string userChoice3 = "";
                        userChoice3 = Console.ReadLine(); //allows the user to choose another option from the sub menu
                        //displays the warden details upon user input 
                        if (userChoice3 == "1")
                        {
                            Console.Clear();
                            newWarden.showWardenDetails();

                            Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                            Console.ReadLine();
                            mainMenu.displayHeadWMenu();


                            //allows the user to assign the head warden into a wing
                        }
                        else if (userChoice3 == "2")
                        {
                            Console.Clear();
                            newWarden.assignWardenWing();

                            Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            mainMenu.displayHeadWMenu();
                        }
                            //allows the user to view records of head warden in a certain wing
                        else if (userChoice3 == "3")
                        {
                            Console.Clear();
                            newWarden.showWardenWing();

                            Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                            Console.ReadLine();
                            Console.Clear();
                            mainMenu.displayHeadWMenu();
                        }

                      //sends the user back to the main menu
                        else if (userChoice3 == "4")
                        {
                            Console.Clear();
                            mainMenu.displayMenu();
                            loop2++; //ends the loop sending the user back to the main menu

                        }
                        //allows the user to input another option if they input an invalid option
                        else
                        {
                            Console.WriteLine("Invalid Option. Please input one of the options.");
                            Thread.Sleep(1500);
                        }
                       }
                    }
                    //displays the warden area sub menu
                    else if (userChoice == "6")
                    {

                        while (loop2 == 0)
                        {
                            mainMenu.displayWardenMenu();
                            string userChoice4 = "";
                            userChoice4 = Console.ReadLine();//allows the user to choose another option from the sub menu
                            //allows the user to add a prisoner
                            if (userChoice4 == "1")
                            {
                                Console.Clear();
                                newPrisoner.setPrisonerID();
                                newPrisoner.setfirstName();
                                newPrisoner.setsurName();
                                newPrisoner.setGender();
                                newPrisoner.setDOB();
                                Console.WriteLine("");
                                newPrisoner.setPrisonerConviction();
                                newPrisoner.addPrisonertoList();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayWardenMenu();

                            }
                            //displays the prisoner details upon user input
                            else if (userChoice4 == "2")
                            {
                                Console.Clear();
                                newPrisoner.showPrisonerDetails();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayWardenMenu();
                            }
                            //allows the user to assign the prisoner into a wing
                            else if (userChoice4 == "3")
                            {
                                Console.Clear();
                                newPrisoner.assignPrisonerWing();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayWardenMenu();

                            }
                                //allows the user to view records of prisoners in a certain wing
                            else if (userChoice4 == "4")
                            {
                                Console.Clear();
                                newPrisoner.showPrisonerWing();

                                Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                                Console.ReadLine();
                                mainMenu.displayWardenMenu();

                            }
                                //sends the user back to the main menu
                            else if (userChoice4 == "5")
                            {
                                Console.Clear();
                                loop2++; //ends the loop sending the user back to the main menu
                                mainMenu.displayMenu();

                            }
                            else //allows the user to input another option if they input an invalid option
                            {
                                Console.WriteLine("Invalid Option. Please input one of the options.");
                                Thread.Sleep(1500);

                            }

                        }
                    }
                        //displays the on screen help of the program
                    else if (userChoice == "7")
                    {
                        Console.Clear();

                        Console.WriteLine("*********HELP PAGE************");
                        Console.WriteLine(@"
How to use the program: 
1.) Each option has a number assigned to it.
2.) Input the option that is wanted. 
3.) Follow what the program tells you to do.
4.) If there's still any problems contact me:
Email: test@gmail.com
Phone: 07123456789");
                        Console.WriteLine("\n \n Press the 'Enter' key to continue...");
                        Console.ReadLine();
                        mainMenu.displayMenu();

                    }
                        //exits the program
                    else if (userChoice == "8")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Please input one of the options.");

                    }

                }
            }
        }

    }
}
