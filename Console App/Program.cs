using Console_App.Controller;
using Core.Constants;
using Core.Entities;
using Core.Helpers;
using DataAccess.Repositories.Implementations;

namespace Manage
{
    public class Program
    {
        static void Main()
        {
            GroupController _groupController = new GroupController();
            GroupRepository _groupRepository = new GroupRepository();
            StudentController _studentController = new StudentController();
            AdminController _adminController = new AdminController();

        Authentication: var admin = _adminController.Authenticate();
            if(admin != null)

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, $"Hello,{ admin.Username}");
            Console.WriteLine("-------");
            while (true)
            {
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "1 - Create Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "2 - Update Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "3 - Delete Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "4 - All Groups");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "5 - Get Group by name");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "6 - Create Student");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "7 - Update Student");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "8 - Delete Student");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "9 - All Student By Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "10 - Get Student By Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Yellow, "0 - Exit");
                Console.WriteLine("-------");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Gray, "Select Option");
                string number = Console.ReadLine();

                int SelectedNumber;
                bool result = int.TryParse(number, out SelectedNumber);

                if (result)
                {
                    if (SelectedNumber >= 0 && SelectedNumber <= 10)
                    {
                        switch (SelectedNumber)
                        {
                            case (int)Options.CreateGroup:
                                _groupController.CreateGroup();
                                break;
                            case (int)Options.UpdateGroup:
                                _groupController.UpdateGroup();
                                break;
                            case (int)Options.DeleteGroup:
                                _groupController.DeleteGroup();
                                break;
                            case (int)Options.AllGroups:
                                _groupController.AllGroups();                        
                                break;
                            case (int)Options.GetGroupByName:
                                _groupController.GetGroupByName();
                                break;
                            case (int)Options.Exit:
                                _groupController.Exit(); 
                                return;
                            case (int)Options.CreateStudent:
                                _studentController.CreateStudent();
                                break;
                            case (int)Options.DeleteStudent:
                                _studentController.DeleteStudent();
                                break;
                            case (int)Options.UpdateStudent:
                                break;
                            case (int)Options.GetAllStudentsByGroup:
                                _studentController.GetAllStudentsByGroup();
                                break;
                            
                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Red,"Please enter correct number");
                    }
                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Red,"Please enter correct number");

                }


            }


        }

    }

}

