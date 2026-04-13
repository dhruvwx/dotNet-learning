using _26MiniProject2;


GuestBook.Welcome();

(List<string> guests , int size) = GuestBook.Details();

GuestBook.DisplayName(guests);
Console.WriteLine($"total users are {size}");



