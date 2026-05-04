using _45Events;


CollegeCourseModel maths = new CollegeCourseModel("Maths", 3);
CollegeCourseModel science = new("Science", 2);

maths.CallEvent += ConsoleHelper.InvokeEventMethod;

maths.SignUpStudent("Dhruv").Print();
maths.SignUpStudent("Indra").Print();
maths.SignUpStudent("Raja").Print();
maths.SignUpStudent("Rani").Print();
maths.SignUpStudent("Chor").Print();
Console.WriteLine();

science.CallEvent += ConsoleHelper.InvokeEventMethod;
science.SignUpStudent("Dhruv").Print();
science.SignUpStudent("Indra").Print();
science.SignUpStudent("Raja").Print();


