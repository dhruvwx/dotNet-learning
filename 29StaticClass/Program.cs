using _29StaticClass;



UserMessage.Display("enter your name:  ");
double x = UserMessage.Values("ENTER NUM 1:  ");
double y = UserMessage.Values("ENTER NUM 2:  ");

UserMessage.End($"your sum is {CalculateValue.Add(x, y)}");
