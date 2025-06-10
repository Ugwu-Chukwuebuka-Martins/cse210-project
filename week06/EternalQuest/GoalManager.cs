using System.IO; 
public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        while(true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            print("Menu Options:");
            print(" 1. Create New Goal");
            print(" 2. List Goals");
            print(" 3. Save Goals");
            print(" 4. Load Goals");
            print(" 5. Record Event");
            print(" 6. Quit");

            int chose = int.Parse(input("Select a choice from the menu: "));

            if (chose == 1)
            {
                CreateGoal();
            }

            else if (chose == 2)
            {
                ListGoalDetails();
            }

            else if (chose == 3)
            {
                SaveGoals();
            }

            else if (chose == 4)
            {
                LoadGoals();
            }

            else if (chose == 5)
            {
                RecordEvent();
            }

            else if (chose == 6)
            {
                Console.Clear();
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        print($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        print("The types of Goals are:");
        print(" 1. Simple Goal");
        print(" 2. Eternal Goal");
        print(" 3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        for(int i = 0; i<_goals.Count;i++)
        {
            if (_goals[i].isComplete() == true)
            {
                print($"[X] {_goals[i].GetDetailsString()}");
            }
            else
            {
                print($"[ ] {_goals[i].GetDetailsString()}");
            }
        }
    }

    public void CreateGoal()
    {
        ListGoalNames();

        int chose = int.Parse(input("Which type of goal would you like to create? "));

        if (chose == 1)
        {
            string name = input("What is the name of your goal? ");
            string description = input("What is a short description of it? ");
            int points = int.Parse(input("What is the amount of points associated with this goal? "));
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points); 
            _goals.Add(simpleGoal);
        }

        else if (chose == 2)
        {
            string name = input("What is the name of your goal? ");
            string description = input("What is a short description of it? ");
            int points = int.Parse(input("What is the amount of points associated with this goal? "));
            EternalGoal eternalGoal  = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

        else if (chose == 3)
        {
            string name = input("What is the name of your goal? ");
            string description = input("What is a short description of it? ");
            int points = int.Parse(input("What is the amount of points associated with this goal? "));
            int target = int.Parse(input("How many times does this goal need to be accomplished for a bonus? "));
            int bonus = int.Parse(input("What is the bonus for accomplishing it that many times? "));
            ChecklistGoal checklistGoal  = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        int i = 0;
        print("The goals are:");
        foreach (Goal goal in _goals)
        {
            i++;
            print($" {i}. {goal.GetName()}");
        }
        int chose = int.Parse(input("Which goal did you accomplished? "));

        for (int j = 0; j<_goals.Count; j++)
        {
            if (chose == j+1)
            {
                _score += _goals[j].RecordEvent();
            }
        }
        print($"Congratulations! you have earned {_score} points!");
        print($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
       string filename = input("What is the filename for the goal file? ");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        string filename = input("What is the filename for the goal file? ");

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string a = line;
            string[] b = a.Split(":");
            string goal = b[0];

            if(goal == "Checklist Goal")
            {
                string goalDetails = b[1];
                string[] c = goalDetails.Split(",");
                string name = c[0];
                string description = c[1];
                int points = int.Parse(c[2]);
                int bonus = int.Parse(c[3]);
                int target = int.Parse(c[4]);
                int amountCompleted = int.Parse(c[5]);

                ChecklistGoal checklistGoal  = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
                checklistGoal.SetAmountCompleted(amountCompleted);
            }

            else if(goal == "Simple Goal")
            {
                string goalDetails = b[1];
                string[] c = goalDetails.Split(",");
                string name = c[0];
                string description = c[1];
                int points = int.Parse(c[2]);
                bool isComplete = bool.Parse(c[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points); 
                _goals.Add(simpleGoal);
                simpleGoal.SetIsComplete(isComplete);
            }

            else if(goal == "Eternal Goal")
            {
                string goalDetails = b[1];
                string[] c = goalDetails.Split(",");
                string name = c[0];
                string description = c[1];
                int points = int.Parse(c[2]);
                bool isComplete = bool.Parse(c[3]);

                EternalGoal eternalGoal  = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                eternalGoal.SetIsComplete(isComplete);
            }

            else
            {
                _score = int.Parse(lines[0]);
            }
        }

    }

    public void print(string text)
    {
        Console.WriteLine(text);
    }

    public string input(string text)
    {
        Console.Write(text);
        return Console.ReadLine();
    }

}