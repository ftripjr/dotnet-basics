/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

// initialize variables - graded assignments 

int examAssignments = 5;

// Student Scores
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregoryScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregory"};
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\t\tExtra Credit\n");

foreach(string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregory")
        studentScores = gregoryScores;
    else
        continue;

    decimal studentSum = 0;
    decimal extraCreditPoints = 0;
    decimal studentScore = 0;

    int gradedAssignments = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments++;
        // add scores to sum
        if (gradedAssignments <= examAssignments)
            studentSum += score;

        else
        {
            extraCreditPoints += score;
        }
    }
    studentScore = (decimal) studentSum / examAssignments;
    decimal extraCreditScore = (decimal) extraCreditPoints / (examAssignments * 10);

    if(studentScore >= 97)
        currentStudentLetterGrade = "A+";
    else if(studentScore >= 93)
        currentStudentLetterGrade = "A";
    else if(studentScore >= 90)
        currentStudentLetterGrade = "A-";
    else if(studentScore >= 87)
        currentStudentLetterGrade = "B+";
    else if(studentScore >= 83)
        currentStudentLetterGrade = "B";
    else if(studentScore >= 80)
        currentStudentLetterGrade = "B-";
    else if(studentScore >= 77)
        currentStudentLetterGrade = "C+";
    else if(studentScore >= 73)
        currentStudentLetterGrade = "C";
    else if(studentScore >= 70)
        currentStudentLetterGrade = "C-";
    else if(studentScore >= 67)
        currentStudentLetterGrade = "D+";
    else if(studentScore >= 63)
        currentStudentLetterGrade = "D";
    else if(studentScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{studentScore}\t\t{studentScore + extraCreditScore}\t{currentStudentLetterGrade}\t\t{(int) studentScore} ({extraCreditScore} pts)");
}
Console.WriteLine();
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
